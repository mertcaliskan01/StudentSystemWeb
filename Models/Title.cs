using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentSystemWeb.Models
{
    public class Title
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public Boolean IsAnaBaslik { get; set; }
        public int AnaBaslikId { get; set; }
        public string AltBaslikUrl { get; set; }
    }
}
