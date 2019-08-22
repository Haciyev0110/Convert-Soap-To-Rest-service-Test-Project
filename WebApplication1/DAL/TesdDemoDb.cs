using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class TesdDemoDb :DbContext
    {

        public TesdDemoDb(DbContextOptions<TesdDemoDb> options) : base(options) 
        {

        }
        public DbSet<FirstTable> firstTables { get; set; }
        public DbSet<SecondTable> secondTables { get; set; }
    }
}
