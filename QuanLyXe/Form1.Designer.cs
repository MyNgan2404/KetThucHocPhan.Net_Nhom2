namespace QuanLyXe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhaXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bienSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiXeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bttEdit = new System.Windows.Forms.ToolStripButton();
            this.bttDelete = new System.Windows.Forms.ToolStripButton();
            this.bttAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maXeDataGridViewTextBoxColumn,
            this.nhaXeDataGridViewTextBoxColumn,
            this.bienSoDataGridViewTextBoxColumn,
            this.taiXeDataGridViewTextBoxColumn,
            this.loaiXeDataGridViewTextBoxColumn,
            this.tinhTrangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.xeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(833, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // maXeDataGridViewTextBoxColumn
            // 
            this.maXeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maXeDataGridViewTextBoxColumn.DataPropertyName = "MaXe";
            this.maXeDataGridViewTextBoxColumn.HeaderText = "MaXe";
            this.maXeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maXeDataGridViewTextBoxColumn.Name = "maXeDataGridViewTextBoxColumn";
            this.maXeDataGridViewTextBoxColumn.Width = 71;
            // 
            // nhaXeDataGridViewTextBoxColumn
            // 
            this.nhaXeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nhaXeDataGridViewTextBoxColumn.DataPropertyName = "NhaXe";
            this.nhaXeDataGridViewTextBoxColumn.FillWeight = 200F;
            this.nhaXeDataGridViewTextBoxColumn.HeaderText = "NhaXe";
            this.nhaXeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nhaXeDataGridViewTextBoxColumn.Name = "nhaXeDataGridViewTextBoxColumn";
            this.nhaXeDataGridViewTextBoxColumn.Width = 77;
            // 
            // bienSoDataGridViewTextBoxColumn
            // 
            this.bienSoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bienSoDataGridViewTextBoxColumn.DataPropertyName = "BienSo";
            this.bienSoDataGridViewTextBoxColumn.HeaderText = "BienSo";
            this.bienSoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bienSoDataGridViewTextBoxColumn.Name = "bienSoDataGridViewTextBoxColumn";
            this.bienSoDataGridViewTextBoxColumn.Width = 80;
            // 
            // taiXeDataGridViewTextBoxColumn
            // 
            this.taiXeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.taiXeDataGridViewTextBoxColumn.DataPropertyName = "TaiXe";
            this.taiXeDataGridViewTextBoxColumn.HeaderText = "TaiXe";
            this.taiXeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.taiXeDataGridViewTextBoxColumn.Name = "taiXeDataGridViewTextBoxColumn";
            this.taiXeDataGridViewTextBoxColumn.Width = 72;
            // 
            // loaiXeDataGridViewTextBoxColumn
            // 
            this.loaiXeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loaiXeDataGridViewTextBoxColumn.DataPropertyName = "LoaiXe";
            this.loaiXeDataGridViewTextBoxColumn.HeaderText = "LoaiXe";
            this.loaiXeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loaiXeDataGridViewTextBoxColumn.Name = "loaiXeDataGridViewTextBoxColumn";
            this.loaiXeDataGridViewTextBoxColumn.Width = 78;
            // 
            // tinhTrangDataGridViewTextBoxColumn
            // 
            this.tinhTrangDataGridViewTextBoxColumn.DataPropertyName = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.HeaderText = "TinhTrang";
            this.tinhTrangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tinhTrangDataGridViewTextBoxColumn.Name = "tinhTrangDataGridViewTextBoxColumn";
            this.tinhTrangDataGridViewTextBoxColumn.Width = 125;
            // 
            // xeBindingSource
            // 
            this.xeBindingSource.DataSource = typeof(QuanLyXe.DAL.Xe);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ XE Ở BẾN XE";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bttEdit,
            this.bttDelete,
            this.bttAdd});
            this.toolStrip1.Location = new System.Drawing.Point(467, 95);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(314, 32);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bttEdit
            // 
            this.bttEdit.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEdit.ForeColor = System.Drawing.Color.Gray;
            this.bttEdit.Image = ((System.Drawing.Image)(resources.GetObject("bttEdit.Image")));
            this.bttEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(110, 29);
            this.bttEdit.Text = "Chỉnh sửa";
            this.bttEdit.ToolTipText = "Chỉnh Sửa";
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // bttDelete
            // 
            this.bttDelete.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDelete.ForeColor = System.Drawing.Color.Red;
            this.bttDelete.Image = ((System.Drawing.Image)(resources.GetObject("bttDelete.Image")));
            this.bttDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttDelete.Name = "bttDelete";
            this.bttDelete.Padding = new System.Windows.Forms.Padding(1);
            this.bttDelete.Size = new System.Drawing.Size(90, 29);
            this.bttDelete.Text = "Xóa Xe";
            this.bttDelete.Click += new System.EventHandler(this.bttDelete_Click);
            // 
            // bttAdd
            // 
            this.bttAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bttAdd.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bttAdd.Image = ((System.Drawing.Image)(resources.GetObject("bttAdd.Image")));
            this.bttAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(101, 29);
            this.bttAdd.Text = "Thêm Xe";
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtFind,
            this.btnFind});
            this.toolStrip2.Location = new System.Drawing.Point(13, 100);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(194, 27);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(150, 27);
            // 
            // btnFind
            // 
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(29, 24);
            this.btnFind.Text = "toolStripButton1";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 461);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xeBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource xeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bienSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiXeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bttEdit;
        private System.Windows.Forms.ToolStripButton bttDelete;
        private System.Windows.Forms.ToolStripButton bttAdd;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripTextBox txtFind;
        private System.Windows.Forms.ToolStripButton btnFind;
    }
}

