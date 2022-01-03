using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyXe.DAL;
using QuanLyXe.BLL;

namespace QuanLyXe
{
    public partial class FrmXeChiTiet : Form
    {
        Xe xe;
        public FrmXeChiTiet(Xe xe = null)
        {
            InitializeComponent();
            this.xe = xe;          
            if (xe == null)
            {
                //Thêm mới
                this.Text = "Thêm mới thông tin xe";
            }
            else
            {
                //cập nhật
                this.Text = "Chỉnh sửa thông tin xe";
                txtNhaXe.Text = xe.NhaXe;
                txtBienSo.Text = xe.BienSo;
                txtTaiXe.Text = xe.TaiXe;
                txtLoaiXe.Text = xe.LoaiXe;
                txtTinhTrang.Text = xe.TinhTrang;

            }
        }

        private bool CheckAddXe()
        {
            var nhaXe = txtNhaXe.Text;
            var bienSo = txtBienSo.Text;
            var loaiXe = txtLoaiXe.Text;
            var tinhTrang = txtTinhTrang.Text;

            if (string.IsNullOrEmpty(nhaXe)){
                MessageBox.Show("Bạn cần nhập nhà xe", "Thông báo");
                return false;
            }
            else if (string.IsNullOrEmpty(bienSo)){
                MessageBox.Show("Bạn cần nhập biển số", "Thông báo");
                return false;
            }
            else if (string.IsNullOrEmpty(loaiXe)){
                MessageBox.Show("Bạn cần nhập loại xe", "Thông báo");
                return false;
            }
            else if (string.IsNullOrEmpty(tinhTrang)){
                MessageBox.Show("Bạn cần nhập tình trạng", "Thông báo");
                return false;
            }

            return true;
        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            if (!CheckAddXe())
                return;

            var nhaXe = txtNhaXe.Text;
            var bienSo = txtBienSo.Text;
            var taiXe = txtTaiXe.Text;
            var loaiXe = txtLoaiXe.Text;
            var tinhTrang = txtTinhTrang.Text;
          
            if (this.xe == null)
            {
                var xe = new Xe

                {
                    
                    NhaXe = nhaXe,
                    BienSo = bienSo,
                    TaiXe = taiXe,
                    LoaiXe = loaiXe,
                    TinhTrang = tinhTrang,

            };
                var db = new QLXeModel();
                db.Xes.Add(xe);
                db.SaveChanges();

                // Đóng form sau khi lưu vào csdl
                DialogResult = DialogResult.OK;
            }
            else
            {
                var an = new QLXeModel();

                xe = an.Xes.Where(t => t.MaXe == xe.MaXe).FirstOrDefault();
                xe.NhaXe = nhaXe;
                xe.BienSo = bienSo;
                xe.TaiXe = taiXe;
                xe.LoaiXe = loaiXe;
                xe.TinhTrang = tinhTrang;

                an.SaveChanges();
                DialogResult = DialogResult.OK;
            }
        }

        private void bttHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

