namespace BY3_CW_Tool
{
    partial class frmAim
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
            this.abotCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // abotCheck
            // 
            this.abotCheck.AutoSize = true;
            this.abotCheck.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.abotCheck.ForeColor = System.Drawing.Color.FloralWhite;
            this.abotCheck.Location = new System.Drawing.Point(19, 20);
            this.abotCheck.Name = "abotCheck";
            this.abotCheck.Size = new System.Drawing.Size(111, 36);
            this.abotCheck.TabIndex = 0;
            this.abotCheck.Text = "Aimbot";
            this.abotCheck.UseVisualStyleBackColor = true;
            // 
            // frmAim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1008, 496);
            this.Controls.Add(this.abotCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAim";
            this.Text = "frmAim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox abotCheck;
    }
}