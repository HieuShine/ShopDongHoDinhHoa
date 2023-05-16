namespace ngay8thang3_Complete.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DongHo")]
    public partial class DongHo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DongHo()
        {
            DatHang_ChiTiet = new HashSet<DatHang_ChiTiet>();
        }
        
        
        public int ID { get; set; }
        [DisplayName("Tên thương hiệu")]

        public int? ThuongHieu_ID { get; set; }
        
        [DisplayName("Loại đồng hồ")]
        public int? TenLoai_ID { get; set; }
        
        [DisplayName("Chất liệu")]
        public int? ChatLieu_ID { get; set; }
        [DisplayName("Xuất xứ")]
        
        public int? XuatXu_ID { get; set; }
        [StringLength(255)]

        [DisplayName("Tên đồng hồ")]
        [Required(ErrorMessage ="Tên đồng hồ không được để trống")]
        [MinLength(3,ErrorMessage ="Tên đồng hồ tối thiểu 3 kí tự")]
        public string TenDongHo { get; set; }
        
        [StringLength(255)]

        [DisplayName("Màu sắc")]
        [Required(ErrorMessage ="Màu sắc không được để trống")]

        public string MauSac { get; set; }
        
        [DisplayName("Hạn bảo hành")]
        public int? HanBaoHanh { get; set; }


        [DisplayName("Đơn giá")]        
         [Required(ErrorMessage ="Đơn giá không được để trống")]

        public int? DonGia { get; set; }
       
        [DisplayName("Số lượng")]  
        [Required(ErrorMessage ="Số lượng")]
     
        public int? SoLuong { get; set; }
       
        [StringLength(255)]
        [DisplayName("Hình ảnh")]
        public string HinhAnhDH { get; set; }

        [Column(TypeName ="ntext")]
        [DisplayName("Mô tả ngắn")]
        public string MoTaNgan { get; set; }

        [Column(TypeName ="ntext")]
        public string Đaciem { get; set; }

        [Column(TypeName = "ntext")]
        public string MoTa { get; set; }

        public virtual ChatLieu ChatLieu { get; set; }
        [DisplayName("Khuyến mại")]
        public int? KhuyenMai { get; set; }
        [DisplayName("Giá nhập")]
        public int GiaNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatHang_ChiTiet> DatHang_ChiTiet { get; set; }

        public virtual LoaiDH LoaiDH { get; set; }

        public virtual ThuongHieu ThuongHieu { get; set; }

        public virtual XuatXu XuatXu { get; set; }
    }
}
