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
    /// <summary>
    /// 书籍的webapi
    /// </summary>
    [Route("api/Book")]
    [ApiController]
    public class BookController : Controller
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
        [HttpGet]
        [Route("GetList")]
        public List<BookModel> GetList()
        {
            var result = Context.BookRepos.Select(o => new BookModel()
            {
                Id = o.Id,
                Name = o.Name,
                Description = o.Description,
                PublishDate = o.PublishDate,
                Price = o.Price
            }).ToList();
            return result;
        }

        /// <summary>
        /// 查询单本书籍的详情
        /// </summary>
        /// <param name="id">书id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetDetail")]
        public BookModel GetDetail(int id)
        {
            var result = Context.BookRepos.Where(o => o.Id == id).Select(o => new BookModel()
            {
                Id = o.Id,
                Name = o.Name,
                Description = o.Description,
                PublishDate = o.PublishDate,
                Price = o.Price
            }).FirstOrDefault();
            return result;
        }

        /// <summary>
        /// 新增书籍
        /// </summary>
        /// <param name="model">新增书籍model</param>
        [HttpPost]
        [Route("Create")]
        public bool Create([FromBody]CreateBookModel model)
        {
            Context.BookRepos.Add(new BookRepo()
            {
                Name = model.Name,
                Price = model.Price,
                PublishDate = model.PublishDate,
                Description = model.Description
            });
            return Context.SaveChanges() > 0;
        }
        /// <summary>
        /// 修改书籍
        /// </summary>
        /// <param name="model">修改书籍model</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Update")]
        public bool Update([FromBody] UpdateBookModel model)
        {
            var entity = Context.BookRepos.Where(o => o.Id == model.Id).FirstOrDefault();
            if (entity == null)
            {
                throw new Exception();
            }
            entity.Name = model.Name;
            entity.Price = model.Price;
            entity.PublishDate = model.PublishDate;
            entity.Description = model.Description;
            return Context.SaveChanges() > 0;
        }
        /// <summary>
        /// 删除书籍
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Delete")]
        public bool Delete(int id)
        {
            var entity = Context.BookRepos.Where(o => o.Id == id).FirstOrDefault();
            if (entity == null)
            {
                throw new Exception();
            }
            Context.BookRepos.Remove(entity);
            return Context.SaveChanges() > 0;
        }
    }
}
