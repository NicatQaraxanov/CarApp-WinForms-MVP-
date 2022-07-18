using mvp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp.Data
{
    public class CarDbContext : DbContext
    {
        public CarDbContext() : base("CarDb") { }

        public DbSet<Car> Cars { get; set; }
    }
}
