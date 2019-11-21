using customer_relationship.LightsAPIs;
using System;
using System.Threading.Tasks;

namespace customer_relationship
{
    #region sebL
    public class FancyClass
    {
        public int Prop1 { get; set; }
        public double Prop2 { get; set; }

        private int ComputeValue()
        {
            return 41 + 1;
        }

        public int SuperProp => ComputeValue();
    }

    public static class FancyClassExtensions
    {
        public static bool TestValue(this FancyClass obj, int val) 
        {
            
            return obj.Prop1 == val;
        }
    }

    public class MyContainer
    {
        public object Element { get; set; }
    }

    public class MyGenericContainer<UnknownType>
    {
        public UnknownType Element { get; set; }
    }
    #endregion

    public class Program
    {
        static void Main(string[] args)
        {
            #region sebLMain
            var myinstance = new FancyClass()
            {
                Prop1 = 42,
                Prop2 = 3.14
            };

            var instance = new AClass();

            myinstance.TestValue(43);

            Console.WriteLine(((IInterface)instance).M1());
            

            var c = new MyContainer();

            c.Element = 42;
            c.Element = "Hey";

            var gc = new MyGenericContainer<int>();
            gc.Element = 42;
            var gc2 = new MyGenericContainer<string>();
            gc2.Element = "coucou";

            var gc3 = new MyGenericContainer<FancyClass>();
            gc3.Element.Prop1 = 3;

            #endregion

            //SampleCustomer c = new SampleCustomer("customer one", new DateTime(2018, 5, 31))
            //    {
            //        Reminders =
            //        {
            //            { new DateTime(2010, 08, 12), "childs's birthday" },
            //            { new DateTime(1012, 11, 15), "anniversary" } }
            //    };

            //    SampleCustomer c2 = new SampleCustomer("customer two", new DateTime(2018, 5, 31))
            //    {
            //        Reminders =
            //        {
            //            { new DateTime(2010, 08, 12), "childs's birthday" },
            //            { new DateTime(1012, 11, 15), "anniversary" } }
            //    };

            //    SampleOrder o = new SampleOrder(new DateTime(2018, 6, 1), 5m); c.AddOrder(o);
            //    //o = new SampleOrder(new DateTime(2017, 7, 4), 25m); c.AddOrder(o);

            //    // Check the discount (version 1): 
            //    //ICustomer theCustomer = c;
            //    //Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");

            //    // test the set loyalty threshold (version 2): 
            //    //ICustomer.SetLoyaltyThresholds(new TimeSpan(30, 0, 0, 0), 1, 0.25m);
            //    //Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");

            //    // test new client's first order
            //    //ICustomer theCustomer2 = c2;
            //   public int entier { get; set; }

          

            //Console.WriteLine($"Current discount:{theCustomer2.ComputeLoyaltyDiscount()}");


            //}


        }
        #region LightAPITests
        private static async Task TestLightCapabilities(ILight light)
        {
            // Perform basic tests:
            light.SwitchOn();
            Console.WriteLine($"\tAfter switching on, the light is {(light.IsOn() ? "on" : "off")}");
            light.SwitchOff();
            Console.WriteLine($"\tAfter switching off, the light is {(light.IsOn() ? "on" : "off")}");
            if (light is ITimerLight timer)
            {
                Console.WriteLine("\tTesting timer function");
                await timer.TurnOnFor(1000);
                Console.WriteLine("\tTimer function completed");
            }
            else
            {
                Console.WriteLine("\tTimer function not supported.");
            }
            if (light is IBlinkingLight blinker)
            {
                Console.WriteLine("\tTesting blinking function");
                await blinker.Blink(500, 5);
                Console.WriteLine("\tBlink function completed");
            }
            else
            {
                Console.WriteLine("\tBlink function not supported.");
            }
        }

        #endregion LightAPITests
    }
}

