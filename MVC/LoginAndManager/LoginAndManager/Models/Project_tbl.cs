//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginAndManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project_tbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project_tbl()
        {
            this.Employee_tbl = new HashSet<Employee_tbl>();
        }
    
        public int Project_id { get; set; }
        public string Projectname { get; set; }
        public System.DateTime PSD { get; set; }
        public System.DateTime PED { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_tbl> Employee_tbl { get; set; }
    }
}
