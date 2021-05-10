namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nhaccs")]
    public partial class NhaCC
    {
        [Key]
        [StringLength(50)]
        [DisplayName("mã nhà cung cap")]
        public string Ma { get; set; }
        [DisplayName("tên nhà cung cap")]
        [StringLength(50)]
        public string TenNCC { get; set; }
       
        [StringLength(11)]
        public string SoDienThoai { get; set; }
      
    }
}
