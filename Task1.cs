using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FifteenthDayClasCSharp
{
    public class Task1
    {
        public void getData()
        {
            SqlConnection con = new SqlConnection("Data source = YKG-PC; database=AdventureWorks2019; user id=sa; password=p@ssword");
            con.Open();
            SqlCommand cmd = new SqlCommand("select FirstName from person.person", con);


            //cmd.ExecuteNonQuery();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString());


            }
            con.Close();
        }
        public static void Main()
        {
            Task1 task1 = new Task1();
            task1.getData();
        }
    }
}
