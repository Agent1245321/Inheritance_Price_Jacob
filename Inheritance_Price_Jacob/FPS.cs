using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Price_Jacob
{
    class FPS : Game
    {
        public FPS(string esbr, string title) : base(esbr, title)
        {
            Title = title;
            ESBR = esbr;
        }

        public override string Describe()
        {
            return $"The game {Title} is an FPS and has an ESBR rating of {ESBR}";
        }
    }
}
