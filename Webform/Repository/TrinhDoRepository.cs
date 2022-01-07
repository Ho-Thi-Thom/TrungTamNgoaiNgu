using System.Collections.Generic;
using System.Linq;
using Webform.Models;

namespace Webform.Repository
{
    public class TrinhDoRepository
    {
        EnglishDbContext _context;

        public TrinhDoRepository(EnglishDbContext context)
        {
            this._context = context;
        }
        public TrinhDo findById(string cccd)
        {
            throw new System.NotImplementedException();
        }

        public List<TrinhDo> getAll()
        {
            return _context.TrinhDos.ToList();
        }
    }
}
