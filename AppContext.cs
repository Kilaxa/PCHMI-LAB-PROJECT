using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PCHMI_LAB_PROJECT
{
    internal class AppContext : DbContext
    {
        public DbSet<Book> Books {  get; set; }
        public DbSet<Reader> Readers { get; set; }

        public AppContext() : base("DefaultConnection") { }
    }
}
