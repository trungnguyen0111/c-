//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop_watch.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tai_khoan_Ad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tai_khoan_Ad()
        {
            this.Binh_luan = new HashSet<Binh_luan>();
        }
    
        public int Id_Tai_khoan_ad { get; set; }
        public string Ho_ten { get; set; }
        public byte Gioi_tinh { get; set; }
        public Nullable<System.DateTime> Ngay_sinh { get; set; }
        public string Dia_chi { get; set; }
        public string Email { get; set; }
        public int So_dien_thoai { get; set; }
        public string Hinh_anh { get; set; }
        public string Nguoi_cap_nhat { get; set; }
        public Nullable<System.DateTime> Ngay_cap_nhat { get; set; }
        public string Chu_thich { get; set; }
        public Nullable<byte> Trang_thai { get; set; }
        public Nullable<byte> Id_chuc_vu { get; set; }
        public string Mat_khau { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Binh_luan> Binh_luan { get; set; }
    }
}