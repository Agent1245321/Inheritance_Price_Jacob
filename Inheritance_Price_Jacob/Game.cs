using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Price_Jacob
{/// <summary>
/// This is the superclass Game.cs, its members and methods are inherited by its subclasses whenever an object of them is created.
/// From this superclass, two string propertys, a method, and an abstract method are inherited.
/// </summary>


    abstract class Game
    {
        //A superclasss constructor accepting the esbr and title paramater
        public Game(string esbr, string title)
        {
            ESBR = esbr;
            Title = title;
        }

        //a public string property named ESBR with the default getter and setter
        public string ESBR
        { get; set; }


        //A public string property named Title with the default getter and setter
        public string Title
        {
            get; set;
        }

        //The Public PlayGame() method, it is inherited by the subclass FPS
        public void PlayGame()
        {
            //Writes to console saying that the objects title is starting.
            Console.WriteLine($"{Title} is Starting");
        }

        //The Public abstract Describe Method. It does not get defined in this superclass but does in each subclass.
        public abstract string Describe();


    }
}
