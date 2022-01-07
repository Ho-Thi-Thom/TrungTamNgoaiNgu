using System.Collections.Generic;
using System.Linq;
using Winform.BIZ;

namespace Winform.DAL
{
    class PhongThiDAL
    {
        TrungTamNgoaiNguEntities db;
        private readonly PhongThi phongThi;

        public PhongThiDAL()
        {

        }
        public PhongThiDAL(PhongThi phongThi)
        {
            this.phongThi = phongThi;
        }


        public List<PhongThi> DanhSachPhongThi()
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from pt in db.PhongThis
                     orderby pt.MaPhong descending
                     select pt;

            return qr.ToList();
        }

        public List<PhongThi> PhongThiComboBox()
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from pt in db.PhongThis
                     orderby pt.TenPhong
                     select pt;

            return qr.ToList();
        }
        public List<ThiSinh> DanhSachThiSinh()
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from ts in db.ThiSinhs
                     orderby ts.SBD
                     where ts.MaPhong == phongThi.MaPhong
                     select ts;

            return qr.ToList();
        }
        public List<GiamThi> DanhSachGiamThi()
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from gt in db.GiamThis
                     orderby gt.GiaoVien.TenGiaoVien
                     where gt.MaPhong == phongThi.MaPhong
                     select gt;

            return qr.ToList();
        }

        public bool ChotSo()
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from pt in db.PhongThis
                     where pt.MaPhong == phongThi.MaPhong
                     select pt;

            foreach (PhongThi pt in qr)
            {
                pt.ChotSo = true;
            }

            return db.SaveChanges() > 0;
        }

        public bool LuuDiem(List<ThiSinh> thiSinhs)
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from ts in db.ThiSinhs
                     where ts.MaPhong == phongThi.MaPhong
                     select ts;

            foreach (ThiSinh ts in qr)
            {
                ThiSinh thiSinh = thiSinhs.Find(i => i.SBD == ts.SBD);
                ts.DiemDoc = thiSinh.DiemDoc;
                ts.DiemNghe = thiSinh.DiemNghe;
                ts.DiemNoi = thiSinh.DiemNoi;
                ts.DiemViet = thiSinh.DiemViet;
            }

            return db.SaveChanges() > 0;
        }
    }
}
