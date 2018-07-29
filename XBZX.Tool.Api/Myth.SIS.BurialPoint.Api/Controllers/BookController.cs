using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Myth.SIS.BurialPoint.Api.DbContent;
using Myth.SIS.BurialPoint.Api.Models;

namespace Myth.SIS.BurialPoint.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private MyContext Context;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_context"></param>
        public BookController(MyContext _context)
        {
            Context = _context;
        }
        /// <summary>
        /// 查询所有的书籍
        /// </summary>
        /// <returns></returns>
        // GET: api/Book
        [HttpGet]
        public List<BookModel> Get()
        {
            //var result= Context.
            //return new string[] { "value1", "value2" };
            return null;
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// 新增书籍
        /// </summary>
        /// <param name="model">新增书籍model</param>
        // POST: api/Book
        [HttpPost]
        public bool Create([FromBody]CreateBookModel model)
        {
            //model.Validate();
            Context.BookRepos.Add(new BookRepo() {
                  Name=model.Name,
                   Price=model.Price,
                    PublishDate=model.PublishDate,
                     //TypeId=model.TypeId,
                      Description=model.Description
            } );
            return Context.SaveChanges()>0;
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
