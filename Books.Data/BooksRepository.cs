using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Reflection.Metadata.Ecma335;

namespace Books.Data
{
    public class BooksRepository : IData
    {
       readonly List<Books> Book;
        public BooksRepository()
        {
            Book = new List<Books>()
            { new Books{
               Id = 1,
                Name = "White Fragility: Why It's So Hard for White People to Talk About Racism",
                Author = "Robin DiAngelo",
                Price = 12.24
            }
        };

          

        }

        public IEnumerable<Books> GetBooks { 
            get

            {
                return Book.OrderBy(r => r.Id);
            }
        }

       

        public IEnumerable<Books> BookOftheweek => throw new NotImplementedException();

        public IEnumerable<Books> TrendyBooks => throw new NotImplementedException();

        public IEnumerable<Books> Newbooks => throw new NotImplementedException();

        public Books Add(Books added)
        {
            Book.Add(added);
            added.Id = Book.Max(r => r.Id) + 1;
            return added;
        }

        public int Commit()
        {
            return 0;
        }

        public Books Delete(int id)
        {
            var query = Book.FirstOrDefault(r => r.Id == id);
            if (query != null)
            {
                Book.Remove(query);
            }
            return query;
        }

     

        public int GetCount()
        {
            return Book.Count();
        }

        public IEnumerable<Books> GetData(string name)
        {
            var query = from a in Book
                        where string.IsNullOrWhiteSpace(name) || a.Name.StartsWith(name)
                        orderby (a.Name)
                        select (a);
            var query2 = Book.Where(a => a.Name.StartsWith(name) || string.IsNullOrWhiteSpace(name)).OrderBy(a => a.Name);
            return query2;
        }

        public Books GetId(int id)
        {
            var query = Book.SingleOrDefault(r => r.Id == id);
            return query;
        }

        public Books Update(Books update)
        {
            var query = Book.SingleOrDefault(r => r.Id == update.Id);
            if (update != null)
            {
                query.Id = update.Id;
                query.Name = update.Name;
                query.Price = update.Price;
                query.Author = update.Author;


            }
            return query;
        }
    }
}
