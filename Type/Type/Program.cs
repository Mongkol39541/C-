using System;


namespace Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "4000";
            int number;
            int.TryParse(x, out number);
            number = number + 6000;
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
