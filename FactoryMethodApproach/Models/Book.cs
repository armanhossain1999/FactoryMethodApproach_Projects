using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApproach.Models
{
    public class Book : IEntity
    {
        public Book()
        {
            
        }
        public Book(int id, string title, Genre genre, decimal price)
        {
            this.Id = id;
            this.Title = title;
            this.Genre = genre;
            this.Price = price;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public decimal Price { get; set; }
    }
}
