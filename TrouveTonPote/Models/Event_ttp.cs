using System;
using System.Collections.Generic;

namespace TrouveTonPote.Models
{
    public class Event_ttp
    {
        public int IdEvt { get; set; }
        public string TitreEvt { get; set; }
        public string LocEvt { get; set; }
        public System.DateTime DateEvt { get; set; }
        public string PhotoEvt { get; set; }
        public bool EtatEvt { get; set; }
        public Nullable<int> NbMaxParticipants { get; set; }
        public string UserNameAdmin { get; set; }

        public virtual Participants Participants { get; set; }
    }
}
