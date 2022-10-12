namespace Demo3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIOHANG")]
    public partial class GIOHANG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        [Display (Name ="Mã sản phẩm")]
        public string MASP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        [Display(Name = "Mã khách hàng")]
        public string MAKH { get; set; }
        [Display(Name = "Số lượng")]
        public int? SOLUONG { get; set; }
        [Display(Name = "Thành Tiền")]
        public int? THANHTIEN { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
