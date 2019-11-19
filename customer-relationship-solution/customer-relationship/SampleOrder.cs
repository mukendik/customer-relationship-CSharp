using System;
using System.Collections.Generic;
using System.Text;

namespace customer_relationship
{
    class SampleOrder : IOrder
    {
        public DateTime Purchased { get; }

        public decimal Cost { get; }

        public SampleOrder(DateTime purchase, decimal cost) =>
            (Purchased, Cost) = (purchase, cost);
    }
}
