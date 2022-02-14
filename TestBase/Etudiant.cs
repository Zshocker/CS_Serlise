using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TestBase
{
    class Etudiant
    {
        static int Cm = 0;
        public int id { get; set; } = ++Cm;
        public string name { get; set; }
        public string CNE { get; set; }
        bool saved = false;
        public Etudiant(string nam, string cne)
        {
            name = nam;
            CNE = cne;
        }
        public Etudiant()
        {
        }
        public void Save_ToBase(string Connection)
        {
           using(SqlConnection sql = new SqlConnection(Connection)){
                SqlCommand command;
                if (!saved) {
                    command = new SqlCommand("dbo.InsertEtu", sql);
                    command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = this.id;
                    saved = true;
                }
                else command = new SqlCommand("dbo.UpdateEtu", sql);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar).Value = this.name;
                command.Parameters.Add("@CNE", System.Data.SqlDbType.VarChar).Value = this.CNE;
                sql.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    Save_ToBase(Connection);
                }
                sql.Close();
           }
   
        }
    }
}
