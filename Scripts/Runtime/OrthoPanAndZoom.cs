using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DoubTech.OrthoTopdownCamera
{
    [RequireComponent(typeof(Camera))]
    public class OrthoPanAndZoom : MonoBehaviour
    {
        [SerializeField] private Camera orthoCamera;
        [SerializeField] private float minZoom = 3.5f;
        [SerializeField] private float maxZoom = 0.3f;

        [Header("Touch")]
        [SerializeField] private bool singleFingerMove = false;
        [SerializeField] private float touchZoomSpeed = 1f;
        [SerializeField] private float touchPanSpeed = 1;

        [Header("Mouse")]
        [SerializeField] private bool flipMouseScroll = false;
        [SerializeField] private float mousePanSpeed = 1f;
        [SerializeField] private float mouseScrollSpeed = 1f;

        [Header("Camera Bounds")]
        [SerializeField] private bool limitCameraXBounds = false;
        [SerializeField] private Vector2 cameraXBounds;
        [SerializeField] private bool limitCameraYBounds = false;
        [SerializeField] private Vector2 cameraYBounds;

        private TouchOrthoPanZoomInput _inputActions;
        private Coroutine _zoomCoroutine;
        private Coroutine _panCoroutine;
        private bool _cursorStartState;

        private void OnValidate()
        {
            if (!orthoCamera) orthoCamera = GetComponent<Camera>();
        }

        private void Awake()
        {
            _inputActions = new TouchOrthoPanZoomInput();
        }

        private void OnEnable()
        {
            _inputActions.Enable();
            _inputActions.TouchInput.SecondaryTouchContact.started += ZoomStart;
            _inputActions.TouchInput.SecondaryTouchContact.canceled += ZoomEnd;

            _inputActions.MouseInput.PanClick.started += MousePanStart;
            _inputActions.MouseInput.PanClick.canceled += MousePanEnd;

            _inputActions.MouseInput.Zoom.performed += MouseZoom;

            if (singleFingerMove)
            {
                _inputActions.TouchInput.PrimaryTouchContact.started += StartTouchPan;
                _inputActions.TouchInput.PrimaryTouchContact.canceled += StopTouchPan;
            }
        }

        private void OnDisable()
        {
            _inputActions.Disable();
            _inputActions.TouchInput.SecondaryTouchContact.started -= ZoomStart;
            _inputActions.TouchInput.SecondaryTouchContact.canceled -= ZoomEnd;

            _inputActions.MouseInput.PanClick.started -= MousePanStart;
            _inputActions.MouseInput.PanClick.canceled -= MousePanEnd;
            
            _inputActions.MouseInput.Zoom.performed -= MouseZoom;

            if (singleFingerMove)
            {
                _inputActions.TouchInput.PrimaryTouchContact.started -= StartTouchPan;
                _inputActions.TouchInput.PrimaryTouchContact.canceled -= StopTouchPan;
            }
        }

        private void MouseZoom(InputAction.CallbackContext ctx)
        {
            var scroll = ctx.ReadValue<float>() * mouseScrollSpeed / 1000f;
            Zoom -= (flipMouseScroll ? -1 : 1) * scroll;
            Debug.Log("Scroll: " + scroll);
        }

        private void MousePanEnd(InputAction.CallbackContext obj)
        {
            Cursor.visible = _cursorStartState;
            StopCoroutine(_panCoroutine);
        }

        private void MousePanStart(InputAction.CallbackContext obj)
        {
            _cursorStartState = Cursor.visible;
            Cursor.visible = false;
            _panCoroutine = StartCoroutine(MousePan());
        }

        private IEnumerator MousePan()
        {
            while (true)
            {
                var panDelta = MouseDelta;
                CameraPosition -= (Vector3.right * panDelta.x + Vector3.forward * panDelta.y)
                                                  * mousePanSpeed * Time.deltaTime * orthoCamera.orthographicSize / 10f;
                yield return null;
            }
        }

        private void ZoomStart(InputAction.CallbackContext obj)
        {
            _zoomCoroutine = StartCoroutine(ZoomDetection());
        }

        private void ZoomEnd(InputAction.CallbackContext obj)
        {
            StopCoroutine(_zoomCoroutine);
        }

        private IEnumerator ZoomDetection()
        {
            float previousDistance = PinchDistance;
            float distance = PinchDistance;

            var pointerPosition = PrimaryPointerPosition;

            while (true)
            {
                var delta = distance - previousDistance;
                var zoomSizeChange = delta * touchZoomSpeed * Time.deltaTime / 10f;
                Zoom -= zoomSizeChange;
                Debug.Log($"Size: {orthoCamera.orthographicSize}, delta: {delta}, zoomSizeChange: {zoomSizeChange}");
                previousDistance = distance;
                distance = PinchDistance;

                if(!singleFingerMove) pointerPosition = TouchPan(pointerPosition);

                yield return null;
            }
        }

        private Vector2 TouchPan(Vector2 pointerPosition)
        {
            var panDelta = PrimaryPointerPosition - pointerPosition;
            CameraPosition -= (Vector3.right * panDelta.x + Vector3.forward * panDelta.y) * touchPanSpeed * Time.deltaTime / 10;
            return PrimaryPointerPosition;
        }

        public Vector3 CameraPosition
        {
            get => orthoCamera.transform.position;
            set
            {
                var position = value;
                if (limitCameraXBounds)
                {
                    position.x = Mathf.Clamp(position.x, cameraXBounds.x, cameraXBounds.y);
                }

                if (limitCameraYBounds)
                {
                    position.z = Mathf.Clamp(position.z, cameraYBounds.x, cameraYBounds.y);
                }
                orthoCamera.transform.position = position;
            }
        }

        public float Zoom
        {
            get => orthoCamera.orthographicSize;
            set
            {
                var min = Mathf.Min(minZoom, maxZoom);
                var max = Mathf.Max(minZoom, maxZoom);
                orthoCamera.orthographicSize = value;
                orthoCamera.orthographicSize = Mathf.Clamp(orthoCamera.orthographicSize, min, max);
            }
        }
        
        

        private void StopTouchPan(InputAction.CallbackContext obj)
        {
            Debug.Log("Stop touch pan");
            StopCoroutine(_panCoroutine);
        }

        private void StartTouchPan(InputAction.CallbackContext obj)
        {
            Debug.Log("Start touch pan");
            _panCoroutine = StartCoroutine(PanCoroutine());   
        }

        private IEnumerator PanCoroutine()
        {
            var pointerPosition = PrimaryPointerPosition;
            while (true)
            {
                //Debug.Log("Pointer position: " + pointerPosition);
                pointerPosition = TouchPan(pointerPosition);
            }
        }

        public Vector2 MouseDelta => _inputActions.MouseInput.PanPosition.ReadValue<Vector2>();
        public Vector2 PrimaryPointerPosition => _inputActions.TouchInput.PrimaryTouchPosition.ReadValue<Vector2>();
        public Vector2 SecondaryPointerPosition => _inputActions.TouchInput.SecondaryTouchPosition.ReadValue<Vector2>();
        public float PinchDistance => Vector2.Distance(PrimaryPointerPosition, SecondaryPointerPosition);
    }
}