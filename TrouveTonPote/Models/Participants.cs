namespace TrouveTonPote.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Participants
    {
        public int IdEvt { get; set; }
        public string UserNamePart { get; set; }

        public virtual Event_ttp Event_ttp { get; set; }
        public virtual User_ttp User_ttp { get; set; }
    }
}