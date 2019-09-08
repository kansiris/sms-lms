using System;
using System.Data;
using System.Data.OleDb;

public class StudentManager
{
	public static void DeleteStudent( System.Int32 Id )
	{
		String ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["DSN"]; 
		OleDbConnection myConnection = new OleDbConnection(ConnectionString);
		String query = "delete from Student where Id = " + Id;
		DataManager.ExecuteNonQuery(ConnectionString, query);
	}

	public static void CreateStudent( Student StudentObj )
	{
		String ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["DSN"]; 
		String query = "insert into STUDENT ( Id, RegNo, BatchId, StudentName, StudentAddress, Phone, DateOfBirthSelected, DateOfBirth, Email, Homepage, FatherName, FatherCellPhone, FatherOfficePhone, MotherName, MotherCellPhone, MotherResPhone, ResidencePhone, ResidenceAddress, AdmissionDateSelected, AdmissionDate, AdmittedBy, PrevSchoolName, PrevSchoolPhone, PrevSchoolAddress, ReasonForLeaving, Remarks, Status, LastModifiedTime ) values ( " + StudentObj.Id + ", " + "'" + StudentObj.RegNo + "', " + StudentObj.BatchId + ", " + "'" + StudentObj.StudentName + "', " + "'" + StudentObj.StudentAddress + "', " + "'" + StudentObj.Phone + "', " + StudentObj.DateOfBirthSelected + ", " + "'" + StudentObj.DateOfBirth + "', " + "'" + StudentObj.Email + "', " + "'" + StudentObj.Homepage + "', " + "'" + StudentObj.FatherName + "', " + "'" + StudentObj.FatherCellPhone + "', " + "'" + StudentObj.FatherOfficePhone + "', " + "'" + StudentObj.MotherName + "', " + "'" + StudentObj.MotherCellPhone + "', " + "'" + StudentObj.MotherResPhone + "', " + "'" + StudentObj.ResidencePhone + "', " + "'" + StudentObj.ResidenceAddress + "', " + StudentObj.AdmissionDateSelected + ", " + "'" + StudentObj.AdmissionDate + "', " + "'" + StudentObj.AdmittedBy + "', " + "'" + StudentObj.PrevSchoolName + "', " + "'" + StudentObj.PrevSchoolPhone + "', " + "'" + StudentObj.PrevSchoolAddress + "', " + "'" + StudentObj.ReasonForLeaving + "', " + "'" + StudentObj.Remarks + "', " + StudentObj.Status + ", " + "'" + StudentObj.LastModifiedTime + "' ) ";

		DataManager.ExecuteNonQuery(ConnectionString, query);
	}

	public static void UpdateStudent( Student StudentObj )
	{
		String ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["DSN"]; 
		String query = "update STUDENT set Id = " + StudentObj.Id + ", RegNo = '" + StudentObj.RegNo + "', BatchId = " + StudentObj.BatchId + ", StudentName = '" + StudentObj.StudentName + "', StudentAddress = '" + StudentObj.StudentAddress + "', Phone = '" + StudentObj.Phone + "', DateOfBirthSelected = " + StudentObj.DateOfBirthSelected + ", DateOfBirth = '" + StudentObj.DateOfBirth + "', Email = '" + StudentObj.Email + "', Homepage = '" + StudentObj.Homepage + "', FatherName = '" + StudentObj.FatherName + "', FatherCellPhone = '" + StudentObj.FatherCellPhone + "', FatherOfficePhone = '" + StudentObj.FatherOfficePhone + "', MotherName = '" + StudentObj.MotherName + "', MotherCellPhone = '" + StudentObj.MotherCellPhone + "', MotherResPhone = '" + StudentObj.MotherResPhone + "', ResidencePhone = '" + StudentObj.ResidencePhone + "', ResidenceAddress = '" + StudentObj.ResidenceAddress + "', AdmissionDateSelected = " + StudentObj.AdmissionDateSelected + ", AdmissionDate = '" + StudentObj.AdmissionDate + "', AdmittedBy = '" + StudentObj.AdmittedBy + "', PrevSchoolName = '" + StudentObj.PrevSchoolName + "', PrevSchoolPhone = '" + StudentObj.PrevSchoolPhone + "', PrevSchoolAddress = '" + StudentObj.PrevSchoolAddress + "', ReasonForLeaving = '" + StudentObj.ReasonForLeaving + "', Remarks = '" + StudentObj.Remarks + "', Status = " + StudentObj.Status + ", LastModifiedTime = '" + StudentObj.LastModifiedTime + "' where Id = " + StudentObj.Id; 

		DataManager.ExecuteNonQuery(ConnectionString, query);
	}

	public static Student GetStudent( System.Int32 Id )
	{
		String ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["DSN"]; 
		String query = "select * from STUDENT where Id = " + Id; 

		DataTable Dt = DataManager.ExecuteQuery(ConnectionString, query, "Student" );
		if (Dt.Rows.Count == 0) 
		{
			return null;
		}

		return new Student(Dt.Rows[0]);
	}

	public static DataTable GetStudents ( String criteria ) 
	{
		String ConnectionString = System.Configuration.ConfigurationSettings.AppSettings["DSN"]; 
		String query = "select * from STUDENT";

		if ( criteria != "" )
		{
			query = query + " where " + criteria;
		}

		DataTable Dt = DataManager.ExecuteQuery(ConnectionString, query, "Student" );
		return Dt;
	}
}