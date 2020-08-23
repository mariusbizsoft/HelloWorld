using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Box box = new Box(10, 4, 5);
            Console.WriteLine("Box width is " + box.Width);
            box.Width = 15;

            Console.WriteLine("Box width is " + box.Width);
            Console.WriteLine("Box volume is " + box.GetVolume());

            box.DisplayInfo();

            Console.Read();
        }
    }
}

