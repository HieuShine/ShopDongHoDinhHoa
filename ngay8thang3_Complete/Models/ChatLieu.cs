﻿namespace ngay8thang3_Complete.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChatLieu")]
    public partial class ChatLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChatLieu()
        {
            DongHoes = new HashSet<DongHo>();
        }

        public int ID { get; set; }

        [Required(ErrorMessage ="Tên chất liệu không được để trống")]
        [DisplayName("Tên chất liệu")]
        [StringLength(255)]
        public string TenChatLieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DongHo> DongHoes { get; set; }
    }
}
