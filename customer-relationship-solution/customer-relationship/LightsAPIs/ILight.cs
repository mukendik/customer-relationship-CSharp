using System;
using System.Collections.Generic;
using System.Text;

namespace customer_relationship.LightsAPIs
{
    interface ILight
    {
        void SwitchOn(); // default interface
        void SwitchOff();
        bool IsOn();

        public enum PowerStatus
        {
            NoPower,
            ACPower,
            FullBattery,
            MidBattery,
            LowBattery
        }

        public PowerStatus Power() => PowerStatus.NoPower;
    }
}
