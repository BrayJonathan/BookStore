using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripositories
{
    public class BookRepository : IBookRepository
    {
        public string GetMessage()
        {
            return "Hello";
        }
    }
}
