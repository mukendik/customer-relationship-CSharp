﻿using System;

namespace customer_relationship
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleCustomer c = new SampleCustomer("customer one", new DateTime(2018, 5, 31))
            { 
                Reminders =
                { 
                    { new DateTime(2010, 08, 12), "childs's birthday" },
                    { new DateTime(1012, 11, 15), "anniversary" } } 
            };

            SampleOrder o = new SampleOrder(new DateTime(2018, 6, 1), 5m); c.AddOrder(o);
            o = new SampleOrder(new DateTime(2017, 7, 4), 25m); c.AddOrder(o);

            // Check the discount (version 1): 
            ICustomer theCustomer = c; 
            Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");

            // test the set loyalty threshold (version 2): 
            ICustomer.SetLoyaltyThresholds(new TimeSpan(30, 0, 0, 0), 1, 0.25m); 
            Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");


        }
    }
}
