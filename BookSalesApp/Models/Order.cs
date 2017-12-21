using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSalesApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public int UserId { get; set; }

        public override string ToString()
        {
            return $"{(DataHolder.DataHolder.Users.FirstOrDefault(x => x.Id == UserId)).Name} {(DataHolder.DataHolder.Users.FirstOrDefault(x => x.Id == UserId)).Lastname} -> {AddedDate.ToShortDateString()}";
        }
    }
}
