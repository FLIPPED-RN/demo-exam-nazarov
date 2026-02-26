using System;
using System.Collections.Generic;
using System.Text;

namespace demo_exam_nazarov.Model
{
    public partial class Agent
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public int AgentTypeID { get; set; }
        public string? Address { get; set; }
        public string? INN { get; set; }
        public string? KPP { get; set; }
        public string? DirectorName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Logo { get; set; }
        public int Priority { get; set; }

        public AgentType? AgentType { get; set; }
    }
}
