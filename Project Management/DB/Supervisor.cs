//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mid_Exam_Scenario_2.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supervisor
    {
        public Supervisor()
        {
            this.Projects = new HashSet<Project>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Project> Projects { get; set; }
    }
}
