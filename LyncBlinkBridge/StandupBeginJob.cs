using Quartz;
using ThingM.Blink1.ColorProcessor;

namespace LyncBlinkBridge
{
    public class StandupBeginJob : IJob
    {
        private readonly Rgb _colorMeeting = new Rgb(255, 255, 255);

        public void Execute(IJobExecutionContext context)
        {
            BlinkLyncConnectorAppContext.Instance.IgnoreLyncStatusChangesMode = true;
            BlinkLyncConnectorAppContext.Instance.SetBlink1State(_colorMeeting);
        }
    }

    public class StandupEndJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            BlinkLyncConnectorAppContext.Instance.IgnoreLyncStatusChangesMode = false;
        }
    }
}