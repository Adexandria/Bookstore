using System;

using System.Collections.Generic;
using System.Text;

namespace Books.Data
{
  public  interface IData 
    {
       IEnumerable<Books> GetBooks { get; }
        IEnumerable<Books> GetData(string name);
        public Books GetId(int id);
        Books Update(Books update);
        Books Delete(int id);
       Books Add(Books added);
        
        IEnumerable<Books>BookOftheweek { get; }
        IEnumerable<Books> TrendyBooks { get; }

        IEnumerable<Books> Newbooks { get; }
        int GetCount();
        int Commit();
    }
}
