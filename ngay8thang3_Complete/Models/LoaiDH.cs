namespace ngay8thang3_Complete.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiDH")]
    public partial class LoaiDH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiDH()
        {
            DongHoes = new HashSet<DongHo>();
        }

        public int ID { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage ="Vui lòng nhập tên đồng hồ")]
        [DisplayName("Tên loại đồng hồ")]
        public string TenLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DongHo> DongHoes { get; set; }
    }
}
