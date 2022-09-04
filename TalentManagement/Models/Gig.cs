using System;
using System.Collections.Generic;

namespace TalentManagement.Models
{
    public partial class Gig
    {
        public int GigsId { get; set; }
        public DateTime GigDate { get; set; }
        public string? VenueName { get; set; }
        public int? ArtisteId { get; set; }
        public decimal? IncomeGenerated { get; set; }
    }
}
