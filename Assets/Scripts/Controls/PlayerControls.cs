// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace inputMaster
{
    public class @InputMaster : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputMaster()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""BaseMovement"",
            ""id"": ""f5ca5350-21e6-486f-a2a1-cfc8deefcc72"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""de8064c3-af09-453f-92b7-0c58c27ba015"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePos"",
                    ""type"": ""PassThrough"",
                    ""id"": ""57a30e3b-cedb-4a5a-a8da-6c596bbc1f35"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Move"",
                    ""id"": ""9bf03a00-a78a-4365-aa85-ee6a8fbbcd32"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""07ebfa1c-897b-4556-9fe4-d45210511a84"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""47319f88-989a-44b8-a1bf-e170e9e1ded2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7d0e77c0-5c17-47e7-9c8e-9c4cfa933cf8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""837d62de-ae4e-44d1-abca-da9203416858"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8404e85d-de2c-47dd-a0d7-0fcdca27ae2e"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // BaseMovement
            m_BaseMovement = asset.FindActionMap("BaseMovement", throwIfNotFound: true);
            m_BaseMovement_Move = m_BaseMovement.FindAction("Move", throwIfNotFound: true);
            m_BaseMovement_MousePos = m_BaseMovement.FindAction("MousePos", throwIfNotFound: true);
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

        // BaseMovement
        private readonly InputActionMap m_BaseMovement;
        private IBaseMovementActions m_BaseMovementActionsCallbackInterface;
        private readonly InputAction m_BaseMovement_Move;
        private readonly InputAction m_BaseMovement_MousePos;
        public struct BaseMovementActions
        {
            private @InputMaster m_Wrapper;
            public BaseMovementActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_BaseMovement_Move;
            public InputAction @MousePos => m_Wrapper.m_BaseMovement_MousePos;
            public InputActionMap Get() { return m_Wrapper.m_BaseMovement; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BaseMovementActions set) { return set.Get(); }
            public void SetCallbacks(IBaseMovementActions instance)
            {
                if (m_Wrapper.m_BaseMovementActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnMove;
                    @MousePos.started -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnMousePos;
                    @MousePos.performed -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnMousePos;
                    @MousePos.canceled -= m_Wrapper.m_BaseMovementActionsCallbackInterface.OnMousePos;
                }
                m_Wrapper.m_BaseMovementActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @MousePos.started += instance.OnMousePos;
                    @MousePos.performed += instance.OnMousePos;
                    @MousePos.canceled += instance.OnMousePos;
                }
            }
        }
        public BaseMovementActions @BaseMovement => new BaseMovementActions(this);
        public interface IBaseMovementActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnMousePos(InputAction.CallbackContext context);
        }
    }
}
