using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bot5PokeMMO.Framework
{
    public class VarHandler
    {
        public  string pokemonName;
        public  Int32[] colPix;
        public  int[] cordX;
        public  int[] cordY;

     public void GenerateVars(int total, Int32 col, int x, int y)
        {
            int pokemonTotal = total;
            Int32 pokemonColor = col;
            int pokemonX = x;
            int pokemonY = y;

            // Creating an amount of variables corresponding to the amount of pokemon.
            for (int i = 0; i < pokemonTotal; i++)
            {
                // Storing the variables so they can be used later.
                colPix[i] = pokemonColor;
                cordX[i] = pokemonX;
                cordY[i] = pokemonY;
            }
        }

        internal void GenerateVars(int col, int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
