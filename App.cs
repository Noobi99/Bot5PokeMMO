using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot5PokeMMO
{
    public partial class App : Form
    {
        // defining variable _totalPokemon which is used by BotLogic.cs
        int _totalPokemon;

        public static string hotkeyUp;
        public static string hotkeyDown;
        public static string hotkeyLeft;
        public static string hotkeyRight;

        Bot5PokeMMO.Framework.BotLogic bot = new Framework.BotLogic();

        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            #region Default values for hotkeys and pixel-/coords
            // This parameters should be filled out by a config file with def values.
            bot.GetDefVal(2, 2, 0x2932, 2, 3, 0x82382);

            // Hotkeys being set by a config file - they are default by now though
            hotkeyUp = "W";
            hotkeyDown = "S";
            hotkeyLeft = "A";
            hotkeyRight = "D";
            #endregion
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            // Defining var _totalPokemon

            // Setting _totalPokemon equal a number from txtTotal
            _totalPokemon = 3;

            // setting total pokemon via textbox - should be set in a script later :)
            bot.SetTotalPokemon(_totalPokemon);

            // add all pokemon that needs to be checked
            bot.AssignVars(0x00A2E8, 755, 398, "dasd");
            bot.AssignVars(0xED1C24, 746, 386);
            bot.AssignVars(0x232932, 232, 211);

            // setting walking pattern
            bot.walkPattern = "leftright";

            timerLogic.Interval = 1000;
            timerLogic.Enabled = true;


        }

        private void timerLogic_Tick(object sender, EventArgs e)
        {
            bot.DoRun();
        }
    }
}