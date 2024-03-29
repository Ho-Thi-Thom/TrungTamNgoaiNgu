﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Webform.Models
{
    [Table("DuThi")]
    public partial class DuThi
    {
        [Key]
        public int MaKhoaThi { get; set; }
        [Key]
        [Column("CCCD")]
        [StringLength(12)]
        public string Cccd { get; set; }
        public int MaTrinhDo { get; set; }

        [ForeignKey(nameof(Cccd))]
        [InverseProperty(nameof(NguoiDung.DuThis))]
        public virtual NguoiDung CccdNavigation { get; set; }
        [ForeignKey(nameof(MaKhoaThi))]
        [InverseProperty(nameof(KhoaThi.DuThis))]
        public virtual KhoaThi MaKhoaThiNavigation { get; set; }
        [ForeignKey(nameof(MaTrinhDo))]
        [InverseProperty(nameof(TrinhDo.DuThis))]
        public virtual TrinhDo MaTrinhDoNavigation { get; set; }
    }
}
