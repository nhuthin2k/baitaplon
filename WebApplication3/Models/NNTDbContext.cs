﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication3.Models
{
    public partial class NNTDbContext : DbContext
    {
        public NNTDbContext()
            : base("name=NNTDbContext")
        { }



        public DbSet<NhaCC> NhaCCs { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhapKho> NhapKhos { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<PhieuXuat> PhieuXuats { get; set; }
        public DbSet<TonKho> TonKhos { get; set; }
        public DbSet<XuatKho> XuatKhos { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }


      

    }
}
