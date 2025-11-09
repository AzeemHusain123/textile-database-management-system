namespace WindowsFormsApp1
{
    partial class SignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.back_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.dateTimePicker02 = new System.Windows.Forms.DateTimePicker();
            this.textBox05 = new System.Windows.Forms.TextBox();
            this.textBox04 = new System.Windows.Forms.TextBox();
            this.textBox03 = new System.Windows.Forms.TextBox();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 67);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(126, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Signing Up";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 41);
            this.panel2.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.textBox2.Font = new System.Drawing.Font("Algerian", 9F);
            this.textBox2.Location = new System.Drawing.Point(21, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 27);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "ADD ACCOUNT";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.back_button);
            this.panel3.Controls.Add(this.clear_button);
            this.panel3.Controls.Add(this.save_button);
            this.panel3.Controls.Add(this.dateTimePicker02);
            this.panel3.Controls.Add(this.textBox05);
            this.panel3.Controls.Add(this.textBox04);
            this.panel3.Controls.Add(this.textBox03);
            this.panel3.Controls.Add(this.textBox01);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 390);
            this.panel3.TabIndex = 5;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.LightSlateGray;
            this.back_button.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F);
            this.back_button.Location = new System.Drawing.Point(3, 351);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(74, 36);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.LightSlateGray;
            this.clear_button.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F);
            this.clear_button.Location = new System.Drawing.Point(263, 275);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(76, 36);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "CLEAR";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.LightSlateGray;
            this.save_button.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F);
            this.save_button.Location = new System.Drawing.Point(356, 274);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(77, 36);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "SAVE";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // dateTimePicker02
            // 
            this.dateTimePicker02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimePicker02.Location = new System.Drawing.Point(201, 73);
            this.dateTimePicker02.Name = "dateTimePicker02";
            this.dateTimePicker02.Size = new System.Drawing.Size(241, 24);
            this.dateTimePicker02.TabIndex = 2;
            // 
            // textBox05
            // 
            this.textBox05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox05.Location = new System.Drawing.Point(201, 211);
            this.textBox05.Name = "textBox05";
            this.textBox05.Size = new System.Drawing.Size(241, 24);
            this.textBox05.TabIndex = 1;
            this.textBox05.UseSystemPasswordChar = true;
            // 
            // textBox04
            // 
            this.textBox04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox04.Location = new System.Drawing.Point(201, 169);
            this.textBox04.Name = "textBox04";
            this.textBox04.Size = new System.Drawing.Size(241, 24);
            this.textBox04.TabIndex = 1;
            this.textBox04.UseSystemPasswordChar = true;
            // 
            // textBox03
            // 
            this.textBox03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox03.Location = new System.Drawing.Point(201, 125);
            this.textBox03.Name = "textBox03";
            this.textBox03.Size = new System.Drawing.Size(241, 24);
            this.textBox03.TabIndex = 1;
            // 
            // textBox01
            // 
            this.textBox01.BackColor = System.Drawing.SystemColors.Window;
            this.textBox01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox01.Location = new System.Drawing.Point(201, 31);
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(241, 24);
            this.textBox01.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(21, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Confirm Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(21, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 498);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker02;
        private System.Windows.Forms.TextBox textBox05;
        private System.Windows.Forms.TextBox textBox04;
        private System.Windows.Forms.TextBox textBox03;
    }
}