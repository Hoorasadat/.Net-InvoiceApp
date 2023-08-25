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
            rmvInvc = new Button();
            btnAddInvc = new Button();
            invDatePkr = new DateTimePicker();
            txtPwrUsg = new TextBox();
            label6 = new Label();
            label5 = new Label();
            invcGrdView = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            clsBtn = new Button();
            btnclose = new Button();
            groupBox3 = new GroupBox();
            txtbAvgBill = new TextBox();
            txtbTtlUsg = new TextBox();
            txtbNoCstm = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cstGrdView).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)invcGrdView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
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
            groupBox1.Location = new Point(-1, 133);
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
            txtBxLstNm.ForeColor = SystemColors.Highlight;
            txtBxLstNm.Location = new Point(291, 113);
            txtBxLstNm.Name = "txtBxLstNm";
            txtBxLstNm.Size = new Size(181, 32);
            txtBxLstNm.TabIndex = 6;
            // 
            // txtBxFrstNm
            // 
            txtBxFrstNm.BackColor = SystemColors.Info;
            txtBxFrstNm.ForeColor = SystemColors.Highlight;
            txtBxFrstNm.Location = new Point(291, 83);
            txtBxFrstNm.Name = "txtBxFrstNm";
            txtBxFrstNm.Size = new Size(181, 32);
            txtBxFrstNm.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(7, 117);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 4;
            label4.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(7, 87);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 3;
            label3.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(7, 57);
            label2.Name = "label2";
            label2.Size = new Size(190, 23);
            label2.TabIndex = 2;
            label2.Text = "Account # (optional):";
            // 
            // txtBxAccNmbr
            // 
            txtBxAccNmbr.BackColor = SystemColors.Info;
            txtBxAccNmbr.ForeColor = SystemColors.Highlight;
            txtBxAccNmbr.Location = new Point(291, 53);
            txtBxAccNmbr.Name = "txtBxAccNmbr";
            txtBxAccNmbr.Size = new Size(181, 32);
            txtBxAccNmbr.TabIndex = 1;
            txtBxAccNmbr.TextChanged += txtBxAccNmbr_TextChanged;
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
            groupBox2.Controls.Add(rmvInvc);
            groupBox2.Controls.Add(btnAddInvc);
            groupBox2.Controls.Add(invDatePkr);
            groupBox2.Controls.Add(txtPwrUsg);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(invcGrdView);
            groupBox2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.Desktop;
            groupBox2.Location = new Point(623, 133);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(623, 667);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Invoices List:";
            // 
            // rmvInvc
            // 
            rmvInvc.BackColor = SystemColors.Info;
            rmvInvc.ForeColor = SystemColors.Highlight;
            rmvInvc.Location = new Point(424, 605);
            rmvInvc.Name = "rmvInvc";
            rmvInvc.Size = new Size(175, 49);
            rmvInvc.TabIndex = 10;
            rmvInvc.Text = "Remove Invoice";
            rmvInvc.UseVisualStyleBackColor = false;
            rmvInvc.Click += rmvInvc_Click;
            // 
            // btnAddInvc
            // 
            btnAddInvc.BackColor = SystemColors.Info;
            btnAddInvc.ForeColor = SystemColors.Highlight;
            btnAddInvc.Location = new Point(23, 605);
            btnAddInvc.Name = "btnAddInvc";
            btnAddInvc.Size = new Size(175, 49);
            btnAddInvc.TabIndex = 9;
            btnAddInvc.Text = "Add Invoice";
            btnAddInvc.UseVisualStyleBackColor = false;
            btnAddInvc.Click += btnAddInvc_Click;
            // 
            // invDatePkr
            // 
            invDatePkr.CalendarForeColor = SystemColors.Highlight;
            invDatePkr.CalendarMonthBackground = SystemColors.Info;
            invDatePkr.CalendarTitleBackColor = SystemColors.Info;
            invDatePkr.CalendarTitleForeColor = SystemColors.Highlight;
            invDatePkr.CalendarTrailingForeColor = SystemColors.Highlight;
            invDatePkr.Location = new Point(273, 86);
            invDatePkr.Name = "invDatePkr";
            invDatePkr.Size = new Size(200, 32);
            invDatePkr.TabIndex = 5;
            // 
            // txtPwrUsg
            // 
            txtPwrUsg.BackColor = SystemColors.Info;
            txtPwrUsg.ForeColor = SystemColors.Highlight;
            txtPwrUsg.Location = new Point(273, 55);
            txtPwrUsg.Name = "txtPwrUsg";
            txtPwrUsg.Size = new Size(200, 32);
            txtPwrUsg.TabIndex = 4;
            txtPwrUsg.TextChanged += txtPwrUsg_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(6, 89);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 3;
            label6.Text = "Invoice Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Highlight;
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
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Window;
            groupBox3.Controls.Add(txtbAvgBill);
            groupBox3.Controls.Add(txtbTtlUsg);
            groupBox3.Controls.Add(txtbNoCstm);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(290, 807);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(531, 166);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Statistics";
            // 
            // txtbAvgBill
            // 
            txtbAvgBill.BackColor = SystemColors.ControlLight;
            txtbAvgBill.ForeColor = SystemColors.Highlight;
            txtbAvgBill.Location = new Point(339, 126);
            txtbAvgBill.Name = "txtbAvgBill";
            txtbAvgBill.Size = new Size(181, 32);
            txtbAvgBill.TabIndex = 9;
            // 
            // txtbTtlUsg
            // 
            txtbTtlUsg.BackColor = SystemColors.ControlLight;
            txtbTtlUsg.ForeColor = SystemColors.Highlight;
            txtbTtlUsg.Location = new Point(339, 96);
            txtbTtlUsg.Name = "txtbTtlUsg";
            txtbTtlUsg.Size = new Size(181, 32);
            txtbTtlUsg.TabIndex = 8;
            // 
            // txtbNoCstm
            // 
            txtbNoCstm.BackColor = SystemColors.ControlLight;
            txtbNoCstm.ForeColor = SystemColors.Highlight;
            txtbNoCstm.Location = new Point(339, 66);
            txtbNoCstm.Name = "txtbNoCstm";
            txtbNoCstm.Size = new Size(181, 32);
            txtbNoCstm.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(6, 126);
            label9.Name = "label9";
            label9.Size = new Size(213, 23);
            label9.TabIndex = 2;
            label9.Text = "Average bill amount ($):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(6, 96);
            label8.Name = "label8";
            label8.Size = new Size(237, 23);
            label8.TabIndex = 1;
            label8.Text = "Total number of kWh used:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(6, 66);
            label7.Name = "label7";
            label7.Size = new Size(283, 23);
            label7.TabIndex = 0;
            label7.Text = "Number of customers processed:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.blurBG;
            ClientSize = new Size(1246, 973);
            Controls.Add(groupBox3);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private DateTimePicker invDatePkr;
        private TextBox txtPwrUsg;
        private Button btnAddCstmr;
        private Button rmvCstmr;
        private Button rmvInvc;
        private Button btnAddInvc;
        private Button clsBtn;
        private Button btnclose;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox txtbAvgBill;
        private TextBox txtbTtlUsg;
        private TextBox txtbNoCstm;
        private Label label9;
        private Label label8;
    }
}