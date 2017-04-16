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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.btnStart = new System.Windows.Forms.Button();
            this.timerLogic = new System.Windows.Forms.Timer(this.components);
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.chkOnTop = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScript = new System.Windows.Forms.Label();
            this.txtLoadedScript = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
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
            this.ofdScript = new System.Windows.Forms.OpenFileDialog();
            this.chkMoveWin = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
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
            this.btnStart.Location = new System.Drawing.Point(418, 12);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerLogic
            // 
            this.timerLogic.Interval = 60;
            this.timerLogic.Tick += new System.EventHandler(this.timerLogic_Tick);
            // 
            // rtbConsole
            // 
            this.rtbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbConsole.Location = new System.Drawing.Point(258, 30);
            this.rtbConsole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(295, 216);
            this.rtbConsole.TabIndex = 2;
            this.rtbConsole.Text = "";
            this.rtbConsole.TextChanged += new System.EventHandler(this.rtbConsole_TextChanged);
            // 
            // chkOnTop
            // 
            this.chkOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.Location = new System.Drawing.Point(20, 28);
            this.chkOnTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkOnTop.Name = "chkOnTop";
            this.chkOnTop.Size = new System.Drawing.Size(68, 17);
            this.chkOnTop.TabIndex = 3;
            this.chkOnTop.Text = "TopMost";
            this.chkOnTop.UseVisualStyleBackColor = true;
            this.chkOnTop.CheckedChanged += new System.EventHandler(this.chkOnTop_CheckedChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(404, 248);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(88, 13);
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
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblScript);
            this.panel1.Controls.Add(this.txtLoadedScript);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Location = new System.Drawing.Point(-1, 267);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 58);
            this.panel1.TabIndex = 5;
            // 
            // lblScript
            // 
            this.lblScript.AutoSize = true;
            this.lblScript.Location = new System.Drawing.Point(30, 6);
            this.lblScript.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScript.Name = "lblScript";
            this.lblScript.Size = new System.Drawing.Size(76, 13);
            this.lblScript.TabIndex = 6;
            this.lblScript.Text = "Bot File Name:";
            // 
            // txtLoadedScript
            // 
            this.txtLoadedScript.BackColor = System.Drawing.Color.White;
            this.txtLoadedScript.Location = new System.Drawing.Point(32, 22);
            this.txtLoadedScript.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLoadedScript.Name = "txtLoadedScript";
            this.txtLoadedScript.ReadOnly = true;
            this.txtLoadedScript.Size = new System.Drawing.Size(290, 20);
            this.txtLoadedScript.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(326, 12);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(87, 30);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Load Bot";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(248, 253);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(240, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkCatchShiny
            // 
            this.chkCatchShiny.AutoSize = true;
            this.chkCatchShiny.Location = new System.Drawing.Point(13, 106);
            this.chkCatchShiny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCatchShiny.Name = "chkCatchShiny";
            this.chkCatchShiny.Size = new System.Drawing.Size(194, 17);
            this.chkCatchShiny.TabIndex = 10;
            this.chkCatchShiny.Text = "Catch Unspecified Pokemon (shiny)";
            this.chkCatchShiny.UseVisualStyleBackColor = true;
            this.chkCatchShiny.CheckedChanged += new System.EventHandler(this.chkCatchShiny_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Interval in ms (Walk)";
            // 
            // txtSleepE
            // 
            this.txtSleepE.Location = new System.Drawing.Point(61, 73);
            this.txtSleepE.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSleepE.MaxLength = 4;
            this.txtSleepE.Name = "txtSleepE";
            this.txtSleepE.Size = new System.Drawing.Size(39, 20);
            this.txtSleepE.TabIndex = 7;
            this.txtSleepE.Text = "500";
            // 
            // txtSleepB
            // 
            this.txtSleepB.Location = new System.Drawing.Point(12, 73);
            this.txtSleepB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSleepB.MaxLength = 4;
            this.txtSleepB.Name = "txtSleepB";
            this.txtSleepB.Size = new System.Drawing.Size(39, 20);
            this.txtSleepB.TabIndex = 6;
            this.txtSleepB.Text = "300";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
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
            "Square",
            "Perfect Square"});
            this.cmbWalk.Location = new System.Drawing.Point(12, 28);
            this.cmbWalk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbWalk.Name = "cmbWalk";
            this.cmbWalk.Size = new System.Drawing.Size(128, 21);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(240, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hotkeys";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Key Right";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Key Left";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Key Down";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Key Up";
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(16, 83);
            this.txtRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(70, 20);
            this.txtRight.TabIndex = 9;
            this.txtRight.Text = "D";
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(16, 60);
            this.txtLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(70, 20);
            this.txtLeft.TabIndex = 8;
            this.txtLeft.Text = "A";
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point(16, 37);
            this.txtDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(70, 20);
            this.txtDown.TabIndex = 7;
            this.txtDown.Text = "S";
            // 
            // txtUp
            // 
            this.txtUp.Location = new System.Drawing.Point(16, 15);
            this.txtUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUp.Name = "txtUp";
            this.txtUp.Size = new System.Drawing.Size(70, 20);
            this.txtUp.TabIndex = 6;
            this.txtUp.Text = "W";
            // 
            // btnHotkeys
            // 
            this.btnHotkeys.Location = new System.Drawing.Point(16, 106);
            this.btnHotkeys.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHotkeys.Name = "btnHotkeys";
            this.btnHotkeys.Size = new System.Drawing.Size(118, 23);
            this.btnHotkeys.TabIndex = 5;
            this.btnHotkeys.TabStop = false;
            this.btnHotkeys.Text = "Set Hotkeys";
            this.btnHotkeys.UseVisualStyleBackColor = true;
            this.btnHotkeys.Click += new System.EventHandler(this.btnHotkeys_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblWidth);
            this.tabPage3.Controls.Add(this.txtWidth);
            this.tabPage3.Controls.Add(this.lblHeight);
            this.tabPage3.Controls.Add(this.txtHeight);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.chkMoveWin);
            this.tabPage3.Controls.Add(this.chkOnTop);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(240, 227);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Advanced";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblEncounters
            // 
            this.lblEncounters.AutoSize = true;
            this.lblEncounters.Location = new System.Drawing.Point(261, 248);
            this.lblEncounters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEncounters.Name = "lblEncounters";
            this.lblEncounters.Size = new System.Drawing.Size(73, 13);
            this.lblEncounters.TabIndex = 7;
            this.lblEncounters.Text = "Encounters: 0";
            // 
            // ofdScript
            // 
            this.ofdScript.FileName = "openFileDialog1";
            this.ofdScript.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdScript_FileOk);
            // 
            // chkMoveWin
            // 
            this.chkMoveWin.AutoSize = true;
            this.chkMoveWin.Location = new System.Drawing.Point(20, 50);
            this.chkMoveWin.Name = "chkMoveWin";
            this.chkMoveWin.Size = new System.Drawing.Size(184, 17);
            this.chkMoveWin.TabIndex = 12;
            this.chkMoveWin.Text = "Move(0,0) and Resize PokeMMO";
            this.chkMoveWin.UseVisualStyleBackColor = true;
            this.chkMoveWin.CheckedChanged += new System.EventHandler(this.chkMoveWin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Useful settings:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(21, 86);
            this.txtHeight.MaxLength = 4;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 14;
            this.txtHeight.Text = "900";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(18, 70);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 15;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(18, 110);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 17;
            this.lblWidth.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(21, 126);
            this.txtWidth.MaxLength = 4;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 16;
            this.txtWidth.Text = "600";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 321);
            this.Controls.Add(this.lblEncounters);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rtbConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.CheckBox chkOnTop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Label lblEncounters;
        private System.Windows.Forms.OpenFileDialog ofdScript;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtLoadedScript;
        private System.Windows.Forms.Label lblScript;
        private System.Windows.Forms.CheckBox chkMoveWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
    }
}