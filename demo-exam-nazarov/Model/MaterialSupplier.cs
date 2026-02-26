using System;
using System.Collections.Generic;
using System.Text;

namespace demo_exam_nazarov.Model
{
    public partial class MaterialSupplier
    {
        public int MaterialID { get; set; }
        public int SupplierID { get; set; }

        public Material? Material { get; set; }
        public Supplier? Supplier { get; set; }
    }
}
