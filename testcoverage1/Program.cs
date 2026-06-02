namespace testcoverage1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Car vw1 = new Car();
            vw1.ShowState();
            Console.WriteLine("Press Enter to gear up.");
            var gearUpCommitted = Console.ReadKey();
            if (ConsoleKey.Enter == gearUpCommitted.Key)
            {
                vw1.GearUp();
                vw1.Accelerate(10);
                vw1.ShowState();
            }
            Console.ReadLine();
        }
    }
}
