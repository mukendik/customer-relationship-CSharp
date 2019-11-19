using System;
using System.Collections.Generic;
using System.Text;

namespace customer_relationship
{
    interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }
}
