using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyXe.BLL;
using QuanLyXe.DAL;

namespace QuanLyXe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapXe();
        }

        void NapXe()
        {
            var ls = XeBLL.GetList();
            xeBindingSource.DataSource = ls;
            dataGridView1.DataSource = xeBindingSource;
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            var xe = xeBindingSource.Current as Xe;
            
            if (xe != null)
            {
                var rs = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    XeBLL.Delete(xe.MaXe);
                    xeBindingSource.RemoveCurrent();
                    MessageBox.Show("Đã xóa xe thành công", "Thông báo");
                }        

            }
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            var f = new FrmXeChiTiet();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapXe();
            }
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            var xe = xeBindingSource.Current as Xe;
            if (xe != null)
            {
                var f = new FrmXeChiTiet(xe);
                var rs = f.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    NapXe();
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string searchValue = txtFind.Text.ToLower();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            int rowIndex = row.Index;
                            dataGridView1.Rows[rowIndex].Selected = false;
                        }

                    }

                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && !string.IsNullOrEmpty(searchValue)
                            && row.Cells[i].Value.ToString().ToLower().Contains(searchValue))
                        {
                            int rowIndex = row.Index;
                            dataGridView1.Rows[rowIndex].Selected = true;
                            break;
                        }

                    }

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
