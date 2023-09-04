using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace CODE_FIRST1
{
    class DataContext:DbContext

    {
        public DataContext(string connectionString): base(connectionString)
        {

        }
        public virtual DbSet<User> Users { get; set; }

    }
}
