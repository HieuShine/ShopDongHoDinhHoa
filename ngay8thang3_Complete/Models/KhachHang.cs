namespace ngay8thang3_Complete.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            DatHangs = new HashSet<DatHang>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        [DisplayName("Họ và tên")]
        [Required(ErrorMessage ="Họ và tên không được để trống!")]
        public string HoVaten { get; set; }

        [StringLength(20)]

        [Display(Name = "Điện thoại")]
        [MaxLength(10, ErrorMessage = "Số điện thoại đa 10 kí tự")]
        [RegularExpression(@"^((09|03|07|08|05)\d{8})$", ErrorMessage = "Số điện thoại không đúng")]
        public string DienThoai { get; set; }
        [DisplayName("Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="Email không đúng định dạng")]
        public string Email { get; set; }

        [StringLength(255)]
        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        public string DiaChi { get; set; }

        [StringLength(50)]
        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống!")]
        public string TenDangNhap { get; set; }

        [StringLength(255)]
        [DisplayName("Mật khẩu")]
        [MinLength(3,ErrorMessage = "Mật khẩu tối thiểu 4 kí tự!")]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }
        //[DisplayName("Xác nhận Mật khẩu")]
        //[Compare("MatKhau",ErrorMessage = "Mật khẩu không trùng khớp!")]
        //[DataType(DataType.Password)]
        //public string XacNhanMatKhau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatHang> DatHangs { get; set; }
    }
}
