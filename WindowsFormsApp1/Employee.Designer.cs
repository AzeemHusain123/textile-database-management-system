namespace WindowsFormsApp1
{
    partial class Employee
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
            this.back_button = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.radioButton09 = new System.Windows.Forms.RadioButton();
            this.radioButton08 = new System.Windows.Forms.RadioButton();
            this.richTextBox05 = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker04 = new System.Windows.Forms.DateTimePicker();
            this.textBox07 = new System.Windows.Forms.TextBox();
            this.textBox06 = new System.Windows.Forms.TextBox();
            this.textBox03 = new System.Windows.Forms.TextBox();
            this.textBox02 = new System.Windows.Forms.TextBox();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.refresh_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxS1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1507, 73);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(384, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "EMPLOYEE INFORMATION";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.back_button);
            this.panel2.Controls.Add(this.new_button);
            this.panel2.Controls.Add(this.delete_button);
            this.panel2.Controls.Add(this.update_button);
            this.panel2.Controls.Add(this.save_button);
            this.panel2.Controls.Add(this.radioButton09);
            this.panel2.Controls.Add(this.radioButton08);
            this.panel2.Controls.Add(this.richTextBox05);
            this.panel2.Controls.Add(this.dateTimePicker04);
            this.panel2.Controls.Add(this.textBox07);
            this.panel2.Controls.Add(this.textBox06);
            this.panel2.Controls.Add(this.textBox03);
            this.panel2.Controls.Add(this.textBox02);
            this.panel2.Controls.Add(this.textBox01);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 586);
            this.panel2.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back_button.Location = new System.Drawing.Point(3, 550);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(88, 32);
            this.back_button.TabIndex = 27;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // new_button
            // 
            this.new_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.new_button.Location = new System.Drawing.Point(283, 459);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(88, 32);
            this.new_button.TabIndex = 28;
            this.new_button.Text = "New";
            this.new_button.UseVisualStyleBackColor = true;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delete_button.Location = new System.Drawing.Point(176, 461);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(88, 32);
            this.delete_button.TabIndex = 29;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.update_button.Location = new System.Drawing.Point(282, 415);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(88, 32);
            this.update_button.TabIndex = 30;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.save_button.Location = new System.Drawing.Point(176, 416);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(88, 32);
            this.save_button.TabIndex = 31;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // radioButton09
            // 
            this.radioButton09.AutoSize = true;
            this.radioButton09.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton09.Location = new System.Drawing.Point(268, 371);
            this.radioButton09.Name = "radioButton09";
            this.radioButton09.Size = new System.Drawing.Size(79, 19);
            this.radioButton09.TabIndex = 26;
            this.radioButton09.TabStop = true;
            this.radioButton09.Text = "Female";
            this.radioButton09.UseVisualStyleBackColor = true;
            // 
            // radioButton08
            // 
            this.radioButton08.AutoSize = true;
            this.radioButton08.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton08.Location = new System.Drawing.Point(179, 371);
            this.radioButton08.Name = "radioButton08";
            this.radioButton08.Size = new System.Drawing.Size(61, 19);
            this.radioButton08.TabIndex = 26;
            this.radioButton08.TabStop = true;
            this.radioButton08.Text = "Male";
            this.radioButton08.UseVisualStyleBackColor = true;
            // 
            // richTextBox05
            // 
            this.richTextBox05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.richTextBox05.Location = new System.Drawing.Point(140, 175);
            this.richTextBox05.Name = "richTextBox05";
            this.richTextBox05.Size = new System.Drawing.Size(228, 96);
            this.richTextBox05.TabIndex = 25;
            this.richTextBox05.Text = "";
            // 
            // dateTimePicker04
            // 
            this.dateTimePicker04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dateTimePicker04.Location = new System.Drawing.Point(140, 139);
            this.dateTimePicker04.Name = "dateTimePicker04";
            this.dateTimePicker04.Size = new System.Drawing.Size(228, 24);
            this.dateTimePicker04.TabIndex = 24;
            // 
            // textBox07
            // 
            this.textBox07.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox07.Location = new System.Drawing.Point(140, 327);
            this.textBox07.Name = "textBox07";
            this.textBox07.Size = new System.Drawing.Size(228, 24);
            this.textBox07.TabIndex = 21;
            this.textBox07.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox06
            // 
            this.textBox06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox06.Location = new System.Drawing.Point(140, 288);
            this.textBox06.Name = "textBox06";
            this.textBox06.Size = new System.Drawing.Size(228, 24);
            this.textBox06.TabIndex = 21;
            // 
            // textBox03
            // 
            this.textBox03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox03.Location = new System.Drawing.Point(141, 104);
            this.textBox03.Name = "textBox03";
            this.textBox03.Size = new System.Drawing.Size(227, 24);
            this.textBox03.TabIndex = 21;
            // 
            // textBox02
            // 
            this.textBox02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox02.Location = new System.Drawing.Point(141, 66);
            this.textBox02.Name = "textBox02";
            this.textBox02.Size = new System.Drawing.Size(227, 24);
            this.textBox02.TabIndex = 22;
            // 
            // textBox01
            // 
            this.textBox01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox01.Location = new System.Drawing.Point(142, 29);
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(226, 24);
            this.textBox01.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(-1, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Contact No";
            this.label6.Click += new System.EventHandler(this.label11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(0, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Joined Date";
            this.label4.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(3, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Gender";
            this.label10.Click += new System.EventHandler(this.label11_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(3, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Salary";
            this.label9.Click += new System.EventHandler(this.label11_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(3, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Address";
            this.label8.Click += new System.EventHandler(this.label11_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(0, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Position";
            this.label7.Click += new System.EventHandler(this.label11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(-1, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Employee Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(-1, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Employee ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(389, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1118, 586);
            this.panel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refresh_button);
            this.groupBox2.Controls.Add(this.search_button);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxS1);
            this.groupBox2.Location = new System.Drawing.Point(249, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 125);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(33, 71);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 25);
            this.refresh_button.TabIndex = 3;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(124, 71);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 25);
            this.search_button.TabIndex = 2;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID";
            // 
            // textBoxS1
            // 
            this.textBoxS1.Location = new System.Drawing.Point(114, 31);
            this.textBoxS1.Name = "textBoxS1";
            this.textBoxS1.Size = new System.Drawing.Size(100, 22);
            this.textBoxS1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 423);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Sr#";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Employee Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Position";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Joined Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Contact";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Address";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Salary";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Gender";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 659);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxS1;
        private System.Windows.Forms.TextBox textBox02;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox05;
        private System.Windows.Forms.DateTimePicker dateTimePicker04;
        private System.Windows.Forms.TextBox textBox07;
        private System.Windows.Forms.TextBox textBox06;
        private System.Windows.Forms.TextBox textBox03;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton09;
        private System.Windows.Forms.RadioButton radioButton08;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button refresh_button;
    }
}