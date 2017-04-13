using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;

namespace Bot5PokeMMO
{
    public partial class App : Form
    {

        Bot5PokeMMO.Framework.VarHandler abc = new Framework.VarHandler();

        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            // Defining var _totalPokemon
            int _totalPokemon;

            // Setting _totalPokemon equal a number from txtTotal
            _totalPokemon = Int32.Parse(txtTotal.Text);

            // test here

        }
    }
}
