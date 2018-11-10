namespace LED_Control
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
            this.cbx1 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx2 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx3 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx4 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx8 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx7 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx6 = new MetroFramework.Controls.MetroCheckBox();
            this.cbx5 = new MetroFramework.Controls.MetroCheckBox();
            this.Button1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.Location = new System.Drawing.Point(23, 84);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(52, 15);
            this.cbx1.TabIndex = 0;
            this.cbx1.Text = "LED 1";
            this.cbx1.UseSelectable = true;
            // 
            // cbx2
            // 
            this.cbx2.AutoSize = true;
            this.cbx2.Location = new System.Drawing.Point(23, 128);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(52, 15);
            this.cbx2.TabIndex = 1;
            this.cbx2.Text = "LED 2";
            this.cbx2.UseSelectable = true;
            // 
            // cbx3
            // 
            this.cbx3.AutoSize = true;
            this.cbx3.Location = new System.Drawing.Point(23, 176);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(52, 15);
            this.cbx3.TabIndex = 2;
            this.cbx3.Text = "LED 3";
            this.cbx3.UseSelectable = true;
            // 
            // cbx4
            // 
            this.cbx4.AutoSize = true;
            this.cbx4.Location = new System.Drawing.Point(23, 217);
            this.cbx4.Name = "cbx4";
            this.cbx4.Size = new System.Drawing.Size(52, 15);
            this.cbx4.TabIndex = 4;
            this.cbx4.Text = "LED 4";
            this.cbx4.UseSelectable = true;
            // 
            // cbx8
            // 
            this.cbx8.AutoSize = true;
            this.cbx8.Location = new System.Drawing.Point(136, 217);
            this.cbx8.Name = "cbx8";
            this.cbx8.Size = new System.Drawing.Size(52, 15);
            this.cbx8.TabIndex = 8;
            this.cbx8.Text = "LED 8";
            this.cbx8.UseSelectable = true;
            // 
            // cbx7
            // 
            this.cbx7.AutoSize = true;
            this.cbx7.Location = new System.Drawing.Point(136, 176);
            this.cbx7.Name = "cbx7";
            this.cbx7.Size = new System.Drawing.Size(52, 15);
            this.cbx7.TabIndex = 7;
            this.cbx7.Text = "LED 7";
            this.cbx7.UseSelectable = true;
            // 
            // cbx6
            // 
            this.cbx6.AutoSize = true;
            this.cbx6.Location = new System.Drawing.Point(136, 128);
            this.cbx6.Name = "cbx6";
            this.cbx6.Size = new System.Drawing.Size(52, 15);
            this.cbx6.TabIndex = 6;
            this.cbx6.Text = "LED 6";
            this.cbx6.UseSelectable = true;
            // 
            // cbx5
            // 
            this.cbx5.AutoSize = true;
            this.cbx5.Location = new System.Drawing.Point(136, 84);
            this.cbx5.Name = "cbx5";
            this.cbx5.Size = new System.Drawing.Size(52, 15);
            this.cbx5.TabIndex = 5;
            this.cbx5.Text = "LED 5";
            this.cbx5.UseSelectable = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(77, 256);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 9;
            this.Button1.Text = "Apply";
            this.Button1.UseSelectable = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 302);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.cbx8);
            this.Controls.Add(this.cbx7);
            this.Controls.Add(this.cbx6);
            this.Controls.Add(this.cbx5);
            this.Controls.Add(this.cbx4);
            this.Controls.Add(this.cbx3);
            this.Controls.Add(this.cbx2);
            this.Controls.Add(this.cbx1);
            this.Name = "Form1";
            this.Text = "LED Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox cbx1;
        private MetroFramework.Controls.MetroCheckBox cbx2;
        private MetroFramework.Controls.MetroCheckBox cbx3;
        private MetroFramework.Controls.MetroCheckBox cbx4;
        private MetroFramework.Controls.MetroCheckBox cbx8;
        private MetroFramework.Controls.MetroCheckBox cbx7;
        private MetroFramework.Controls.MetroCheckBox cbx6;
        private MetroFramework.Controls.MetroCheckBox cbx5;
        private MetroFramework.Controls.MetroButton Button1;
    }
}

