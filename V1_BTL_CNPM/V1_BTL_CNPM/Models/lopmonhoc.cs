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
    
    public partial class lopmonhoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public lopmonhoc()
        {
            this.ctlophps = new HashSet<ctlophp>();
            this.ctlophps1 = new HashSet<ctlophp>();
        }
    
        public string MaLTM { get; set; }
        public string TenLopMon { get; set; }
        public string MaMon { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ctlophp> ctlophps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ctlophp> ctlophps1 { get; set; }
        public virtual mon mon { get; set; }
    }
}
