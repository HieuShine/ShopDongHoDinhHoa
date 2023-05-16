namespace ngay8thang3_Complete.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            DatHangs = new HashSet<DatHang>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        [DisplayName("Họ tên:")]
        
        public string HoVaTen { get; set; }

        [StringLength(20)]
        [DisplayName("Điện thoại:")]
       
        public string DienThoai { get; set; }

        [StringLength(255)]
        [DisplayName("Địa chỉ:")]
        public string DiaChi { get; set; }

        [StringLength(50)]
       
        [DisplayName("Tên đăng nhập:")]

        public string TenDangNhap { get; set; }

        [StringLength(255)]
        [DisplayName("Mật khẩu:")]

        public string MatKhau { get; set; }
        [DisplayName("Quyền:")]

        public bool? Quyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatHang> DatHangs { get; set; }
    }
}
