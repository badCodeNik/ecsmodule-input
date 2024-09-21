using Exerussus._1EasyEcs.Scripts.Core;
using UnityEngine;

namespace BadCodeNik.EasyEcsModules.Input.PlatformerInput
{
    public class PlatformerInputData
    {
        public struct Direction : IEcsComponent { public Vector3 Value; }
    }
}