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
    
    public partial class sinhvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sinhvien()
        {
            this.Diems = new HashSet<Diem>();
        }
    
        public Nullable<int> MaTK { get; set; }
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }
        public string MaNganh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }
        public virtual nganh nganh { get; set; }
        public virtual taikhoan taikhoan { get; set; }
    }
}
