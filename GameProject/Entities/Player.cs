using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Player
    {
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public string TcNo { get; set; }
        public int BirthYear { get; set; }

        public static implicit operator Player(OldPlayer v)
        {
            throw new NotImplementedException();
        }
    }
}
