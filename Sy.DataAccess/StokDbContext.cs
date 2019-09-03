using Sy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.DataAccess
{
    class StokDbContext : DbContext
    {
        public StokDbContext() : base("name=MyCon")
        {

        }
        public virtual DbSet<Product> Products{ get; set; }

    }
}
