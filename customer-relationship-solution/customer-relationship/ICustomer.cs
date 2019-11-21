using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace customer_relationship
{
    interface ICustomer
    {
        IEnumerable<IOrder> PreviousOrders { get; }
        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }

        #region version 1
        //// Version 1: 
        //public decimal ComputeLoyaltyDiscount()
        //{    
        //    DateTime TwoYearsAgo = DateTime.Now.AddYears(-2);
        //    if ((DateJoined < TwoYearsAgo) && (PreviousOrders.Count() > 10))  
        //    {       
        //        return 0.10m; 
        //    }   
        //    return 0;
        //}
        #endregion version 1
        #region version 2
        // Version 2: 
        public void SetLoyaltyThresholds(
            TimeSpan ago,
            int minimumOrders = 10,
            decimal percentageDiscount = 0.10m
            )
        {
            length = ago;
            orderCount = minimumOrders;
            discountPercent = percentageDiscount;
        }

        private static TimeSpan length = new TimeSpan(365 * 2, 0, 0, 0);
        // two years 
        private static int orderCount = 10;
        private static decimal discountPercent = 0.10m;

        public decimal ComputeLoyaltyDiscount() => DefaultLoyaltyDiscount(this);
        protected static decimal DefaultLoyaltyDiscount(ICustomer c) // fonctionnalité par défaut
        {
            DateTime start = DateTime.Now - length;
            if ((c.DateJoined < start) && (c.PreviousOrders.Count() > orderCount))
            {
                return discountPercent;
            }
            return 0;
        }
        #endregion version 2



    }
    #region testsSebL
    interface IInterface
    {
        int M1() { return 42; }
    }

    public class AClass : IInterface
    {

    }
    #endregion
}
