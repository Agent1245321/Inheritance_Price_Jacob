using System;

namespace Inheritance_Price_Jacob
{
    class Program
    {///this is the main Program, where the classes are constructed as objects

        static void Main(string[] args)
        {
            //creates a new fps object called apex with the parameters Teen and Apex Legends
            FPS apex = new FPS("Teen", "Apex Legends");

            //calls the Describe And PlayGame Method from the fps object named apex
            Console.WriteLine(apex.Describe());
            apex.PlayGame();
        }
    }
}
