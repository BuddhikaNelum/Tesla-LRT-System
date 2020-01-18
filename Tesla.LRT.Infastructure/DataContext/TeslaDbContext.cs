using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tesla.LRT.Infastructure.DataContext
{
    public class TeslaDbContext : DbContext
    {
        public TeslaDbContext(DbContextOptions<TeslaDbContext> options) : base(options) { }

    }
}
