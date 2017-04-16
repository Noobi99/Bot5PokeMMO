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
using System.IO;

namespace Bot5PokeMMO
{
    public partial class App : Form
    {
        // get bots
        string path = Directory.GetCurrentDirectory();
        string strfilename = "null";

        // get bots - text interpretion
        string colPoke;
        string x;
        string y;
        string state;
        string pokemon;

        // Creating an instance of AutoItX3
        AutoItX3 autoit = new AutoItX3();

        bool botRunning = false;

        public static string hotkeyUp = "W";
        public static string hotkeyDown = "S";
        public static string hotkeyLeft = "A";
        public static string hotkeyRight = "D";

        int runTimeS = 0; // Run time given in seconds
        int runTimeM = 0; // Run time given in minutes - Variable used for conversion s-m
        int runTimeH = 0;

        public static Bot5PokeMMO.Framework.BotLogic bot = new Framework.BotLogic();

        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e)
        {
            // Settings recommended settings
            chkOnTop.Checked = false;
            chkOnTop.Checked = true; // performing checkChanged to execute code

            chkMoveWin.Checked = true; //- should not be set to TRUE as default as there are no tooltips yet explaining how it only works when PokeMMO is at login state
            chkMoveWin.Checked = false; // setting to false again so we get to execute checkChanged, so we hide the textboxes and labels.
            cmbWalk.Text = "Left & Right";
            btnStart.Enabled = false;
            chkCatchShiny.Checked = true;

            #region Default values for hotkeys and pixel-/coords

            // Hotkeys being set by a config file - they are default by now though. These are not working
            hotkeyUp = "W";
            hotkeyDown = "S";
            hotkeyLeft = "A";
            hotkeyRight = "D";
            #endregion
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (botRunning == false)
            {
                // setting sleep interval
                bot.randomSleepWalkB = Int32.Parse(txtSleepB.Text);
                bot.randomSleepWalkE = Int32.Parse(txtSleepE.Text);

                tmrTime.Enabled = true;
                timerLogic.Enabled = true;
                botRunning = true;
                btnStart.Text = "Stop";
                printToConsole("Started");


                if(chkMoveWin.Checked == true) setPokeMMO();

                btnBrowse.Enabled = false;

            }
            else if (botRunning == true)
            {
                tmrTime.Enabled = false;
                timerLogic.Enabled = false;
                botRunning = false;
                btnStart.Text = "Start";
                printToConsole("Stopped");
                btnBrowse.Enabled = true;
            }
        }
   

        private void timerLogic_Tick(object sender, EventArgs e)
        {
            bot.DoRun();
        }

        private void chkOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnTop.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        public void printToConsole(string text = "Console message is not defined!")
        {
            string _text = text;
            rtbConsole.AppendText(_text + "\n" + " - Time: " + runTimeH.ToString() + "h " + runTimeM.ToString() + "m " + runTimeS.ToString() + "s\n");
        }

        private void rtbConsole_TextChanged(object sender, EventArgs e)
        {
            // Scrolls rtbConsole to end when something is written to the console.
            rtbConsole.ScrollToCaret();
        }

        public void calculateRunTime()
        {
            // Updates lblStatus and converts from seconds to minute when 60 seconds have passed.
            if (runTimeS >= 60)
            {
                runTimeS = 0;
                runTimeM++;

            }
            else if (runTimeM >= 60)
            {
                runTimeM = 0;
                runTimeH++;
            }
            else
            {
                // Only counts seconds when below 60
                lblStatus.Text = "Time: " + runTimeS++.ToString() + "s";

                if (runTimeH >= 1) // Starts to counts hours when the first hour is reached.
                {
                    lblStatus.Text = "Time: " + runTimeH.ToString() + "h " + runTimeM.ToString() + "m " + runTimeS.ToString() + "s";
                }
                else if (runTimeM >= 1) // Start to count minutes when the first minute is reached.
                {
                    lblStatus.Text = "Time: " + runTimeM.ToString() + "m " + runTimeS.ToString() + "s";
                }

            }


        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            // Update console
            if (bot.type == 1)
            {
                rtbConsole.AppendText(bot.WriteToConsole());
            }


            // Encounters has to be divided by 2
            lblEncounters.Text = "Encounters: " + bot.encounters.ToString();

            calculateRunTime();
        }

        public void setPokeMMO() // this method sets window size and position
        {
            autoit.WinMove("PokeMMO", "", 0, 0, 522, 322); // WinMove ( "title", "text", x, y [, width [, height [, speed]]] )
            autoit.WinActivate("PokeMMO"); // this line doesn't work. bah

            printToConsole("Window moved succesfully");
        }

        private void cmbWalk_SelectedIndexChanged(object sender, EventArgs e)
        {
            // enabling walk interval
            txtSleepB.Enabled = true;
            txtSleepE.Enabled = true;

            if (cmbWalk.Text == "Left & Right")
            {
                // setting walking pattern
                bot.walkPattern = "leftright";
            }
            else if (cmbWalk.Text == "Up & Down")
            {
                // setting walking pattern
                bot.walkPattern = "updown";
            }
            else if (cmbWalk.Text == "Square")
            {
                // setting walking pattern
                bot.walkPattern = "square";
            }
            else if (cmbWalk.Text == "Perfect Square")
            {
                // disabling walk interval
                txtSleepB.Enabled = false;
                txtSleepE.Enabled = false;
                txtSleepB.Text = "300";
                txtSleepE.Text = "300";

                // setting walking pattern
                bot.walkPattern = "perfectsquare";
            }

        }

        private void chkCatchShiny_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCatchShiny.Checked)
            {
                bot.catchUnspecifiedPokemon = true;
            }
            else
            {
                bot.catchUnspecifiedPokemon = false;
            }
        }

        private void btnHotkeys_Click(object sender, EventArgs e)
        {
            hotkeyUp = txtUp.Text;
            hotkeyDown = txtDown.Text;
            hotkeyLeft = txtLeft.Text;
            hotkeyRight = txtRight.Text;

            bot.setHotkeys();

            MessageBox.Show("Hotkeys set!" + " up: " + hotkeyUp + ", down: " + hotkeyDown + ", left: " + hotkeyLeft + " & right: " + hotkeyRight, "Bot5PokeMMO");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {


        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // txt interpreter
            ofdScript.Filter = "Text|*.txt";
            ofdScript.Title = "Bot5PokeMMO - Open bot (.txt files only)";

            if (ofdScript.ShowDialog(this) == DialogResult.OK)
            {
                strfilename = ofdScript.InitialDirectory + ofdScript.FileName;
                btnStart.Enabled = true;


                /*if (new FileInfo(strfilename).Length == 0)
                {
                    // empty
                }
                else
                {
                */
                    string fixedFilename = ofdScript.SafeFileName;

                    txtLoadedScript.Text = fixedFilename;

                    // code taken from: http://stackoverflow.com/questions/5174404/get-parameters-out-of-text-file (answered Mar 2 '11 at 22:42)
                    // Dic string
                    var dic = File.ReadAllLines(strfilename)
                    .Select(l => l.Split(new[] { '=' }))
                    .ToDictionary(s => s[0].Trim(), s => s[1].Trim());

                    // basic config vars
                    string botName = dic["BOT_NAME"];
                    MessageBox.Show(botName);

                    string setTotalPokemon = dic["TOTAL_POKEMON"];
                    int setTotalPokemonInt = Int32.Parse(setTotalPokemon);
                    // setting equal to what has been found in the txt document
                    bot.SetTotalPokemon(setTotalPokemonInt);

                    string setAtkMoveX1 = dic["ATK_MOVE1_X"];
                    int setAtkMoveX1Int = Int32.Parse(setAtkMoveX1);
                    // setting equal to what has been found in the txt document
                    bot.atkMove1X = setAtkMoveX1Int;

                    string setAtkMoveY1 = dic["ATK_MOVE1_Y"];
                    int setAtkMoveY1Int = Int32.Parse(setAtkMoveY1);
                    // setting equal to what has been found in the txt document
                    bot.atkMove1Y = setAtkMoveY1Int;


                    string setRunMouseX = dic["RUN_MOUSE_X"];
                    int setRunMouseXInt = Int32.Parse(setRunMouseX);
                    // setting equal to what has been found in the txt document
                    bot.runMouseX = setRunMouseXInt;

                    string setRunMouseY = dic["RUN_MOUSE_Y"];
                    int setRunMouseYInt = Int32.Parse(setRunMouseY);
                    // setting equal to what has been found in the txt document
                    bot.runMouseY = setRunMouseYInt;

                    string setCatchPokemonX1 = dic["CATCH_POKE_X1"];
                    int setCatchPokemonX1Int = Int32.Parse(setCatchPokemonX1);
                    // setting equal to what has been found in the txt document
                    bot.catchPokemonX1 = setCatchPokemonX1Int;

                string setCatchPokemonY1 = dic["CATCH_POKE_Y1"];
                int setCatchPokemonY1Int = Int32.Parse(setCatchPokemonY1);
                // setting equal to what has been found in the txt document
                bot.catchPokemonY1 = setCatchPokemonY1Int;

                string setCatchPokemonX2 = dic["CATCH_POKE_X2"];
                    int setCatchPokemonX2Int = Int32.Parse(setCatchPokemonX2);
                    // setting equal to what has been found in the txt document
                    bot.catchPokemonX2 = setCatchPokemonX2Int;

                string setCatchPokemonY2 = dic["CATCH_POKE_Y2"];
                int setCatchPokemonY2Int = Int32.Parse(setCatchPokemonY2);
                // setting equal to what has been found in the txt document
                bot.catchPokemonY2 = setCatchPokemonY2Int;

                string setCatchPokemonX3 = dic["CATCH_POKE_X3"];
                int setCatchPokemonX3Int = Int32.Parse(setCatchPokemonX3);
                // setting equal to what has been found in the txt document
                bot.catchPokemonX3 = setCatchPokemonX3Int;

                string setCatchPokemonY3 = dic["CATCH_POKE_Y3"];
                int setCatchPokemonY3Int = Int32.Parse(setCatchPokemonY3);
                // setting equal to what has been found in the txt document
                bot.catchPokemonY3 = setCatchPokemonY3Int;

                string setCatchPokemonX4 = dic["CATCH_POKE_X4"];
                int setCatchPokemonX4Int = Int32.Parse(setCatchPokemonX4);
                // setting equal to what has been found in the txt document
                bot.catchPokemonX4 = setCatchPokemonX4Int;

                string setCatchPokemonY4 = dic["CATCH_POKE_Y4"];
                int setCatchPokemonY4Int = Int32.Parse(setCatchPokemonY4);
                // setting equal to what has been found in the txt document
                bot.catchPokemonY4 = setCatchPokemonY4Int;

                string battleX = dic["BATTLE_X"];
                    int setBattleXInt = Int32.Parse(battleX);

                     string battleY = dic["BATTLE_Y"];
                     int setBattleYInt = Int32.Parse(battleY);

                    string battleCol = dic["BATTLE_COL"];
                    int setBattleColInt32 = Convert.ToInt32(battleCol, 16);

                    string hordeX = dic["HORDE_X"];
                    int setHordeX = Int32.Parse(hordeX);

                    string hordeY = dic["HORDE_Y"];
                    int setHordeY = Int32.Parse(hordeY);

                    string hordeCol = dic["HORDE_COL"];
                    int setHordeColInt32 = Convert.ToInt32(hordeCol, 16);

                    bot.GetDefVal(setBattleXInt, setBattleYInt, setBattleColInt32, setHordeX, setHordeY, setHordeColInt32);
                // bot.GetDefVal(458, 439, 0x87959C, 557, 129, 0x84D18E);
                MessageBox.Show("Total pokemon set to: " + setTotalPokemon);

                    for (int i = 0; i < setTotalPokemonInt; i++)
                    {
                        pokemon = dic["NAME_POKE" + i];
                        //MessageBox.Show(pokemon);

                        state = dic["STATE_POKE" + i];
                       // MessageBox.Show(state);

                        colPoke = dic["COL_POKE" + i];
                        //MessageBox.Show(colPoke);

                        x = dic["X_POKE" + i];
                        //MessageBox.Show(x);

                        y = dic["Y_POKE" + i];
                        //MessageBox.Show(y);

                    // conversion
                        Int32 _colPoke = Convert.ToInt32(colPoke, 16);
                        int _x = Int32.Parse(x);
                        int _y = Int32.Parse(y);

                        bot.AssignVars(_colPoke, _x, _y, pokemon, state);
                    }

                    timerLogic.Interval = 1000; // This needs to be set to 1000

                printToConsole(strfilename + " --- Values Loaded!");

                    btnStart.PerformClick();

            }
            }

        private void ofdScript_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void chkMoveWin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMoveWin.Checked == true)
            {
                txtHeight.Visible = true;
                txtWidth.Visible = true;
                lblHeight.Visible = true;
                lblWidth.Visible = true;
            }
            else if(chkMoveWin.Checked == false)
            {
                txtHeight.Visible = false;
                txtWidth.Visible = false;
                lblHeight.Visible = false;
                lblWidth.Visible = false;
            }

        }



        /*
        if(cmbBot.Text == "Viridian Forest")
        {
            // setting total pokemon via textbox
            bot.SetTotalPokemon(5);

            bot.randomSleepRunB = 300;
            bot.randomSleepRunB = 400;

            // add all pokemon that needs to be checked
            bot.AssignVars(0x98D048, 668, 234, "Caterpie", "run"); // Caterpie
            bot.AssignVars(0xF8E800, 666, 239, "Pikachu", "run"); // Pikachu
            bot.AssignVars(0xB8F870, 647, 243, "Metapod", "run"); // Metapod
            bot.AssignVars(0xF8E098, 672, 210, "Kakuna", "run"); // Kakuna
            bot.AssignVars(0xE8A840, 659, 265, "Weedle", "run"); // Weedle

            timerLogic.Interval = 1000; // This needs to be set to 1000
        }
        */

    }
}