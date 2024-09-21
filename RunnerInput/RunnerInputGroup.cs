using Exerussus._1EasyEcs.Scripts.Core;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;

namespace BadCodeNik.EasyEcsModules.Input
{
    public class RunnerInputGroup : EcsGroup<RunnerInputPooler>
    {
        public InputSettings Settings;
        
        protected override void SetUpdateSystems(IEcsSystems updateSystems)
        {
            updateSystems.Add(new RunnerInputSystem());
            
        }

        protected override void SetLateUpdateSystems(IEcsSystems lateUpdateSystems)
        {
            
        }

        protected override void SetFixedUpdateSystems(IEcsSystems fixedUpdateSystems)
        {
            
        }
    }
}