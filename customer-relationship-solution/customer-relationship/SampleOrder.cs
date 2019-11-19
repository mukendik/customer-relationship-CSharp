using System;
using System.Collections.Generic;
using System.Text;

namespace customer_relationship
{
    class SampleOrder : IOrder
    {
        public DateTime Purchased => throw new NotImplementedException();

        public decimal Cost => throw new NotImplementedException();
    }
}
