using System;
using System.Windows.Forms;
using Winform.BIZ;
using Winform.DAL;

namespace Winform.GUI.QLKhoaThi
{
    public partial class FNhiemVu : Form
    {
        GiamThi giamThi;
        private bool isSuccess = false;
        public bool Saved { get { return isSuccess; } }
        public FNhiemVu(GiamThi giamThi)
        {
            InitializeComponent();
            this.giamThi = giamThi;
            ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            giamThi.NhiemVu = textBox1.Text.Trim();

            if (isSuccess = new KhoaThiDAL().CapNhatNhiemVu(giamThi))
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Dữ liệu không thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void FThemGiaoVien_Load(object sender, EventArgs e)
        {
            ActiveControl = textBox1;
            textBox1.Text = giamThi.NhiemVu;
        }
    }
}
