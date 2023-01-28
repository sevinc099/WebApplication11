using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Table3
    {
        public int Id { get; set; }
        public string KitabAd { get; set; }
        public string KitabYazar { get; set; }
        public int? KitabSehife { get; set; }
        public decimal? KitabQiymet { get; set; }
        public DateTime? KitabTarix { get; set; }
        public string KitabCapevi { get; set; }
    }
}
