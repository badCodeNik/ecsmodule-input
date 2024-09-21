using BadCodeNik.EasyEcsModules.Input.FpsInput.System;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;

namespace BadCodeNik.EasyEcsModules.Input.FpsInput
{
    public class FpsInputGroup : EcsGroup<FpsInputPooler>
    {
        public InputSettings Settings;
        
        protected override void SetUpdateSystems(IEcsSystems updateSystems)
        {
            updateSystems.Add(new FpsInputSystem());
            
        }

        protected override void SetLateUpdateSystems(IEcsSystems lateUpdateSystems)
        {
            
        }

        protected override void SetFixedUpdateSystems(IEcsSystems fixedUpdateSystems)
        {
            
        }
    }
}