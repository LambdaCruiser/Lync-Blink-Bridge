using Quartz;
using ThingM.Blink1.ColorProcessor;

namespace LyncBlinkBridge
{
    public class StandupJob : IJob
    {
        private readonly Rgb _colorMeeting = new Rgb(255, 255, 255);

        public void Execute(IJobExecutionContext context)
        {
            BlinkLyncConnectorAppContext.Instance.SetBlink1State(_colorMeeting);
        }
    }
}