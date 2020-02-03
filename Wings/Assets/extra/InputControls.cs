// GENERATED AUTOMATICALLY FROM 'Assets/extra/InputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay1"",
            ""id"": ""b3143175-d612-4c66-91e2-c860208a7fc1"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""992ff8e3-c0eb-46b9-b9a5-e8fa6a23c98e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""5be65542-16af-4c07-8f8a-655d07a44960"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move2"",
                    ""type"": ""Button"",
                    ""id"": ""568b3b76-daa1-42c8-83b0-e8ec1d89c500"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Repair"",
                    ""type"": ""Button"",
                    ""id"": ""5581fc9a-efa2-4dc6-a3b8-4c585ab0cb4f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""b0173169-b340-40d1-81f1-a937ad9778cf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill"",
                    ""type"": ""Button"",
                    ""id"": ""08896a6f-c26b-400a-91a2-d5f8352b727e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""1cec64dc-0cbc-4545-bf9a-22e60c9dad99"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""481a775f-4e4b-400a-9ccf-6d4e659ab7e1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d45d538-4982-4264-bb7a-6ff8a03a1621"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cfec568-6bb8-4fdc-8d57-8af487d24d59"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b6fe26f-857c-4ff5-9847-5719b0033bbc"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Repair"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15c4885e-540c-42ce-b8b3-3d9d2e3372df"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17e466b9-f5b1-4652-9cab-ba83b4b49395"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0059cced-f69a-404c-9f54-5b3496200e7b"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay1
        m_Gameplay1 = asset.FindActionMap("Gameplay1", throwIfNotFound: true);
        m_Gameplay1_Jump = m_Gameplay1.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay1_Move = m_Gameplay1.FindAction("Move", throwIfNotFound: true);
        m_Gameplay1_Move2 = m_Gameplay1.FindAction("Move2", throwIfNotFound: true);
        m_Gameplay1_Repair = m_Gameplay1.FindAction("Repair", throwIfNotFound: true);
        m_Gameplay1_Shoot = m_Gameplay1.FindAction("Shoot", throwIfNotFound: true);
        m_Gameplay1_Skill = m_Gameplay1.FindAction("Skill", throwIfNotFound: true);
        m_Gameplay1_Down = m_Gameplay1.FindAction("Down", throwIfNotFound: true);
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

    // Gameplay1
    private readonly InputActionMap m_Gameplay1;
    private IGameplay1Actions m_Gameplay1ActionsCallbackInterface;
    private readonly InputAction m_Gameplay1_Jump;
    private readonly InputAction m_Gameplay1_Move;
    private readonly InputAction m_Gameplay1_Move2;
    private readonly InputAction m_Gameplay1_Repair;
    private readonly InputAction m_Gameplay1_Shoot;
    private readonly InputAction m_Gameplay1_Skill;
    private readonly InputAction m_Gameplay1_Down;
    public struct Gameplay1Actions
    {
        private @InputControls m_Wrapper;
        public Gameplay1Actions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Gameplay1_Jump;
        public InputAction @Move => m_Wrapper.m_Gameplay1_Move;
        public InputAction @Move2 => m_Wrapper.m_Gameplay1_Move2;
        public InputAction @Repair => m_Wrapper.m_Gameplay1_Repair;
        public InputAction @Shoot => m_Wrapper.m_Gameplay1_Shoot;
        public InputAction @Skill => m_Wrapper.m_Gameplay1_Skill;
        public InputAction @Down => m_Wrapper.m_Gameplay1_Down;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Gameplay1Actions set) { return set.Get(); }
        public void SetCallbacks(IGameplay1Actions instance)
        {
            if (m_Wrapper.m_Gameplay1ActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnJump;
                @Move.started -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnMove;
                @Move2.started -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnMove2;
                @Move2.performed -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnMove2;
                @Move2.canceled -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnMove2;
                @Repair.started -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnRepair;
                @Repair.performed -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnRepair;
                @Repair.canceled -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnRepair;
                @Shoot.started -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnShoot;
                @Skill.started -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnSkill;
                @Skill.performed -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnSkill;
                @Skill.canceled -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnSkill;
                @Down.started -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_Gameplay1ActionsCallbackInterface.OnDown;
            }
            m_Wrapper.m_Gameplay1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Move2.started += instance.OnMove2;
                @Move2.performed += instance.OnMove2;
                @Move2.canceled += instance.OnMove2;
                @Repair.started += instance.OnRepair;
                @Repair.performed += instance.OnRepair;
                @Repair.canceled += instance.OnRepair;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Skill.started += instance.OnSkill;
                @Skill.performed += instance.OnSkill;
                @Skill.canceled += instance.OnSkill;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
            }
        }
    }
    public Gameplay1Actions @Gameplay1 => new Gameplay1Actions(this);
    public interface IGameplay1Actions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnMove2(InputAction.CallbackContext context);
        void OnRepair(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnSkill(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
    }
}
