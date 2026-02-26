using System;
using System.Collections.Generic;
using System.Text;

namespace demo_exam_nazarov.Model
{
    public partial class MaterialType
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public double DefectedPercent { get; set; }
    }
}
