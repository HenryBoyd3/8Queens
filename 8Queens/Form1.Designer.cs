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
            this.newgrid = new System.Windows.Forms.FlowLayoutPanel();
            this.Randoms = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newgrid
            // 
            this.newgrid.BackColor = System.Drawing.SystemColors.Info;
            this.newgrid.Location = new System.Drawing.Point(231, 44);
            this.newgrid.Name = "newgrid";
            this.newgrid.Size = new System.Drawing.Size(401, 405);
            this.newgrid.TabIndex = 2;
            // 
            // Randoms
            // 
            this.Randoms.Location = new System.Drawing.Point(2, 44);
            this.Randoms.Name = "Randoms";
            this.Randoms.Size = new System.Drawing.Size(141, 23);
            this.Randoms.TabIndex = 3;
            this.Randoms.Text = "Random Start";
            this.Randoms.UseVisualStyleBackColor = true;
            this.Randoms.Click += new System.EventHandler(this.randomStart);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(2, 82);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(141, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Restart board";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.RestartButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 543);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.Randoms);
            this.Controls.Add(this.newgrid);
            this.Name = "Form1";
            this.Text = "8 Queens";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel newgrid;
        private System.Windows.Forms.Button Randoms;
        private System.Windows.Forms.Button buttonReset;
    }
}

