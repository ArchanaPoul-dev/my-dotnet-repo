using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyFirstProject_C.Models
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> empList = new List<Employee>();
            //Feature1 Code commited to GIThub
            SqlConnection sqlcon = new SqlConnection(@"Server=DESKTOP-2HALD25;Database=TestDB;Trusted_Connection=True;MultipleActiveResultSets=True;User Id=sa;Password=W3lc0m3");
            string Query = "Select * from Employee";

            SqlCommand sqlcmd = new SqlCommand(Query, sqlcon);
            sqlcon.Open();
            SqlDataReader dr = sqlcmd.ExecuteReader();
            //sqlcmd.Parameters.Add("@UserName", UserName);
           
            while(dr.Read())
            {
                empList.Add(new Employee
                {
                    Id = (int)dr[0],
                    Name=dr[1].ToString(),
                    City=dr[2].ToString()

                });

            }
            sqlcon.Close();
            return empList;
        }


        public List<Employee> GetEmployeebyID(int id)
        {
            List<Employee> empList = new List<Employee>();

            SqlConnection sqlcon = new SqlConnection(@"Server=DESKTOP-2HALD25;Database=TestDB;Trusted_Connection=True;MultipleActiveResultSets=True;User Id=sa;Password=W3lc0m3");
            string Query = "Select * from Employee where id=@Ref";

            SqlCommand sqlcmd = new SqlCommand(Query, sqlcon);
            sqlcon.Open();
           
            sqlcmd.Parameters.AddWithValue("@Ref", id);
            SqlDataReader dr = sqlcmd.ExecuteReader();
            while (dr.Read())
            {
                empList.Add(new Employee
                {
                    Id = (int)dr[0],
                    Name = dr[1].ToString(),
                    City = dr[2].ToString()

                });

            }
            sqlcon.Close();
            return empList;
        }

        public Boolean validateLogin(LoginData logindt)
        {
            SqlConnection sqlcon = new SqlConnection(@"Server=DESKTOP-2HALD25;Database=TestDB;Trusted_Connection=True;MultipleActiveResultSets=True;User Id=sa;Password=W3lc0m3");
            string Query = "Select count(*) from Login where LoginId=@Ref";

            SqlCommand sqlcmd = new SqlCommand(Query, sqlcon);
            sqlcmd.Parameters.AddWithValue("@Ref", logindt.Login_Ref);
          
            sqlcon.Open();
           int Result =(int) sqlcmd.ExecuteScalar();
            sqlcon.Close();
            if (Result>0)
                {
                return true;
            }
            
            return false;
        }

        public Boolean deleteEmployee(int id)
        {
            SqlConnection sqlcon = new SqlConnection(@"Server=DESKTOP-2HALD25;Database=TestDB;Trusted_Connection=True;MultipleActiveResultSets=True;User Id=sa;Password=W3lc0m3");
            string Query = "delete from Employee where Id=@Ref";

            SqlCommand sqlcmd = new SqlCommand(Query, sqlcon);
            sqlcmd.Parameters.AddWithValue("@Ref", id);

            sqlcon.Open();
            int Result = (int)sqlcmd.ExecuteNonQuery();
            sqlcon.Close();

            if (Result > 0)
            {
                return true;
            }
            return false;


        }

       
    }
}