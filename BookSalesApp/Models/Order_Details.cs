using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesApp.Models
{
    public class Order_Details
    {
        public DateTime AddedDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int BookId { get; set; }
        public int OrderId { get; set; }

    }
}
