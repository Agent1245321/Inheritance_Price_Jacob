using System;

namespace Inheritance_Price_Jacob
{
    class Program
    {
        static void Main(string[] args)
        {
            FPS apex = new FPS("Teen", "Apex Legends");

            Console.WriteLine(apex.Describe());
            apex.PlayGame();
        }
    }
}
