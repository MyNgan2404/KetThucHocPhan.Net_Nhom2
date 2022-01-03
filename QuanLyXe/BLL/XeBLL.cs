using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyXe.DAL;

namespace QuanLyXe.BLL
{
    internal class XeBLL
    {
        public static List<Xe> GetList()
        {
            QLXeModel model = new QLXeModel();
            var ls = model.Xes.ToList();
            return ls;
        }
        public static bool Delete(long idMaXe)
        {
            QLXeModel model = new QLXeModel();
            var xe = model.Xes.Where(e => e.MaXe == idMaXe).FirstOrDefault();

            model.Xes.Remove(xe);
            model.SaveChanges();
            return true;


        }
    }
}
