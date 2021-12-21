
namespace SimonSays
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RedBox = new System.Windows.Forms.PictureBox();
            this.BlueBox = new System.Windows.Forms.PictureBox();
            this.PurpleBox = new System.Windows.Forms.PictureBox();
            this.YellowBox = new System.Windows.Forms.PictureBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.YellowBlackground = new System.Windows.Forms.PictureBox();
            this.PurpleBackground = new System.Windows.Forms.PictureBox();
            this.BlueBackground = new System.Windows.Forms.PictureBox();
            this.RedBackground = new System.Windows.Forms.PictureBox();
            this.LbScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurpleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowBlackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurpleBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // RedBox
            // 
            this.RedBox.BackColor = System.Drawing.Color.Black;
            this.RedBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RedBox.Image = ((System.Drawing.Image)(resources.GetObject("RedBox.Image")));
            this.RedBox.Location = new System.Drawing.Point(85, 28);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(166, 151);
            this.RedBox.TabIndex = 0;
            this.RedBox.TabStop = false;
            this.RedBox.Visible = false;
            this.RedBox.Click += new System.EventHandler(this.RedBox_Click);
            // 
            // BlueBox
            // 
            this.BlueBox.BackColor = System.Drawing.Color.Black;
            this.BlueBox.Image = ((System.Drawing.Image)(resources.GetObject("BlueBox.Image")));
            this.BlueBox.Location = new System.Drawing.Point(319, 28);
            this.BlueBox.Name = "BlueBox";
            this.BlueBox.Size = new System.Drawing.Size(166, 151);
            this.BlueBox.TabIndex = 1;
            this.BlueBox.TabStop = false;
            this.BlueBox.Visible = false;
            this.BlueBox.Click += new System.EventHandler(this.BlueBox_Click);
            // 
            // PurpleBox
            // 
            this.PurpleBox.BackColor = System.Drawing.Color.Black;
            this.PurpleBox.Image = ((System.Drawing.Image)(resources.GetObject("PurpleBox.Image")));
            this.PurpleBox.Location = new System.Drawing.Point(85, 238);
            this.PurpleBox.Name = "PurpleBox";
            this.PurpleBox.Size = new System.Drawing.Size(166, 151);
            this.PurpleBox.TabIndex = 2;
            this.PurpleBox.TabStop = false;
            this.PurpleBox.Visible = false;
            this.PurpleBox.Click += new System.EventHandler(this.PurpleBox_Click);
            // 
            // YellowBox
            // 
            this.YellowBox.BackColor = System.Drawing.Color.Black;
            this.YellowBox.Image = ((System.Drawing.Image)(resources.GetObject("YellowBox.Image")));
            this.YellowBox.Location = new System.Drawing.Point(319, 238);
            this.YellowBox.Name = "YellowBox";
            this.YellowBox.Size = new System.Drawing.Size(166, 151);
            this.YellowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YellowBox.TabIndex = 3;
            this.YellowBox.TabStop = false;
            this.YellowBox.Visible = false;
            this.YellowBox.Click += new System.EventHandler(this.YellowBox_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(500, 193);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(94, 29);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(500, 193);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(94, 29);
            this.BtnStop.TabIndex = 5;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // YellowBlackground
            // 
            this.YellowBlackground.BackColor = System.Drawing.Color.Khaki;
            this.YellowBlackground.Location = new System.Drawing.Point(319, 238);
            this.YellowBlackground.Name = "YellowBlackground";
            this.YellowBlackground.Size = new System.Drawing.Size(166, 151);
            this.YellowBlackground.TabIndex = 6;
            this.YellowBlackground.TabStop = false;
            this.YellowBlackground.Click += new System.EventHandler(this.YellowBlackground_Click);
            // 
            // PurpleBackground
            // 
            this.PurpleBackground.BackColor = System.Drawing.Color.MediumOrchid;
            this.PurpleBackground.Location = new System.Drawing.Point(85, 238);
            this.PurpleBackground.Name = "PurpleBackground";
            this.PurpleBackground.Size = new System.Drawing.Size(166, 151);
            this.PurpleBackground.TabIndex = 7;
            this.PurpleBackground.TabStop = false;
            this.PurpleBackground.Click += new System.EventHandler(this.PurpleBackground_Click);
            // 
            // BlueBackground
            // 
            this.BlueBackground.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BlueBackground.Location = new System.Drawing.Point(319, 28);
            this.BlueBackground.Name = "BlueBackground";
            this.BlueBackground.Size = new System.Drawing.Size(166, 151);
            this.BlueBackground.TabIndex = 8;
            this.BlueBackground.TabStop = false;
            this.BlueBackground.Click += new System.EventHandler(this.BlueBackground_Click);
            // 
            // RedBackground
            // 
            this.RedBackground.BackColor = System.Drawing.Color.IndianRed;
            this.RedBackground.Location = new System.Drawing.Point(85, 28);
            this.RedBackground.Name = "RedBackground";
            this.RedBackground.Size = new System.Drawing.Size(166, 151);
            this.RedBackground.TabIndex = 9;
            this.RedBackground.TabStop = false;
            this.RedBackground.Click += new System.EventHandler(this.RedBackground_Click);
            // 
            // LbScore
            // 
            this.LbScore.AutoSize = true;
            this.LbScore.Location = new System.Drawing.Point(615, 197);
            this.LbScore.Name = "LbScore";
            this.LbScore.Size = new System.Drawing.Size(17, 20);
            this.LbScore.TabIndex = 10;
            this.LbScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LbScore);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.YellowBox);
            this.Controls.Add(this.PurpleBox);
            this.Controls.Add(this.BlueBox);
            this.Controls.Add(this.RedBox);
            this.Controls.Add(this.RedBackground);
            this.Controls.Add(this.BlueBackground);
            this.Controls.Add(this.PurpleBackground);
            this.Controls.Add(this.YellowBlackground);
            this.Controls.Add(this.BtnStop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurpleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowBlackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurpleBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.PictureBox YellowBlackground;
        private System.Windows.Forms.PictureBox PurpleBackground;
        private System.Windows.Forms.PictureBox BlueBackground;
        private System.Windows.Forms.PictureBox RedBackground;
        public System.Windows.Forms.PictureBox BlueBox;
        public System.Windows.Forms.PictureBox RedBox;
        public System.Windows.Forms.PictureBox PurpleBox;
        public System.Windows.Forms.PictureBox YellowBox;
        private System.Windows.Forms.Label LbScore;
    }
}

