using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Winform.BIZ;
using Winform.DAL;

namespace Winform.GUI.QLNguoiDung
{
    public partial class FNguoiDung : Form
    {
        NguoiDungDAL nguoiDungDAL;
        List<NguoiDung> nguoiDungs;
        List<NguoiDung> nguoiDungsTemp;
        List<KhoaThi> khoaThis;
        int nguoiDungIndex;

        public FNguoiDung()
        {
            InitializeComponent();
            nguoiDungDAL = new NguoiDungDAL();
            nguoiDungs = new List<NguoiDung>();
            nguoiDungsTemp = new List<NguoiDung>();
            khoaThis = new List<KhoaThi>();
            nguoiDungIndex = -1;
        }

        private void FNguoiDung_Load(object sender, EventArgs e)
        {
            getDataNguoiDung();

            // search
            textBoxSearch.GotFocus += new EventHandler(this.TextGotFocus);
            textBoxSearch.LostFocus += new EventHandler(this.TextLostFocus);
            getComboBoxSearch();
        }

        private void getDataNguoiDung()
        {
            try
            {
                nguoiDungs = nguoiDungDAL.DanhSachNguoiDung();
                nguoiDungsTemp = nguoiDungs;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = nguoiDungs;
                dataGridView1.Columns["CCCD"].DataPropertyName = "CCCD";
                dataGridView1.Columns["ho"].DataPropertyName = "HoNguoiDung";
                dataGridView1.Columns["ten"].DataPropertyName = "TenNguoiDung";
                dataGridView1.Columns["gioiTinh"].DataPropertyName = "GioiTinh";
                dataGridView1.Columns["ngaySinh"].DataPropertyName = "NgaySinh";
                dataGridView1.Columns["noiSinh"].DataPropertyName = "NoiSinh";
                dataGridView1.Columns["ngayCap"].DataPropertyName = "NgayCap";
                dataGridView1.Columns["noiCap"].DataPropertyName = "NoiCap";
                dataGridView1.Columns["sdt"].DataPropertyName = "SoDienThoai";
                dataGridView1.Columns["email"].DataPropertyName = "Email";
                FMain.SetVisible(new List<Button>() { btnDangKyDuThi, btnXemKetQuaThi, btnSua }, false);
            }
            catch
            {
                MessageBox.Show("Lấy dữ liệu người dùng không thành công, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            FThemSuaNguoiDung fThemSuaNguoiDung = new FThemSuaNguoiDung();
            fThemSuaNguoiDung.ShowDialog();
            if (fThemSuaNguoiDung.Saved)
            {
                getDataNguoiDung();
                nguoiDungIndex = -1;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FThemSuaNguoiDung fThemSuaNguoiDung = new FThemSuaNguoiDung(nguoiDungsTemp[nguoiDungIndex]);
            fThemSuaNguoiDung.ShowDialog();
            if (fThemSuaNguoiDung.Saved)
            {
                getDataNguoiDung();
                dataGridView1.Rows[nguoiDungIndex].Selected = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                nguoiDungIndex = e.RowIndex;
                FMain.SetVisible(new List<Button>() { btnDangKyDuThi, btnXemKetQuaThi, btnSua }, true);
            }
        }

        #region SEARCH
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            textBoxSearch.ForeColor = Color.Black;
            textBoxSearch.Focus();
            dataGridView1.DataSource = nguoiDungs;
            nguoiDungsTemp = nguoiDungs;
            nguoiDungIndex = -1;
            FMain.SetVisible(new List<Button>() { btnDangKyDuThi, btnXemKetQuaThi, btnSua }, false);
        }

        private string PLACEHOLDER = "Tìm kiếm thí sinh...";

        public void TextGotFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == PLACEHOLDER)
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = PLACEHOLDER;
                tb.ForeColor = Color.LightGray;
                dataGridView1.DataSource = nguoiDungs;
                nguoiDungsTemp = nguoiDungs;
                nguoiDungIndex = -1;
                FMain.SetVisible(new List<Button>() { btnDangKyDuThi, btnXemKetQuaThi, btnSua }, false);
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int index = comboBoxSearch.SelectedIndex;
                string text = textBoxSearch.Text.Trim().ToLower();
                if (index == -1)
                {
                    MessageBox.Show("Bạn chưa chọn điều kiện tìm kiếm, vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ActiveControl = comboBoxSearch;
                }
                else if (string.IsNullOrEmpty(text))
                {
                    MessageBox.Show("Bạn chưa nhập từ khoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ActiveControl = textBoxSearch;
                }
                else
                {
                    switch (index)
                    {
                        case 0: // tên
                            nguoiDungsTemp = nguoiDungs.FindAll(i => i.TenNguoiDung.ToLower().Contains(text));
                            break;
                        case 1: // số điện thoại
                            nguoiDungsTemp = nguoiDungs.FindAll(i => i.SoDienThoai.Contains(text));
                            break;
                    }
                    if (nguoiDungsTemp.Count != 0)
                        dataGridView1.DataSource = nguoiDungsTemp;
                    else
                        MessageBox.Show("Không tìm thấy kết quả nào cả!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //
        // comboBox search
        //
        private void getComboBoxSearch()
        {
            comboBoxSearch.Items.Add("Tên");
            comboBoxSearch.Items.Add("Số điện thoại");
            comboBoxSearch.SelectedIndex = -1;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                btnClearSearch.Visible = false;
            }
            else if (btnClearSearch.Visible == false) btnClearSearch.Visible = true;
        }
        #endregion

        private void btnXemKetQuaThi_Click(object sender, EventArgs e)
        {
            new FKetQuaThi(nguoiDungsTemp[nguoiDungIndex]);
        }

        private void btnDangKyDuThi_Click(object sender, EventArgs e)
        {
            new FDangKyDuThi(nguoiDungsTemp[nguoiDungIndex]);
        }
    }
}
