namespace HCI
{
    partial class FirstView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstView));
            this.playMain = new System.Windows.Forms.PictureBox();
            this.playLingvistic = new System.Windows.Forms.PictureBox();
            this.playMath = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playLingvistic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playMath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // playMain
            // 
            this.playMain.Image = ((System.Drawing.Image)(resources.GetObject("playMain.Image")));
            this.playMain.Location = new System.Drawing.Point(39, 67);
            this.playMain.Name = "playMain";
            this.playMain.Size = new System.Drawing.Size(296, 235);
            this.playMain.TabIndex = 0;
            this.playMain.TabStop = false;
            this.playMain.Click += new System.EventHandler(this.playMain_Click);
            // 
            // playLingvistic
            // 
            this.playLingvistic.Image = ((System.Drawing.Image)(resources.GetObject("playLingvistic.Image")));
            this.playLingvistic.Location = new System.Drawing.Point(362, 57);
            this.playLingvistic.Name = "playLingvistic";
            this.playLingvistic.Size = new System.Drawing.Size(372, 244);
            this.playLingvistic.TabIndex = 1;
            this.playLingvistic.TabStop = false;
            this.playLingvistic.Click += new System.EventHandler(this.playLingvistic_Click);
            // 
            // playMath
            // 
            this.playMath.Image = ((System.Drawing.Image)(resources.GetObject("playMath.Image")));
            this.playMath.Location = new System.Drawing.Point(759, 57);
            this.playMath.Name = "playMath";
            this.playMath.Size = new System.Drawing.Size(215, 258);
            this.playMath.TabIndex = 2;
            this.playMath.TabStop = false;
            this.playMath.Click += new System.EventHandler(this.playMath_Click);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(996, 76);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(233, 239);
            this.close.TabIndex = 3;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // FirstView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1324, 400);
            this.Controls.Add(this.close);
            this.Controls.Add(this.playMath);
            this.Controls.Add(this.playLingvistic);
            this.Controls.Add(this.playMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstView";
            this.Text = "FirstView";
            ((System.ComponentModel.ISupportInitialize)(this.playMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playLingvistic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playMath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playMain;
        private System.Windows.Forms.PictureBox playLingvistic;
        private System.Windows.Forms.PictureBox playMath;
        private System.Windows.Forms.PictureBox close;
    }
}