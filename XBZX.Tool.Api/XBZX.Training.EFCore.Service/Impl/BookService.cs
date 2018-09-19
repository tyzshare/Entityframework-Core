using System;
using System.Collections.Generic;
using System.Text;
using XBZX.Training.EFCore.Repository;

namespace XBZX.Training.EFCore.Service
{
    public class BookService : IBookService
    {
        private MyContext _db;
        public BookService(MyContext db)
        {
            _db = db;
        }
        public bool CreateBook(CreateBookDto dto)
        {
            _db.BookRepos.Add(new BookRepo()
            {
                Name = dto.Name,
                Description = dto.Description,
                PublishDate = dto.PublishDate
            });
            return _db.SaveChanges() > 0;
        }
    }
}
