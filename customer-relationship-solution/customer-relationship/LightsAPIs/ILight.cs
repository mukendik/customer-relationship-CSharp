using System;
using System.Collections.Generic;
using System.Text;

namespace customer_relationship.LightsAPIs
{
    interface ILight
    {
        void SwitchOn();
        void SwitchOff();
        bool IsOn();
    }
}
