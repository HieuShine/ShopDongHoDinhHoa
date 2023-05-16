namespace ngay8thang3_Complete.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatHang")]
    public partial class DatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatHang()
        {
            DatHang_ChiTiet = new HashSet<DatHang_ChiTiet>();
        }

        public int ID { get; set; }

        public int? NhanVien_ID { get; set; }

        public int? KhachHang_ID { get; set; }

        [StringLength(20)]
        [DisplayName("Số điện thoại giao hàng")]
        [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string DienThoaiGiaoHang { get; set; }

        [StringLength(255)]
        [DisplayName("Địa chỉ giao hàng")]
        [Required(ErrorMessage ="Vui lòng nhập trường này!")]
        public string DiaChiGiaoHang { get; set; }
        [DisplayName("Ngày đặt hàng")]

        public DateTime? NgayDatHang { get; set; }
        [DisplayName("Tình trạng")]

        public short? TinhTrang { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatHang_ChiTiet> DatHang_ChiTiet { get; set; }
    }
}
