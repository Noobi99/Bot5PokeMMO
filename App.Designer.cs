﻿namespace Bot5PokeMMO
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.txtUp = new System.Windows.Forms.TextBox();
            this.btnHotkeys = new System.Windows.Forms.Button();
            this.cmbWalk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSleepB = new System.Windows.Forms.TextBox();
            this.txtSleepE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStart.Location = new System.Drawing.Point(482, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 33);
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
            // cmbBot
            // 
            this.cmbBot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBot.FormattingEnabled = true;
            this.cmbBot.Items.AddRange(new object[] {
            "Cape Brink"});
            this.cmbBot.Location = new System.Drawing.Point(23, 30);
            this.cmbBot.Name = "cmbBot";
            this.cmbBot.Size = new System.Drawing.Size(190, 24);
            this.cmbBot.TabIndex = 1;
            this.cmbBot.SelectedIndexChanged += new System.EventHandler(this.cmbBot_SelectedIndexChanged);
            // 
            // rtbConsole
            // 
            this.rtbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbConsole.Location = new System.Drawing.Point(348, 12);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(266, 294);
            this.rtbConsole.TabIndex = 2;
            this.rtbConsole.Text = "";
            this.rtbConsole.TextChanged += new System.EventHandler(this.rtbConsole_TextChanged);
            // 
            // chkOnTop
            // 
            this.chkOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOnTop.AutoSize = true;
            this.chkOnTop.Location = new System.Drawing.Point(17, 16);
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
            this.lblStatus.Location = new System.Drawing.Point(12, 309);
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
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.cmbBot);
            this.panel1.Location = new System.Drawing.Point(-1, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 71);
            this.panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(330, 294);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtSleepE);
            this.tabPage1.Controls.Add(this.txtSleepB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbWalk);
            this.tabPage1.Controls.Add(this.chkOnTop);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(322, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtRight);
            this.tabPage2.Controls.Add(this.txtLeft);
            this.tabPage2.Controls.Add(this.txtDown);
            this.tabPage2.Controls.Add(this.txtUp);
            this.tabPage2.Controls.Add(this.btnHotkeys);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(322, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hotkeys";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(322, 265);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Advanced";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(21, 102);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(92, 22);
            this.txtRight.TabIndex = 9;
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(21, 74);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(92, 22);
            this.txtLeft.TabIndex = 8;
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point(21, 46);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(92, 22);
            this.txtDown.TabIndex = 7;
            // 
            // txtUp
            // 
            this.txtUp.Location = new System.Drawing.Point(21, 18);
            this.txtUp.Name = "txtUp";
            this.txtUp.Size = new System.Drawing.Size(92, 22);
            this.txtUp.TabIndex = 6;
            // 
            // btnHotkeys
            // 
            this.btnHotkeys.Location = new System.Drawing.Point(21, 130);
            this.btnHotkeys.Name = "btnHotkeys";
            this.btnHotkeys.Size = new System.Drawing.Size(92, 28);
            this.btnHotkeys.TabIndex = 5;
            this.btnHotkeys.Text = "Set Hotkeys";
            this.btnHotkeys.UseVisualStyleBackColor = true;
            // 
            // cmbWalk
            // 
            this.cmbWalk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWalk.FormattingEnabled = true;
            this.cmbWalk.Items.AddRange(new object[] {
            "Left & Right",
            "Up & Down"});
            this.cmbWalk.Location = new System.Drawing.Point(17, 87);
            this.cmbWalk.Name = "cmbWalk";
            this.cmbWalk.Size = new System.Drawing.Size(169, 24);
            this.cmbWalk.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Walk Pattern:";
            // 
            // txtSleepB
            // 
            this.txtSleepB.Location = new System.Drawing.Point(17, 142);
            this.txtSleepB.MaxLength = 20;
            this.txtSleepB.Name = "txtSleepB";
            this.txtSleepB.Size = new System.Drawing.Size(51, 22);
            this.txtSleepB.TabIndex = 6;
            this.txtSleepB.Text = "300";
            // 
            // txtSleepE
            // 
            this.txtSleepE.Location = new System.Drawing.Point(82, 142);
            this.txtSleepE.MaxLength = 20;
            this.txtSleepE.Name = "txtSleepE";
            this.txtSleepE.Size = new System.Drawing.Size(51, 22);
            this.txtSleepE.TabIndex = 7;
            this.txtSleepE.Text = "500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Interval in ms (Walk)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 395);
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
    }
}