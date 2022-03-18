//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Packages/com.doubtech.unity.orthotopdowncamera/Scripts/Runtime/TouchOrthoPanZoomInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace DoubTech.OrthoTopdownCamera
{
    public partial class @TouchOrthoPanZoomInput : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @TouchOrthoPanZoomInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchOrthoPanZoomInput"",
    ""maps"": [
        {
            ""name"": ""TouchInput"",
            ""id"": ""1e770fda-8ac7-4ca0-88f1-e79c693db573"",
            ""actions"": [
                {
                    ""name"": ""PrimaryTouchPosition"",
                    ""type"": ""Value"",
                    ""id"": ""dba36431-499d-430a-9e0c-b91d15cebba1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryTouchPosition"",
                    ""type"": ""Value"",
                    ""id"": ""8bf60564-0ba9-484d-835e-3df5e05937e2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryTouchContact"",
                    ""type"": ""Button"",
                    ""id"": ""e77589ed-22bc-4686-b4ff-f0146948a684"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PrimaryTouchContact"",
                    ""type"": ""Button"",
                    ""id"": ""22c25432-0af7-470c-a7e6-236bd5499af7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a84702fe-f137-43fe-9b39-f31584476cd6"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryTouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df0bc045-7619-4eee-9be4-a58f93fe6305"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d065f0ab-3024-459d-ba51-18da827eb498"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouchContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f225180-3475-492b-b02f-9af4fa4da6ed"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryTouchContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MouseInput"",
            ""id"": ""370d3315-7f9b-4a95-9c97-b434371d9728"",
            ""actions"": [
                {
                    ""name"": ""PanPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7b4571bc-6dfb-4a5c-881b-299bf6dff794"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PanClick"",
                    ""type"": ""Button"",
                    ""id"": ""02de87b7-7fcb-4155-921f-04cfe0305f3e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""31652fc5-15c0-4b2c-b0cb-d1c398dbf33f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""44fe72f7-7317-41a3-a53d-f0f8b08c5cc3"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PanPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46201211-7ba3-42d2-9c50-844e586e67df"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PanClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""059bdf8e-6332-4949-bf09-cb50ab39c83b"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // TouchInput
            m_TouchInput = asset.FindActionMap("TouchInput", throwIfNotFound: true);
            m_TouchInput_PrimaryTouchPosition = m_TouchInput.FindAction("PrimaryTouchPosition", throwIfNotFound: true);
            m_TouchInput_SecondaryTouchPosition = m_TouchInput.FindAction("SecondaryTouchPosition", throwIfNotFound: true);
            m_TouchInput_SecondaryTouchContact = m_TouchInput.FindAction("SecondaryTouchContact", throwIfNotFound: true);
            m_TouchInput_PrimaryTouchContact = m_TouchInput.FindAction("PrimaryTouchContact", throwIfNotFound: true);
            // MouseInput
            m_MouseInput = asset.FindActionMap("MouseInput", throwIfNotFound: true);
            m_MouseInput_PanPosition = m_MouseInput.FindAction("PanPosition", throwIfNotFound: true);
            m_MouseInput_PanClick = m_MouseInput.FindAction("PanClick", throwIfNotFound: true);
            m_MouseInput_Zoom = m_MouseInput.FindAction("Zoom", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // TouchInput
        private readonly InputActionMap m_TouchInput;
        private ITouchInputActions m_TouchInputActionsCallbackInterface;
        private readonly InputAction m_TouchInput_PrimaryTouchPosition;
        private readonly InputAction m_TouchInput_SecondaryTouchPosition;
        private readonly InputAction m_TouchInput_SecondaryTouchContact;
        private readonly InputAction m_TouchInput_PrimaryTouchContact;
        public struct TouchInputActions
        {
            private @TouchOrthoPanZoomInput m_Wrapper;
            public TouchInputActions(@TouchOrthoPanZoomInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @PrimaryTouchPosition => m_Wrapper.m_TouchInput_PrimaryTouchPosition;
            public InputAction @SecondaryTouchPosition => m_Wrapper.m_TouchInput_SecondaryTouchPosition;
            public InputAction @SecondaryTouchContact => m_Wrapper.m_TouchInput_SecondaryTouchContact;
            public InputAction @PrimaryTouchContact => m_Wrapper.m_TouchInput_PrimaryTouchContact;
            public InputActionMap Get() { return m_Wrapper.m_TouchInput; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TouchInputActions set) { return set.Get(); }
            public void SetCallbacks(ITouchInputActions instance)
            {
                if (m_Wrapper.m_TouchInputActionsCallbackInterface != null)
                {
                    @PrimaryTouchPosition.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnPrimaryTouchPosition;
                    @PrimaryTouchPosition.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnPrimaryTouchPosition;
                    @PrimaryTouchPosition.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnPrimaryTouchPosition;
                    @SecondaryTouchPosition.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnSecondaryTouchPosition;
                    @SecondaryTouchPosition.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnSecondaryTouchPosition;
                    @SecondaryTouchPosition.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnSecondaryTouchPosition;
                    @SecondaryTouchContact.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnSecondaryTouchContact;
                    @SecondaryTouchContact.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnSecondaryTouchContact;
                    @SecondaryTouchContact.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnSecondaryTouchContact;
                    @PrimaryTouchContact.started -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnPrimaryTouchContact;
                    @PrimaryTouchContact.performed -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnPrimaryTouchContact;
                    @PrimaryTouchContact.canceled -= m_Wrapper.m_TouchInputActionsCallbackInterface.OnPrimaryTouchContact;
                }
                m_Wrapper.m_TouchInputActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @PrimaryTouchPosition.started += instance.OnPrimaryTouchPosition;
                    @PrimaryTouchPosition.performed += instance.OnPrimaryTouchPosition;
                    @PrimaryTouchPosition.canceled += instance.OnPrimaryTouchPosition;
                    @SecondaryTouchPosition.started += instance.OnSecondaryTouchPosition;
                    @SecondaryTouchPosition.performed += instance.OnSecondaryTouchPosition;
                    @SecondaryTouchPosition.canceled += instance.OnSecondaryTouchPosition;
                    @SecondaryTouchContact.started += instance.OnSecondaryTouchContact;
                    @SecondaryTouchContact.performed += instance.OnSecondaryTouchContact;
                    @SecondaryTouchContact.canceled += instance.OnSecondaryTouchContact;
                    @PrimaryTouchContact.started += instance.OnPrimaryTouchContact;
                    @PrimaryTouchContact.performed += instance.OnPrimaryTouchContact;
                    @PrimaryTouchContact.canceled += instance.OnPrimaryTouchContact;
                }
            }
        }
        public TouchInputActions @TouchInput => new TouchInputActions(this);

        // MouseInput
        private readonly InputActionMap m_MouseInput;
        private IMouseInputActions m_MouseInputActionsCallbackInterface;
        private readonly InputAction m_MouseInput_PanPosition;
        private readonly InputAction m_MouseInput_PanClick;
        private readonly InputAction m_MouseInput_Zoom;
        public struct MouseInputActions
        {
            private @TouchOrthoPanZoomInput m_Wrapper;
            public MouseInputActions(@TouchOrthoPanZoomInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @PanPosition => m_Wrapper.m_MouseInput_PanPosition;
            public InputAction @PanClick => m_Wrapper.m_MouseInput_PanClick;
            public InputAction @Zoom => m_Wrapper.m_MouseInput_Zoom;
            public InputActionMap Get() { return m_Wrapper.m_MouseInput; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MouseInputActions set) { return set.Get(); }
            public void SetCallbacks(IMouseInputActions instance)
            {
                if (m_Wrapper.m_MouseInputActionsCallbackInterface != null)
                {
                    @PanPosition.started -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnPanPosition;
                    @PanPosition.performed -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnPanPosition;
                    @PanPosition.canceled -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnPanPosition;
                    @PanClick.started -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnPanClick;
                    @PanClick.performed -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnPanClick;
                    @PanClick.canceled -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnPanClick;
                    @Zoom.started -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnZoom;
                    @Zoom.performed -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnZoom;
                    @Zoom.canceled -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnZoom;
                }
                m_Wrapper.m_MouseInputActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @PanPosition.started += instance.OnPanPosition;
                    @PanPosition.performed += instance.OnPanPosition;
                    @PanPosition.canceled += instance.OnPanPosition;
                    @PanClick.started += instance.OnPanClick;
                    @PanClick.performed += instance.OnPanClick;
                    @PanClick.canceled += instance.OnPanClick;
                    @Zoom.started += instance.OnZoom;
                    @Zoom.performed += instance.OnZoom;
                    @Zoom.canceled += instance.OnZoom;
                }
            }
        }
        public MouseInputActions @MouseInput => new MouseInputActions(this);
        public interface ITouchInputActions
        {
            void OnPrimaryTouchPosition(InputAction.CallbackContext context);
            void OnSecondaryTouchPosition(InputAction.CallbackContext context);
            void OnSecondaryTouchContact(InputAction.CallbackContext context);
            void OnPrimaryTouchContact(InputAction.CallbackContext context);
        }
        public interface IMouseInputActions
        {
            void OnPanPosition(InputAction.CallbackContext context);
            void OnPanClick(InputAction.CallbackContext context);
            void OnZoom(InputAction.CallbackContext context);
        }
    }
}