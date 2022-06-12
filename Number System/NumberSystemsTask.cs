namespace NumberSystemsTask
{
    using System;
    class NumberSystemsTask
    {
        public static string NumberSystems(int value, int toBase)
        {
            string result = string.Empty;
            do
            {
                result = "0123456789ABCDEF"[value % toBase] + result;
                value /= toBase;
            }
            while (value > 0);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value: ");
            int val = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter a positive value!");
                val = int.Parse(Console.ReadLine());
            } while (val < 0);

            Console.WriteLine("Enter to which base to be converted: ");
            int whichBase = int.Parse(Console.ReadLine());

            Console.WriteLine(val + " converted to " + whichBase + " base is: ");
            Console.WriteLine(NumberSystems(val, whichBase));
        }
    }
}
