using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TalentManagement.Models
{
    public partial class Agent
    {
        [Display(Name = "Agent ID")]
        public int AgentId { get; set; }
        [Display(Name = "Agent First Name")]
        public string AgentFirstName { get; set; } = null!;
        [Display(Name = "Agent Last Name")]
        public string? AgentLastName { get; set; }
        [Display(Name = "Artiste ID")]
        public int ArtisteId { get; set; }
    }
}
