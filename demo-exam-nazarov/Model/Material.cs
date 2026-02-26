using System;
using System.Collections.Generic;
using System.Text;

namespace demo_exam_nazarov.Model
{
    public partial class Material
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public int CountInPack { get; set; }
        public string? Unit {  get; set; }
        public double CountInStock { get; set; }
        public double MinCount {  get; set; }
        public string? Description { get; set; }
        public decimal Cost { get; set; }
        public string? Image { get; set; }
        public int MaterialTypeID { get; set; }

        public MaterialType? MaterialType { get; set; }
    }
}
