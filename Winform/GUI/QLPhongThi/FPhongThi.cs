using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Winform.BIZ;
using Winform.DAL;

namespace Winform.GUI.QLKhoaThi
{
    public partial class FPhongThi : Form
    {
        PhongThiDAL phongThiDAL;
        PhongThi phongThi;
        List<ThiSinh> thiSinhs;
        List<GiamThi> giamThis;
        int giamThiIndex;

        public FPhongThi(PhongThi phongThi)
        {
            InitializeComponent();
            this.phongThi = phongThi;
            phongThiDAL = new PhongThiDAL(phongThi);
            thiSinhs = new List<ThiSinh>();
            giamThis = new List<GiamThi>();
            giamThiIndex = -1;
        }

        private void FPhongThi_Load(object sender, EventArgs e)
        {
            FMain.SetVisible(new List<Button>() { btnSave, btnChotPhongThi }, !phongThi.ChotSo);
            lbTitle.Text = String.Format("{0} | Phòng thi: {1}", phongThi.KhoaThi.TenKhoa, phongThi.TenPhong);
            getDataGiamThi();
            getDataThiSinh();
            getDataThongTinChung();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FMain.GetPage(new FKhoaThi());
        }

        //
        // getDataThiSinh
        //
        private void getDataThiSinh()
        {
            try
            {
                thiSinhs = phongThiDAL.DanhSachThiSinh();
                dataGridView2.AutoGenerateColumns = false;
                dataGridView2.DataSource = thiSinhs;
                dataGridView2.Columns["SBD"].DataPropertyName = "SBD";
                dataGridView2.Columns["CCCD"].DataPropertyName = "CCCD";
                dataGridView2.Columns["nguoiDung"].DataPropertyName = "NguoiDung";
                dataGridView2.Columns["doc"].DataPropertyName = "DiemDoc";
                dataGridView2.Columns["nghe"].DataPropertyName = "DiemNghe";
                dataGridView2.Columns["noi"].DataPropertyName = "DiemNoi";
                dataGridView2.Columns["viet"].DataPropertyName = "DiemViet";
            }
            catch
            {
                MessageBox.Show("Lấy dữ liệu thí sinh không thành công, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //
        // getDataGiamThi
        //
        private void getDataGiamThi()
        {
            try
            {
                giamThis = phongThiDAL.DanhSachGiamThi();
                dataGridView3.AutoGenerateColumns = false;
                dataGridView3.DataSource = giamThis;
                dataGridView3.Columns["giaoVien"].DataPropertyName = "GiaoVien";
                dataGridView3.Columns["nhiemVu"].DataPropertyName = "NhiemVu";
                FMain.SetVisible(btnNhiemVu, false);
            }
            catch
            {
                MessageBox.Show("Lấy dữ liệu giám thị không thành công, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //
        // getDataThongTinChung
        //
        private void getDataThongTinChung()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add(new string[] { "Trạng thái chốt sổ", phongThi.ChotSo ? "Đã chốt sổ" : "Chưa chốt sổ" });
            dataGridView1.Rows.Add(new string[] { "Sĩ số", thiSinhs.Count.ToString() });

        }
        private void btnChotPhongThi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn chốt điểm phòng thi không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (phongThiDAL.ChotSo())
                {
                    phongThi.ChotSo = true;
                    FMain.SetVisible(new List<Button>() { btnSave, btnChotPhongThi, btnNhiemVu }, false);
                    getDataThongTinChung();
                    MessageBox.Show("Điểm phòng thi đã được chốt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thao tác thất bại, vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = true;
            if (!phongThi.ChotSo)
                switch (e.ColumnIndex)
                {
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                        e.Cancel = false;
                        break;
                }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận lưu dữ liệu?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (phongThiDAL.LuuDiem(thiSinhs))
                    MessageBox.Show("Điểm phòng thi đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Dữ liệu không thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                giamThiIndex = e.RowIndex;
                FMain.SetVisible(btnNhiemVu, !phongThi.ChotSo);
            }
        }

        private void btnNhiemVu_Click(object sender, EventArgs e)
        {
            FNhiemVu fNhiemVu = new FNhiemVu(giamThis[giamThiIndex]);
            if (fNhiemVu.Saved) getDataGiamThi();
        }
    }
}
