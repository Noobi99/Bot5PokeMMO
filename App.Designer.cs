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
            this.btnTry = new System.Windows.Forms.Button();
            this.timerLogic = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnTry
            // 
            this.btnTry.Location = new System.Drawing.Point(22, 12);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(226, 57);
            this.btnTry.TabIndex = 0;
            this.btnTry.Text = "Try";
            this.btnTry.UseVisualStyleBackColor = true;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // timerLogic
            // 
            this.timerLogic.Tick += new System.EventHandler(this.timerLogic_Tick);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnTry);
            this.Name = "App";
            this.Text = "App";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Timer timerLogic;
    }
}