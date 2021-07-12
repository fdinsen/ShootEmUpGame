// GENERATED AUTOMATICALLY FROM 'Assets/Input/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""CombatMovement"",
            ""id"": ""0d492d38-5aaa-42c2-a588-dbccb0843086"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""fb2243eb-69f0-4a41-b09c-0e1bc1d0eb94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8050be1a-0014-4033-9e36-96a3c5047c4f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""2DMovement"",
            ""id"": ""f6553863-75f7-4f33-982a-a811b5575b84"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""a6b95178-543f-423b-9ae8-e412e7676fcb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fb4f7e25-5d0e-41a8-a434-67908fde8d98"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CombatMovement
        m_CombatMovement = asset.FindActionMap("CombatMovement", throwIfNotFound: true);
        m_CombatMovement_Newaction = m_CombatMovement.FindAction("New action", throwIfNotFound: true);
        // 2DMovement
        m__2DMovement = asset.FindActionMap("2DMovement", throwIfNotFound: true);
        m__2DMovement_Newaction = m__2DMovement.FindAction("New action", throwIfNotFound: true);
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

    // CombatMovement
    private readonly InputActionMap m_CombatMovement;
    private ICombatMovementActions m_CombatMovementActionsCallbackInterface;
    private readonly InputAction m_CombatMovement_Newaction;
    public struct CombatMovementActions
    {
        private @Input m_Wrapper;
        public CombatMovementActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_CombatMovement_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_CombatMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatMovementActions set) { return set.Get(); }
        public void SetCallbacks(ICombatMovementActions instance)
        {
            if (m_Wrapper.m_CombatMovementActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_CombatMovementActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_CombatMovementActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_CombatMovementActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_CombatMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public CombatMovementActions @CombatMovement => new CombatMovementActions(this);

    // 2DMovement
    private readonly InputActionMap m__2DMovement;
    private I_2DMovementActions m__2DMovementActionsCallbackInterface;
    private readonly InputAction m__2DMovement_Newaction;
    public struct _2DMovementActions
    {
        private @Input m_Wrapper;
        public _2DMovementActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m__2DMovement_Newaction;
        public InputActionMap Get() { return m_Wrapper.m__2DMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_2DMovementActions set) { return set.Get(); }
        public void SetCallbacks(I_2DMovementActions instance)
        {
            if (m_Wrapper.m__2DMovementActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m__2DMovementActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m__2DMovementActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m__2DMovementActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m__2DMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public _2DMovementActions @_2DMovement => new _2DMovementActions(this);
    public interface ICombatMovementActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface I_2DMovementActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
