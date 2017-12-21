using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }
        public int DiscountRate { get; set; }
        public int PublisherId { get; set; }

        public int CategoryId { get; set; }

        public override string ToString()
        {
            return $"{Name} : {Price} : {DataHolder.DataHolder.Publishers.FirstOrDefault(x => x.Id == PublisherId)} : {AddedDate.ToShortDateString()}";
        }

    }
}
