﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication11.Models
{
    public partial class Kitablar2
    {
        public int Id { get; set; }
        public string KitabAd { get; set; }
        public string KitabYazar { get; set; }
        public int? KitabSehife { get; set; }
        public decimal? KitabQiymet { get; set; }
        public DateTime? KitabTarixi { get; set; }
        public string KitabCapev { get; set; }
    }
}
