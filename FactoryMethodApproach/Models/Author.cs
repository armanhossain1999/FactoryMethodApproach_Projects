using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodApproach.Models
{
    public class Author:IEntity
    {
        public Author() { }
        public Author(int id, string name, string email) 
        { 
            this.Id = id;
            this.Name = name;
            this.Email = email;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
