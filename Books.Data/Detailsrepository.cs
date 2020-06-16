using Book.info;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Data
{
   public class Detailsrepository : IDetails
    {
        private readonly AppDbContext app;

        public Detailsrepository(AppDbContext app)
        {
            this.app = app;
        }

        Details IDetails.Add(Details added)
        {
            app.Add(added);
            return added;
        }

        public Details GetDetails(int id)
        {
            return app.Details.Find(id);
        }

         Details IDetails.Update(Details id)
        {
            var entity = app.Details.Attach(id);
            entity.State = EntityState.Modified;
            
            return id;
        }

        public int Commit()
        {
            return app.SaveChanges();
        }

        public Details Delete(int id)
        {
            var query = GetDetails(id);
            if (query != null)
            {
                app.Details.Remove(query);
            }
            return query;
        }
    }
}
