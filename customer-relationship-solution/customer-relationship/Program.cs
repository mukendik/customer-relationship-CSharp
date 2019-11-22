using customer_relationship.LightsAPIs;
using System;
using System.Linq;
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
        #region customer-relationship
        //static void Main(string[] args)
        //{
        #region sebLMain
        //    //var myinstance = new FancyClass()
        //    //{
        //    //    Prop1 = 42,
        //    //    Prop2 = 3.14
        //    //};

        //    //var instance = new AClass();

        //    //myinstance.TestValue(43);

        //    //Console.WriteLine(((IInterface)instance).M1());


        //    //var c = new MyContainer();

        //    //c.Element = 42;
        //    //c.Element = "Hey";

        //    //var gc = new MyGenericContainer<int>();
        //    //gc.Element = 42;
        //    //var gc2 = new MyGenericContainer<string>();
        //    //gc2.Element = "coucou";

        //    //var gc3 = new MyGenericContainer<FancyClass>();
        //    //gc3.Element.Prop1 = 3;

        #endregion sebLMain


        //    //SampleCustomer c = new SampleCustomer("customer one", new DateTime(2018, 5, 31))
        //    //    {
        //    //        Reminders =
        //    //        {
        //    //            { new DateTime(2010, 08, 12), "childs's birthday" },
        //    //            { new DateTime(1012, 11, 15), "anniversary" } }
        //    //    };

        //    //    SampleCustomer c2 = new SampleCustomer("customer two", new DateTime(2018, 5, 31))
        //    //    {
        //    //        Reminders =
        //    //        {
        //    //            { new DateTime(2010, 08, 12), "childs's birthday" },
        //    //            { new DateTime(1012, 11, 15), "anniversary" } }
        //    //    };

        //    //    SampleOrder o = new SampleOrder(new DateTime(2018, 6, 1), 5m); c.AddOrder(o);
        //    //    //o = new SampleOrder(new DateTime(2017, 7, 4), 25m); c.AddOrder(o);

        //    //    // Check the discount (version 1): 
        //    //    //ICustomer theCustomer = c;
        //    //    //Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");

        //    //    // test the set loyalty threshold (version 2): 
        //    //    //ICustomer.SetLoyaltyThresholds(new TimeSpan(30, 0, 0, 0), 1, 0.25m);
        //    //    //Console.WriteLine($"Current discount: {theCustomer.ComputeLoyaltyDiscount()}");

        //    //    // test new client's first order
        //    //    //ICustomer theCustomer2 = c2;
        //    //   public int entier { get; set; }



        //    //Console.WriteLine($"Current discount:{theCustomer2.ComputeLoyaltyDiscount()}");


        //    //}
        #endregion customer-relationship 

        //}
        #region LightAPITests
        //    static async Task Main(string[] args)
        //{
        //    Console.WriteLine("Testing the overhead light");
        //    var overhead = new OverheadLight();
        //    await TestLightCapabilities(overhead);
        //    Console.WriteLine();
        //    Console.WriteLine("Testing the halogen light");
        //    var halogen = new HalogenLight();
        //    await TestLightCapabilities(halogen);
        //    Console.WriteLine();
        //    Console.WriteLine("Testing the LED light");
        //    var led = new LEDLight();
        //    await TestLightCapabilities(led);
        //    Console.WriteLine();
        //    Console.WriteLine("Testing the fancy light");
        //    var fancy = new ExtraFancyLight();
        //    await TestLightCapabilities(fancy);
        //    Console.WriteLine();

        //}
        //private static async Task TestLightCapabilities(ILight light)
        //{
        //    // Perform basic tests:
        //    light.SwitchOn();
        //    Console.WriteLine($"\tAfter switching on, the light is {(light.IsOn() ? "on" : "off")}");
        //    light.SwitchOff();
        //    Console.WriteLine($"\tAfter switching off, the light is {(light.IsOn() ? "on" : "off")}");
        //    if (light is ITimerLight timer)
        //    {
        //        Console.WriteLine("\tTesting timer function");
        //        await timer.TurnOnFor(1000);
        //        Console.WriteLine("\tTimer function completed");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\tTimer function not supported.");
        //    }
        //    if (light is IBlinkingLight blinker)
        //    {
        //        Console.WriteLine("\tTesting blinking function");
        //        await blinker.Blink(500, 5);
        //        Console.WriteLine("\tBlink function completed");
        //    }
        //    else
        //    {
        //        Console.WriteLine("\tBlink function not supported.");
        //    }
        //}

        #endregion LightAPITests

        #region indices and ranges
        //static void Main(string[] args)
        //{
        //    string[] words = new string[]
        //    {
        //        // index from start index from end
        //        "The", // 0 ^9
        //        "quick", // 1 ^8
        //        "brown", // 2 ^7
        //        "fox", // 3 ^6
        //        "jumped", // 4 ^5
        //        "over", // 5 ^4
        //        "the", // 6 ^3
        //        "lazy", // 7 ^2
        //        "dog" // 8 ^1
        //    }; // 9 (or words.Length) ^0

        //    Console.WriteLine($"The first word is : {words[0]}"); // with simple index
        //    Console.WriteLine($"The Last word is : {words[^1]}"); // with index from end operator
           
        //    string[] quickBrownFox = words[1..4];
        //    foreach (var word in quickBrownFox)
        //        Console.Write($"< {word} >");
        //    Console.WriteLine();

        //    string[] lazyDog = words[^2..^0];
        //    foreach (var word in lazyDog)
        //        Console.Write($"< {word} >");
        //    Console.WriteLine();


        //    string[] allWords = words[..]; // contains "The" through "dog".
        //    string[] firstPhrase = words[..4]; // contains "The" through "fox"
        //    string[] lastPhrase = words[6..]; // contains "the, "lazy" and "dog"
        //    foreach (var word in allWords)
        //        Console.Write($"< {word} >");
        //    Console.WriteLine();
        //    foreach (var word in firstPhrase)
        //        Console.Write($"< {word} >");
        //    Console.WriteLine();
        //    foreach (var word in lastPhrase)
        //        Console.Write($"< {word} >");
        //    Console.WriteLine();

        //    Index the = ^3;
        //    Console.WriteLine(words[the]);
        //    Range phrase = 1..4;
        //    string[] text = words[phrase];
        //    foreach (var word in text)
        //        Console.Write($"< {word} >");
        //    Console.WriteLine();

        //    int[] numbers = Enumerable.Range(0, 100).ToArray();
        //    int x = 12;
        //    int y = 25;
        //    int z = 36;
        //    Console.WriteLine($"{numbers[^x]} is the same as {numbers[numbers.Length - x]}");
        //    Console.WriteLine($"{numbers[x..y].Length} is the same as {y - x}");
            
        //    Console.WriteLine("numbers[x..y] and numbers[y..z] are consecutive and disjoint:");
        //    Span<int> x_y = numbers[x..y];
        //    Span<int> y_z = numbers[y..z];
        //    Console.WriteLine($"\tnumbers[x..y] is {x_y[0]} through {x_y[^1]}, numbers[y..z] is {y_z[0]} through { y_z[^1]}");
            
        //    Console.WriteLine("numbers[x..^x] removes x elements at each end:");
        //    Span<int> x_x = numbers[x..^x];
        //    Console.WriteLine($"\tnumbers[x..^x] starts with {x_x[0]} and ends with {x_x[^1]}");
        //    Console.WriteLine("numbers[..x] means numbers[0..x] and numbers[x..] means numbers[x..^0]");
        //    Span<int> start_x = numbers[..x];
        //    Span<int> zero_x = numbers[0..x];
        //    Console.WriteLine($"\t{start_x[0]}..{start_x[^1]} is the same as {zero_x[0]}..{zero_x[^1]}");
        //    Span<int> z_end = numbers[z..];
        //    Span<int> z_zero = numbers[z..^0];
        //    Console.WriteLine($"\t{z_end[0]}..{z_end[^1]} is the same as {z_zero[0]}..{z_zero[^1]}");

        //    // Scenarios for indices and ranges

        //    int[] sequence = Sequence(1000);
        //    for (int start = 0; start < sequence.Length; start += 100)
        //    {
        //        Range r = start..(start + 10);
        //        var (min, max, average) = MovingAverage(sequence, r);
        //        Console.WriteLine($"From {r.Start} to {r.End}: \tMin: {min},\tMax: {max},\tAverage: {average}");
        //    }
        //    for (int start = 0; start < sequence.Length; start += 100)
        //    {
        //        Range r = ^(start + 10)..^start;
        //        var (min, max, average) = MovingAverage(sequence, r);
        //        Console.WriteLine($"From {r.Start} to {r.End}: \tMin: {min},\tMax: {max},\tAverage: {average}");
        //    }
        //    (int min, int max, double average) MovingAverage(int[] subSequence, Range range) =>
        //    (
        //    subSequence[range].Min(),
        //    subSequence[range].Max(),
        //    subSequence[range].Average()
        //    );
        //    int[] Sequence(int count) =>
        //    Enumerable.Range(0, count).Select(x => (int)(Math.Sqrt(x) * 100)).ToArray();
        //}
        
        #endregion indices and ranges

        static void Main(string[] args)
        {

        }
    }
}

