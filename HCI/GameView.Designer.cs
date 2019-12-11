namespace HCI
{
    partial class GameView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameView));
            this.yellowBin = new System.Windows.Forms.PictureBox();
            this.greenBin = new System.Windows.Forms.PictureBox();
            this.blackBin = new System.Windows.Forms.PictureBox();
            this.blueBin = new System.Windows.Forms.PictureBox();
            this.brownBin = new System.Windows.Forms.PictureBox();
            this.redBin = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gunoi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yellowBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunoi)).BeginInit();
            this.SuspendLayout();
            // 
            // yellowBin
            // 
            this.yellowBin.Image = ((System.Drawing.Image)(resources.GetObject("yellowBin.Image")));
            this.yellowBin.Location = new System.Drawing.Point(-2, 472);
            this.yellowBin.Name = "yellowBin";
            this.yellowBin.Size = new System.Drawing.Size(146, 212);
            this.yellowBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowBin.TabIndex = 0;
            this.yellowBin.TabStop = false;
            this.yellowBin.Click += new System.EventHandler(this.yellowBin_Click);
            // 
            // greenBin
            // 
            this.greenBin.Image = ((System.Drawing.Image)(resources.GetObject("greenBin.Image")));
            this.greenBin.Location = new System.Drawing.Point(150, 482);
            this.greenBin.Name = "greenBin";
            this.greenBin.Size = new System.Drawing.Size(145, 200);
            this.greenBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenBin.TabIndex = 1;
            this.greenBin.TabStop = false;
            this.greenBin.Click += new System.EventHandler(this.greenBin_Click);
            // 
            // blackBin
            // 
            this.blackBin.Image = ((System.Drawing.Image)(resources.GetObject("blackBin.Image")));
            this.blackBin.Location = new System.Drawing.Point(317, 472);
            this.blackBin.Name = "blackBin";
            this.blackBin.Size = new System.Drawing.Size(149, 214);
            this.blackBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blackBin.TabIndex = 2;
            this.blackBin.TabStop = false;
            this.blackBin.Click += new System.EventHandler(this.blackBin_Click);
            // 
            // blueBin
            // 
            this.blueBin.Image = ((System.Drawing.Image)(resources.GetObject("blueBin.Image")));
            this.blueBin.Location = new System.Drawing.Point(490, 482);
            this.blueBin.Name = "blueBin";
            this.blueBin.Size = new System.Drawing.Size(144, 202);
            this.blueBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueBin.TabIndex = 3;
            this.blueBin.TabStop = false;
            this.blueBin.Click += new System.EventHandler(this.blueBin_Click);
            // 
            // brownBin
            // 
            this.brownBin.Image = ((System.Drawing.Image)(resources.GetObject("brownBin.Image")));
            this.brownBin.Location = new System.Drawing.Point(1198, 491);
            this.brownBin.Name = "brownBin";
            this.brownBin.Size = new System.Drawing.Size(150, 224);
            this.brownBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.brownBin.TabIndex = 5;
            this.brownBin.TabStop = false;
            this.brownBin.Click += new System.EventHandler(this.brownBin_Click);
            // 
            // redBin
            // 
            this.redBin.Image = ((System.Drawing.Image)(resources.GetObject("redBin.Image")));
            this.redBin.Location = new System.Drawing.Point(654, 491);
            this.redBin.Name = "redBin";
            this.redBin.Size = new System.Drawing.Size(155, 220);
            this.redBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.redBin.TabIndex = 6;
            this.redBin.TabStop = false;
            this.redBin.Click += new System.EventHandler(this.redBin_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1261, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 75);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 7;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Red;
            this.scoreLabel.Location = new System.Drawing.Point(572, 31);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 44);
            this.scoreLabel.TabIndex = 9;
            // 
            // gunoi
            // 
            this.gunoi.BackColor = System.Drawing.Color.Transparent;
            this.gunoi.Location = new System.Drawing.Point(938, 600);
            this.gunoi.Name = "gunoi";
            this.gunoi.Size = new System.Drawing.Size(212, 180);
            this.gunoi.TabIndex = 10;
            this.gunoi.TabStop = false;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1373, 784);
            this.Controls.Add(this.gunoi);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.redBin);
            this.Controls.Add(this.brownBin);
            this.Controls.Add(this.blueBin);
            this.Controls.Add(this.blackBin);
            this.Controls.Add(this.greenBin);
            this.Controls.Add(this.yellowBin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameView";
            this.Text = "GameView";
            ((System.ComponentModel.ISupportInitialize)(this.yellowBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox yellowBin;
        private System.Windows.Forms.PictureBox greenBin;
        private System.Windows.Forms.PictureBox blackBin;
        private System.Windows.Forms.PictureBox blueBin;
        private System.Windows.Forms.PictureBox brownBin;
        private System.Windows.Forms.PictureBox redBin;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox gunoi;
    }
}