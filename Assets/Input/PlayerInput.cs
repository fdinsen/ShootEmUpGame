// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""CombatMovement"",
            ""id"": ""0d492d38-5aaa-42c2-a588-dbccb0843086"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""fb2243eb-69f0-4a41-b09c-0e1bc1d0eb94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""0df65bdc-915f-42ba-b1ba-177dcf8a6434"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryAttack"",
                    ""type"": ""Button"",
                    ""id"": ""686d132b-943c-4538-9351-cff979f9b301"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""063304ed-f052-4482-a612-3d74a3745d5d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fe171451-1574-4410-884c-81078407448e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""210112a9-7dbe-42f1-ad2d-170b7a0a6429"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ea61901b-7cc0-4bc6-b833-643424d402dd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d8db5c12-85e1-4f69-8876-b71beccbd2cb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4cbdb40c-f713-488a-885e-e08368dcba76"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68fcbef4-4b01-4e36-839b-696bc82eace2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryAttack"",
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
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""a6b95178-543f-423b-9ae8-e412e7676fcb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""91bc04a4-0d35-4cc4-8229-545f218be567"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1502c51c-2aa8-4326-a019-9826d2070109"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1c063604-cf2f-4f20-9a08-86fc5c4268c7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c40f5cb6-1821-46f0-9483-4597fb688500"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f0220fbf-e1de-4848-bda2-41a9020db9a5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""913b29eb-05c8-40ee-86a3-96f3ddd2d660"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a366b1c2-85e0-4118-884f-bc4597e38e76"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
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
        m_CombatMovement_Movement = m_CombatMovement.FindAction("Movement", throwIfNotFound: true);
        m_CombatMovement_Mouse = m_CombatMovement.FindAction("Mouse", throwIfNotFound: true);
        m_CombatMovement_PrimaryAttack = m_CombatMovement.FindAction("PrimaryAttack", throwIfNotFound: true);
        // 2DMovement
        m__2DMovement = asset.FindActionMap("2DMovement", throwIfNotFound: true);
        m__2DMovement_Movement = m__2DMovement.FindAction("Movement", throwIfNotFound: true);
        m__2DMovement_Interact = m__2DMovement.FindAction("Interact", throwIfNotFound: true);
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
    private readonly InputAction m_CombatMovement_Movement;
    private readonly InputAction m_CombatMovement_Mouse;
    private readonly InputAction m_CombatMovement_PrimaryAttack;
    public struct CombatMovementActions
    {
        private @PlayerInput m_Wrapper;
        public CombatMovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_CombatMovement_Movement;
        public InputAction @Mouse => m_Wrapper.m_CombatMovement_Mouse;
        public InputAction @PrimaryAttack => m_Wrapper.m_CombatMovement_PrimaryAttack;
        public InputActionMap Get() { return m_Wrapper.m_CombatMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatMovementActions set) { return set.Get(); }
        public void SetCallbacks(ICombatMovementActions instance)
        {
            if (m_Wrapper.m_CombatMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CombatMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CombatMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CombatMovementActionsCallbackInterface.OnMovement;
                @Mouse.started -= m_Wrapper.m_CombatMovementActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_CombatMovementActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_CombatMovementActionsCallbackInterface.OnMouse;
                @PrimaryAttack.started -= m_Wrapper.m_CombatMovementActionsCallbackInterface.OnPrimaryAttack;
                @PrimaryAttack.performed -= m_Wrapper.m_CombatMovementActionsCallbackInterface.OnPrimaryAttack;
                @PrimaryAttack.canceled -= m_Wrapper.m_CombatMovementActionsCallbackInterface.OnPrimaryAttack;
            }
            m_Wrapper.m_CombatMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @PrimaryAttack.started += instance.OnPrimaryAttack;
                @PrimaryAttack.performed += instance.OnPrimaryAttack;
                @PrimaryAttack.canceled += instance.OnPrimaryAttack;
            }
        }
    }
    public CombatMovementActions @CombatMovement => new CombatMovementActions(this);

    // 2DMovement
    private readonly InputActionMap m__2DMovement;
    private I_2DMovementActions m__2DMovementActionsCallbackInterface;
    private readonly InputAction m__2DMovement_Movement;
    private readonly InputAction m__2DMovement_Interact;
    public struct _2DMovementActions
    {
        private @PlayerInput m_Wrapper;
        public _2DMovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m__2DMovement_Movement;
        public InputAction @Interact => m_Wrapper.m__2DMovement_Interact;
        public InputActionMap Get() { return m_Wrapper.m__2DMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_2DMovementActions set) { return set.Get(); }
        public void SetCallbacks(I_2DMovementActions instance)
        {
            if (m_Wrapper.m__2DMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m__2DMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m__2DMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m__2DMovementActionsCallbackInterface.OnMovement;
                @Interact.started -= m_Wrapper.m__2DMovementActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m__2DMovementActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m__2DMovementActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m__2DMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public _2DMovementActions @_2DMovement => new _2DMovementActions(this);
    public interface ICombatMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
        void OnPrimaryAttack(InputAction.CallbackContext context);
    }
    public interface I_2DMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
