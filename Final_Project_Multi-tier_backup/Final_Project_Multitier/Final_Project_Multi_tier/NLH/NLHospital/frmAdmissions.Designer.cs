namespace NLHospital
{
    partial class frmAdmissions
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Closebtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AdmissionRecordIDtxt = new System.Windows.Forms.TextBox();
            this.EPatientIDtxt = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.AddExtrasbtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.findbtn = new System.Windows.Forms.Button();
            this.FNtxt = new System.Windows.Forms.TextBox();
            this.DateOfBirthtxt = new System.Windows.Forms.TextBox();
            this.PatientIDtxt = new System.Windows.Forms.TextBox();
            this.HealthNumbertxt = new System.Windows.Forms.TextBox();
            this.LNtxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.Citytxt = new System.Windows.Forms.TextBox();
            this.NextOfKintxt = new System.Windows.Forms.TextBox();
            this.InsuranceNumbertxt = new System.Windows.Forms.TextBox();
            this.InsuranceCompanytxt = new System.Windows.Forms.TextBox();
            this.Phonetxt = new System.Windows.Forms.TextBox();
            this.PostalCodetxt = new System.Windows.Forms.TextBox();
            this.Doctortxt = new System.Windows.Forms.TextBox();
            this.Provincetxt = new System.Windows.Forms.TextBox();
            this.NOKRelationshiptxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddPatientbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddAdmissionRecordbtn = new System.Windows.Forms.Button();
            this.DischargeDatetxt = new System.Windows.Forms.TextBox();
            this.AdmissionIDtxt = new System.Windows.Forms.TextBox();
            this.APatientIDtxt = new System.Windows.Forms.TextBox();
            this.BedNumbertxt = new System.Windows.Forms.TextBox();
            this.SurgeryScheduledtxt = new System.Windows.Forms.TextBox();
            this.AdmitDatetxt = new System.Windows.Forms.TextBox();
            this.SurgeryDatetxt = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TVrbtn = new System.Windows.Forms.RadioButton();
            this.Phonerbtn = new System.Windows.Forms.RadioButton();
            this.SPrbtn = new System.Windows.Forms.RadioButton();
            this.Privaterbtn = new System.Windows.Forms.RadioButton();
            this.Wardrbtn = new System.Windows.Forms.RadioButton();
            this.BedType = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.BedType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Closebtn
            // 
            this.Closebtn.Location = new System.Drawing.Point(680, 259);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(75, 23);
            this.Closebtn.TabIndex = 19;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(22, 279);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(652, 288);
            this.dataGridView.TabIndex = 39;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.BedType);
            this.tabPage3.Controls.Add(this.AdmissionRecordIDtxt);
            this.tabPage3.Controls.Add(this.EPatientIDtxt);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.AddExtrasbtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(644, 225);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Extras";
            // 
            // AdmissionRecordIDtxt
            // 
            this.AdmissionRecordIDtxt.Location = new System.Drawing.Point(120, 41);
            this.AdmissionRecordIDtxt.Name = "AdmissionRecordIDtxt";
            this.AdmissionRecordIDtxt.Size = new System.Drawing.Size(100, 20);
            this.AdmissionRecordIDtxt.TabIndex = 26;
            // 
            // EPatientIDtxt
            // 
            this.EPatientIDtxt.Location = new System.Drawing.Point(120, 18);
            this.EPatientIDtxt.Name = "EPatientIDtxt";
            this.EPatientIDtxt.Size = new System.Drawing.Size(100, 20);
            this.EPatientIDtxt.TabIndex = 25;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(109, 13);
            this.label25.TabIndex = 18;
            this.label25.Text = "Admission Record ID:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(55, 21);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 13);
            this.label29.TabIndex = 14;
            this.label29.Text = "Patient ID:";
            // 
            // AddExtrasbtn
            // 
            this.AddExtrasbtn.Location = new System.Drawing.Point(145, 86);
            this.AddExtrasbtn.Name = "AddExtrasbtn";
            this.AddExtrasbtn.Size = new System.Drawing.Size(75, 23);
            this.AddExtrasbtn.TabIndex = 0;
            this.AddExtrasbtn.Text = "Add Extras";
            this.AddExtrasbtn.UseVisualStyleBackColor = true;
            this.AddExtrasbtn.Click += new System.EventHandler(this.AddExtrasbtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage2.Controls.Add(this.findbtn);
            this.tabPage2.Controls.Add(this.FNtxt);
            this.tabPage2.Controls.Add(this.DateOfBirthtxt);
            this.tabPage2.Controls.Add(this.PatientIDtxt);
            this.tabPage2.Controls.Add(this.HealthNumbertxt);
            this.tabPage2.Controls.Add(this.LNtxt);
            this.tabPage2.Controls.Add(this.Addresstxt);
            this.tabPage2.Controls.Add(this.Citytxt);
            this.tabPage2.Controls.Add(this.NextOfKintxt);
            this.tabPage2.Controls.Add(this.InsuranceNumbertxt);
            this.tabPage2.Controls.Add(this.InsuranceCompanytxt);
            this.tabPage2.Controls.Add(this.Phonetxt);
            this.tabPage2.Controls.Add(this.PostalCodetxt);
            this.tabPage2.Controls.Add(this.Doctortxt);
            this.tabPage2.Controls.Add(this.Provincetxt);
            this.tabPage2.Controls.Add(this.NOKRelationshiptxt);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.AddPatientbtn);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patients";
            // 
            // findbtn
            // 
            this.findbtn.Location = new System.Drawing.Point(459, 112);
            this.findbtn.Name = "findbtn";
            this.findbtn.Size = new System.Drawing.Size(75, 23);
            this.findbtn.TabIndex = 38;
            this.findbtn.Text = "Find patient";
            this.findbtn.UseVisualStyleBackColor = true;
            this.findbtn.Click += new System.EventHandler(this.findbtn_Click);
            // 
            // FNtxt
            // 
            this.FNtxt.Location = new System.Drawing.Point(101, 79);
            this.FNtxt.Name = "FNtxt";
            this.FNtxt.Size = new System.Drawing.Size(100, 20);
            this.FNtxt.TabIndex = 8;
            // 
            // DateOfBirthtxt
            // 
            this.DateOfBirthtxt.Location = new System.Drawing.Point(101, 27);
            this.DateOfBirthtxt.Name = "DateOfBirthtxt";
            this.DateOfBirthtxt.Size = new System.Drawing.Size(100, 20);
            this.DateOfBirthtxt.TabIndex = 5;
            // 
            // PatientIDtxt
            // 
            this.PatientIDtxt.Location = new System.Drawing.Point(520, 31);
            this.PatientIDtxt.Name = "PatientIDtxt";
            this.PatientIDtxt.Size = new System.Drawing.Size(100, 20);
            this.PatientIDtxt.TabIndex = 36;
            // 
            // HealthNumbertxt
            // 
            this.HealthNumbertxt.Location = new System.Drawing.Point(101, 53);
            this.HealthNumbertxt.Name = "HealthNumbertxt";
            this.HealthNumbertxt.Size = new System.Drawing.Size(100, 20);
            this.HealthNumbertxt.TabIndex = 7;
            // 
            // LNtxt
            // 
            this.LNtxt.Location = new System.Drawing.Point(101, 105);
            this.LNtxt.Name = "LNtxt";
            this.LNtxt.Size = new System.Drawing.Size(100, 20);
            this.LNtxt.TabIndex = 9;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Location = new System.Drawing.Point(101, 131);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(100, 20);
            this.Addresstxt.TabIndex = 10;
            // 
            // Citytxt
            // 
            this.Citytxt.Location = new System.Drawing.Point(101, 157);
            this.Citytxt.Name = "Citytxt";
            this.Citytxt.Size = new System.Drawing.Size(100, 20);
            this.Citytxt.TabIndex = 11;
            // 
            // NextOfKintxt
            // 
            this.NextOfKintxt.Location = new System.Drawing.Point(309, 135);
            this.NextOfKintxt.Name = "NextOfKintxt";
            this.NextOfKintxt.Size = new System.Drawing.Size(100, 20);
            this.NextOfKintxt.TabIndex = 29;
            // 
            // InsuranceNumbertxt
            // 
            this.InsuranceNumbertxt.Location = new System.Drawing.Point(309, 109);
            this.InsuranceNumbertxt.Name = "InsuranceNumbertxt";
            this.InsuranceNumbertxt.Size = new System.Drawing.Size(100, 20);
            this.InsuranceNumbertxt.TabIndex = 28;
            // 
            // InsuranceCompanytxt
            // 
            this.InsuranceCompanytxt.Location = new System.Drawing.Point(309, 83);
            this.InsuranceCompanytxt.Name = "InsuranceCompanytxt";
            this.InsuranceCompanytxt.Size = new System.Drawing.Size(100, 20);
            this.InsuranceCompanytxt.TabIndex = 27;
            // 
            // Phonetxt
            // 
            this.Phonetxt.Location = new System.Drawing.Point(309, 57);
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(100, 20);
            this.Phonetxt.TabIndex = 26;
            // 
            // PostalCodetxt
            // 
            this.PostalCodetxt.Location = new System.Drawing.Point(309, 31);
            this.PostalCodetxt.Name = "PostalCodetxt";
            this.PostalCodetxt.Size = new System.Drawing.Size(100, 20);
            this.PostalCodetxt.TabIndex = 25;
            // 
            // Doctortxt
            // 
            this.Doctortxt.Location = new System.Drawing.Point(309, 187);
            this.Doctortxt.Name = "Doctortxt";
            this.Doctortxt.Size = new System.Drawing.Size(100, 20);
            this.Doctortxt.TabIndex = 20;
            // 
            // Provincetxt
            // 
            this.Provincetxt.Location = new System.Drawing.Point(101, 183);
            this.Provincetxt.Name = "Provincetxt";
            this.Provincetxt.Size = new System.Drawing.Size(100, 20);
            this.Provincetxt.TabIndex = 24;
            // 
            // NOKRelationshiptxt
            // 
            this.NOKRelationshiptxt.Location = new System.Drawing.Point(309, 161);
            this.NOKRelationshiptxt.Name = "NOKRelationshiptxt";
            this.NOKRelationshiptxt.Size = new System.Drawing.Size(100, 20);
            this.NOKRelationshiptxt.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(443, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "PatientID:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(232, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Doctor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(214, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "NOK Relationship:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Next Of Kin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(262, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Insurance Company:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Insurance Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Province:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Postal Code:";
            // 
            // AddPatientbtn
            // 
            this.AddPatientbtn.Location = new System.Drawing.Point(459, 79);
            this.AddPatientbtn.Name = "AddPatientbtn";
            this.AddPatientbtn.Size = new System.Drawing.Size(75, 23);
            this.AddPatientbtn.TabIndex = 18;
            this.AddPatientbtn.Text = "Add patient";
            this.AddPatientbtn.UseVisualStyleBackColor = true;
            this.AddPatientbtn.Click += new System.EventHandler(this.AddPatientbtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Health Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Date Of Birth:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabPage1.Controls.Add(this.AddAdmissionRecordbtn);
            this.tabPage1.Controls.Add(this.DischargeDatetxt);
            this.tabPage1.Controls.Add(this.AdmissionIDtxt);
            this.tabPage1.Controls.Add(this.APatientIDtxt);
            this.tabPage1.Controls.Add(this.BedNumbertxt);
            this.tabPage1.Controls.Add(this.SurgeryScheduledtxt);
            this.tabPage1.Controls.Add(this.AdmitDatetxt);
            this.tabPage1.Controls.Add(this.SurgeryDatetxt);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admissions";
            // 
            // AddAdmissionRecordbtn
            // 
            this.AddAdmissionRecordbtn.Location = new System.Drawing.Point(69, 143);
            this.AddAdmissionRecordbtn.Name = "AddAdmissionRecordbtn";
            this.AddAdmissionRecordbtn.Size = new System.Drawing.Size(135, 23);
            this.AddAdmissionRecordbtn.TabIndex = 14;
            this.AddAdmissionRecordbtn.Text = "Add Admission Record";
            this.AddAdmissionRecordbtn.UseVisualStyleBackColor = true;
            this.AddAdmissionRecordbtn.Click += new System.EventHandler(this.AddAdmissionRecordbtn_Click);
            // 
            // DischargeDatetxt
            // 
            this.DischargeDatetxt.Location = new System.Drawing.Point(291, 67);
            this.DischargeDatetxt.Name = "DischargeDatetxt";
            this.DischargeDatetxt.Size = new System.Drawing.Size(100, 20);
            this.DischargeDatetxt.TabIndex = 13;
            // 
            // AdmissionIDtxt
            // 
            this.AdmissionIDtxt.Location = new System.Drawing.Point(104, 22);
            this.AdmissionIDtxt.Name = "AdmissionIDtxt";
            this.AdmissionIDtxt.Size = new System.Drawing.Size(100, 20);
            this.AdmissionIDtxt.TabIndex = 12;
            // 
            // APatientIDtxt
            // 
            this.APatientIDtxt.Location = new System.Drawing.Point(104, 45);
            this.APatientIDtxt.Name = "APatientIDtxt";
            this.APatientIDtxt.Size = new System.Drawing.Size(100, 20);
            this.APatientIDtxt.TabIndex = 11;
            // 
            // BedNumbertxt
            // 
            this.BedNumbertxt.Location = new System.Drawing.Point(104, 68);
            this.BedNumbertxt.Name = "BedNumbertxt";
            this.BedNumbertxt.Size = new System.Drawing.Size(100, 20);
            this.BedNumbertxt.TabIndex = 10;
            // 
            // SurgeryScheduledtxt
            // 
            this.SurgeryScheduledtxt.Location = new System.Drawing.Point(104, 90);
            this.SurgeryScheduledtxt.Name = "SurgeryScheduledtxt";
            this.SurgeryScheduledtxt.Size = new System.Drawing.Size(100, 20);
            this.SurgeryScheduledtxt.TabIndex = 9;
            // 
            // AdmitDatetxt
            // 
            this.AdmitDatetxt.Location = new System.Drawing.Point(291, 17);
            this.AdmitDatetxt.Name = "AdmitDatetxt";
            this.AdmitDatetxt.Size = new System.Drawing.Size(100, 20);
            this.AdmitDatetxt.TabIndex = 8;
            // 
            // SurgeryDatetxt
            // 
            this.SurgeryDatetxt.Location = new System.Drawing.Point(291, 41);
            this.SurgeryDatetxt.Name = "SurgeryDatetxt";
            this.SurgeryDatetxt.Size = new System.Drawing.Size(100, 20);
            this.SurgeryDatetxt.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(210, 68);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "Discharge Date:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(32, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Bed Number:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(41, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Patient ID:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Surgery Scheduled:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(223, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Admit Date:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(221, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Surgery Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Admission ID:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 251);
            this.tabControl1.TabIndex = 38;
            // 
            // TVrbtn
            // 
            this.TVrbtn.AutoSize = true;
            this.TVrbtn.Location = new System.Drawing.Point(6, 11);
            this.TVrbtn.Name = "TVrbtn";
            this.TVrbtn.Size = new System.Drawing.Size(39, 17);
            this.TVrbtn.TabIndex = 29;
            this.TVrbtn.TabStop = true;
            this.TVrbtn.Text = "TV";
            this.TVrbtn.UseVisualStyleBackColor = true;
            // 
            // Phonerbtn
            // 
            this.Phonerbtn.AutoSize = true;
            this.Phonerbtn.Location = new System.Drawing.Point(6, 11);
            this.Phonerbtn.Name = "Phonerbtn";
            this.Phonerbtn.Size = new System.Drawing.Size(56, 17);
            this.Phonerbtn.TabIndex = 30;
            this.Phonerbtn.TabStop = true;
            this.Phonerbtn.Text = "Phone";
            this.Phonerbtn.UseVisualStyleBackColor = true;
            // 
            // SPrbtn
            // 
            this.SPrbtn.AutoSize = true;
            this.SPrbtn.Location = new System.Drawing.Point(6, 46);
            this.SPrbtn.Name = "SPrbtn";
            this.SPrbtn.Size = new System.Drawing.Size(84, 17);
            this.SPrbtn.TabIndex = 31;
            this.SPrbtn.TabStop = true;
            this.SPrbtn.Text = "Semi-Private";
            this.SPrbtn.UseVisualStyleBackColor = true;
            // 
            // Privaterbtn
            // 
            this.Privaterbtn.AutoSize = true;
            this.Privaterbtn.Location = new System.Drawing.Point(6, 65);
            this.Privaterbtn.Name = "Privaterbtn";
            this.Privaterbtn.Size = new System.Drawing.Size(58, 17);
            this.Privaterbtn.TabIndex = 32;
            this.Privaterbtn.TabStop = true;
            this.Privaterbtn.Text = "Private";
            this.Privaterbtn.UseVisualStyleBackColor = true;
            // 
            // Wardrbtn
            // 
            this.Wardrbtn.AutoSize = true;
            this.Wardrbtn.Location = new System.Drawing.Point(6, 23);
            this.Wardrbtn.Name = "Wardrbtn";
            this.Wardrbtn.Size = new System.Drawing.Size(51, 17);
            this.Wardrbtn.TabIndex = 33;
            this.Wardrbtn.TabStop = true;
            this.Wardrbtn.Text = "Ward";
            this.Wardrbtn.UseVisualStyleBackColor = true;
            // 
            // BedType
            // 
            this.BedType.Controls.Add(this.SPrbtn);
            this.BedType.Controls.Add(this.Wardrbtn);
            this.BedType.Controls.Add(this.Privaterbtn);
            this.BedType.Location = new System.Drawing.Point(242, 48);
            this.BedType.Name = "BedType";
            this.BedType.Size = new System.Drawing.Size(200, 100);
            this.BedType.TabIndex = 34;
            this.BedType.TabStop = false;
            this.BedType.Text = "Bed Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TVrbtn);
            this.groupBox1.Location = new System.Drawing.Point(240, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 36);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Phonerbtn);
            this.groupBox2.Location = new System.Drawing.Point(350, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 36);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // frmAdmissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(773, 596);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Closebtn);
            this.Name = "frmAdmissions";
            this.Text = "frmAdmissions";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.BedType.ResumeLayout(false);
            this.BedType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button findbtn;
        private System.Windows.Forms.TextBox FNtxt;
        private System.Windows.Forms.TextBox DateOfBirthtxt;
        private System.Windows.Forms.TextBox PatientIDtxt;
        private System.Windows.Forms.TextBox HealthNumbertxt;
        private System.Windows.Forms.TextBox LNtxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.TextBox Citytxt;
        private System.Windows.Forms.TextBox NextOfKintxt;
        private System.Windows.Forms.TextBox InsuranceNumbertxt;
        private System.Windows.Forms.TextBox InsuranceCompanytxt;
        private System.Windows.Forms.TextBox Phonetxt;
        private System.Windows.Forms.TextBox PostalCodetxt;
        private System.Windows.Forms.TextBox Doctortxt;
        private System.Windows.Forms.TextBox Provincetxt;
        private System.Windows.Forms.TextBox NOKRelationshiptxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddPatientbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button AddAdmissionRecordbtn;
        private System.Windows.Forms.TextBox DischargeDatetxt;
        private System.Windows.Forms.TextBox AdmissionIDtxt;
        private System.Windows.Forms.TextBox APatientIDtxt;
        private System.Windows.Forms.TextBox BedNumbertxt;
        private System.Windows.Forms.TextBox SurgeryScheduledtxt;
        private System.Windows.Forms.TextBox AdmitDatetxt;
        private System.Windows.Forms.TextBox SurgeryDatetxt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button AddExtrasbtn;
        private System.Windows.Forms.TextBox AdmissionRecordIDtxt;
        private System.Windows.Forms.TextBox EPatientIDtxt;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RadioButton Privaterbtn;
        private System.Windows.Forms.RadioButton SPrbtn;
        private System.Windows.Forms.RadioButton Phonerbtn;
        private System.Windows.Forms.RadioButton TVrbtn;
        private System.Windows.Forms.RadioButton Wardrbtn;
        private System.Windows.Forms.GroupBox BedType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}