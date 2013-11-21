//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthcareDashboard.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
        public Patient()
        {
            this.Admittances = new HashSet<Admittance>();
            this.PatientAllergies = new HashSet<PatientAllergy>();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> VIP { get; set; }
        public Nullable<bool> Infectious { get; set; }
        public Nullable<bool> DNR { get; set; }
        public Nullable<bool> Visited { get; set; }
    
        public virtual ICollection<Admittance> Admittances { get; set; }
        public virtual ICollection<PatientAllergy> PatientAllergies { get; set; }
    }
}
