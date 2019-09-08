using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace StudentManagementSystem
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnStudent;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel MainPanel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnStudent = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.MainPanel = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnStudent);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(96, 585);
			this.panel1.TabIndex = 1;
			// 
			// btnStudent
			// 
			this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnStudent.Location = new System.Drawing.Point(8, 16);
			this.btnStudent.Name = "btnStudent";
			this.btnStudent.TabIndex = 1;
			this.btnStudent.Text = "&Student";
			this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click_1);
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Location = new System.Drawing.Point(8, 544);
			this.btnClose.Name = "btnClose";
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "C&lose";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.AliceBlue;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(96, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(708, 48);
			this.label1.TabIndex = 2;
			this.label1.Text = "Student Managment System";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainPanel
			// 
			this.MainPanel.BackColor = System.Drawing.Color.AliceBlue;
			this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.ForeColor = System.Drawing.Color.Black;
			this.MainPanel.Location = new System.Drawing.Point(96, 48);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(708, 537);
			this.MainPanel.TabIndex = 3;
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(804, 585);
			this.Controls.Add(this.MainPanel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "frmMain";
			this.Text = "StudentManagementSystem";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		private void frmMain_Load(object sender, System.EventArgs e)
		{
			StudentDetails frm= new StudentDetails();
			frm.Visible= true;
			frm.Dock=DockStyle.Fill;
			MainPanel.Controls.Clear();
			MainPanel.Controls.Add(frm);
		}

		private void btnStudent_Click_1(object sender, System.EventArgs e)
		{	
			StudentDetails frm = new StudentDetails();
			frm.Visible = true;
			frm.Dock = DockStyle.Fill;
			MainPanel.Controls.Clear();
			MainPanel.Controls.Add(frm);		
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
