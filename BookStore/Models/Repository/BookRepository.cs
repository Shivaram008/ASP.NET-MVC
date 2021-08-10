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

        public BookModel GetBook(int id)
        {
            return DataSource().Where(x => x.id == id).FirstOrDefault();
        }
        public List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){id=1,Title="C#",Author="Ram" ,Description="This Book is written by the author RAM and this is the 1st edition.",Category="Programming",Language="English",Pages=225},
                new BookModel(){id=2,Title="F#",Author="Siva" ,Description="This Book is written by the author Siva and this is the 3rd edition." ,Category="Programming",Language="French",Pages=400},
                new BookModel(){id=3,Title="ASP",Author="Ram" ,Description="This Book is written by the author RAM and this is the 2nd edition.",Category="Framework",Language="English",Pages=637},
                new BookModel(){id=4,Title="C#",Author="Prasad",Description="This Book is written by the author PRASAD and this is the 6th edition." ,Category="Programming",Language="Hindi",Pages=546},
                new BookModel(){id=5,Title="Python",Author="Raj",Description="This Book is written by the author RAJ and this is the 5th edition.",Category="OOPS",Language="Spanish",Pages=435 }
            };
        }
    }
}
