using Exerussus._1EasyEcs.Scripts.Core;

namespace BadCodeNik.EasyEcsModules.Input
{
    public class InputSettings
    {
        public ControllerMap ControllerMap;
    }

    public enum ControllerMap
    {
        FpsController,
        TwoDPlatformerController,
        RunnerController,
    } 
}