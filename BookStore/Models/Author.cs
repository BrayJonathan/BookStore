using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BookStore.Models
{
    //[DataContract(IsReference = true)]
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }


       //public virtual ICollection<Book> books {get;set;}
    }
}