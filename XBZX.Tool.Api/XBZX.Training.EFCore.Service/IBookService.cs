using System;

namespace XBZX.Training.EFCore.Service
{
    public interface IBookService
    {
        bool CreateBook(CreateBookDto dto);
    }
}
