using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Books.Data
{
  public class Books
    {
        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Name { get; set; }
        [Required, StringLength(80)]
        public string Author { get; set; }
        public string Image { get; set; }
        public bool Trendy { get; set; }

        public bool New { get; set; }
        public bool BestOfTheWeek { get; set; }
        public ICollection<Details> Description { get; set; }

        public double Price { get; set; }
    }
}
