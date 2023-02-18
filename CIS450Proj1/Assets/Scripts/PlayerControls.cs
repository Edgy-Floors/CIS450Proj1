//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""BasicActions"",
            ""id"": ""49673c4a-fd08-40af-aba0-e2d872461fef"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""60bb03c2-cd00-44f5-950f-64fe4d574694"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""729bbc02-0656-4432-9a65-83a20ee24410"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Smell"",
                    ""type"": ""Button"",
                    ""id"": ""7bd88942-5dcf-4cb3-ba9a-5d8c872490ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Water"",
                    ""type"": ""Button"",
                    ""id"": ""afd0a0ad-0dc1-4010-aadc-a8473eb72391"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""576aed60-fcb8-4234-a8a4-fb3a56474357"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29bfd747-f935-4d0d-b7a6-dbc17db86752"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Smell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cdb7e04-88a8-4c1e-85fc-6d2b90dccefb"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Smell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3339fa34-374d-4c8d-90b0-4fc99df6cb57"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Water"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54cee741-dc57-4bf5-b638-37382837c6a9"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Water"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c878e934-2329-4cf3-a2d1-4e3b9b29303b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b3d0d95f-ea7b-48aa-946c-33ef2c0447a7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b68dc1f5-b1aa-48b5-9e11-9d8e910d6503"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bec3426f-aac9-4306-bfe4-8742f6a97b9d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e01dc138-7c8c-4fca-8030-b0a7f8b5d8de"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""MiniGameActions"",
            ""id"": ""d2a36738-6bcd-4ada-b420-d9a931d439b0"",
            ""actions"": [
                {
                    ""name"": ""StopTimingBar"",
                    ""type"": ""Button"",
                    ""id"": ""809dee25-ecf9-4fe0-96a2-5622d970f92a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""1Key"",
                    ""type"": ""Button"",
                    ""id"": ""adf1b1a8-950d-482d-aa53-da9f19a04c17"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""2Key"",
                    ""type"": ""Button"",
                    ""id"": ""5c70c9bb-eba1-4d43-bfe9-5b8968f840ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""3Key"",
                    ""type"": ""Button"",
                    ""id"": ""4b85c83a-4d27-44fd-8331-3e851edcb6bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""4Key"",
                    ""type"": ""Button"",
                    ""id"": ""092c15fc-ba55-4cb1-a981-578178aa356e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""5Key"",
                    ""type"": ""Button"",
                    ""id"": ""8c58027b-b0e6-48fc-b6bb-ed841c48fad5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""6Key"",
                    ""type"": ""Button"",
                    ""id"": ""e8957050-d5a6-4f71-8e4f-954180f9c1a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""7Key"",
                    ""type"": ""Button"",
                    ""id"": ""7c59ee1d-a0a6-46a3-9928-370ac0830f38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""8Key"",
                    ""type"": ""Button"",
                    ""id"": ""009ac0b5-4757-405c-b729-9a9648e9544d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""9Key"",
                    ""type"": ""Button"",
                    ""id"": ""229ad331-05b0-4f40-a9f0-d3c8b71ee1f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""391dc69c-e008-4056-addb-0fe8035924c2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopTimingBar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6680bd38-9c7c-4d96-ae4f-f7ef84ead2f6"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""1Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9df26c5d-66a8-47d3-8d2e-baddf4fe9a82"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""2Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d34a8aaa-d40d-453c-8b03-c612fea3d509"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""3Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54699ecf-2405-419b-b913-ec34adef0b09"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""4Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2261fdfe-04a8-4e15-b1d0-33a9c6519ab2"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""5Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""538babb4-e0b2-43e9-b5c7-3c1edd5a033b"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""6Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48db1b35-8c06-4042-9fa6-22495b03ee13"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""7Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c52dbafb-408a-4e3c-8e2b-8a4203eacdae"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""8Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a7c3a87-680b-43d7-93d1-358bd72c432b"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""9Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BasicActions
        m_BasicActions = asset.FindActionMap("BasicActions", throwIfNotFound: true);
        m_BasicActions_Walk = m_BasicActions.FindAction("Walk", throwIfNotFound: true);
        m_BasicActions_Run = m_BasicActions.FindAction("Run", throwIfNotFound: true);
        m_BasicActions_Smell = m_BasicActions.FindAction("Smell", throwIfNotFound: true);
        m_BasicActions_Water = m_BasicActions.FindAction("Water", throwIfNotFound: true);
        // MiniGameActions
        m_MiniGameActions = asset.FindActionMap("MiniGameActions", throwIfNotFound: true);
        m_MiniGameActions_StopTimingBar = m_MiniGameActions.FindAction("StopTimingBar", throwIfNotFound: true);
        m_MiniGameActions__1Key = m_MiniGameActions.FindAction("1Key", throwIfNotFound: true);
        m_MiniGameActions__2Key = m_MiniGameActions.FindAction("2Key", throwIfNotFound: true);
        m_MiniGameActions__3Key = m_MiniGameActions.FindAction("3Key", throwIfNotFound: true);
        m_MiniGameActions__4Key = m_MiniGameActions.FindAction("4Key", throwIfNotFound: true);
        m_MiniGameActions__5Key = m_MiniGameActions.FindAction("5Key", throwIfNotFound: true);
        m_MiniGameActions__6Key = m_MiniGameActions.FindAction("6Key", throwIfNotFound: true);
        m_MiniGameActions__7Key = m_MiniGameActions.FindAction("7Key", throwIfNotFound: true);
        m_MiniGameActions__8Key = m_MiniGameActions.FindAction("8Key", throwIfNotFound: true);
        m_MiniGameActions__9Key = m_MiniGameActions.FindAction("9Key", throwIfNotFound: true);
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

    // BasicActions
    private readonly InputActionMap m_BasicActions;
    private IBasicActionsActions m_BasicActionsActionsCallbackInterface;
    private readonly InputAction m_BasicActions_Walk;
    private readonly InputAction m_BasicActions_Run;
    private readonly InputAction m_BasicActions_Smell;
    private readonly InputAction m_BasicActions_Water;
    public struct BasicActionsActions
    {
        private @PlayerControls m_Wrapper;
        public BasicActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_BasicActions_Walk;
        public InputAction @Run => m_Wrapper.m_BasicActions_Run;
        public InputAction @Smell => m_Wrapper.m_BasicActions_Smell;
        public InputAction @Water => m_Wrapper.m_BasicActions_Water;
        public InputActionMap Get() { return m_Wrapper.m_BasicActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicActionsActions set) { return set.Get(); }
        public void SetCallbacks(IBasicActionsActions instance)
        {
            if (m_Wrapper.m_BasicActionsActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnWalk;
                @Run.started -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnRun;
                @Smell.started -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnSmell;
                @Smell.performed -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnSmell;
                @Smell.canceled -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnSmell;
                @Water.started -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnWater;
                @Water.performed -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnWater;
                @Water.canceled -= m_Wrapper.m_BasicActionsActionsCallbackInterface.OnWater;
            }
            m_Wrapper.m_BasicActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Smell.started += instance.OnSmell;
                @Smell.performed += instance.OnSmell;
                @Smell.canceled += instance.OnSmell;
                @Water.started += instance.OnWater;
                @Water.performed += instance.OnWater;
                @Water.canceled += instance.OnWater;
            }
        }
    }
    public BasicActionsActions @BasicActions => new BasicActionsActions(this);

    // MiniGameActions
    private readonly InputActionMap m_MiniGameActions;
    private IMiniGameActionsActions m_MiniGameActionsActionsCallbackInterface;
    private readonly InputAction m_MiniGameActions_StopTimingBar;
    private readonly InputAction m_MiniGameActions__1Key;
    private readonly InputAction m_MiniGameActions__2Key;
    private readonly InputAction m_MiniGameActions__3Key;
    private readonly InputAction m_MiniGameActions__4Key;
    private readonly InputAction m_MiniGameActions__5Key;
    private readonly InputAction m_MiniGameActions__6Key;
    private readonly InputAction m_MiniGameActions__7Key;
    private readonly InputAction m_MiniGameActions__8Key;
    private readonly InputAction m_MiniGameActions__9Key;
    public struct MiniGameActionsActions
    {
        private @PlayerControls m_Wrapper;
        public MiniGameActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @StopTimingBar => m_Wrapper.m_MiniGameActions_StopTimingBar;
        public InputAction @_1Key => m_Wrapper.m_MiniGameActions__1Key;
        public InputAction @_2Key => m_Wrapper.m_MiniGameActions__2Key;
        public InputAction @_3Key => m_Wrapper.m_MiniGameActions__3Key;
        public InputAction @_4Key => m_Wrapper.m_MiniGameActions__4Key;
        public InputAction @_5Key => m_Wrapper.m_MiniGameActions__5Key;
        public InputAction @_6Key => m_Wrapper.m_MiniGameActions__6Key;
        public InputAction @_7Key => m_Wrapper.m_MiniGameActions__7Key;
        public InputAction @_8Key => m_Wrapper.m_MiniGameActions__8Key;
        public InputAction @_9Key => m_Wrapper.m_MiniGameActions__9Key;
        public InputActionMap Get() { return m_Wrapper.m_MiniGameActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MiniGameActionsActions set) { return set.Get(); }
        public void SetCallbacks(IMiniGameActionsActions instance)
        {
            if (m_Wrapper.m_MiniGameActionsActionsCallbackInterface != null)
            {
                @StopTimingBar.started -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.OnStopTimingBar;
                @StopTimingBar.performed -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.OnStopTimingBar;
                @StopTimingBar.canceled -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.OnStopTimingBar;
                @_1Key.started -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_1Key;
                @_1Key.performed -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_1Key;
                @_1Key.canceled -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_1Key;
                @_2Key.started -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_2Key;
                @_2Key.performed -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_2Key;
                @_2Key.canceled -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_2Key;
                @_3Key.started -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_3Key;
                @_3Key.performed -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_3Key;
                @_3Key.canceled -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_3Key;
                @_4Key.started -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_4Key;
                @_4Key.performed -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_4Key;
                @_4Key.canceled -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_4Key;
                @_5Key.started -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_5Key;
                @_5Key.performed -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_5Key;
                @_5Key.canceled -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_5Key;
                @_6Key.started -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_6Key;
                @_6Key.performed -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_6Key;
                @_6Key.canceled -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_6Key;
                @_7Key.started -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_7Key;
                @_7Key.performed -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_7Key;
                @_7Key.canceled -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_7Key;
                @_8Key.started -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_8Key;
                @_8Key.performed -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_8Key;
                @_8Key.canceled -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_8Key;
                @_9Key.started -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_9Key;
                @_9Key.performed -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_9Key;
                @_9Key.canceled -= m_Wrapper.m_MiniGameActionsActionsCallbackInterface.On_9Key;
            }
            m_Wrapper.m_MiniGameActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @StopTimingBar.started += instance.OnStopTimingBar;
                @StopTimingBar.performed += instance.OnStopTimingBar;
                @StopTimingBar.canceled += instance.OnStopTimingBar;
                @_1Key.started += instance.On_1Key;
                @_1Key.performed += instance.On_1Key;
                @_1Key.canceled += instance.On_1Key;
                @_2Key.started += instance.On_2Key;
                @_2Key.performed += instance.On_2Key;
                @_2Key.canceled += instance.On_2Key;
                @_3Key.started += instance.On_3Key;
                @_3Key.performed += instance.On_3Key;
                @_3Key.canceled += instance.On_3Key;
                @_4Key.started += instance.On_4Key;
                @_4Key.performed += instance.On_4Key;
                @_4Key.canceled += instance.On_4Key;
                @_5Key.started += instance.On_5Key;
                @_5Key.performed += instance.On_5Key;
                @_5Key.canceled += instance.On_5Key;
                @_6Key.started += instance.On_6Key;
                @_6Key.performed += instance.On_6Key;
                @_6Key.canceled += instance.On_6Key;
                @_7Key.started += instance.On_7Key;
                @_7Key.performed += instance.On_7Key;
                @_7Key.canceled += instance.On_7Key;
                @_8Key.started += instance.On_8Key;
                @_8Key.performed += instance.On_8Key;
                @_8Key.canceled += instance.On_8Key;
                @_9Key.started += instance.On_9Key;
                @_9Key.performed += instance.On_9Key;
                @_9Key.canceled += instance.On_9Key;
            }
        }
    }
    public MiniGameActionsActions @MiniGameActions => new MiniGameActionsActions(this);
    public interface IBasicActionsActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnSmell(InputAction.CallbackContext context);
        void OnWater(InputAction.CallbackContext context);
    }
    public interface IMiniGameActionsActions
    {
        void OnStopTimingBar(InputAction.CallbackContext context);
        void On_1Key(InputAction.CallbackContext context);
        void On_2Key(InputAction.CallbackContext context);
        void On_3Key(InputAction.CallbackContext context);
        void On_4Key(InputAction.CallbackContext context);
        void On_5Key(InputAction.CallbackContext context);
        void On_6Key(InputAction.CallbackContext context);
        void On_7Key(InputAction.CallbackContext context);
        void On_8Key(InputAction.CallbackContext context);
        void On_9Key(InputAction.CallbackContext context);
    }
}
