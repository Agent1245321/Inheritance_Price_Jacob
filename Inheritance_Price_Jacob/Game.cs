using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Price_Jacob
{
    abstract class Game
    {

        public Game(string esbr, string title)
        {
            ESBR = esbr;
            Title = title;
        }
        public string ESBR
        { get; set; }

        public string Title
        {
            get; set;
        }

        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting");
        }

        public abstract string Describe();


    }
}
