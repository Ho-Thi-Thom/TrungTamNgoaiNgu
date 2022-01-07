using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Winform.BIZ;
using Winform.DAL;

namespace Winform.GUI.QLNguoiDung
{
    public partial class FKetQuaThi : Form
    {
        NguoiDung nguoiDung;
        public FKetQuaThi(NguoiDung nguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            lblCCCD.Text = nguoiDung.CCCD;
            lblEmail.Text = nguoiDung.Email;
            lblHoTen.Text = String.Format("{0} {1}", nguoiDung.HoNguoiDung, nguoiDung.TenNguoiDung);
            lblNgaySinh.Text = nguoiDung.NgaySinh.ToShortDateString();
            lblNoiSinh.Text = nguoiDung.NoiSinh;
            ShowDialog();
        }
        private void FKetQuaThi_Load(object sender, EventArgs e)
        {
            List<KetQuaThi> ketQuaThis = new NguoiDungDAL().DanhSachKetQuaThi(nguoiDung);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ketQuaThis;
            dataGridView1.Columns["khoaThi"].DataPropertyName = "KhoaThi";
            dataGridView1.Columns["phongThi"].DataPropertyName = "PhongThi";
            dataGridView1.Columns["sbd"].DataPropertyName = "SBD";
            dataGridView1.Columns["nghe"].DataPropertyName = "DiemNghe";
            dataGridView1.Columns["noi"].DataPropertyName = "DiemNoi";
            dataGridView1.Columns["doc"].DataPropertyName = "DiemDoc";
            dataGridView1.Columns["viet"].DataPropertyName = "DiemViet";
            lblSoLanThi.Text = ketQuaThis.Count.ToString();
        }
    }
}
