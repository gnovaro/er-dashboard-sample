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
    
    public partial class ChatRespons
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public string Response { get; set; }
    
        public virtual ChatRole ChatRole { get; set; }
    }
}
