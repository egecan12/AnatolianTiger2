//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputSystem/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""7c89500b-d8cb-44b4-a4a3-e500670cf450"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f8cf63d2-4974-4c62-9a85-ceb2ddcbe130"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""553fd5b9-bab8-4447-be76-0ccc77fe69ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""e6e010c7-7ecb-44eb-bc2b-db039e3f7c5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""236f0020-0eae-4552-ba0a-40ac4b91ee4f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""efda379f-5072-45a6-a1b2-1c559b5127c1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2d175ba4-50e9-4db4-b56e-31631c6bdd96"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""0787032b-0c9b-4180-91a0-1d070d722693"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4df4c3b0-22ea-46d2-8697-af9bc5919554"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cd326ea4-be56-471b-98da-89a99ce67f7a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4d855de7-b9d6-4e87-bb06-ff0842cf5e41"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9aa3b36e-6ea5-4f34-b4be-304053e08f11"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Episode2"",
            ""id"": ""6a01b0c9-cb68-4f20-91f4-64e9c2db0bb9"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""927118e7-c7b3-4a5a-beb4-67d44d26ed34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ee4fe5fb-1677-4836-98ba-febd85cadc6d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Episode3"",
            ""id"": ""3e0f65a0-7d4a-498e-9005-30c1548bfb50"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""879d8843-482f-40d9-bc8a-d03ed5cd8775"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""054a6559-d2b1-4a37-a2bd-8c785c985d62"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""LoadingScenes"",
            ""id"": ""c650e76a-7ccc-465f-b35a-f44f7d83c1f3"",
            ""actions"": [
                {
                    ""name"": ""PassScreen"",
                    ""type"": ""Button"",
                    ""id"": ""a340dbed-458e-442b-bf86-cb8370277240"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""68301003-21a9-43b0-951e-bb5118dc51aa"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PassScreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Attack = m_Gameplay.FindAction("Attack", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        // Episode2
        m_Episode2 = asset.FindActionMap("Episode2", throwIfNotFound: true);
        m_Episode2_Jump = m_Episode2.FindAction("Jump", throwIfNotFound: true);
        // Episode3
        m_Episode3 = asset.FindActionMap("Episode3", throwIfNotFound: true);
        m_Episode3_Jump = m_Episode3.FindAction("Jump", throwIfNotFound: true);
        // LoadingScenes
        m_LoadingScenes = asset.FindActionMap("LoadingScenes", throwIfNotFound: true);
        m_LoadingScenes_PassScreen = m_LoadingScenes.FindAction("PassScreen", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Attack;
    private readonly InputAction m_Gameplay_Jump;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Attack => m_Wrapper.m_Gameplay_Attack;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Episode2
    private readonly InputActionMap m_Episode2;
    private List<IEpisode2Actions> m_Episode2ActionsCallbackInterfaces = new List<IEpisode2Actions>();
    private readonly InputAction m_Episode2_Jump;
    public struct Episode2Actions
    {
        private @PlayerControls m_Wrapper;
        public Episode2Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Episode2_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Episode2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Episode2Actions set) { return set.Get(); }
        public void AddCallbacks(IEpisode2Actions instance)
        {
            if (instance == null || m_Wrapper.m_Episode2ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Episode2ActionsCallbackInterfaces.Add(instance);
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IEpisode2Actions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IEpisode2Actions instance)
        {
            if (m_Wrapper.m_Episode2ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IEpisode2Actions instance)
        {
            foreach (var item in m_Wrapper.m_Episode2ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Episode2ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Episode2Actions @Episode2 => new Episode2Actions(this);

    // Episode3
    private readonly InputActionMap m_Episode3;
    private List<IEpisode3Actions> m_Episode3ActionsCallbackInterfaces = new List<IEpisode3Actions>();
    private readonly InputAction m_Episode3_Jump;
    public struct Episode3Actions
    {
        private @PlayerControls m_Wrapper;
        public Episode3Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Episode3_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Episode3; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Episode3Actions set) { return set.Get(); }
        public void AddCallbacks(IEpisode3Actions instance)
        {
            if (instance == null || m_Wrapper.m_Episode3ActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_Episode3ActionsCallbackInterfaces.Add(instance);
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IEpisode3Actions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IEpisode3Actions instance)
        {
            if (m_Wrapper.m_Episode3ActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IEpisode3Actions instance)
        {
            foreach (var item in m_Wrapper.m_Episode3ActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_Episode3ActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public Episode3Actions @Episode3 => new Episode3Actions(this);

    // LoadingScenes
    private readonly InputActionMap m_LoadingScenes;
    private List<ILoadingScenesActions> m_LoadingScenesActionsCallbackInterfaces = new List<ILoadingScenesActions>();
    private readonly InputAction m_LoadingScenes_PassScreen;
    public struct LoadingScenesActions
    {
        private @PlayerControls m_Wrapper;
        public LoadingScenesActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PassScreen => m_Wrapper.m_LoadingScenes_PassScreen;
        public InputActionMap Get() { return m_Wrapper.m_LoadingScenes; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LoadingScenesActions set) { return set.Get(); }
        public void AddCallbacks(ILoadingScenesActions instance)
        {
            if (instance == null || m_Wrapper.m_LoadingScenesActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_LoadingScenesActionsCallbackInterfaces.Add(instance);
            @PassScreen.started += instance.OnPassScreen;
            @PassScreen.performed += instance.OnPassScreen;
            @PassScreen.canceled += instance.OnPassScreen;
        }

        private void UnregisterCallbacks(ILoadingScenesActions instance)
        {
            @PassScreen.started -= instance.OnPassScreen;
            @PassScreen.performed -= instance.OnPassScreen;
            @PassScreen.canceled -= instance.OnPassScreen;
        }

        public void RemoveCallbacks(ILoadingScenesActions instance)
        {
            if (m_Wrapper.m_LoadingScenesActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ILoadingScenesActions instance)
        {
            foreach (var item in m_Wrapper.m_LoadingScenesActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_LoadingScenesActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public LoadingScenesActions @LoadingScenes => new LoadingScenesActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IEpisode2Actions
    {
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IEpisode3Actions
    {
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ILoadingScenesActions
    {
        void OnPassScreen(InputAction.CallbackContext context);
    }
}
