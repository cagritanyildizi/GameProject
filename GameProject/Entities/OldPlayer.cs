using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class OldPlayer
    {
        public int MembershipYear { get; set; }
        public string TcNo { get; internal set; }
        public int BirthYear { get; internal set; }
        public string PlayerName { get; internal set; }
        public string PlayerSurname { get; internal set; }
    }
}
