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
    
    public partial class SelectTasksByProjectID_Result
    {
        public int TaskID { get; set; }
        public Nullable<int> SubContractorID { get; set; }
        public string Description { get; set; }
        public int TaskTypeID { get; set; }
        public Nullable<System.DateTime> ActualStartDate { get; set; }
        public Nullable<System.DateTime> ActualEndDate { get; set; }
        public System.DateTime CreationDate { get; set; }
        public long DurationTicks { get; set; }
    }
}
