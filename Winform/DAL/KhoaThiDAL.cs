using System.Collections.Generic;
using System.Linq;
using Winform.BIZ;

namespace Winform.DAL
{
    class KhoaThiDAL
    {
        TrungTamNgoaiNguEntities db;

        public KhoaThiDAL() { }

        public List<KhoaThi> DanhSachKhoaThi()
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from kt in db.KhoaThis
                     orderby kt.MaKhoaThi descending
                     select kt;

            return qr.ToList();
        }
        public List<PhongThi> DanhSachPhongThi(KhoaThi khoaThi)
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from pt in db.PhongThis
                     orderby pt.MaKhoaThi descending
                     where pt.MaKhoaThi == khoaThi.MaKhoaThi
                     select pt;

            return qr.ToList();
        }
        public List<DuThi> DanhSachDuThi(KhoaThi khoaThi)
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from dt in db.DuThis
                     orderby dt.MaTrinhDo descending, dt.NguoiDung.TenNguoiDung
                     where dt.MaKhoaThi == khoaThi.MaKhoaThi
                     select dt;

            return qr.ToList();
        }
        public List<NguoiDung> DanhSachNguoiDungNgoaiKhoaThi(int maKhoaThi)
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from nd in db.NguoiDungs
                     orderby nd.TenNguoiDung descending
                     select nd;

            var qr2 = from dt in db.DuThis
                      where dt.MaKhoaThi == maKhoaThi
                      select dt.NguoiDung;

            return qr.Except(qr2).ToList();
        }
        public List<KhoaThi> KhoaThiComboBox(NguoiDung nguoiDung)
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from kt in db.KhoaThis
                     orderby kt.MaKhoaThi descending
                     where kt.ChotSo == false
                     select kt;

            var qr2 = from dt in db.DuThis
                      where dt.CCCD == nguoiDung.CCCD
                      select dt.KhoaThi;

            return qr.Except(qr2).ToList();
        }


        public bool Them(KhoaThi khoaThi)
        {
            db = new TrungTamNgoaiNguEntities();
            db.KhoaThis.Add(khoaThi);
            return db.SaveChanges() > 0;
        }
        public bool Sua(KhoaThi khoaThi)
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from kt in db.KhoaThis
                     where kt.MaKhoaThi == khoaThi.MaKhoaThi
                     select kt;

            foreach (KhoaThi kt in qr)
            {
                kt.TenKhoa = khoaThi.TenKhoa;
                kt.NgayThi = khoaThi.NgayThi;
                kt.ChotSo = false;
            }
            return db.SaveChanges() > 0;
        }
        public bool Xoa(KhoaThi khoaThi)
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from kt in db.KhoaThis
                     where kt.MaKhoaThi == khoaThi.MaKhoaThi
                     select kt;

            foreach (KhoaThi kt in qr)
            {
                db.KhoaThis.Remove(kt);
            }

            var qr2 = from dt in db.DuThis
                      where dt.MaKhoaThi == khoaThi.MaKhoaThi
                      select dt;

            foreach (DuThi dt in qr2)
            {
                db.DuThis.Remove(dt);
            }

            return db.SaveChanges() > 0;
        }
        public bool ThemThiSinhDuThi(int maKhoaThi, List<string> CCCDs, int maTrinhDo)
        {
            db = new TrungTamNgoaiNguEntities();
            foreach (string CCCD in CCCDs)
            {
                DuThi duThi = new DuThi
                {
                    MaKhoaThi = maKhoaThi,
                    CCCD = CCCD,
                    MaTrinhDo = maTrinhDo
                };
                db.DuThis.Add(duThi);
            }
            return db.SaveChanges() > 0;
        }
        public bool XoaThiSinhDuThi(DuThi duThi)
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from dt in db.DuThis
                     where dt.MaKhoaThi == duThi.MaKhoaThi && dt.CCCD == duThi.CCCD
                     select dt;

            foreach (DuThi dt in qr)
            {
                db.DuThis.Remove(dt);
            }
            return db.SaveChanges() > 0;
        }



        public bool ThemGiaoVien(GiaoVien giaovien)
        {
            db = new TrungTamNgoaiNguEntities();
            db.GiaoViens.Add(giaovien);
            return db.SaveChanges() > 0;
        }


        //
        // Chốt sổ + Tạo phòng thi
        //
        public bool chotSo(KhoaThi khoaThi)
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from kt in db.KhoaThis
                     where kt.MaKhoaThi == khoaThi.MaKhoaThi
                     select kt;

            foreach (KhoaThi kt in qr)
            {
                kt.ChotSo = true;
            }
            return db.SaveChanges() > 0;
        }
        public bool createRoom(int maKhoaThi, int least, int countA2, int countB1)
        {
            db = new TrungTamNgoaiNguEntities();

            int number = 1;
            for (int i = 0; i < countA2; i += least)
            {
                string tenPhong = string.Format("0{0}", number++);
                tenPhong = string.Format("A2P{0}", tenPhong.Substring(tenPhong.Length - 2, 2));
                PhongThi phongThi = new PhongThi
                {
                    TenPhong = tenPhong,
                    MaKhoaThi = maKhoaThi,
                    MaTrinhDo = 2
                };
                db.PhongThis.Add(phongThi);
            }

            number = 1;
            for (int i = 0; i < countB1; i += least)
            {
                string tenPhong = string.Format("0{0}", number++);
                tenPhong = string.Format("B2P{0}", tenPhong.Substring(tenPhong.Length - 2, 2));
                PhongThi phongThi = new PhongThi
                {
                    TenPhong = tenPhong,
                    MaKhoaThi = maKhoaThi,
                    MaTrinhDo = 1
                };
                db.PhongThis.Add(phongThi);
            }

            return db.SaveChanges() > 0;
        }

        public bool addCandidates(List<PhongThi> phongThis, int least, List<DuThi> duThisA2, List<DuThi> duThisB1)
        {
            List<PhongThi> phongThisA2 = phongThis.FindAll(i => i.MaTrinhDo == 2);
            int index = 0;
            foreach (PhongThi phongThi in phongThisA2)
            {
                for (int i = 0; i < least; i++)
                {
                    string sbd = string.Format("00{0}", index + 1);
                    sbd = string.Format("A2{0}", sbd.Substring(sbd.Length - 3, 3));
                    ThiSinh thiSinh = new ThiSinh
                    {
                        CCCD = duThisA2[index++].CCCD,
                        MaPhong = phongThi.MaPhong,
                        SBD = sbd,
                        DiemNghe = null,
                        DiemDoc = null,
                        DiemNoi = null,
                        DiemViet = null,
                    };
                    db.ThiSinhs.Add(thiSinh);
                    if (index == duThisA2.Count) break;
                }
            }

            List<PhongThi> phongThisB1 = phongThis.FindAll(i => i.MaTrinhDo == 1);
            index = 0;
            foreach (PhongThi phongThi in phongThisB1)
            {
                for (int i = 0; i < least; i++)
                {
                    string sbd = string.Format("00{0}", index + 1);
                    sbd = string.Format("B1{0}", sbd.Substring(sbd.Length - 3, 3));
                    ThiSinh thiSinh = new ThiSinh
                    {
                        CCCD = duThisB1[index++].CCCD,
                        MaPhong = phongThi.MaPhong,
                        SBD = sbd,
                        DiemNghe = null,
                        DiemDoc = null,
                        DiemNoi = null,
                        DiemViet = null,
                    };
                    db.ThiSinhs.Add(thiSinh);
                    if (index == duThisB1.Count) break;
                }
            }

            return db.SaveChanges() > 0;
        }

        public bool addTeachesIntoRoom(List<PhongThi> phongThis)
        {
            db = new TrungTamNgoaiNguEntities();
            var result = from gv in db.GiaoViens select gv;
            List<GiaoVien> GiaoViens = result.ToList();
            int index = 0;

            foreach (PhongThi phongThi in phongThis)
            {
                if (index == GiaoViens.Count) break;
                for (int i = 0; i < 2; i++)
                {
                    GiamThi giamThi = new GiamThi
                    {
                        MaGiaoVien = GiaoViens[index++].MaGiaoVien,
                        MaPhong = phongThi.MaPhong,
                        NhiemVu = null
                    };
                    db.GiamThis.Add(giamThi);
                    if (index == GiaoViens.Count) break;
                }
            }
            return db.SaveChanges() > 0;
        }

        public bool CapNhatNhiemVu(GiamThi giamThi)
        {
            db = new TrungTamNgoaiNguEntities();
            var qr = from gt in db.GiamThis
                     where gt.MaGiaoVien == giamThi.MaGiaoVien
                     select gt;

            foreach (GiamThi gt in qr)
            {
                gt.NhiemVu = giamThi.NhiemVu;
            }
            return db.SaveChanges() > 0;
        }
    }
}
