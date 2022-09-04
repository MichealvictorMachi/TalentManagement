using System;
using System.Collections.Generic;

namespace TalentManagement.Models
{
    public partial class Venue
    {
        public string VenueName { get; set; } = null!;
        public string? VenueCity { get; set; }
        public int? GigsId { get; set; }
    }
}
