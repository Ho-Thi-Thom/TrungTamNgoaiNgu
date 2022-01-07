using System.Collections.Generic;
using System.Linq;
using Webform.Models;

namespace Webform.Repository
{
    public class PhongThiRepository
    {
        EnglishDbContext _context;

        public PhongThiRepository(EnglishDbContext context)
        {
            this._context = context;
        }
        public List<PhongThi> getAll()
        {
            return _context.PhongThis.ToList();
        }

        public List<PhongThi> PhongThiCombobox(int makhoa)
        {
            var qr = _context.PhongThis.Where(s => s.MaKhoaThi == makhoa).ToList();
            return qr;
        }

    }
}
