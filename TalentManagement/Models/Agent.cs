using System;
using System.Collections.Generic;

namespace TalentManagement.Models
{
    public partial class Agent
    {
        public int AgentId { get; set; }
        public string AgentFirstName { get; set; } = null!;
        public string? AgentLastName { get; set; }
        public int ArtisteId { get; set; }
    }
}
