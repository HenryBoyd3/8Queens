namespace _8Queens
{
    partial class Form1
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
            this.RandomStart = new System.Windows.Forms.Button();
            this.newgrid = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // RandomStart
            // 
            this.RandomStart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RandomStart.Location = new System.Drawing.Point(2, 12);
            this.RandomStart.Name = "RandomStart";
            this.RandomStart.Size = new System.Drawing.Size(141, 23);
            this.RandomStart.TabIndex = 0;
            this.RandomStart.Text = "RandomStart";
            this.RandomStart.UseVisualStyleBackColor = false;
            this.RandomStart.Click += new System.EventHandler(this.RandomStart_Click);
            // 
            // newgrid
            // 
            this.newgrid.BackColor = System.Drawing.SystemColors.Info;
            this.newgrid.Location = new System.Drawing.Point(231, 44);
            this.newgrid.Name = "newgrid";
            this.newgrid.Size = new System.Drawing.Size(401, 405);
            this.newgrid.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 543);
            this.Controls.Add(this.newgrid);
            this.Controls.Add(this.RandomStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RandomStart;
        private System.Windows.Forms.FlowLayoutPanel newgrid;
    }
}

