namespace BY3_CW_Tool
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseMenu = new System.Windows.Forms.Button();
            this.Trainer = new System.Windows.Forms.Button();
            this.Misc = new System.Windows.Forms.Button();
            this.Visual = new System.Windows.Forms.Button();
            this.Aim = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.CloseMenu);
            this.panel1.Controls.Add(this.Trainer);
            this.panel1.Controls.Add(this.Misc);
            this.panel1.Controls.Add(this.Visual);
            this.panel1.Controls.Add(this.Aim);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 99);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CloseMenu
            // 
            this.CloseMenu.AccessibleName = "Close";
            this.CloseMenu.FlatAppearance.BorderSize = 0;
            this.CloseMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseMenu.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseMenu.ForeColor = System.Drawing.Color.DarkRed;
            this.CloseMenu.Location = new System.Drawing.Point(863, 0);
            this.CloseMenu.Name = "CloseMenu";
            this.CloseMenu.Size = new System.Drawing.Size(145, 99);
            this.CloseMenu.TabIndex = 2;
            this.CloseMenu.Text = "X";
            this.CloseMenu.UseVisualStyleBackColor = true;
            this.CloseMenu.Click += new System.EventHandler(this.CloseMenu_Click);
            // 
            // Trainer
            // 
            this.Trainer.AccessibleName = "Trainer";
            this.Trainer.FlatAppearance.BorderSize = 0;
            this.Trainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Trainer.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Trainer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Trainer.Location = new System.Drawing.Point(692, 0);
            this.Trainer.Name = "Trainer";
            this.Trainer.Size = new System.Drawing.Size(177, 99);
            this.Trainer.TabIndex = 1;
            this.Trainer.Text = "Trainer";
            this.Trainer.UseVisualStyleBackColor = true;
            this.Trainer.Click += new System.EventHandler(this.Trainer_Click);
            // 
            // Misc
            // 
            this.Misc.AccessibleName = "Misc";
            this.Misc.FlatAppearance.BorderSize = 0;
            this.Misc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Misc.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Misc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Misc.Location = new System.Drawing.Point(490, 0);
            this.Misc.Name = "Misc";
            this.Misc.Size = new System.Drawing.Size(207, 99);
            this.Misc.TabIndex = 1;
            this.Misc.Text = "Misc";
            this.Misc.UseVisualStyleBackColor = true;
            this.Misc.Click += new System.EventHandler(this.Misc_Click);
            // 
            // Visual
            // 
            this.Visual.AccessibleName = "Visual";
            this.Visual.FlatAppearance.BorderSize = 0;
            this.Visual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visual.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Visual.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Visual.Location = new System.Drawing.Point(303, 0);
            this.Visual.Name = "Visual";
            this.Visual.Size = new System.Drawing.Size(192, 99);
            this.Visual.TabIndex = 1;
            this.Visual.Text = "Visual";
            this.Visual.UseVisualStyleBackColor = true;
            this.Visual.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Aim
            // 
            this.Aim.AccessibleName = "Aim";
            this.Aim.FlatAppearance.BorderSize = 0;
            this.Aim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aim.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Aim.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Aim.Location = new System.Drawing.Point(91, 0);
            this.Aim.Name = "Aim";
            this.Aim.Size = new System.Drawing.Size(215, 99);
            this.Aim.TabIndex = 1;
            this.Aim.Text = "Aim";
            this.Aim.UseVisualStyleBackColor = true;
            this.Aim.Click += new System.EventHandler(this.Main_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 99);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1008, 595);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button Aim;
        private Button Trainer;
        private Button Misc;
        private Button Visual;
        private Button CloseMenu;
    }
}