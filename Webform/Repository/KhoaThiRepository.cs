using System.Collections.Generic;
using System.Linq;
using Webform.Models;

namespace Webform.Repository
{
    public class KhoaThiRepository
    {
        EnglishDbContext _context;

        public KhoaThiRepository(EnglishDbContext context)
        {
            this._context = context;
        }
        public List<KhoaThi> getAll()
        {
            return _context.KhoaThis.ToList();
        }
    }
}
