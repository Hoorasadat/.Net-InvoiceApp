﻿namespace Lab_3
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(-1, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(495, 667);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customers List:";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(293, 605);
            button2.Name = "button2";
            button2.Size = new Size(175, 49);
            button2.TabIndex = 8;
            button2.Text = "Remove Customer";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(24, 605);
            button1.Name = "button1";
            button1.Size = new Size(175, 49);
            button1.TabIndex = 7;
            button1.Text = "Add Customer";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(291, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 32);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(291, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 32);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 117);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 4;
            label4.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 87);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 3;
            label3.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 57);
            label2.Name = "label2";
            label2.Size = new Size(190, 23);
            label2.TabIndex = 2;
            label2.Text = "Account # (optional):";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(291, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 32);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(482, 437);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Window;
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Desktop;
            groupBox2.Location = new Point(623, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(494, 667);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Invoices List:";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.ForeColor = SystemColors.Highlight;
            button3.Location = new Point(296, 605);
            button3.Name = "button3";
            button3.Size = new Size(175, 49);
            button3.TabIndex = 10;
            button3.Text = "Remove Invoice";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Info;
            button4.ForeColor = SystemColors.Highlight;
            button4.Location = new Point(23, 605);
            button4.Name = "button4";
            button4.Size = new Size(175, 49);
            button4.TabIndex = 9;
            button4.Text = "Add Invoice";
            button4.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.Highlight;
            dateTimePicker1.CalendarMonthBackground = SystemColors.Info;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.Info;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.Highlight;
            dateTimePicker1.CalendarTrailingForeColor = SystemColors.Highlight;
            dateTimePicker1.Location = new Point(273, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 32);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Info;
            textBox4.Location = new Point(273, 55);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 32);
            textBox4.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 89);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 3;
            label6.Text = "Invoice Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 59);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 2;
            label5.Text = "Power Usage:";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.BackgroundColor = SystemColors.Info;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 156);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(482, 437);
            dataGridView2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(259, 0);
            label1.Name = "label1";
            label1.Size = new Size(625, 92);
            label1.TabIndex = 3;
            label1.Text = "Invoice Application";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blurBG;
            ClientSize = new Size(1117, 827);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}