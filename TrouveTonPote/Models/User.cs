using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrouveTonPote.Models
{
    public class Users
    {

        public class ContextUser : System.Data.Entity.DbContext
        {
            public ContextUser() : base()
            {

            }

            public ContextUser(string connectionString) : base(connectionString)
            {

            }
            public DbSet<User> ListeUser { get; set; }
        }

        public class User
        {

            public int id { get; set; }
            public string nom { get; set; }
            public string prénom { get; set; }
            public string Email { get; set; }
            public string mdp { get; set; }
            public string Age { get; set; }
            public string Genre { get; set; }
            public string Tel { get; set; }
            public string Photo { get; set; }

        }
    }
}