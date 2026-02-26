using System;
using System.Collections.Generic;
using System.Text;

namespace demo_exam_nazarov.Model
{
    public partial class Supplier
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? INN { get; set; }
        public DateTime StartDate { get; set; }
        public int QualityRating { get; set; }
        public string? SupplierType { get; set; }
    }
}
