using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TrouveTonPote.Models
{
    public class Event
    {
        public int idEvent { get; set; }
        public string titre { get; set; }
        public string localisation { get; set; }
        public string date { get; set; }
        public string etat { get; set; }
        public string nbMax { get; set; }
        public string photo { get; internal set; }

        public List<string> listEvent = new List<string>();


        public void saveNewEvent()
        {
            connexionBD dbconn = new connexionBD();
            // mettre un try catch la
            dbconn.connexionDataBase("INSERT INTO TTP.dbo.Event_ttp (TitreEvt, LocEvt,DateEvt, PhotoEvt, EtatEvt , NbMaxParticipant) VALUES ('" + titre + "','" + localisation + "','" + date + "','" + etat + "','" + nbMax +"')");
        }

        public List<string> showAllEvent()
        {
            String ConnectionS = "Data Source=NANA;Initial Catalog=TTP;Integrated Security=SSPI;";

            SqlConnection connection = new SqlConnection(ConnectionS);
            string request = "SELECT TitreEvt, LocEvt,DateEvt, PhotoEvt, EtatEvt , NbMaxParticipant FROM Event_ttp";
            SqlCommand command = new SqlCommand(request, connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
            SqlDataReader sr = command.ExecuteReader();
            while (sr.Read())
            {
                listEvent.Add(sr.GetString(0));
            }

            return listEvent;



        }

        public List<String> showUserEvent(string UserName)
        {
            String ConnectionS = "Data Source=NANA;Initial Catalog=TTP;Integrated Security=SSPI;";

            SqlConnection connection = new SqlConnection(ConnectionS);
            string request = "SELECT  TitreEvt, LocEvt,DateEvt, PhotoEvt, EtatEvt , NbMaxParticipant FROM TTP.dbo.Event_ttp WHERE UserName = ";
            SqlCommand command = new SqlCommand(request, connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
            SqlDataReader sr = command.ExecuteReader();
            while (sr.Read())
            {
                listEvent.Add(sr.GetString(0));
            }

            return listEvent;

        }

        public void deleteEvent(string idEvent)
        {
            String ConnectionS = "Data Source=NANA;Initial Catalog=TTP;Integrated Security=SSPI;";

            SqlConnection connection = new SqlConnection(ConnectionS);
            string request = "DELETE *  FROM TTP.dbo.Event_ttp WHERE IdEvt = " + idEvent ;
            SqlCommand command = new SqlCommand(request, connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
            
        }

        public void addParticipant(string idEvent)
        {
            String ConnectionS = "Data Source=NANA;Initial Catalog=TTP;Integrated Security=SSPI;";

            SqlConnection connection = new SqlConnection(ConnectionS);
            string request = "UPDATE NbMaxParticipant FROM TTP.dbo.Event_ttp WHERE IdEvt = " + idEvent;
            SqlCommand command = new SqlCommand(request, connection);
            command.Connection.Open();
            command.ExecuteNonQuery();
        }

    }

   
}