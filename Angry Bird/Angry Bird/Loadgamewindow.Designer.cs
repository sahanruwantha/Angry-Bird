namespace Angry_Bird
{
    partial class Loadgamewindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loadgamewindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonplay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.highestscore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Angry_Bird.Properties.Resources.bird;
            this.pictureBox1.Location = new System.Drawing.Point(457, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonplay
            // 
            this.buttonplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonplay.Location = new System.Drawing.Point(440, 254);
            this.buttonplay.Margin = new System.Windows.Forms.Padding(4);
            this.buttonplay.Name = "buttonplay";
            this.buttonplay.Size = new System.Drawing.Size(173, 87);
            this.buttonplay.TabIndex = 1;
            this.buttonplay.Text = "Play";
            this.buttonplay.UseVisualStyleBackColor = true;
            this.buttonplay.Click += new System.EventHandler(this.Loadgame);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 87);
            this.button1.TabIndex = 2;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // highestscore
            // 
            this.highestscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestscore.Location = new System.Drawing.Point(440, 543);
            this.highestscore.Margin = new System.Windows.Forms.Padding(4);
            this.highestscore.Name = "highestscore";
            this.highestscore.Size = new System.Drawing.Size(173, 87);
            this.highestscore.TabIndex = 3;
            this.highestscore.Text = "Previous Score";
            this.highestscore.UseVisualStyleBackColor = true;
            this.highestscore.Click += new System.EventHandler(this.highestscore_Click);
            // 
            // Loadgamewindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1067, 694);
            this.Controls.Add(this.highestscore);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonplay);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Loadgamewindow";
            this.Text = "Load";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button highestscore;
    }
}