using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;

namespace RestorauntAdminPanel.Data
{
    internal class DbHelper
    {
        private static RestorauntDbContext _context;

        public static RestorauntDbContext GetContext()
        {
            if (_context == null)
                _context = new RestorauntDbContext();

            return _context;
        }
    }
}
