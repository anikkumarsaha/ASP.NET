//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mid_Exam_Scenario_1.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicineSupplier
    {
        public int Id { get; set; }
        public int MedId { get; set; }
        public int SupId { get; set; }
    
        public virtual Medicine Medicine { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
