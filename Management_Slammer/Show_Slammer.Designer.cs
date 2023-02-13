namespace Management_Slammer
{
    partial class Show_Slammer
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Date_Of_Out = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.comPunshment = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rYes = new System.Windows.Forms.RadioButton();
            this.rNo = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Date_Of_Enter = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comErea = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rMale = new System.Windows.Forms.RadioButton();
            this.rFimale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.conAccusation = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSereach = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.btnSereach.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(200, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 38);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(6, 23);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(257, 26);
            this.txtPhone.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(269, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "رقم الهاتف";
            // 
            // Date_Of_Out
            // 
            this.Date_Of_Out.Location = new System.Drawing.Point(230, 31);
            this.Date_Of_Out.Name = "Date_Of_Out";
            this.Date_Of_Out.Size = new System.Drawing.Size(312, 26);
            this.Date_Of_Out.TabIndex = 15;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridView1);
            this.groupBox7.Location = new System.Drawing.Point(6, 305);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1105, 277);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1093, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(774, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "العقوبة";
            // 
            // comPunshment
            // 
            this.comPunshment.FormattingEnabled = true;
            this.comPunshment.Location = new System.Drawing.Point(647, 27);
            this.comPunshment.Name = "comPunshment";
            this.comPunshment.Size = new System.Drawing.Size(121, 27);
            this.comPunshment.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(548, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "تاريخ الخروج";
            // 
            // rYes
            // 
            this.rYes.AutoSize = true;
            this.rYes.Location = new System.Drawing.Point(56, 19);
            this.rYes.Name = "rYes";
            this.rYes.Size = new System.Drawing.Size(42, 23);
            this.rYes.TabIndex = 1;
            this.rYes.TabStop = true;
            this.rYes.Text = "نعم";
            this.rYes.UseVisualStyleBackColor = true;
            // 
            // rNo
            // 
            this.rNo.AutoSize = true;
            this.rNo.Location = new System.Drawing.Point(3, 19);
            this.rNo.Name = "rNo";
            this.rNo.Size = new System.Drawing.Size(36, 23);
            this.rNo.TabIndex = 0;
            this.rNo.TabStop = true;
            this.rNo.Text = "لا";
            this.rNo.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(119, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 21);
            this.label11.TabIndex = 1;
            this.label11.Text = "هل تمت محاكمته";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rYes);
            this.groupBox6.Controls.Add(this.rNo);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(856, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(241, 48);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // Date_Of_Enter
            // 
            this.Date_Of_Enter.Location = new System.Drawing.Point(104, 26);
            this.Date_Of_Enter.Name = "Date_Of_Enter";
            this.Date_Of_Enter.Size = new System.Drawing.Size(281, 26);
            this.Date_Of_Enter.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Date_Of_Out);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.comPunshment);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(8, 168);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1103, 69);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(391, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "تاريخ الدخول";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Date_Of_Enter);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.comErea);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.conAccusation);
            this.groupBox4.Location = new System.Drawing.Point(6, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1105, 69);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1040, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "المنطقة";
            // 
            // comErea
            // 
            this.comErea.FormattingEnabled = true;
            this.comErea.Location = new System.Drawing.Point(873, 21);
            this.comErea.Name = "comErea";
            this.comErea.Size = new System.Drawing.Size(152, 27);
            this.comErea.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rMale);
            this.groupBox2.Controls.Add(this.rFimale);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(484, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 48);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // rMale
            // 
            this.rMale.AutoSize = true;
            this.rMale.Location = new System.Drawing.Point(56, 19);
            this.rMale.Name = "rMale";
            this.rMale.Size = new System.Drawing.Size(46, 23);
            this.rMale.TabIndex = 1;
            this.rMale.TabStop = true;
            this.rMale.Text = "ذكر";
            this.rMale.UseVisualStyleBackColor = true;
            // 
            // rFimale
            // 
            this.rFimale.AutoSize = true;
            this.rFimale.Location = new System.Drawing.Point(3, 19);
            this.rFimale.Name = "rFimale";
            this.rFimale.Size = new System.Drawing.Size(47, 23);
            this.rFimale.TabIndex = 0;
            this.rFimale.TabStop = true;
            this.rFimale.Text = "أنثى";
            this.rFimale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(119, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "الجنس";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(822, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "التهمة";
            // 
            // conAccusation
            // 
            this.conAccusation.FormattingEnabled = true;
            this.conAccusation.Location = new System.Drawing.Point(670, 25);
            this.conAccusation.Name = "conAccusation";
            this.conAccusation.Size = new System.Drawing.Size(146, 27);
            this.conAccusation.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.txtAge);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1105, 69);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(896, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1002, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "رقم السجين";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(477, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(341, 26);
            this.txtName.TabIndex = 14;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(345, 25);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(85, 26);
            this.txtAge.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(824, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم السجين";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(436, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "العمر";
            // 
            // btnSereach
            // 
            this.btnSereach.Controls.Add(this.groupBox9);
            this.btnSereach.Controls.Add(this.groupBox7);
            this.btnSereach.Controls.Add(this.groupBox5);
            this.btnSereach.Controls.Add(this.groupBox4);
            this.btnSereach.Controls.Add(this.groupBox3);
            this.btnSereach.Location = new System.Drawing.Point(12, 12);
            this.btnSereach.Name = "btnSereach";
            this.btnSereach.Size = new System.Drawing.Size(1117, 588);
            this.btnSereach.TabIndex = 1;
            this.btnSereach.TabStop = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnNew);
            this.groupBox9.Controls.Add(this.button3);
            this.groupBox9.Controls.Add(this.btnUpdate);
            this.groupBox9.Controls.Add(this.btnDelete);
            this.groupBox9.Location = new System.Drawing.Point(490, 243);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(482, 56);
            this.groupBox9.TabIndex = 20;
            this.groupBox9.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(94, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 38);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "جديد";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(389, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "بحث";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(304, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 38);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Show_Slammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 612);
            this.Controls.Add(this.btnSereach);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Show_Slammer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض بيانات السجناء";
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.btnSereach.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker Date_Of_Out;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comPunshment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rYes;
        private System.Windows.Forms.RadioButton rNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker Date_Of_Enter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comErea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rMale;
        private System.Windows.Forms.RadioButton rFimale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox conAccusation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox btnSereach;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNew;
    }
}