using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Winform.BIZ;
using Winform.DAL;

namespace Winform.GUI.QLKhoaThi
{
    public partial class FKhoaThi : Form
    {
        private readonly int LEAST = 30;
        KhoaThiDAL khoaThiDAL;
        List<KhoaThi> khoaThis;
        List<PhongThi> phongThis;
        List<DuThi> duThis;
        int khoaThiIndex;
        int phongThiIndex;
        int duThiIndex;

        public FKhoaThi()
        {
            InitializeComponent();
            khoaThiDAL = new KhoaThiDAL();
            khoaThis = new List<KhoaThi>();
            phongThis = new List<PhongThi>();
            duThis = new List<DuThi>();
            khoaThiIndex = -1;
            phongThiIndex = -1;
            duThiIndex = -1;
        }

        private void FKhoaThi_Load(object sender, EventArgs e)
        {
            getKhoaThis();
        }

        private void getKhoaThis()
        {
            try
            {
                khoaThis = khoaThiDAL.DanhSachKhoaThi();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = khoaThis;
                dataGridView1.Columns["khoaThiChotSo"].DataPropertyName = "ChotSo";
                dataGridView1.Columns["tenKhoa"].DataPropertyName = "TenKhoa";
                dataGridView1.Columns["ngayThi"].DataPropertyName = "NgayThi";
                FMain.SetVisible(new List<Button>() { btnSuaKhoaThi, btnChotKhoaThi, btnXoaKhoaThi }, false);
            }
            catch
            {
                MessageBox.Show("Lấy dữ liệu khoá thi không thành công, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemKhoaThi_Click(object sender, EventArgs e)
        {
            FThemSuaKhoaThi fThemSuaKhoaThi = new FThemSuaKhoaThi();
            fThemSuaKhoaThi.ShowDialog();
            if (fThemSuaKhoaThi.Saved)
            {
                getKhoaThis();
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
            }
        }

        private void btnSuaKhoaThi_Click(object sender, EventArgs e)
        {
            FThemSuaKhoaThi fThemSuaKhoaThi = new FThemSuaKhoaThi(khoaThis[khoaThiIndex]);
            fThemSuaKhoaThi.ShowDialog();
            if (fThemSuaKhoaThi.Saved)
            {
                getKhoaThis();
                dataGridView1.Rows[khoaThiIndex].Selected = true;
            }
        }
        private void btnChotKhoaThi_Click(object sender, EventArgs e)
        {
            List<DuThi> duThisB1 = duThis.FindAll(i => i.MaTrinhDo == 1);
            int countB1 = duThisB1.Count;
            List<DuThi> duThisA2 = duThis.FindAll(i => i.MaTrinhDo == 2);
            int countA2 = duThisA2.Count;

            if (countA2 == 0 && countB1 == 0)
            {
                MessageBox.Show("Không có thí sinh dự thi, không thể chốt khoá thi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool flag = true;
            if (countB1 > 0 && countB1 < LEAST)
            {
                flag = false;
                MessageBox.Show("Danh sách thí sinh B1 không đủ chỉ tiêu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (countA2 > 0 && countA2 < LEAST)
            {
                flag = false;
                MessageBox.Show("Danh sách thí sinh A2 không đủ chỉ tiêu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (flag)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn chốt khoá thi không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    if (khoaThiDAL.chotSo(khoaThis[khoaThiIndex]))
                    {
                        khoaThiDAL.createRoom(khoaThis[khoaThiIndex].MaKhoaThi, LEAST, countA2, countB1);
                        khoaThiDAL.addCandidates(khoaThis[khoaThiIndex].PhongThis.ToList(), LEAST, duThisA2, duThisB1);
                        khoaThiDAL.addTeachesIntoRoom(khoaThis[khoaThiIndex].PhongThis.ToList());
                        getKhoaThis();
                        getDataPhongThi();
                        dataGridView1.Rows[khoaThiIndex].Selected = true;
						FMain.SetVisible(btnThemDuThi, false);
                        MessageBox.Show("Khoá thi đã được chốt, tạo phòng thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thao tác thất bại, vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnXoaKhoaThi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá khoá thi không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (khoaThiDAL.Xoa(khoaThis[khoaThiIndex]))
                {
                    getKhoaThis();
                    dataGridView2.DataSource = null;
                    dataGridView3.DataSource = null;
                    khoaThiIndex = -1;
                    MessageBox.Show("Khoá thi đã được xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thao tác thất bại, vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnThemGiaoVien_Click(object sender, EventArgs e)
        {
            new FThemGiaoVien();
        }

        private void getDataDuThi()
        {
            duThis = khoaThiDAL.DanhSachDuThi(khoaThis[khoaThiIndex]);
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.DataSource = duThis;
            dataGridView3.Columns["CCCD"].DataPropertyName = "CCCD";
            dataGridView3.Columns["nguoiDung"].DataPropertyName = "NguoiDung";
            dataGridView3.Columns["trinhDoDuThi"].DataPropertyName = "TrinhDo";
            duThiIndex = -1;
            FMain.SetVisible(btnXoaThiSinhDuThi, false);
        }
        private void getDataPhongThi()
        {
            phongThis = khoaThiDAL.DanhSachPhongThi(khoaThis[khoaThiIndex]);
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = phongThis;
            dataGridView2.Columns["phongThiChotSo"].DataPropertyName = "ChotSo";
            dataGridView2.Columns["tenPhong"].DataPropertyName = "TenPhong";
            dataGridView2.Columns["trinhDo"].DataPropertyName = "TrinhDo";
            phongThiIndex = -1;
            FMain.SetVisible(btnChiTietPhong, false);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex != khoaThiIndex)
            {
                khoaThiIndex = e.RowIndex;
                getDataDuThi();
                getDataPhongThi();

                bool isOpen = !khoaThis[khoaThiIndex].ChotSo;
                FMain.SetVisible(new List<Button>()
                {
                    btnSuaKhoaThi,
                    btnThemDuThi,
                    btnChotKhoaThi,
                    btnXoaKhoaThi
                }
                , isOpen);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex != phongThiIndex)
            {
                phongThiIndex = e.RowIndex;
                FMain.SetVisible(btnChiTietPhong, true);
            }
        }

        private void btnChiTietPhong_Click(object sender, EventArgs e)
        {
            FMain.GetPage(new FPhongThi(phongThis[phongThiIndex]));
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex != duThiIndex)
            {
                duThiIndex = e.RowIndex;
                FMain.SetVisible(btnXoaThiSinhDuThi, !khoaThis[khoaThiIndex].ChotSo);
            }
        }

        private void btnXoaThiSinhDuThi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá thí sinh này khỏi danh sách dự thi không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (khoaThiDAL.XoaThiSinhDuThi(duThis[duThiIndex]))
                {
                    getDataDuThi();
                    MessageBox.Show("Thí sinh đã được xoá khỏi danh sách dự thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thao tác thất bại, vui lòng kiểm tra lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemDuThi_Click(object sender, EventArgs e)
        {
            FThemDuThi fThemDuThi = new FThemDuThi(khoaThis[khoaThiIndex].MaKhoaThi);
            fThemDuThi.ShowDialog();
            if (fThemDuThi.Saved) getDataDuThi();
        }
    }
}
