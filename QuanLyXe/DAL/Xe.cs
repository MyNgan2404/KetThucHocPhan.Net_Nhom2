namespace QuanLyXe.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xe")]
    public partial class Xe
    {
        [Key]
        public long MaXe { get; set; }

        [StringLength(50)]
        public string NhaXe { get; set; }

        [StringLength(50)]
        public string BienSo { get; set; }

        [StringLength(50)]
        public string TaiXe { get; set; }

        [StringLength(50)]
        public string LoaiXe { get; set; }

        public string TinhTrang { get; set; }
    }
}
