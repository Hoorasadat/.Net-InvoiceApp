namespace Lab_3
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
            rmvCstmr = new Button();
            btnAddCstmr = new Button();
            txtBxLstNm = new TextBox();
            txtBxFrstNm = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtBxAccNmbr = new TextBox();
            cstGrdView = new DataGridView();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button4 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            invcGrdView = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            clsBtn = new Button();
            btnclose = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cstGrdView).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)invcGrdView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Window;
            groupBox1.Controls.Add(rmvCstmr);
            groupBox1.Controls.Add(btnAddCstmr);
            groupBox1.Controls.Add(txtBxLstNm);
            groupBox1.Controls.Add(txtBxFrstNm);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBxAccNmbr);
            groupBox1.Controls.Add(cstGrdView);
            groupBox1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Desktop;
            groupBox1.Location = new Point(-1, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(495, 667);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customers List:";
            // 
            // rmvCstmr
            // 
            rmvCstmr.BackColor = SystemColors.Info;
            rmvCstmr.ForeColor = SystemColors.Highlight;
            rmvCstmr.Location = new Point(293, 605);
            rmvCstmr.Name = "rmvCstmr";
            rmvCstmr.Size = new Size(175, 49);
            rmvCstmr.TabIndex = 8;
            rmvCstmr.Text = "Remove Customer";
            rmvCstmr.UseVisualStyleBackColor = false;
            rmvCstmr.Click += rmvCstmr_Click;
            // 
            // btnAddCstmr
            // 
            btnAddCstmr.BackColor = SystemColors.Info;
            btnAddCstmr.ForeColor = SystemColors.Highlight;
            btnAddCstmr.Location = new Point(24, 605);
            btnAddCstmr.Name = "btnAddCstmr";
            btnAddCstmr.Size = new Size(175, 49);
            btnAddCstmr.TabIndex = 7;
            btnAddCstmr.Text = "Add Customer";
            btnAddCstmr.UseVisualStyleBackColor = false;
            btnAddCstmr.Click += btnAddCstmr_Click;
            // 
            // txtBxLstNm
            // 
            txtBxLstNm.BackColor = SystemColors.Info;
            txtBxLstNm.Location = new Point(291, 113);
            txtBxLstNm.Name = "txtBxLstNm";
            txtBxLstNm.Size = new Size(181, 32);
            txtBxLstNm.TabIndex = 6;
            // 
            // txtBxFrstNm
            // 
            txtBxFrstNm.BackColor = SystemColors.Info;
            txtBxFrstNm.Location = new Point(291, 83);
            txtBxFrstNm.Name = "txtBxFrstNm";
            txtBxFrstNm.Size = new Size(181, 32);
            txtBxFrstNm.TabIndex = 5;
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
            // txtBxAccNmbr
            // 
            txtBxAccNmbr.BackColor = SystemColors.Info;
            txtBxAccNmbr.Location = new Point(291, 53);
            txtBxAccNmbr.Name = "txtBxAccNmbr";
            txtBxAccNmbr.Size = new Size(181, 32);
            txtBxAccNmbr.TabIndex = 1;
            // 
            // cstGrdView
            // 
            cstGrdView.AllowUserToOrderColumns = true;
            cstGrdView.BackgroundColor = SystemColors.Info;
            cstGrdView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cstGrdView.Location = new Point(6, 156);
            cstGrdView.Name = "cstGrdView";
            cstGrdView.RowTemplate.Height = 25;
            cstGrdView.Size = new Size(482, 437);
            cstGrdView.TabIndex = 0;
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
            groupBox2.Controls.Add(invcGrdView);
            groupBox2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Desktop;
            groupBox2.Location = new Point(623, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(623, 667);
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
            // invcGrdView
            // 
            invcGrdView.AllowUserToOrderColumns = true;
            invcGrdView.BackgroundColor = SystemColors.Info;
            invcGrdView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invcGrdView.Location = new Point(6, 156);
            invcGrdView.Name = "invcGrdView";
            invcGrdView.RowTemplate.Height = 25;
            invcGrdView.Size = new Size(611, 437);
            invcGrdView.TabIndex = 1;
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
            // clsBtn
            // 
            clsBtn.Location = new Point(0, 0);
            clsBtn.Name = "clsBtn";
            clsBtn.Size = new Size(75, 23);
            clsBtn.TabIndex = 0;
            // 
            // btnclose
            // 
            btnclose.BackColor = SystemColors.Info;
            btnclose.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnclose.ForeColor = SystemColors.Highlight;
            btnclose.Location = new Point(1171, 12);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(75, 75);
            btnclose.TabIndex = 4;
            btnclose.Text = "Close App";
            btnclose.UseVisualStyleBackColor = false;
            btnclose.Click += btnclose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blurBG;
            ClientSize = new Size(1246, 827);
            Controls.Add(btnclose);
            Controls.Add(clsBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cstGrdView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)invcGrdView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView cstGrdView;
        private DataGridView invcGrdView;
        private TextBox txtBxAccNmbr;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox txtBxLstNm;
        private TextBox txtBxFrstNm;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private Button btnAddCstmr;
        private Button rmvCstmr;
        private Button button3;
        private Button button4;
        private Button clsBtn;
        private Button btnclose;
    }
}