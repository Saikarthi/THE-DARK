// GENERATED AUTOMATICALLY FROM 'Assets/code/player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""player"",
    ""maps"": [
        {
            ""name"": ""player_one"",
            ""id"": ""53e0eed4-5bf3-4810-8973-0aafbdad4b0b"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""308bd423-989c-4560-a5f1-cbb9dd52af50"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""wasd"",
                    ""id"": ""4efbe5f8-1600-4a5b-8f29-6ab0c7295269"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""580581e6-9dd2-4c66-9c6e-7f2f8ae157ee"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1f11259a-ba6f-43ad-b011-68b45b21c1ed"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e4b5908e-9907-4618-8945-7d2959900c6e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fe3a0cdf-ac3e-4b25-9b94-227dc1762f23"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""player_two"",
            ""id"": ""a9a19db5-99a6-40bd-8804-2312295d3f78"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""9ef1200c-8e54-4bde-bf5b-e437436b1b31"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""arrow"",
                    ""id"": ""b4cd506e-d026-4b5a-b96e-8c7912067e7e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""543636b5-0209-46fb-8f03-220016eeb67c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a780d0cb-0222-4bea-ab8a-7fb7c901116f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""57bbacf1-e616-4c66-9894-216ff8302200"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e351e651-1d59-4683-9212-20d028cae9ea"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""camera"",
            ""id"": ""743784f4-2986-4286-afc2-77d867a1a8b1"",
            ""actions"": [
                {
                    ""name"": ""cammove"",
                    ""type"": ""Button"",
                    ""id"": ""6b8e3e10-2429-47b9-8bbb-17b4308ad71a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d88cb9cc-4774-44cb-9005-97daf33f4144"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cammove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""hint"",
            ""id"": ""7adbaf55-1b8c-46f9-99fc-04910aaa8f32"",
            ""actions"": [
                {
                    ""name"": ""hint"",
                    ""type"": ""Button"",
                    ""id"": ""cf8a8aff-373e-42d5-95b2-df4143cc5042"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""restart"",
                    ""type"": ""Button"",
                    ""id"": ""8e845547-f185-493d-9aa2-0e5e80df99a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26b0f395-497b-4514-9676-63b9e2eb8f17"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf2f1f7e-5c77-4a2a-94fe-466f56dc4249"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // player_one
        m_player_one = asset.FindActionMap("player_one", throwIfNotFound: true);
        m_player_one_move = m_player_one.FindAction("move", throwIfNotFound: true);
        // player_two
        m_player_two = asset.FindActionMap("player_two", throwIfNotFound: true);
        m_player_two_move = m_player_two.FindAction("move", throwIfNotFound: true);
        // camera
        m_camera = asset.FindActionMap("camera", throwIfNotFound: true);
        m_camera_cammove = m_camera.FindAction("cammove", throwIfNotFound: true);
        // hint
        m_hint = asset.FindActionMap("hint", throwIfNotFound: true);
        m_hint_hint = m_hint.FindAction("hint", throwIfNotFound: true);
        m_hint_restart = m_hint.FindAction("restart", throwIfNotFound: true);
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

    // player_one
    private readonly InputActionMap m_player_one;
    private IPlayer_oneActions m_Player_oneActionsCallbackInterface;
    private readonly InputAction m_player_one_move;
    public struct Player_oneActions
    {
        private @Player m_Wrapper;
        public Player_oneActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player_one_move;
        public InputActionMap Get() { return m_Wrapper.m_player_one; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_oneActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_oneActions instance)
        {
            if (m_Wrapper.m_Player_oneActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_Player_oneActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_Player_oneActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_Player_oneActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_Player_oneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
            }
        }
    }
    public Player_oneActions @player_one => new Player_oneActions(this);

    // player_two
    private readonly InputActionMap m_player_two;
    private IPlayer_twoActions m_Player_twoActionsCallbackInterface;
    private readonly InputAction m_player_two_move;
    public struct Player_twoActions
    {
        private @Player m_Wrapper;
        public Player_twoActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player_two_move;
        public InputActionMap Get() { return m_Wrapper.m_player_two; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player_twoActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer_twoActions instance)
        {
            if (m_Wrapper.m_Player_twoActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_Player_twoActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_Player_twoActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_Player_twoActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_Player_twoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
            }
        }
    }
    public Player_twoActions @player_two => new Player_twoActions(this);

    // camera
    private readonly InputActionMap m_camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_camera_cammove;
    public struct CameraActions
    {
        private @Player m_Wrapper;
        public CameraActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @cammove => m_Wrapper.m_camera_cammove;
        public InputActionMap Get() { return m_Wrapper.m_camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @cammove.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnCammove;
                @cammove.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnCammove;
                @cammove.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnCammove;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @cammove.started += instance.OnCammove;
                @cammove.performed += instance.OnCammove;
                @cammove.canceled += instance.OnCammove;
            }
        }
    }
    public CameraActions @camera => new CameraActions(this);

    // hint
    private readonly InputActionMap m_hint;
    private IHintActions m_HintActionsCallbackInterface;
    private readonly InputAction m_hint_hint;
    private readonly InputAction m_hint_restart;
    public struct HintActions
    {
        private @Player m_Wrapper;
        public HintActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @hint => m_Wrapper.m_hint_hint;
        public InputAction @restart => m_Wrapper.m_hint_restart;
        public InputActionMap Get() { return m_Wrapper.m_hint; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HintActions set) { return set.Get(); }
        public void SetCallbacks(IHintActions instance)
        {
            if (m_Wrapper.m_HintActionsCallbackInterface != null)
            {
                @hint.started -= m_Wrapper.m_HintActionsCallbackInterface.OnHint;
                @hint.performed -= m_Wrapper.m_HintActionsCallbackInterface.OnHint;
                @hint.canceled -= m_Wrapper.m_HintActionsCallbackInterface.OnHint;
                @restart.started -= m_Wrapper.m_HintActionsCallbackInterface.OnRestart;
                @restart.performed -= m_Wrapper.m_HintActionsCallbackInterface.OnRestart;
                @restart.canceled -= m_Wrapper.m_HintActionsCallbackInterface.OnRestart;
            }
            m_Wrapper.m_HintActionsCallbackInterface = instance;
            if (instance != null)
            {
                @hint.started += instance.OnHint;
                @hint.performed += instance.OnHint;
                @hint.canceled += instance.OnHint;
                @restart.started += instance.OnRestart;
                @restart.performed += instance.OnRestart;
                @restart.canceled += instance.OnRestart;
            }
        }
    }
    public HintActions @hint => new HintActions(this);
    public interface IPlayer_oneActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IPlayer_twoActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnCammove(InputAction.CallbackContext context);
    }
    public interface IHintActions
    {
        void OnHint(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
    }
}
