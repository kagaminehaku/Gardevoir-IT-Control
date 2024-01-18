namespace GITC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            Enable = new System.Windows.Forms.Button();
            Disable = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            Exit = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Enable
            // 
            Enable.Location = new System.Drawing.Point(75, 22);
            Enable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Enable.Name = "Enable";
            Enable.Size = new System.Drawing.Size(88, 27);
            Enable.TabIndex = 0;
            Enable.Text = "Enable";
            Enable.UseVisualStyleBackColor = true;
            Enable.Click += Enable_Click;
            // 
            // Disable
            // 
            Disable.Location = new System.Drawing.Point(75, 68);
            Disable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Disable.Name = "Disable";
            Disable.Size = new System.Drawing.Size(88, 27);
            Disable.TabIndex = 1;
            Disable.Text = "Disable";
            Disable.UseVisualStyleBackColor = true;
            Disable.Click += Disable_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Disable);
            groupBox1.Controls.Add(Enable);
            groupBox1.Location = new System.Drawing.Point(14, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(233, 115);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Desktop Computer/Network Icon";
            // 
            // Exit
            // 
            Exit.Location = new System.Drawing.Point(832, 479);
            Exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Exit.Name = "Exit";
            Exit.Size = new System.Drawing.Size(88, 27);
            Exit.TabIndex = 3;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            // 
            // UI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(Exit);
            Controls.Add(groupBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "UI";
            StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            Text = "Gardevoir IT Control";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Enable;
        private System.Windows.Forms.Button Disable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Exit;
    }
}

