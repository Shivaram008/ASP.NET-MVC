using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Models.Repository
{
    public class BookRepository 
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public List<BookModel> GetBook(int id)
        {
            return DataSource().Where(x => x.id == id).ToList();
        }
        public List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){id=1,Title="C#",Author="Ram" },
                new BookModel(){id=2,Title="F#",Author="Siva" },
                new BookModel(){id=3,Title="ASP",Author="Ram" },
                new BookModel(){id=4,Title="C#",Author="Prasad" }
            };
        }
    }
}
