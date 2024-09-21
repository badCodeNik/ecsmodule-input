using Exerussus._1EasyEcs.Scripts.Core;
using UnityEngine;

namespace BadCodeNik.EasyEcsModules.Input
{
    public static class RunnerInputData
    {
        public struct Direction : IEcsComponent { public Vector3 Value; }
    }
}