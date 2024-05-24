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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            // button1
            // 
            button1.Location = new System.Drawing.Point(66, 22);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(111, 27);
            button1.TabIndex = 4;
            button1.Text = "Install Visual C++ ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(66, 68);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(111, 27);
            button2.TabIndex = 5;
            button2.Text = "Install DirectX";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new System.Drawing.Point(266, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(233, 115);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Game Components";
            // 
            // UI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(511, 263);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "UI";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Gardevoir IT Control";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Enable;
        private System.Windows.Forms.Button Disable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

