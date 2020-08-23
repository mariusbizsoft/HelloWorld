using System;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Box box = new Box();
            // box.length = 3;
            box.SetLength(4);
            box.Height = -5;
            box.Width = 5;

            Console.WriteLine("Box width is " + box.Width);
            Console.WriteLine("Box volume is " + box.GetVolume());

            box.DisplayInfo();

            Console.Read();
        }
    }
}

