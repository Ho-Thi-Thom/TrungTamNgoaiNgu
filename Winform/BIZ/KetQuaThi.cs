using System;

namespace Winform.BIZ
{
    class KetQuaThi
    {
        public KetQuaThi() { }

        public KhoaThi KhoaThi { get; set; }
        public PhongThi PhongThi { get; set; }
        public string SBD { get; set; }
        public Nullable<int> DiemDoc { get; set; }
        public Nullable<int> DiemNghe { get; set; }
        public Nullable<int> DiemNoi { get; set; }
        public Nullable<int> DiemViet { get; set; }
    }
}
