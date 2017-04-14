namespace Bot5PokeMMO
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerLogic = new System.Windows.Forms.Timer(this.components);
            this.cmbBot = new System.Windows.Forms.ComboBox();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCustomize = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkCatchShiny = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSleepE = new System.Windows.Forms.TextBox();
            this.txtSleepB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbWalk = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.txtUp = new System.Windows.Forms.TextBox();
            this.btnHotkeys = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblEncounters = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Location = new System.Drawing.Point(480, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerLogic
            // 
            this.timerLogic.Interval = 1000;
            this.timerLogic.Tick += new System.EventHandler(this.timerLogic_Tick);
            // 
            // cmbBot
            // 
            this.cmbBot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBot.FormattingEnabled = true;
            this.cmbBot.Items.AddRange(new object[] {
            "Viridian Forest",
            "Mt. Ember"});
            this.cmbBot.Location = new System.Drawing.Point(21, 28);
            this.cmbBot.Name = "cmbBot";
            this.cmbBot.Size = new System.Drawing.Size(190, 24);
            this.cmbBot.TabIndex = 1;
            this.cmbBot.SelectedIndexChanged += new System.EventHandler(this.cmbBot_SelectedIndexChanged);
            // 
            // rtbConsole
            // 
            this.rtbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbConsole.Location = new System.Drawing.Point(344, 37);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(270, 265);
            this.rtbConsole.TabIndex = 2;
            this.rtbConsole.Text = "";
            this.rtbConsole.TextChanged += new System.EventHandler(this.rtbConsole_TextChanged);
            // 
            // chkOnTop
            // 
            this.chkOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.Location = new System.Drawing.Point(28, 16);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(85, 21);
            this.chkOnTop.TabIndex = 3;
            this.chkOnTop.Text = "TopMost";
            this.chkOnTop.UseVisualStyleBackColor = true;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(478, 305);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(117, 17);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Time: Not started";
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCustomize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.cmbBot);
            this.panel1.Location = new System.Drawing.Point(-1, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 71);
            this.panel1.TabIndex = 5;
            // 
            // btnCustomize
            // 
            this.btnCustomize.AutoSize = true;
            this.btnCustomize.Location = new System.Drawing.Point(213, 32);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Size = new System.Drawing.Size(73, 17);
            this.btnCustomize.TabIndex = 3;
            this.btnCustomize.TabStop = true;
            this.btnCustomize.Text = "Customize";
            this.btnCustomize.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCustomize_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a bot:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(330, 311);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkCatchShiny);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSleepE);
            this.tabPage1.Controls.Add(this.txtSleepB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbWalk);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(322, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkCatchShiny
            // 
            this.chkCatchShiny.AutoSize = true;
            this.chkCatchShiny.Location = new System.Drawing.Point(17, 130);
            this.chkCatchShiny.Name = "chkCatchShiny";
            this.chkCatchShiny.Size = new System.Drawing.Size(254, 21);
            this.chkCatchShiny.TabIndex = 10;
            this.chkCatchShiny.Text = "Catch Unspecified Pokemon (shiny)";
            this.chkCatchShiny.UseVisualStyleBackColor = true;
            this.chkCatchShiny.CheckedChanged += new System.EventHandler(this.chkCatchShiny_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Interval in ms (Walk)";
            // 
            // txtSleepE
            // 
            this.txtSleepE.Location = new System.Drawing.Point(81, 90);
            this.txtSleepE.MaxLength = 4;
            this.txtSleepE.Name = "txtSleepE";
            this.txtSleepE.Size = new System.Drawing.Size(51, 22);
            this.txtSleepE.TabIndex = 7;
            this.txtSleepE.Text = "500";
            // 
            // txtSleepB
            // 
            this.txtSleepB.Location = new System.Drawing.Point(16, 90);
            this.txtSleepB.MaxLength = 4;
            this.txtSleepB.Name = "txtSleepB";
            this.txtSleepB.Size = new System.Drawing.Size(51, 22);
            this.txtSleepB.TabIndex = 6;
            this.txtSleepB.Text = "300";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Walk Pattern:";
            // 
            // cmbWalk
            // 
            this.cmbWalk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWalk.FormattingEnabled = true;
            this.cmbWalk.Items.AddRange(new object[] {
            "Left & Right",
            "Up & Down",
            "Square"});
            this.cmbWalk.Location = new System.Drawing.Point(16, 35);
            this.cmbWalk.Name = "cmbWalk";
            this.cmbWalk.Size = new System.Drawing.Size(169, 24);
            this.cmbWalk.TabIndex = 4;
            this.cmbWalk.SelectedIndexChanged += new System.EventHandler(this.cmbWalk_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtRight);
            this.tabPage2.Controls.Add(this.txtLeft);
            this.tabPage2.Controls.Add(this.txtDown);
            this.tabPage2.Controls.Add(this.txtUp);
            this.tabPage2.Controls.Add(this.btnHotkeys);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(322, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hotkeys";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Key Right";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Key Left";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Key Down";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Key Up";
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(21, 102);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(92, 22);
            this.txtRight.TabIndex = 9;
            this.txtRight.Text = "D";
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(21, 74);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(92, 22);
            this.txtLeft.TabIndex = 8;
            this.txtLeft.Text = "A";
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point(21, 46);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(92, 22);
            this.txtDown.TabIndex = 7;
            this.txtDown.Text = "S";
            // 
            // txtUp
            // 
            this.txtUp.Location = new System.Drawing.Point(21, 18);
            this.txtUp.Name = "txtUp";
            this.txtUp.Size = new System.Drawing.Size(92, 22);
            this.txtUp.TabIndex = 6;
            this.txtUp.Text = "W";
            // 
            // btnHotkeys
            // 
            this.btnHotkeys.Location = new System.Drawing.Point(21, 130);
            this.btnHotkeys.Name = "btnHotkeys";
            this.btnHotkeys.Size = new System.Drawing.Size(158, 28);
            this.btnHotkeys.TabIndex = 5;
            this.btnHotkeys.TabStop = false;
            this.btnHotkeys.Text = "Set Hotkeys";
            this.btnHotkeys.UseVisualStyleBackColor = true;
            this.btnHotkeys.Click += new System.EventHandler(this.btnHotkeys_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chkOnTop);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(322, 282);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Advanced";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblEncounters
            // 
            this.lblEncounters.AutoSize = true;
            this.lblEncounters.Location = new System.Drawing.Point(348, 305);
            this.lblEncounters.Name = "lblEncounters";
            this.lblEncounters.Size = new System.Drawing.Size(96, 17);
            this.lblEncounters.TabIndex = 7;
            this.lblEncounters.Text = "Encounters: 0";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 395);
            this.Controls.Add(this.lblEncounters);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rtbConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "App";
            this.Text = "Bot5PokeMMO";
            this.Load += new System.EventHandler(this.App_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerLogic;
        private System.Windows.Forms.ComboBox cmbBot;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.TextBox txtUp;
        private System.Windows.Forms.Button btnHotkeys;
        private System.Windows.Forms.ComboBox cmbWalk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSleepE;
        private System.Windows.Forms.TextBox txtSleepB;
        private System.Windows.Forms.CheckBox chkCatchShiny;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel btnCustomize;
        private System.Windows.Forms.Label lblEncounters;
    }
}