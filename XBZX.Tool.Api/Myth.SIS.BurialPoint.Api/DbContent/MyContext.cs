using Microsoft.EntityFrameworkCore;
using Myth.SIS.BurialPoint.Api.DbContent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myth.SIS.BurialPoint.Api
{
    /// <summary>
    /// 构造的 DbContext
    /// </summary>
    public class MyContext : DbContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="options"></param>
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        { }
        /// <summary>
        /// 书
        /// </summary>
        public DbSet<BookRepo> BookRepos { get; set; }

        public DbSet<BookaaRepo> BookaaRepos { get; set; }

    }
}
