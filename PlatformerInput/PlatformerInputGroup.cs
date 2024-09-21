using BadCodeNik.EasyEcsModules.Input.Plugins.BadCodeNik.Input.PlatformerInput.System;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;

namespace BadCodeNik.EasyEcsModules.Input
{
    public class PlatformerInputGroup : EcsGroup<RunnerInputPooler>
    {
        public InputSettings Settings;
        
        protected override void SetUpdateSystems(IEcsSystems updateSystems)
        {
            updateSystems.Add(new PlatformerInputSystem());
            
        }

        protected override void SetLateUpdateSystems(IEcsSystems lateUpdateSystems)
        {
            
        }

        protected override void SetFixedUpdateSystems(IEcsSystems fixedUpdateSystems)
        {
            
        }
    }
}