namespace HCI
{
    partial class InfoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoView));
            this.yellowBin = new System.Windows.Forms.Button();
            this.greenBin = new System.Windows.Forms.Button();
            this.blackBin = new System.Windows.Forms.Button();
            this.redBin = new System.Windows.Forms.Button();
            this.blueBin = new System.Windows.Forms.Button();
            this.orangeBin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yellowBin
            // 
            this.yellowBin.Image = ((System.Drawing.Image)(resources.GetObject("yellowBin.Image")));
            this.yellowBin.Location = new System.Drawing.Point(40, 553);
            this.yellowBin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellowBin.Name = "yellowBin";
            this.yellowBin.Size = new System.Drawing.Size(147, 212);
            this.yellowBin.TabIndex = 0;
            this.yellowBin.UseVisualStyleBackColor = true;
            this.yellowBin.Click += new System.EventHandler(this.yellowBin_Click);
            // 
            // greenBin
            // 
            this.greenBin.Image = ((System.Drawing.Image)(resources.GetObject("greenBin.Image")));
            this.greenBin.Location = new System.Drawing.Point(235, 553);
            this.greenBin.Margin = new System.Windows.Forms.Padding(4);
            this.greenBin.Name = "greenBin";
            this.greenBin.Size = new System.Drawing.Size(173, 212);
            this.greenBin.TabIndex = 1;
            this.greenBin.UseVisualStyleBackColor = true;
            this.greenBin.Click += new System.EventHandler(this.greenBin_Click);
            // 
            // blackBin
            // 
            this.blackBin.Image = ((System.Drawing.Image)(resources.GetObject("blackBin.Image")));
            this.blackBin.Location = new System.Drawing.Point(452, 558);
            this.blackBin.Margin = new System.Windows.Forms.Padding(4);
            this.blackBin.Name = "blackBin";
            this.blackBin.Size = new System.Drawing.Size(165, 207);
            this.blackBin.TabIndex = 2;
            this.blackBin.UseVisualStyleBackColor = true;
            this.blackBin.Click += new System.EventHandler(this.blackBin_Click);
            // 
            // redBin
            // 
            this.redBin.Image = ((System.Drawing.Image)(resources.GetObject("redBin.Image")));
            this.redBin.Location = new System.Drawing.Point(893, 575);
            this.redBin.Margin = new System.Windows.Forms.Padding(4);
            this.redBin.Name = "redBin";
            this.redBin.Size = new System.Drawing.Size(159, 218);
            this.redBin.TabIndex = 4;
            this.redBin.UseVisualStyleBackColor = true;
            this.redBin.Click += new System.EventHandler(this.redBin_Click);
            // 
            // blueBin
            // 
            this.blueBin.Image = ((System.Drawing.Image)(resources.GetObject("blueBin.Image")));
            this.blueBin.Location = new System.Drawing.Point(672, 561);
            this.blueBin.Margin = new System.Windows.Forms.Padding(4);
            this.blueBin.Name = "blueBin";
            this.blueBin.Size = new System.Drawing.Size(171, 203);
            this.blueBin.TabIndex = 3;
            this.blueBin.UseVisualStyleBackColor = true;
            this.blueBin.Click += new System.EventHandler(this.blueBin_Click);
            // 
            // orangeBin
            // 
            this.orangeBin.Image = ((System.Drawing.Image)(resources.GetObject("orangeBin.Image")));
            this.orangeBin.Location = new System.Drawing.Point(1505, 575);
            this.orangeBin.Margin = new System.Windows.Forms.Padding(0);
            this.orangeBin.Name = "orangeBin";
            this.orangeBin.Size = new System.Drawing.Size(149, 224);
            this.orangeBin.TabIndex = 5;
            this.orangeBin.UseVisualStyleBackColor = true;
            this.orangeBin.Click += new System.EventHandler(this.orangeBin_Click);
            // 
            // InfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1687, 876);
            this.Controls.Add(this.orangeBin);
            this.Controls.Add(this.redBin);
            this.Controls.Add(this.blueBin);
            this.Controls.Add(this.blackBin);
            this.Controls.Add(this.greenBin);
            this.Controls.Add(this.yellowBin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InfoView";
            this.Text = "InfoView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yellowBin;
        private System.Windows.Forms.Button greenBin;
        private System.Windows.Forms.Button blackBin;
        private System.Windows.Forms.Button redBin;
        private System.Windows.Forms.Button blueBin;
        private System.Windows.Forms.Button orangeBin;
    }
}