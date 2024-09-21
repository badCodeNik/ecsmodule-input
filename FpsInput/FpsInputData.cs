using Exerussus._1EasyEcs.Scripts.Core;
using UnityEngine;

namespace BadCodeNik.EasyEcsModules.Input.FpsInput
{
    public class FpsInputData
    {
        public struct Direction : IEcsComponent { public Vector3 Value; }
    }
}