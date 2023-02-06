using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Lopushok.Base;


namespace Lopushok.Bascon
{
    internal class ConDB
    {
        public static Frame mainFrame { get; set; }
        private static DemobaseEntities _context { get; set; }
        public static DemobaseEntities Context
        {
            get
            {
                if (_context == null)
                    _context = new DemobaseEntities();
                return _context;
            }
        }
    }
}

