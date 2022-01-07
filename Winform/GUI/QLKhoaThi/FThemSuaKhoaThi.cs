using System;
using System.Windows.Forms;
using Winform.BIZ;
using Winform.DAL;

namespace Winform.GUI.QLKhoaThi
{
    public partial class FThemSuaKhoaThi : Form
    {
        KhoaThiDAL khoaThiDAL = new KhoaThiDAL();
        private int maKhoaThi;
        private bool isThem = true;
        private bool isSuccess = false;

        public bool Saved
        {
            get { return isSuccess; }
        }

        public FThemSuaKhoaThi()
        {
            InitializeComponent();
            Text = "Thêm khoá thi";
            textBox1.Text = "";
            dateTimePicker1.MinDate = DateTime.Now;
        }

        public FThemSuaKhoaThi(KhoaThi khoaThi)
        {
            InitializeComponent();
            isThem = false;
            Text = String.Format("Sửa khoá thi {0}", khoaThi.MaKhoaThi);
            maKhoaThi = khoaThi.MaKhoaThi;
            textBox1.Text = khoaThi.TenKhoa;
            dateTimePicker1.Value = khoaThi.NgayThi;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // getData
            string tenKhoaThi = textBox1.Text.Trim();
            DateTime ngayThi = dateTimePicker1.Value;


            // validate
            if (string.IsNullOrEmpty(tenKhoaThi))
            {
                MessageBox.Show("Các trường không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = textBox1;
            }
            else
            {
                // query
                KhoaThi khoaThi = new KhoaThi
                {
                    TenKhoa = tenKhoaThi,
                    NgayThi = ngayThi
                };

                if (isThem)
                {
                    if (isSuccess = khoaThiDAL.Them(khoaThi))
                        MessageBox.Show("Thêm khoá thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm khoá thi thất bại, vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    khoaThi.MaKhoaThi = maKhoaThi;
                    if (isSuccess = khoaThiDAL.Sua(khoaThi))
                        MessageBox.Show("Sửa khoá thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Dữ liệu khoá thi không đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
        }

        private void FThemSuaKhoaThi_Load(object sender, EventArgs e)
        {
            ActiveControl = textBox1;
        }
    }
}
