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
    
    public partial class Messages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Messages()
        {
            this.Messages1 = new HashSet<Messages>();
        }
    
        public int MessageID { get; set; }
        public int UserID { get; set; }
        public Nullable<int> ReplyToID { get; set; }
        public Nullable<int> DirectToID { get; set; }
        public Nullable<int> ProjectGroupID { get; set; }
        public Nullable<int> TaskTypesGroupID { get; set; }
        public Nullable<int> CompanyGroupID { get; set; }
        public Nullable<int> OfficeGroupID { get; set; }
        public string Text { get; set; }
        public System.DateTime Time { get; set; }
    
        public virtual Companys Companys { get; set; }
        public virtual Users Users { get; set; }
        public virtual Offices Offices { get; set; }
        public virtual Projects Projects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Messages> Messages1 { get; set; }
        public virtual Messages Messages2 { get; set; }
        public virtual TaskTypes TaskTypes { get; set; }
        public virtual Users Users1 { get; set; }
    }
}