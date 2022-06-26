using System;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Humen p1 = new Humen();
            p1.name = "Boss";
            p1.sex = "Man";
            p1.age = 18;
            p1.color = "Black";
            Humen p2 = new Humen();
            p2.name = "Zero";
            p2.sex = "Man";
            p2.age = 18;
            p2.color = "Red";
            Console.WriteLine(p1.name);
            Console.WriteLine(p2.name);
            p1.jump();
            p2.walk();
            Console.ReadKey();
        }
    }
}
