//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DisabilityAdvantage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Division
    {
        public Division()
        {
            this.Schools = new HashSet<School>();
        }
    
        public int Number { get; set; }
        public string Name { get; set; }
    
        internal virtual ICollection<School> Schools { get; set; }
    }
}
