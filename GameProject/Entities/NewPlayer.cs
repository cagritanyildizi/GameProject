using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class NewPlayer
    {
        public int UndertakingYear { get; set; }
        public string PlayerSurname { get; internal set; }
        public int BirthYear { get; internal set; }
        public string PlayerName { get; internal set; }
        public string TcNo { get; internal set; }
    }
}
