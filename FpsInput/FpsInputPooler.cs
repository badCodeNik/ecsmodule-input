using Exerussus._1EasyEcs.Scripts.Core;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;

namespace BadCodeNik.EasyEcsModules.Input.FpsInput
{
    public class FpsInputPooler : IGroupPooler
    {
        public PoolerModule<FpsInputData.Direction> Direction { get; private set; }

        public void Initialize(EcsWorld world)
        {
            Direction = new PoolerModule<FpsInputData.Direction>(world);
        }
    }
}