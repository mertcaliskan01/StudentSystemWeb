using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystemWeb.Models
{
    public class IssizlikOrani
    {
        public int Id { get; set; }
        public int Toplam1 { get; set; }
        public int Toplam2 { get; set; }
        public int Erkek1 { get; set; }
        public int Erkek2 { get; set; }
        public int Kadın1 { get; set; }
        public int Kadın2 { get; set; }
        public float ToplamOran1 { get; set; }
        public float ToplamOran2 { get; set; }
        public float ErkekOran1 { get; set; }
        public float ErkekOran2 { get; set; }
        public float KadınOran1 { get; set; }
        public float KadınOran2 { get; set; }
        public string Aciklama { get; set; }
        public int TabloId { get; set; }
    }
}
