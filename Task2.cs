using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FifteenthDayClasCSharp
{
    internal class Task2
    {
        public void insData(int BussinuessEntityID, string passwordsalt, DateTime date)
        {
            SqlConnection con = new SqlConnection("data source = ykg-pc; database=AdventureWorks2019; user id=sa; password=p@ssword");
            SqlCommand cmd = new SqlCommand("sp_Person.Password", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BussinuessEntityID", SqlDbType.Int).Value = BussinuessEntityID;
            cmd.Parameters.AddWithValue("@passwordsalt", SqlDbType.NVarChar).Value = passwordsalt;
            cmd.Parameters.AddWithValue("@ModifiedDate", SqlDbType.DateTime).Value = date;




            con.Open();
           // cmd.ExecuteNonQuery();
            con.Close();

            Console.WriteLine("inserted");

        }
        public static void Main()
        {
          Task2 task2 = new Task2();
            task2.insData( 20778, "7iy/muc=", DateTime.Now );
        }


    }
}
    

