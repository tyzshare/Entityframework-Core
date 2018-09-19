using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace XBZX.Training.EFCore.Repository
{
    public class MyContext : DbContext
    {
        public DbSet<BookRepo> BookRepos { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
    }
}
