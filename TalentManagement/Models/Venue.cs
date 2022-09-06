using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TalentManagement.Models
{
    public partial class Venue
    {
        [Display(Name = "Venue Name")]
        public string VenueName { get; set; } = null!;
        [Display(Name = "Venue City")]
        public string? VenueCity { get; set; }
        [Display(Name = "Gigs ID")]
        public int? GigsId { get; set; }
    }
}
