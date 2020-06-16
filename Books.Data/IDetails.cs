
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Data
{
   public interface IDetails 
   {
        public Details GetDetails(int id);
        Details Update(Details id);
        int Commit();
        Details Delete(int id);
        Details Add(Details added);

    }
}
