namespace ngay8thang3_Complete.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XuatXu")]
    public partial class XuatXu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XuatXu()
        {
            DongHoes = new HashSet<DongHo>();
        }

        public int ID { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập vào trường này")]
        [StringLength(255)]
        [DisplayName("Tên quốc gia")]
        public string TenQG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DongHo> DongHoes { get; set; }
    }
}
