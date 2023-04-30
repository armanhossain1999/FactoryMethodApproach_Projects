using FactoryMethodApproach.Factories;
using FactoryMethodApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApproach.Tests
{
    public class FactoryTest
    {
        private readonly IEntityCreator ec;
        public FactoryTest(IEntityCreator ec)
        {
            this.ec = ec;
        }
        public void RunTest()
        {
            var books = new List<Book>
            {
                ec.Create<Book>(1, "Othelo", (Genre)Genre.Novel, 99.00M),
                ec.Create<Book>(2, "War and Peace", (Genre)Genre.Classic, 199.00M),
                ec.Create<Book>(3, "Ancient Mariner", (Genre)Genre.Poetry, 299.00M)
            };
            Console.WriteLine("Books");
            Console.WriteLine("-------------------------------------------------------------");
            books.ForEach(b => Console.WriteLine($"Title: {b.Title} Genre: {b.Genre} Price: {b.Price:0.00}"));
            var authors = new List<Author>
            {
                ec.Create<Author>(1, "Homer", "homer@greece.com"),
                ec.Create<Author>(2, "Tolstoy", "tolstoy@mail.ru"),
                ec.Create<Author>(3, "Shelkirk", "shell@mail.com")
            };
            Console.WriteLine("Authors");
            Console.WriteLine("-------------------------------------------------------------");
            authors.ForEach(a => Console.WriteLine($"{a.Name} E-mail: {a.Email}"));
        }
    }
}
