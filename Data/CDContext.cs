using Microsoft.EntityFrameworkCore;
using Moment3._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moment3._2.Data
{
    public class CDContext : DbContext
    {
        public CDContext(DbContextOptions<CDContext> options) : base(options)
        {
        }
        public DbSet<CD> CD { get; set; }
    }
}
