//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP.NetMVCExample.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyRoles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyRoles()
        {
            this.CompanyWorkers = new HashSet<CompanyWorkers>();
            this.CompanyRoles1 = new HashSet<CompanyRoles>();
        }
    
        public int RoleID { get; set; }
        public int CompanyID { get; set; }
        public string RoleName { get; set; }
        public Nullable<int> SuperRole { get; set; }
        public bool Admin { get; set; }
    
        public virtual Companys Companys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyWorkers> CompanyWorkers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyRoles> CompanyRoles1 { get; set; }
        public virtual CompanyRoles CompanyRoles2 { get; set; }
    }
}
