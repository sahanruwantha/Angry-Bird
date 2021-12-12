namespace Angry_Bird
{
    partial class Highesscore
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
            this.high = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // high
            // 
            this.high.AutoSize = true;
            this.high.Cursor = System.Windows.Forms.Cursors.Hand;
            this.high.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high.Location = new System.Drawing.Point(206, 217);
            this.high.Name = "high";
            this.high.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.high.Size = new System.Drawing.Size(356, 48);
            this.high.TabIndex = 0;
            this.high.Text = "Double Click Here";
            this.high.Click += new System.EventHandler(this.high_Click);
            // 
            // Highesscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.high);
            this.Name = "Highesscore";
            this.Text = "Highesscore";
            this.Load += new System.EventHandler(this.Highesscore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label high;
    }
}