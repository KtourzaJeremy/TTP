using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace TTPV2.Models
{
    public partial class TTPDBEntities : DbContext
    {
        public TTPDBEntities()
            : base("name= TTPDBEntities")
        {

        }

        public virtual DbSet<User_ttp> Users { get; set; }
        public virtual DbSet<Event_ttp> Events { get; set; }
        public virtual DbSet<Participants> Participants { get; set; }

      

    }

    
}