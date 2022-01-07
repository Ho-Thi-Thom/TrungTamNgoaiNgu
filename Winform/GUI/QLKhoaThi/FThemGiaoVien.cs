using System;
using System.Windows.Forms;
using Winform.BIZ;
using Winform.DAL;

namespace Winform.GUI.QLKhoaThi
{
    public partial class FThemGiaoVien : Form
    {
        public FThemGiaoVien()
        {
            InitializeComponent();
            ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // getData
            string ho = textBox1.Text.Trim();
            string ten = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(ho))
            {
                MessageBox.Show("Trường họ không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = textBox1;
            }
            else if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Trường tên không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = textBox2;
            }
            else
            {
                GiaoVien giaoVien = new GiaoVien
                {
                    HoGiaoVien = ho,
                    TenGiaoVien = ten
                };

                if (new KhoaThiDAL().ThemGiaoVien(giaoVien))
                    MessageBox.Show("Thêm giáo viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Thêm giáo viên thất bại, vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void FThemGiaoVien_Load(object sender, EventArgs e)
        {
            ActiveControl = textBox1;
        }
    }
}
