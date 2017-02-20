using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TTPV2.Models
{
    public class connexionBD
    {
        public void connexionDataBase(string request)
        {
            String ConnectionS = "Data Source=NANA;Initial Catalog=TTP;Integrated Security=SSPI;";

            using (SqlConnection connection = new SqlConnection(ConnectionS))
            {
                SqlCommand command = new SqlCommand(request, connection);
                command.Connection.Open();

            }

        }
    }
}