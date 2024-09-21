using Exerussus._1EasyEcs.Scripts.Core;
using UnityEngine.InputSystem;

namespace BadCodeNik.EasyEcsModules.Input.FpsInput.System
{
    public class FpsInputSystem : EasySystem<FpsInputPooler>
    {
        private InputActions _input;

        protected override void Initialize()
        {
            _input = new InputActions();
            _input.Enable();
            _input.FpsController.Movement.performed += Move;
            _input.FpsController.Dash.performed += Dash;
            _input.FpsController.Interact.performed += Interact;
        }

        private void Interact(InputAction.CallbackContext context)
        {
        }

        private void Dash(InputAction.CallbackContext context)
        {
        }

        private void Move(InputAction.CallbackContext context)
        {
        }
    }
}