//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace V1_BTL_CNPM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class thoigianhoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public thoigianhoc()
        {
            this.lophocphans = new HashSet<lophocphan>();
        }
    
        public string NamHoc { get; set; }
        public Nullable<int> HocKy { get; set; }
        public Nullable<int> GiaiDoan { get; set; }
        public string MaTGH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<lophocphan> lophocphans { get; set; }
    }
}
