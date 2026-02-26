using System;
using System.Collections.Generic;
using System.Text;

namespace demo_exam_nazarov.Model
{
    public partial class Shop
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Address { get; set; }
        public int AgentID {  get; set; }

        public Agent? Agent { get; set; }
    }
}
