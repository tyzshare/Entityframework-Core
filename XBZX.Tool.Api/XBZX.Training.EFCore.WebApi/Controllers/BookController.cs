using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XBZX.Training.EFCore.Service;

namespace XBZX.Training.EFCore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        
        /// <summary>
        ///  创建课本
        /// </summary>
        /// <param name="book"></param>
        [HttpPost]
        [Route("CreateBook")]
        public bool CreateBook([FromBody] CreateBookDto book)
        {
            return _bookService.CreateBook(book);
        }
    }
}
