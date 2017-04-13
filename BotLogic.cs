using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot5PokeMMO.Framework
{
    public class BotLogic
    {
        public static int totalPokemon = 5; // should be set by App.cs

        public static Int32 _col;
        public static int _x;
        public static int _y;


        public void AssignVars()
        {
            // Creating an instance of VarHandler.
            VarHandler var1 = new VarHandler();

            var1.GenerateVars(totalPokemon, _col, _x, _y);


        }




    }
}
