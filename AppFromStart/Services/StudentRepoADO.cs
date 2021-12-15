using AppFromStart.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AppFromStart.Services
{
    public class StudentRepoADO : IRepo<Student>
    {
        public bool Add(Student t)
        {
            throw new NotImplementedException();
        }

        public Student Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            SqlConnection con = new SqlConnection(@"Data source=DESKTOP-1C1EU5R\SQLSERVER2019G3;user id=sa;password=P@ssw0rd;Initial catalog=dbSchool15Dec21");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand= new SqlCommand("Select * from Students");
            da.SelectCommand.Connection = con;
            DataSet ds = new DataSet();
            da.Fill(ds, "Studnets");
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                Student student = new Student();
                student.Id = Convert.ToInt32(item[0].ToString());
                student.Name = item[1].ToString();
                student.Status = item[2].ToString();
                students.Add(student);
            }
            return students;
        }

        public Student Update(Student t)
        {
            throw new NotImplementedException();
        }
    }
}
