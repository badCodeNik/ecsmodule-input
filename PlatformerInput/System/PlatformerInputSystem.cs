using Exerussus._1EasyEcs.Scripts.Core;
using Leopotam.EcsLite;
using UnityEngine.InputSystem;
using NotImplementedException = System.NotImplementedException;

namespace BadCodeNik.EasyEcsModules.Input.Plugins.BadCodeNik.Input.PlatformerInput.System
{
    public class PlatformerInputSystem : EasySystem<PlatformerInputPooler>
    {
        private InputActions _input;

        protected override void Initialize()
        {
            _input = new InputActions();
            _input.Enable();
            _input.PlatformerController.Movement.performed += Move;
            _input.PlatformerController.Dash.performed += Dash;
            _input.PlatformerController.Interact.performed += Interact;
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

        public override void Destroy(IEcsSystems systems)
        {
            _input.PlatformerController.Movement.performed -= Move;
        }
    }
}