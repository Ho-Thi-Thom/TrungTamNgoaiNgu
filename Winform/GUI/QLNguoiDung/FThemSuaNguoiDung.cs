using System;
using System.Windows.Forms;
using Winform.BIZ;
using Winform.DAL;

namespace Winform.GUI.QLNguoiDung
{
    public partial class FThemSuaNguoiDung : Form
    {
        NguoiDungDAL nguoiDungDAL;
        private bool isSuccess;
        private bool isThem;

        public bool Saved
        {
            get { return isSuccess; }
        }

        public FThemSuaNguoiDung()
        {
            InitializeComponent();
            init();
            Text = "Thêm người dùng";
            radioButton1.Checked = true;
        }

        public FThemSuaNguoiDung(NguoiDung nguoiDung)
        {
            InitializeComponent();
            init();
            isThem = false;
            textBox1.Enabled = false;
            Text = "Cập nhật thông tin người dùng";
            textBox1.Text = nguoiDung.CCCD;
            textBox2.Text = nguoiDung.NoiCap;
            dateTimePicker1.Value = nguoiDung.NgayCap;
            textBox3.Text = nguoiDung.HoNguoiDung;
            textBox4.Text = nguoiDung.TenNguoiDung;
            textBox5.Text = nguoiDung.SoDienThoai;
            if (nguoiDung.GioiTinh == true)
                radioButton1.Checked = true;
            else radioButton2.Checked = true;
            textBox6.Text = nguoiDung.Email;
            dateTimePicker2.Value = nguoiDung.NgaySinh;
            textBox7.Text = nguoiDung.NoiSinh;
        }
        private void init()
        {
            nguoiDungDAL = new NguoiDungDAL();
            isSuccess = false;
            isThem = true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FThemSuaNguoiDung_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker2.MaxDate = DateTime.Now;
            if (isThem)
                ActiveControl = textBox1;
            else
                ActiveControl = dateTimePicker1;

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string CCCD = textBox1.Text.Trim();
            string noiCap = textBox2.Text.Trim();
            DateTime ngayCap = dateTimePicker1.Value;
            string ho = textBox3.Text.Trim();
            string ten = textBox4.Text.Trim();
            string SDT = textBox5.Text;
            bool gioiTinh = radioButton1.Checked;
            string email = textBox6.Text.Trim();
            DateTime ngaySinh = dateTimePicker2.Value;
            string noiSinh = textBox7.Text.Trim();

            if (string.IsNullOrEmpty(CCCD) || string.IsNullOrEmpty(noiCap) || string.IsNullOrEmpty(ho) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(SDT) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(noiSinh))
            {
                MessageBox.Show("Cần nhập đầy đủ thông tin tất cả các trường!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (string.IsNullOrEmpty(CCCD)) ActiveControl = textBox1;
                else if (string.IsNullOrEmpty(noiCap)) ActiveControl = textBox2;
                else if (string.IsNullOrEmpty(ho)) ActiveControl = textBox3;
                else if (string.IsNullOrEmpty(ten)) ActiveControl = textBox4;
                else if (string.IsNullOrEmpty(SDT)) ActiveControl = textBox5;
                else if (string.IsNullOrEmpty(email)) ActiveControl = textBox6;
                else ActiveControl = textBox7;
            }
            else if (CCCD.Length != 12 && CCCD.Length != 9)
            {
                MessageBox.Show("Căn cước công dân không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = textBox1;
            }
            else if (SDT.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ActiveControl = textBox5;
            }
            else
            {
                NguoiDung nguoiDung = new NguoiDung
                {
                    CCCD = CCCD,
                    NoiCap = noiCap,
                    NgayCap = ngayCap,
                    HoNguoiDung = ho,
                    TenNguoiDung = ten,
                    SoDienThoai = SDT,
                    GioiTinh = gioiTinh,
                    Email = email,
                    NgaySinh = ngaySinh,
                    NoiSinh = noiSinh
                };

                if (isThem)
                {
                    if (isSuccess = nguoiDungDAL.Them(nguoiDung))
                        MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm người dùng thất bại, vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (isSuccess = nguoiDungDAL.Sua(nguoiDung))
                        MessageBox.Show("Cập nhật thông tin người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thông tin người dùng không có sự thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
        }
    }
}
