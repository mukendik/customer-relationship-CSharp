using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace customer_relationship.LightsAPIs
{
    interface ITimerLight : ILight
    {
     //   Task TurnOnFor(int duration);

        public async Task TurnOnFor(int duration)
        {
            Console.WriteLine("Using the default interface method for the ITimerLight.TurnOnFor.");
            SwitchOn();
            await Task.Delay(duration);
            SwitchOff();
            Console.WriteLine("Completed ITimerLight.TurnOnFor sequence.");
        }
    }
}
