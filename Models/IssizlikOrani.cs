using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystemWeb.Models
{
    public class IssizlikOrani
    {
        public int Id { get; set; }
        public string Toplam1 { get; set; }
        public string Toplam2 { get; set; }
        public string Erkek1 { get; set; }
        public string Erkek2 { get; set; }
        public string Kadın1 { get; set; }
        public string Kadın2 { get; set; }
        public string ToplamOran1 { get; set; }
        public string ToplamOran2 { get; set; }
        public string ErkekOran1 { get; set; }
        public string ErkekOran2 { get; set; }
        public string KadınOran1 { get; set; }
        public string KadınOran2 { get; set; }
    }
}
