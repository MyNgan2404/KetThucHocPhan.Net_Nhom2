using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyXe.DAL
{
    public partial class QLXeModel : DbContext
    {
        public QLXeModel()
            : base("name=AppConnectionString")
        {
        }

        public virtual DbSet<Xe> Xes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
