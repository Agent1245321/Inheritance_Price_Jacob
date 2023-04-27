using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Price_Jacob
{/// <summary>
/// This is the FPS class, it inherits the members of the Game superClass
/// It Contains one constructor and then defines the abstract Define() method it inherits from the superclass
/// </summary>
    class FPS : Game
    {

        //The Constructor for the FPS class, it references esbr, and title from the superclass using the base keyword
        public FPS(string esbr, string title) : base(esbr, title)
        {
            //sets the Title and ESBR propetys
            Title = title;
            ESBR = esbr;
        }

        //using the override keyword, this defines the abstract Define() method it inherits from the superclass
        public override string Describe()
        {
            //returns a string describe the title and esbr rating of the object
            return $"The game {Title} is an FPS and has an ESBR rating of {ESBR}";
        }
    }
}
