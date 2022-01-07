using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Winform.DAL;

namespace Winform.GUI.QLKhoaThi
{
    public partial class FThemDuThi : Form
    {
        private bool isSuccess = false;
        private int maKhoaThi;
        private KhoaThiDAL khoaThiDAL;
        public bool Saved
        {
            get { return isSuccess; }
        }
        public FThemDuThi(int maKhoaThi)
        {
            InitializeComponent();
            khoaThiDAL = new KhoaThiDAL();
            this.maKhoaThi = maKhoaThi;
        }
        private void FThemDuThi_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            DataGridViewCheckBoxColumn col1 = new DataGridViewCheckBoxColumn();
            col1.Width = 50;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Insert(0, col1);
            dataGridView1.DataSource = khoaThiDAL.DanhSachNguoiDungNgoaiKhoaThi(maKhoaThi);
            dataGridView1.Columns["CCCD"].DataPropertyName = "CCCD";
            dataGridView1.Columns["ho"].DataPropertyName = "HoNguoiDung";
            dataGridView1.Columns["ten"].DataPropertyName = "TenNguoiDung";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int trinhDo = radioButton1.Checked ? 1 : 2;
            List<string> CCCDs = new List<string>();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                    CCCDs.Add(Convert.ToString(dataGridView1.Rows[i].Cells[1].Value));
            }
            if (isSuccess = khoaThiDAL.ThemThiSinhDuThi(maKhoaThi, CCCDs, trinhDo))
                MessageBox.Show("Thêm danh sách dự thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm danh sách dự thi thất bại, vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Close();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex != 0) e.Cancel = true;
        }
    }
}
