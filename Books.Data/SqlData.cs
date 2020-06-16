using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Books.Data
{
  public  class SqlData :IData
    {
        private readonly AppDbContext app;
        public SqlData(AppDbContext app)
        {
            this.app=app;
        }

        public IEnumerable<Books> GetBooks { 
            get
            {
                var query = from r in app.Books
                            orderby r.Id
                            select r;
                return query;
            }
        }

        public IEnumerable<Books> BookOftheweek {
            get

            {
                return app.Books.Where(r => r.BestOfTheWeek == true);
            }
        }

        public IEnumerable<Books> TrendyBooks
        {
            get
            {
                return app.Books.Where(r => r.Trendy == true);
            }
        }

        public IEnumerable<Books> Newbooks
        {
            get
            {
                return app.Books.Where(r => r.New == true);
            }
        }

       

        public Books Add(Books added)
        {
            app.Add(added);
            return added;





        }

        public int Commit()
        {
            return app.SaveChanges();
        }

        public Books Delete(int id)
        {
            var query = GetId(id);
            if (query != null)
            {
                app.Books.Remove(query);
            }
            return query;
        }

       

        public int GetCount()
        {
            return app.Books.Count();
        }

        public IEnumerable<Books> GetData(string name)
        {
            var query = from a in app.Books
                        where string.IsNullOrWhiteSpace(name) || a.Name.StartsWith(name)
                        orderby a.Name
                        select a;
            return query;
        }

        public Books GetId(int id)
        {
            return app.Books.Find(id);
        }

        public Books Update(Books update)
        {
            var query = app.Books.Attach(update);
            query.State = EntityState.Modified;
            return update;
        }
    }
}

