using Exerussus._1EasyEcs.Scripts.Core;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;

namespace BadCodeNik.EasyEcsModules.Input
{
    public class RunnerInputPooler : IGroupPooler
    {
        public PoolerModule<RunnerInputData.Direction> Direction { get; private set; }

        public void Initialize(EcsWorld world)
        {
            Direction = new PoolerModule<RunnerInputData.Direction>(world);
        }
    }
}