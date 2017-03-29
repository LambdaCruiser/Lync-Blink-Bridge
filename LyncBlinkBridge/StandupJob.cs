using Quartz;
using ThingM.Blink1.ColorProcessor;

namespace LyncBlinkBridge
{
    public class StandupJob : IJob
    {
        private Rgb colorMeeting = new Rgb(255, 255, 255);

        public void Execute(IJobExecutionContext context)
        {
            BlinkLyncConnectorAppContext.instance.SetBlink1State(colorMeeting);
        }
    }
}