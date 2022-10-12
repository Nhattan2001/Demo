namespace Demo3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            GIOHANGs = new HashSet<GIOHANG>();
        }

        [Key]
        [StringLength(10)]
        
        public string MASP { get; set; }

        [StringLength(30)]
        [Display(Name = "Tên sản phẩm")]
        public string TENSP { get; set; }
        [Display(Name = "Đơn giá")]
        public int? DONGIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIOHANG> GIOHANGs { get; set; }
    }
}
