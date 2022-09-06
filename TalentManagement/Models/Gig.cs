using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TalentManagement.Models
{
    public partial class Gig
    {
        [Display(Name = "Gigs ID")]
        public int GigsId { get; set; }
        [Display(Name = "Gigs Date")]
        public DateTime GigDate { get; set; }
        [Display(Name = "Venue Name")]
        public string? VenueName { get; set; }
        [Display(Name = "Artiste ID")]
        public int? ArtisteId { get; set; }
        [Display(Name = "Income Generated")]
        public decimal? IncomeGenerated { get; set; }
    }
}
