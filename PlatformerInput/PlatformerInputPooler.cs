using BadCodeNik.EasyEcsModules.Input.PlatformerInput;
using Exerussus._1EasyEcs.Scripts.Core;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;

namespace BadCodeNik.EasyEcsModules.Input
{
    public class PlatformerInputPooler : IGroupPooler
    {
        public PoolerModule<PlatformerInputData.Direction> Direction { get; private set; }

        public void Initialize(EcsWorld world)
        {
            Direction = new PoolerModule<PlatformerInputData.Direction>(world);
        }
    }
}