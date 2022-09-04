using System;
using System.Collections.Generic;

namespace TalentManagement.Models
{
    public partial class Artiste
    {
        public int ArtisteId { get; set; }
        public string? StageName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string ContractStatus { get; set; } = null!;
        public int AgentId { get; set; }
        public string? Gigs { get; set; }

        public DateTime? Dob { get; set; }
    }
}
