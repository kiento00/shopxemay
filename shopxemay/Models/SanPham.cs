namespace shopxemay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        public int MaSP { get; set; }

        [StringLength(200)]
        public string TenSP { get; set; }

        [StringLength(200)]
        public string MoTa1 { get; set; }

        public string MoTa2 { get; set; }

        public int? GiaBan { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public string Hinh { get; set; }

        public int? SolanMua { get; set; }

        public bool? TrangThai { get; set; }

        public int? TonKho { get; set; }

        public int? SPMoi { get; set; }

        public int? MaLoaiSP { get; set; }

        public int? MaNCC { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
