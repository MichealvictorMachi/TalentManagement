using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TalentManagement.Models
{
    public partial class Artiste
    {
        [Display(Name = "Artiste ID")]
        public int ArtisteId { get; set; }
        [Display(Name = "Stage Name")]
        public string? StageName { get; set; }
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Display(Name = "Contract Status")]
        public string ContractStatus { get; set; } = null!;
        [Display(Name = "Agent ID")]
        public int AgentId { get; set; }
        [Display(Name = "Gigs")]
        public string? Gigs { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime? Dob { get; set; }
    }
}
