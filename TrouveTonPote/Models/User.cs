using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TrouveTonPote.Models
{
    public class User
    {
        public string userName { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string mdp { get; set; }
        public string Tel { get; set; }
        public string Age { get; set; }
        public string Genre { get; set; }

        public int checkuserName(string userName)
        {
            String ConnectionS = "Data Source=NANA;Initial Catalog=TTP;Integrated Security=SSPI;";
            SqlConnection connection = new SqlConnection(ConnectionS);
            string request = "SELECT COUNT (*) FROM TTP.dbo.User_ttp where UserName = '" + userName + "'";

            //mettre un try catch
            SqlCommand command = new SqlCommand(request, connection);
            command.Connection.Open();
            Int32 result = (Int32)command.ExecuteScalar();



           return result;
        }

        public void saveUser()
        {
            
            connexionBD dbconn = new connexionBD();
            // mettre un try catch la
                dbconn.connexionDataBase("INSERT INTO TTP.dbo.User_ttp (UserName, NomUser,PrenomUser, MailUser, MdpUser , TelUser, AgeUser, GenreUser) VALUES ('" + userName + "','" + firstname + "','" + lastname + "','" + email + "','" + mdp + "','" + Tel + "','" + Age + "','" + Genre + "')");
            
        }

        public int  checkUser(string userName, string pswd)
        {
            String ConnectionS = "Data Source=NANA;Initial Catalog=TTP;Integrated Security=SSPI;";
            SqlConnection connection = new SqlConnection(ConnectionS);
            string request = "SELECT COUNT (*) FROM TTP.dbo.User_ttp where UserName = '" + userName + "' AND MdpUser = '" + pswd + "'";

            //mettre un try catch
            SqlCommand command = new SqlCommand(request, connection);
            command.Connection.Open();
            Int32 result = (Int32)command.ExecuteScalar();
            return result;
        }

    }
}