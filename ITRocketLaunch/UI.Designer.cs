namespace ITRocketLaunch
{
    partial class UI
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
            this.Enable = new System.Windows.Forms.Button();
            this.Disable = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enable
            // 
            this.Enable.Location = new System.Drawing.Point(64, 19);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(75, 23);
            this.Enable.TabIndex = 0;
            this.Enable.Text = "Enable";
            this.Enable.UseVisualStyleBackColor = true;
            this.Enable.Click += new System.EventHandler(this.Enable_Click);
            // 
            // Disable
            // 
            this.Disable.Location = new System.Drawing.Point(64, 59);
            this.Disable.Name = "Disable";
            this.Disable.Size = new System.Drawing.Size(75, 23);
            this.Disable.TabIndex = 1;
            this.Disable.Text = "Disable";
            this.Disable.UseVisualStyleBackColor = true;
            this.Disable.Click += new System.EventHandler(this.Disable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Disable);
            this.groupBox1.Controls.Add(this.Enable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desktop Computer/Network Icon";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(713, 415);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.groupBox1);
            this.Name = "UI";
            this.Text = "Gardevoir IT Control";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Enable;
        private System.Windows.Forms.Button Disable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Exit;
    }
}

