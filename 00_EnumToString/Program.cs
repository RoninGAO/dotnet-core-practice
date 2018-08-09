using System;

namespace EnumToString
{
    class Program
    {
        enum Colors { Red = 0, Green = 1, Blue = 2, Yellow = 12 };
        static void Main(string[] args)
        {
            Console.WriteLine("Colors.Red = {0}", Colors.Red);
            Console.WriteLine("Colors.Red.ToString() = {0}", Colors.Red.ToString());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Colors.Blue.ToString(\"d\") = {0}", Colors.Red.ToString("d"));
            Console.WriteLine("Colors.Blue.ToString(\"D\") = {0}", Colors.Red.ToString("D"));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Colors.Blue.ToString(\"g\") = {0}", Colors.Red.ToString("g"));
            Console.WriteLine("Colors.Blue.ToString(\"G\") = {0}", Colors.Red.ToString("G"));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("///////////////////////////");
            Console.WriteLine("Enum.ToString() = Enum.ToString(\"g\")");
            Console.WriteLine("///////////////////////////");

            Console.ReadLine();
        }
    }
}
