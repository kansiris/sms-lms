using System; 
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace StudentManagementSystem
{
	/// <summary>
	/// Summary description for StudentDetails.
	/// </summary>
	public class StudentDetails : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox grpControls;
		public System.Windows.Forms.DataGrid grdStudent;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtSearchByRegNo;
		public System.Windows.Forms.TextBox txtSearchByName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tbpPersonel;
		private System.Windows.Forms.TabPage tbpAdmission;
		private System.Windows.Forms.TabPage tbpFamily;
		private System.Windows.Forms.TabPage tbpMarks;
		private System.Windows.Forms.GroupBox grpField;
		private System.Windows.Forms.TextBox txtHomepage;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtAddress;
		public System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage tbpPromotion;
		private System.Windows.Forms.TabPage tbpExtraCurricular;
		private System.Windows.Forms.TabPage tbpRemarks;
		private System.Windows.Forms.GroupBox grpAdmission;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox txtAdmittedBy;
		private System.Windows.Forms.TextBox txtPrevSchool;
		private System.Windows.Forms.TextBox txtReasonForLeaving;
		private System.Windows.Forms.TextBox txtPrevSchoolPhone;
		private System.Windows.Forms.TextBox txtPrevSchoolAddress;
		private System.Windows.Forms.TextBox txtRemarks;
		private System.Windows.Forms.TabPage tbpCurricular;
		private System.Windows.Forms.DateTimePicker dtAdmissionDate;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtFather;
		private System.Windows.Forms.Label label6;
		internal System.Windows.Forms.ComboBox cmbBatch;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox txtRegNo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMother;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtFatherOfficePhone;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtFatherCellPhone;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtMotherOfficePhone;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox txtMotherCellPhone;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox txtResPhone;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.TextBox txtResidenceAddress;
		private System.Windows.Forms.DateTimePicker dtBirthDate;
		private System.Windows.Forms.Button btnCancel;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StudentDetails()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpControls = new System.Windows.Forms.GroupBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grdStudent = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtSearchByRegNo = new System.Windows.Forms.TextBox();
			this.txtSearchByName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tbpPersonel = new System.Windows.Forms.TabPage();
			this.grpField = new System.Windows.Forms.GroupBox();
			this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
			this.txtHomepage = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbpFamily = new System.Windows.Forms.TabPage();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtFatherOfficePhone = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtFatherCellPhone = new System.Windows.Forms.TextBox();
			this.txtFather = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtMotherCellPhone = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtMotherOfficePhone = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.txtMother = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtResidenceAddress = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.txtResPhone = new System.Windows.Forms.TextBox();
			this.tbpAdmission = new System.Windows.Forms.TabPage();
			this.grpAdmission = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtAdmittedBy = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dtAdmissionDate = new System.Windows.Forms.DateTimePicker();
			this.label18 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.txtPrevSchool = new System.Windows.Forms.TextBox();
			this.txtPrevSchoolAddress = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtPrevSchoolPhone = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txtReasonForLeaving = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.tbpCurricular = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.txtRegNo = new System.Windows.Forms.TextBox();
			this.cmbBatch = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbpExtraCurricular = new System.Windows.Forms.TabPage();
			this.tbpPromotion = new System.Windows.Forms.TabPage();
			this.tbpMarks = new System.Windows.Forms.TabPage();
			this.tbpRemarks = new System.Windows.Forms.TabPage();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.grpControls.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdStudent)).BeginInit();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tbpPersonel.SuspendLayout();
			this.grpField.SuspendLayout();
			this.tbpFamily.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tbpAdmission.SuspendLayout();
			this.grpAdmission.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tbpCurricular.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.tbpRemarks.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpControls
			// 
			this.grpControls.Controls.Add(this.btnCancel);
			this.grpControls.Controls.Add(this.grdStudent);
			this.grpControls.Controls.Add(this.btnClose);
			this.grpControls.Controls.Add(this.btnSave);
			this.grpControls.Controls.Add(this.btnDelete);
			this.grpControls.Controls.Add(this.btnEdit);
			this.grpControls.Controls.Add(this.btnAdd);
			this.grpControls.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpControls.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpControls.Location = new System.Drawing.Point(0, 0);
			this.grpControls.Name = "grpControls";
			this.grpControls.Size = new System.Drawing.Size(800, 283);
			this.grpControls.TabIndex = 12;
			this.grpControls.TabStop = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(528, 16);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(78, 32);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cance&l";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// grdStudent
			// 
			this.grdStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.grdStudent.CaptionText = "Student Master";
			this.grdStudent.DataMember = "";
			this.grdStudent.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.grdStudent.Location = new System.Drawing.Point(8, 61);
			this.grdStudent.Name = "grdStudent";
			this.grdStudent.ReadOnly = true;
			this.grdStudent.Size = new System.Drawing.Size(784, 211);
			this.grdStudent.TabIndex = 5;
			this.grdStudent.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								   this.dataGridTableStyle1});
			this.grdStudent.CurrentCellChanged += new System.EventHandler(this.grdStudent_CurrentCellChanged);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.grdStudent;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn7,
																												  this.dataGridTextBoxColumn8,
																												  this.dataGridTextBoxColumn9});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "Student";
			this.dataGridTableStyle1.ReadOnly = true;
			// 
			// dataGridTextBoxColumn7
			// 
			this.dataGridTextBoxColumn7.Format = "";
			this.dataGridTextBoxColumn7.FormatInfo = null;
			this.dataGridTextBoxColumn7.MappingName = "Id";
			this.dataGridTextBoxColumn7.NullText = "";
			this.dataGridTextBoxColumn7.ReadOnly = true;
			this.dataGridTextBoxColumn7.Width = 0;
			// 
			// dataGridTextBoxColumn8
			// 
			this.dataGridTextBoxColumn8.Format = "";
			this.dataGridTextBoxColumn8.FormatInfo = null;
			this.dataGridTextBoxColumn8.HeaderText = "Register No:";
			this.dataGridTextBoxColumn8.MappingName = "RegNo";
			this.dataGridTextBoxColumn8.NullText = "";
			this.dataGridTextBoxColumn8.ReadOnly = true;
			this.dataGridTextBoxColumn8.Width = 75;
			// 
			// dataGridTextBoxColumn9
			// 
			this.dataGridTextBoxColumn9.Format = "";
			this.dataGridTextBoxColumn9.FormatInfo = null;
			this.dataGridTextBoxColumn9.HeaderText = "Name";
			this.dataGridTextBoxColumn9.MappingName = "StudentName";
			this.dataGridTextBoxColumn9.NullText = "";
			this.dataGridTextBoxColumn9.ReadOnly = true;
			this.dataGridTextBoxColumn9.Width = 250;
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(616, 16);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(78, 32);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "&Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(431, 16);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(78, 32);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "&Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(319, 16);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(78, 32);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(215, 16);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(78, 32);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "&Edit";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(103, 16);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(72, 32);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "&Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtSearchByRegNo);
			this.panel1.Controls.Add(this.txtSearchByName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 283);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 34);
			this.panel1.TabIndex = 14;
			// 
			// txtSearchByRegNo
			// 
			this.txtSearchByRegNo.Location = new System.Drawing.Point(434, 5);
			this.txtSearchByRegNo.Name = "txtSearchByRegNo";
			this.txtSearchByRegNo.Size = new System.Drawing.Size(144, 20);
			this.txtSearchByRegNo.TabIndex = 1;
			this.txtSearchByRegNo.Text = "";
			this.txtSearchByRegNo.TextChanged += new System.EventHandler(this.txtSearchByRegNo_TextChanged);
			// 
			// txtSearchByName
			// 
			this.txtSearchByName.Location = new System.Drawing.Point(106, 5);
			this.txtSearchByName.Name = "txtSearchByName";
			this.txtSearchByName.Size = new System.Drawing.Size(144, 20);
			this.txtSearchByName.TabIndex = 0;
			this.txtSearchByName.Text = "";
			this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Search By Name:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(330, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Search By Reg.No:";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tbpPersonel);
			this.tabControl1.Controls.Add(this.tbpFamily);
			this.tabControl1.Controls.Add(this.tbpAdmission);
			this.tabControl1.Controls.Add(this.tbpCurricular);
			this.tabControl1.Controls.Add(this.tbpExtraCurricular);
			this.tabControl1.Controls.Add(this.tbpPromotion);
			this.tabControl1.Controls.Add(this.tbpMarks);
			this.tabControl1.Controls.Add(this.tbpRemarks);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabControl1.Location = new System.Drawing.Point(0, 317);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 235);
			this.tabControl1.TabIndex = 15;
			// 
			// tbpPersonel
			// 
			this.tbpPersonel.Controls.Add(this.grpField);
			this.tbpPersonel.Location = new System.Drawing.Point(4, 22);
			this.tbpPersonel.Name = "tbpPersonel";
			this.tbpPersonel.Size = new System.Drawing.Size(792, 209);
			this.tbpPersonel.TabIndex = 0;
			this.tbpPersonel.Text = "Personal";
			// 
			// grpField
			// 
			this.grpField.BackColor = System.Drawing.Color.AliceBlue;
			this.grpField.Controls.Add(this.dtBirthDate);
			this.grpField.Controls.Add(this.txtHomepage);
			this.grpField.Controls.Add(this.label16);
			this.grpField.Controls.Add(this.txtEmail);
			this.grpField.Controls.Add(this.txtPhone);
			this.grpField.Controls.Add(this.label9);
			this.grpField.Controls.Add(this.label10);
			this.grpField.Controls.Add(this.label12);
			this.grpField.Controls.Add(this.txtAddress);
			this.grpField.Controls.Add(this.txtName);
			this.grpField.Controls.Add(this.label7);
			this.grpField.Controls.Add(this.label4);
			this.grpField.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpField.Location = new System.Drawing.Point(0, 0);
			this.grpField.Name = "grpField";
			this.grpField.Size = new System.Drawing.Size(792, 209);
			this.grpField.TabIndex = 14;
			this.grpField.TabStop = false;
			// 
			// dtBirthDate
			// 
			this.dtBirthDate.CustomFormat = "dd / MMM / yyyy";
			this.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtBirthDate.Location = new System.Drawing.Point(384, 24);
			this.dtBirthDate.Name = "dtBirthDate";
			this.dtBirthDate.ShowCheckBox = true;
			this.dtBirthDate.ShowUpDown = true;
			this.dtBirthDate.TabIndex = 26;
			// 
			// txtHomepage
			// 
			this.txtHomepage.BackColor = System.Drawing.Color.White;
			this.txtHomepage.Location = new System.Drawing.Point(384, 88);
			this.txtHomepage.Name = "txtHomepage";
			this.txtHomepage.Size = new System.Drawing.Size(192, 20);
			this.txtHomepage.TabIndex = 12;
			this.txtHomepage.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(304, 96);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(67, 23);
			this.label16.TabIndex = 25;
			this.label16.Text = "Home Page";
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.White;
			this.txtEmail.Location = new System.Drawing.Point(384, 56);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(192, 20);
			this.txtEmail.TabIndex = 9;
			this.txtEmail.Text = "";
			// 
			// txtPhone
			// 
			this.txtPhone.BackColor = System.Drawing.Color.White;
			this.txtPhone.Location = new System.Drawing.Point(72, 160);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(184, 20);
			this.txtPhone.TabIndex = 6;
			this.txtPhone.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(304, 64);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 16);
			this.label9.TabIndex = 17;
			this.label9.Text = "Email";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(304, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 16);
			this.label10.TabIndex = 16;
			this.label10.Text = "Date of birth";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(8, 160);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 23);
			this.label12.TabIndex = 14;
			this.label12.Text = "Phone";
			// 
			// txtAddress
			// 
			this.txtAddress.BackColor = System.Drawing.Color.White;
			this.txtAddress.Location = new System.Drawing.Point(72, 64);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(184, 80);
			this.txtAddress.TabIndex = 5;
			this.txtAddress.Text = "";
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.Color.White;
			this.txtName.Location = new System.Drawing.Point(72, 24);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(184, 20);
			this.txtName.TabIndex = 2;
			this.txtName.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 72);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 17);
			this.label7.TabIndex = 4;
			this.label7.Text = "Address";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Name";
			// 
			// tbpFamily
			// 
			this.tbpFamily.BackColor = System.Drawing.Color.AliceBlue;
			this.tbpFamily.Controls.Add(this.groupBox6);
			this.tbpFamily.Location = new System.Drawing.Point(4, 22);
			this.tbpFamily.Name = "tbpFamily";
			this.tbpFamily.Size = new System.Drawing.Size(792, 209);
			this.tbpFamily.TabIndex = 2;
			this.tbpFamily.Text = "Family";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.groupBox2);
			this.groupBox6.Controls.Add(this.groupBox1);
			this.groupBox6.Controls.Add(this.groupBox3);
			this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox6.Location = new System.Drawing.Point(0, 0);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(792, 209);
			this.groupBox6.TabIndex = 20;
			this.groupBox6.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtFatherOfficePhone);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.txtFatherCellPhone);
			this.groupBox2.Controls.Add(this.txtFather);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Location = new System.Drawing.Point(8, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(264, 136);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Father";
			// 
			// txtFatherOfficePhone
			// 
			this.txtFatherOfficePhone.BackColor = System.Drawing.Color.White;
			this.txtFatherOfficePhone.Location = new System.Drawing.Point(80, 64);
			this.txtFatherOfficePhone.Name = "txtFatherOfficePhone";
			this.txtFatherOfficePhone.Size = new System.Drawing.Size(166, 20);
			this.txtFatherOfficePhone.TabIndex = 10;
			this.txtFatherOfficePhone.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Name";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(8, 96);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(64, 16);
			this.label15.TabIndex = 11;
			this.label15.Text = "Cell Phone";
			// 
			// txtFatherCellPhone
			// 
			this.txtFatherCellPhone.BackColor = System.Drawing.Color.White;
			this.txtFatherCellPhone.Location = new System.Drawing.Point(80, 96);
			this.txtFatherCellPhone.Name = "txtFatherCellPhone";
			this.txtFatherCellPhone.Size = new System.Drawing.Size(166, 20);
			this.txtFatherCellPhone.TabIndex = 12;
			this.txtFatherCellPhone.Text = "";
			// 
			// txtFather
			// 
			this.txtFather.BackColor = System.Drawing.Color.White;
			this.txtFather.Location = new System.Drawing.Point(80, 32);
			this.txtFather.Name = "txtFather";
			this.txtFather.Size = new System.Drawing.Size(166, 20);
			this.txtFather.TabIndex = 6;
			this.txtFather.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(8, 64);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 16);
			this.label13.TabIndex = 9;
			this.label13.Text = "Off Phone";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtMotherCellPhone);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.txtMotherOfficePhone);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.txtMother);
			this.groupBox1.Location = new System.Drawing.Point(280, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 136);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Name";
			// 
			// txtMotherCellPhone
			// 
			this.txtMotherCellPhone.BackColor = System.Drawing.Color.White;
			this.txtMotherCellPhone.Location = new System.Drawing.Point(88, 88);
			this.txtMotherCellPhone.Name = "txtMotherCellPhone";
			this.txtMotherCellPhone.Size = new System.Drawing.Size(166, 20);
			this.txtMotherCellPhone.TabIndex = 16;
			this.txtMotherCellPhone.Text = "";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(16, 56);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(56, 16);
			this.label23.TabIndex = 13;
			this.label23.Text = "Off Phone";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(16, 24);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(64, 23);
			this.label11.TabIndex = 7;
			this.label11.Text = "Name";
			// 
			// txtMotherOfficePhone
			// 
			this.txtMotherOfficePhone.BackColor = System.Drawing.Color.White;
			this.txtMotherOfficePhone.Location = new System.Drawing.Point(88, 56);
			this.txtMotherOfficePhone.Name = "txtMotherOfficePhone";
			this.txtMotherOfficePhone.Size = new System.Drawing.Size(166, 20);
			this.txtMotherOfficePhone.TabIndex = 14;
			this.txtMotherOfficePhone.Text = "";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(16, 88);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(72, 16);
			this.label24.TabIndex = 15;
			this.label24.Text = "Cell Phone";
			// 
			// txtMother
			// 
			this.txtMother.BackColor = System.Drawing.Color.White;
			this.txtMother.Location = new System.Drawing.Point(88, 24);
			this.txtMother.Name = "txtMother";
			this.txtMother.Size = new System.Drawing.Size(166, 20);
			this.txtMother.TabIndex = 8;
			this.txtMother.Text = "";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtResidenceAddress);
			this.groupBox3.Controls.Add(this.label26);
			this.groupBox3.Controls.Add(this.label25);
			this.groupBox3.Controls.Add(this.txtResPhone);
			this.groupBox3.Location = new System.Drawing.Point(560, 16);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(296, 136);
			this.groupBox3.TabIndex = 19;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Residence";
			// 
			// txtResidenceAddress
			// 
			this.txtResidenceAddress.BackColor = System.Drawing.Color.White;
			this.txtResidenceAddress.Location = new System.Drawing.Point(80, 48);
			this.txtResidenceAddress.Multiline = true;
			this.txtResidenceAddress.Name = "txtResidenceAddress";
			this.txtResidenceAddress.Size = new System.Drawing.Size(184, 80);
			this.txtResidenceAddress.TabIndex = 18;
			this.txtResidenceAddress.Text = "";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(8, 48);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(64, 17);
			this.label26.TabIndex = 17;
			this.label26.Text = "Address";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(8, 24);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(64, 16);
			this.label25.TabIndex = 15;
			this.label25.Text = "Res Phone";
			// 
			// txtResPhone
			// 
			this.txtResPhone.BackColor = System.Drawing.Color.White;
			this.txtResPhone.Location = new System.Drawing.Point(80, 24);
			this.txtResPhone.Name = "txtResPhone";
			this.txtResPhone.Size = new System.Drawing.Size(166, 20);
			this.txtResPhone.TabIndex = 16;
			this.txtResPhone.Text = "";
			// 
			// tbpAdmission
			// 
			this.tbpAdmission.Controls.Add(this.grpAdmission);
			this.tbpAdmission.Location = new System.Drawing.Point(4, 22);
			this.tbpAdmission.Name = "tbpAdmission";
			this.tbpAdmission.Size = new System.Drawing.Size(792, 209);
			this.tbpAdmission.TabIndex = 1;
			this.tbpAdmission.Text = "Admission";
			// 
			// grpAdmission
			// 
			this.grpAdmission.BackColor = System.Drawing.Color.AliceBlue;
			this.grpAdmission.Controls.Add(this.groupBox5);
			this.grpAdmission.Controls.Add(this.groupBox4);
			this.grpAdmission.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpAdmission.Location = new System.Drawing.Point(0, 0);
			this.grpAdmission.Name = "grpAdmission";
			this.grpAdmission.Size = new System.Drawing.Size(792, 209);
			this.grpAdmission.TabIndex = 0;
			this.grpAdmission.TabStop = false;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txtAdmittedBy);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.dtAdmissionDate);
			this.groupBox5.Controls.Add(this.label18);
			this.groupBox5.Location = new System.Drawing.Point(8, 16);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(248, 176);
			this.groupBox5.TabIndex = 29;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Admission";
			// 
			// txtAdmittedBy
			// 
			this.txtAdmittedBy.BackColor = System.Drawing.Color.White;
			this.txtAdmittedBy.Location = new System.Drawing.Point(96, 64);
			this.txtAdmittedBy.Name = "txtAdmittedBy";
			this.txtAdmittedBy.Size = new System.Drawing.Size(136, 20);
			this.txtAdmittedBy.TabIndex = 4;
			this.txtAdmittedBy.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 26);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 17);
			this.label8.TabIndex = 27;
			this.label8.Text = "Admn: Date";
			// 
			// dtAdmissionDate
			// 
			this.dtAdmissionDate.CalendarMonthBackground = System.Drawing.Color.White;
			this.dtAdmissionDate.CalendarTitleBackColor = System.Drawing.Color.White;
			this.dtAdmissionDate.CalendarTitleForeColor = System.Drawing.Color.Black;
			this.dtAdmissionDate.CalendarTrailingForeColor = System.Drawing.Color.Black;
			this.dtAdmissionDate.CustomFormat = "dd / MMM / yyyy";
			this.dtAdmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtAdmissionDate.Location = new System.Drawing.Point(96, 24);
			this.dtAdmissionDate.Name = "dtAdmissionDate";
			this.dtAdmissionDate.ShowCheckBox = true;
			this.dtAdmissionDate.ShowUpDown = true;
			this.dtAdmissionDate.Size = new System.Drawing.Size(136, 20);
			this.dtAdmissionDate.TabIndex = 25;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(8, 63);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(72, 23);
			this.label18.TabIndex = 1;
			this.label18.Text = "Admitted By";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label19);
			this.groupBox4.Controls.Add(this.txtPrevSchool);
			this.groupBox4.Controls.Add(this.txtPrevSchoolAddress);
			this.groupBox4.Controls.Add(this.label22);
			this.groupBox4.Controls.Add(this.txtPrevSchoolPhone);
			this.groupBox4.Controls.Add(this.label21);
			this.groupBox4.Controls.Add(this.txtReasonForLeaving);
			this.groupBox4.Controls.Add(this.label20);
			this.groupBox4.Location = new System.Drawing.Point(264, 16);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(544, 176);
			this.groupBox4.TabIndex = 28;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Previous Institute";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(16, 24);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(56, 16);
			this.label19.TabIndex = 2;
			this.label19.Text = "Name";
			// 
			// txtPrevSchool
			// 
			this.txtPrevSchool.BackColor = System.Drawing.Color.White;
			this.txtPrevSchool.Location = new System.Drawing.Point(80, 24);
			this.txtPrevSchool.Name = "txtPrevSchool";
			this.txtPrevSchool.Size = new System.Drawing.Size(200, 20);
			this.txtPrevSchool.TabIndex = 5;
			this.txtPrevSchool.Text = "";
			// 
			// txtPrevSchoolAddress
			// 
			this.txtPrevSchoolAddress.BackColor = System.Drawing.Color.White;
			this.txtPrevSchoolAddress.Location = new System.Drawing.Point(80, 48);
			this.txtPrevSchoolAddress.Multiline = true;
			this.txtPrevSchoolAddress.Name = "txtPrevSchoolAddress";
			this.txtPrevSchoolAddress.Size = new System.Drawing.Size(200, 48);
			this.txtPrevSchoolAddress.TabIndex = 9;
			this.txtPrevSchoolAddress.Text = "";
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(16, 48);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(48, 24);
			this.label22.TabIndex = 6;
			this.label22.Text = "Address";
			// 
			// txtPrevSchoolPhone
			// 
			this.txtPrevSchoolPhone.BackColor = System.Drawing.Color.White;
			this.txtPrevSchoolPhone.Location = new System.Drawing.Point(80, 104);
			this.txtPrevSchoolPhone.Name = "txtPrevSchoolPhone";
			this.txtPrevSchoolPhone.Size = new System.Drawing.Size(136, 20);
			this.txtPrevSchoolPhone.TabIndex = 10;
			this.txtPrevSchoolPhone.Text = "";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(16, 104);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(48, 16);
			this.label21.TabIndex = 7;
			this.label21.Text = "Phone";
			// 
			// txtReasonForLeaving
			// 
			this.txtReasonForLeaving.BackColor = System.Drawing.Color.White;
			this.txtReasonForLeaving.Location = new System.Drawing.Point(296, 32);
			this.txtReasonForLeaving.Multiline = true;
			this.txtReasonForLeaving.Name = "txtReasonForLeaving";
			this.txtReasonForLeaving.Size = new System.Drawing.Size(240, 88);
			this.txtReasonForLeaving.TabIndex = 11;
			this.txtReasonForLeaving.Text = "";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(296, 16);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(176, 16);
			this.label20.TabIndex = 8;
			this.label20.Text = "Reason For Leaving";
			// 
			// tbpCurricular
			// 
			this.tbpCurricular.BackColor = System.Drawing.Color.AliceBlue;
			this.tbpCurricular.Controls.Add(this.groupBox7);
			this.tbpCurricular.Location = new System.Drawing.Point(4, 22);
			this.tbpCurricular.Name = "tbpCurricular";
			this.tbpCurricular.Size = new System.Drawing.Size(792, 209);
			this.tbpCurricular.TabIndex = 7;
			this.tbpCurricular.Text = "Academic";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.txtRegNo);
			this.groupBox7.Controls.Add(this.cmbBatch);
			this.groupBox7.Controls.Add(this.label5);
			this.groupBox7.Controls.Add(this.label3);
			this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox7.Location = new System.Drawing.Point(0, 0);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(792, 209);
			this.groupBox7.TabIndex = 8;
			this.groupBox7.TabStop = false;
			// 
			// txtRegNo
			// 
			this.txtRegNo.BackColor = System.Drawing.Color.White;
			this.txtRegNo.Location = new System.Drawing.Point(104, 24);
			this.txtRegNo.Name = "txtRegNo";
			this.txtRegNo.Size = new System.Drawing.Size(96, 20);
			this.txtRegNo.TabIndex = 7;
			this.txtRegNo.Text = "";
			// 
			// cmbBatch
			// 
			this.cmbBatch.BackColor = System.Drawing.Color.White;
			this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBatch.Location = new System.Drawing.Point(104, 56);
			this.cmbBatch.Name = "cmbBatch";
			this.cmbBatch.Size = new System.Drawing.Size(144, 21);
			this.cmbBatch.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(24, 56);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "Batch";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 24);
			this.label3.Name = "label3";
			this.label3.TabIndex = 6;
			this.label3.Text = "Register No:";
			// 
			// tbpExtraCurricular
			// 
			this.tbpExtraCurricular.BackColor = System.Drawing.Color.AliceBlue;
			this.tbpExtraCurricular.Location = new System.Drawing.Point(4, 22);
			this.tbpExtraCurricular.Name = "tbpExtraCurricular";
			this.tbpExtraCurricular.Size = new System.Drawing.Size(792, 209);
			this.tbpExtraCurricular.TabIndex = 5;
			this.tbpExtraCurricular.Text = "ExtraCurricular";
			// 
			// tbpPromotion
			// 
			this.tbpPromotion.BackColor = System.Drawing.Color.AliceBlue;
			this.tbpPromotion.Location = new System.Drawing.Point(4, 22);
			this.tbpPromotion.Name = "tbpPromotion";
			this.tbpPromotion.Size = new System.Drawing.Size(792, 209);
			this.tbpPromotion.TabIndex = 4;
			this.tbpPromotion.Text = "Promotions";
			// 
			// tbpMarks
			// 
			this.tbpMarks.BackColor = System.Drawing.Color.AliceBlue;
			this.tbpMarks.Location = new System.Drawing.Point(4, 22);
			this.tbpMarks.Name = "tbpMarks";
			this.tbpMarks.Size = new System.Drawing.Size(792, 209);
			this.tbpMarks.TabIndex = 3;
			this.tbpMarks.Text = "Marks";
			// 
			// tbpRemarks
			// 
			this.tbpRemarks.Controls.Add(this.txtRemarks);
			this.tbpRemarks.Location = new System.Drawing.Point(4, 22);
			this.tbpRemarks.Name = "tbpRemarks";
			this.tbpRemarks.Size = new System.Drawing.Size(792, 209);
			this.tbpRemarks.TabIndex = 6;
			this.tbpRemarks.Text = "Remarks";
			// 
			// txtRemarks
			// 
			this.txtRemarks.BackColor = System.Drawing.Color.White;
			this.txtRemarks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtRemarks.Location = new System.Drawing.Point(0, 0);
			this.txtRemarks.Multiline = true;
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.Size = new System.Drawing.Size(792, 209);
			this.txtRemarks.TabIndex = 27;
			this.txtRemarks.Text = "";
			// 
			// StudentDetails
			// 
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.Controls.Add(this.grpControls);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabControl1);
			this.Name = "StudentDetails";
			this.Size = new System.Drawing.Size(800, 552);
			this.Load += new System.EventHandler(this.StudentDetails_Load);
			this.grpControls.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdStudent)).EndInit();
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tbpPersonel.ResumeLayout(false);
			this.grpField.ResumeLayout(false);
			this.tbpFamily.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.tbpAdmission.ResumeLayout(false);
			this.grpAdmission.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tbpCurricular.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.tbpRemarks.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private DataTable studentTable;
		public string pageAction;
		public string deleted;
		public string reLoad;
					
		private void StudentDetails_Load(object sender, System.EventArgs e)
		{
			// Load records into the grid.
			LoadGrid();

			// make sure all fields (like text boxes etc) are read only.
			EnableFields( false );

			// Enabel / Disable appropriate buttons.
			SetEditState( false );

			String connectionString = System.Configuration.ConfigurationSettings.AppSettings["dsn"];
			util.PopulateCombo( cmbBatch, connectionString, "Batch", "BatchName", "BatchId", "1" );

			LoadCurrentItem();

			
////			DisableFields();
////			LoadCurrentItem();
////
////
////			txtSearchByName.Focus();		
////			btnSave.Enabled=false;
////			deleted="false";			
		}

		private void EnableFields( bool enable )
		{
			bool readOnly = !enable;

			txtHomepage.ReadOnly = readOnly;
			txtEmail.ReadOnly = readOnly;
			txtPhone.ReadOnly = readOnly;
			txtAddress.ReadOnly = readOnly;
			txtName.ReadOnly = readOnly;
			txtAdmittedBy.ReadOnly = readOnly;
			txtPrevSchool.ReadOnly = readOnly;
			txtReasonForLeaving.ReadOnly = readOnly;
			txtPrevSchoolPhone.ReadOnly = readOnly;
			txtPrevSchoolAddress.ReadOnly = readOnly;
			txtRemarks.ReadOnly = readOnly;
			txtFather.ReadOnly = readOnly;			
			txtRegNo.ReadOnly = readOnly;			
			txtMother.ReadOnly = readOnly;
			txtFatherOfficePhone.ReadOnly = readOnly;
			txtFatherCellPhone.ReadOnly = readOnly;
			txtMotherOfficePhone.ReadOnly = readOnly;
			txtMotherCellPhone.ReadOnly = readOnly;
			txtResPhone.ReadOnly = readOnly;
			txtResidenceAddress.ReadOnly = readOnly;

			cmbBatch.Enabled  = enable;
			dtBirthDate.Enabled = enable;
			dtAdmissionDate.Enabled = enable;

			txtSearchByRegNo.ReadOnly = enable;
			txtSearchByName.ReadOnly = enable;
		}

		private void SetEditState ( bool edit )
		{
			// When a record is selected for edit, disable the Add, Edit & Close buttons.
			btnAdd.Enabled = !edit;
			btnEdit.Enabled = !edit;			
			btnClose.Enabled = !edit;
			btnDelete.Enabled = !edit;

			// When we are editing, do not allow to navigate in the grid.
			grdStudent.Enabled = !edit;

			// When we are editing, only Cancel and Save buttons are enabled.
			btnCancel.Enabled = edit;
			btnSave.Enabled = edit;
		}

		private void LoadCurrentItem()
		{
			if ( grdStudent.CurrentRowIndex == -1 )		// Is there any row selected now?
				return;

			// The first column of the grid contains the id field. Since the width of the 
			// field is set to zero, the column is not visible in the grid. But we
			// can still access the value in it.

			// Retrieve the first column from the selected row.
			int Id = int.Parse ( grdStudent[grdStudent.CurrentRowIndex, 0].ToString() );

			Student student = StudentManager.GetStudent( Id );
			if ( student == null )
			{
				MessageBox.Show ( "Couldn't retrieve the object for the selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return;
			}

			txtHomepage.Text = student.Homepage;
			txtEmail.Text = student.Email;
			txtPhone.Text = student.Phone;
			txtAddress.Text = student.StudentAddress;
			txtName.Text = student.StudentName;
			txtAdmittedBy.Text = student.AdmittedBy;
			txtPrevSchool.Text = student.PrevSchoolName;
			txtReasonForLeaving.Text = student.ReasonForLeaving;
			txtPrevSchoolPhone.Text = student.PrevSchoolPhone;
			txtPrevSchoolAddress.Text = student.PrevSchoolAddress;
			txtRemarks.Text = student.Remarks;
			txtFather.Text = student.FatherName;
			txtRegNo.Text = student.RegNo;
			txtMother.Text = student.MotherName;
			txtFatherOfficePhone.Text = student.FatherOfficePhone; 
			txtFatherCellPhone.Text = student.FatherCellPhone;
			txtMotherOfficePhone.Text = student.MotherResPhone;
			txtMotherCellPhone.Text = student.MotherCellPhone;
			txtResPhone.Text = student.ResidencePhone;
			txtResidenceAddress.Text = student.ResidenceAddress;

			cmbBatch.SelectedValue = student.BatchId;
			
			dtAdmissionDate.Value = student.AdmissionDate;
			dtAdmissionDate.Checked = student.AdmissionDateSelected;
			
			dtBirthDate.Value = student.DateOfBirth;
			dtBirthDate.Checked = student.DateOfBirthSelected;
		}

		private void ClearFields()
		{
			txtHomepage.Text = String.Empty;
			txtEmail.Text = String.Empty;
			txtPhone.Text = String.Empty;
			txtAddress.Text = String.Empty;
			txtName.Text = String.Empty;
			txtAdmittedBy.Text = String.Empty;
			txtPrevSchool.Text = String.Empty;
			txtReasonForLeaving.Text = String.Empty;
			txtPrevSchoolPhone.Text = String.Empty;
			txtPrevSchoolAddress.Text = String.Empty;
			txtRemarks.Text = String.Empty;
			txtFather.Text = String.Empty;
			txtRegNo.Text = String.Empty;
			txtMother.Text = String.Empty;
			txtFatherOfficePhone.Text = String.Empty;
			txtFatherCellPhone.Text = String.Empty;
			txtMotherOfficePhone.Text = String.Empty;
			txtMotherCellPhone.Text = String.Empty;
			txtResPhone.Text = String.Empty;
			txtResidenceAddress.Text = String.Empty;

			cmbBatch.SelectedIndex = 0;
			dtAdmissionDate.Value = DateTime.Today;
			dtAdmissionDate.Checked = false;
			dtBirthDate.Value = DateTime.Today;
			dtBirthDate.Checked = false;
		}
		//   Can be used to Search 2 diff text field values.
		private void LoadGrid()
		{
			string criteria  = "StudentName like '%" + txtSearchByName.Text + "%' AND RegNo like '%" + txtSearchByRegNo.Text + "%' AND Status <> " + (Int16)eStatus.Deleted;
			studentTable = StudentManager.GetStudents( criteria );
			grdStudent.DataSource = studentTable;
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Visible = false;			
		}

		private void txtSearchByName_TextChanged(object sender, System.EventArgs e)
		{
			LoadGrid();
		}

		private void txtSearchByRegNo_TextChanged(object sender, System.EventArgs e)
		{
			LoadGrid();
		}

		private void grdStudent_CurrentCellChanged(object sender, System.EventArgs e)
		{
			grdStudent.Select ( grdStudent.CurrentRowIndex );
			LoadCurrentItem();
			EnableFields( false );
			SetEditState( false );
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			pageAction= "EDIT";

			LoadCurrentItem();
			EnableFields( true );
			SetEditState( true );
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			pageAction= "ADD";

			ClearFields();
			EnableFields( true );
			SetEditState( true );		
		}

		private void btnSave_Click(object sender, System.EventArgs e)
		{
			if ( txtName.Text.Trim() == String.Empty )
			{
				MessageBox.Show ( "Please enter the student name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				txtName.Focus();
				return;
			}
			
			if ( txtRegNo.Text == String.Empty )
			{
				MessageBox.Show ( "Please enter the Register Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				txtRegNo.Focus();
				return;
			}
			
			Student student;

			if ( pageAction== "ADD" )
			{
				// We are creating a new student.

				// Make sure the RegNo is not duplicated.
				DataTable table = StudentManager.GetStudents( "RegNo='" + txtRegNo.Text + "'" );
				if ( table.Rows.Count != 0 )
				{                                                             
					MessageBox.Show("Register Number already exists. Please choose a different number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning );
					return;
				}

				student = new Student();
				int id = IdManager.GetNextID( "Student", "Id" );
				student.Id = id;

				student.Status = (int)eStatus.New;
			}
			else
			{
				// We are editing an existing student.
				int id = int.Parse ( grdStudent[grdStudent.CurrentRowIndex, 0].ToString() );
				student = StudentManager.GetStudent( id );
			}

			student.Homepage = txtHomepage.Text;
			student.Email = txtEmail.Text;
			student.Phone = txtPhone.Text;
			student.StudentAddress = txtAddress.Text;
			student.StudentName = txtName.Text;
			student.AdmittedBy = txtAdmittedBy.Text;
			student.PrevSchoolName = txtPrevSchool.Text;
			student.ReasonForLeaving = txtReasonForLeaving.Text;
			student.PrevSchoolPhone = txtPrevSchoolPhone.Text;
			student.PrevSchoolAddress = txtPrevSchoolAddress.Text;
			student.Remarks = txtRemarks.Text;
			student.FatherName = txtFather.Text;
			student.RegNo = txtRegNo.Text;
			student.MotherName = txtMother.Text;
			student.FatherOfficePhone = txtFatherOfficePhone.Text;
			student.FatherCellPhone = txtFatherCellPhone.Text;
			student.MotherResPhone = txtMotherOfficePhone.Text;
			student.MotherCellPhone = txtMotherCellPhone.Text;
			student.ResidencePhone = txtResPhone.Text;
			student.ResidenceAddress = txtResidenceAddress.Text;

			student.BatchId = (int)cmbBatch.SelectedValue;

			student.LastModifiedTime = DateTime.Now;

			student.AdmissionDateSelected = dtAdmissionDate.Checked;
			student.AdmissionDate = dtAdmissionDate.Value;

			student.DateOfBirthSelected = dtBirthDate.Checked;
			student.DateOfBirth = dtBirthDate.Value;

			if ( pageAction== "ADD" )
			{
                int id = IdManager.GetNextID( "Student", "Id" );
				student.Id = id;
				StudentManager.CreateStudent( student );
			}
			else
			{
				StudentManager.UpdateStudent( student );
			}

			MessageBox.Show( "Saved successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information );
			
			// Make sure all fields (like text boxes etc) are read only.
			EnableFields( false );

			// Enable / Disable appropriate buttons.
			SetEditState( false );

			LoadGrid();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			LoadCurrentItem();

			// Make sure all fields (like text boxes etc) are read only.
			EnableFields( false );

			// Enable / Disable appropriate buttons.
			SetEditState( false );
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			// Ask the user to confirm whether he really want to delete.
			DialogResult result = MessageBox.Show( "Are you sure to delete the selected item ?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2 );
			if ( result == DialogResult.Yes )
			{
				// user selected 'Yes' in the confirmation dialog.

				// We are not permanently deleting any record... just changing the status field to 'Deleted'.

				int id = int.Parse ( grdStudent[grdStudent.CurrentRowIndex, 0].ToString() );
				Student student = StudentManager.GetStudent( id );
				student.Status = (int)eStatus.Deleted;			// Change status
				StudentManager.UpdateStudent( student );	// Update record.
			}

			LoadGrid();
			EnableFields( false );
			SetEditState( false );
		}
	}
}
