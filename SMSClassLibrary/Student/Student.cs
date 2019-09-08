using System;
using System.Data;
using System.Data.OleDb;

public class Student
{
	// Public Attributes
	public Int32 Id;
	public String RegNo;
	public Int32 BatchId;
	public String StudentName;
	public String StudentAddress;
	public String Phone;
	public Boolean DateOfBirthSelected;
	public DateTime DateOfBirth;
	public String Email;
	public String Homepage;
	public String FatherName;
	public String FatherCellPhone;
	public String FatherOfficePhone;
	public String MotherName;
	public String MotherCellPhone;
	public String MotherResPhone;
	public String ResidencePhone;
	public String ResidenceAddress;
	public Boolean AdmissionDateSelected;
	public DateTime AdmissionDate;
	public String AdmittedBy;
	public String PrevSchoolName;
	public String PrevSchoolPhone;
	public String PrevSchoolAddress;
	public String ReasonForLeaving;
	public String Remarks;
	public Int32 Status;
	public DateTime LastModifiedTime;


	// Default constructor
	public Student()
	{
	}

	// Constructor
	public Student( DataRow dr )
	{
		if ( dr["Id"] != DBNull.Value )
		{
			this.Id = Int16.Parse(dr["Id"].ToString());
		}

		if ( dr["RegNo"] != DBNull.Value )
		{
			this.RegNo = dr["RegNo"].ToString();
		}

		if ( dr["BatchId"] != DBNull.Value )
		{
			this.BatchId = Int32.Parse(dr["BatchId"].ToString());
		}

		if ( dr["StudentName"] != DBNull.Value )
		{
			this.StudentName = dr["StudentName"].ToString();
		}

		if ( dr["StudentAddress"] != DBNull.Value )
		{
			this.StudentAddress = dr["StudentAddress"].ToString();
		}

		if ( dr["Phone"] != DBNull.Value )
		{
			this.Phone = dr["Phone"].ToString();
		}

		if ( dr["DateOfBirthSelected"] != DBNull.Value )
		{
			this.DateOfBirthSelected = Boolean.Parse(dr["DateOfBirthSelected"].ToString());
		}

		if ( dr["DateOfBirth"] != DBNull.Value )
		{
			this.DateOfBirth = DateTime.Parse(dr["DateOfBirth"].ToString());
		}

		if ( dr["Email"] != DBNull.Value )
		{
			this.Email = dr["Email"].ToString();
		}

		if ( dr["Homepage"] != DBNull.Value )
		{
			this.Homepage = dr["Homepage"].ToString();
		}

		if ( dr["FatherName"] != DBNull.Value )
		{
			this.FatherName = dr["FatherName"].ToString();
		}

		if ( dr["FatherCellPhone"] != DBNull.Value )
		{
			this.FatherCellPhone = dr["FatherCellPhone"].ToString();
		}

		if ( dr["FatherOfficePhone"] != DBNull.Value )
		{
			this.FatherOfficePhone = dr["FatherOfficePhone"].ToString();
		}

		if ( dr["MotherName"] != DBNull.Value )
		{
			this.MotherName = dr["MotherName"].ToString();
		}

		if ( dr["MotherCellPhone"] != DBNull.Value )
		{
			this.MotherCellPhone = dr["MotherCellPhone"].ToString();
		}

		if ( dr["MotherResPhone"] != DBNull.Value )
		{
			this.MotherResPhone = dr["MotherResPhone"].ToString();
		}

		if ( dr["ResidencePhone"] != DBNull.Value )
		{
			this.ResidencePhone = dr["ResidencePhone"].ToString();
		}

		if ( dr["ResidenceAddress"] != DBNull.Value )
		{
			this.ResidenceAddress = dr["ResidenceAddress"].ToString();
		}

		if ( dr["AdmissionDateSelected"] != DBNull.Value )
		{
			this.AdmissionDateSelected = Boolean.Parse(dr["AdmissionDateSelected"].ToString());
		}

		if ( dr["AdmissionDate"] != DBNull.Value )
		{
			this.AdmissionDate = DateTime.Parse(dr["AdmissionDate"].ToString());
		}

		if ( dr["AdmittedBy"] != DBNull.Value )
		{
			this.AdmittedBy = dr["AdmittedBy"].ToString();
		}

		if ( dr["PrevSchoolName"] != DBNull.Value )
		{
			this.PrevSchoolName = dr["PrevSchoolName"].ToString();
		}

		if ( dr["PrevSchoolPhone"] != DBNull.Value )
		{
			this.PrevSchoolPhone = dr["PrevSchoolPhone"].ToString();
		}

		if ( dr["PrevSchoolAddress"] != DBNull.Value )
		{
			this.PrevSchoolAddress = dr["PrevSchoolAddress"].ToString();
		}

		if ( dr["ReasonForLeaving"] != DBNull.Value )
		{
			this.ReasonForLeaving = dr["ReasonForLeaving"].ToString();
		}

		if ( dr["Remarks"] != DBNull.Value )
		{
			this.Remarks = dr["Remarks"].ToString();
		}

		if ( dr["Status"] != DBNull.Value )
		{
			this.Status = Int32.Parse(dr["Status"].ToString());
		}

		if ( dr["LastModifiedTime"] != DBNull.Value )
		{
			this.LastModifiedTime = DateTime.Parse(dr["LastModifiedTime"].ToString());
		}

	}
} 

