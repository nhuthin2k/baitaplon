namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("khachhangs")]
    public partial class KhachHang
    {
        [Key]
        [StringLength(50)]
        [DisplayName("Mã Khách hàng")]
        public string MaKhachHang { get; set; }

        [StringLength(50)]
        [DisplayName("Tên khách hàng")] 
        public string TenKhachHang { get; set; }

        [StringLength(11)]
        [DisplayName("Số điện thoại")]
        public string SoDienThoai { get; set; }
        [DisplayName("nhà cung cấp")]
        public int Nhacc{ get; set; }
    }
}
