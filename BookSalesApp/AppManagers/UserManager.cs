using BookSalesApp.Models;
using System.Linq;

namespace BookSalesApp.AppManagers
{ 
    public class UserManager
    {
        public bool checkUser(string username, string password)
        {
            User currentUser;
            currentUser = DataHolder.DataHolder.Users.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (currentUser != null)
            {
                DataHolder.DataHolder.CurrentUser = currentUser;
                return true;
            }

            return false;
        }
    }
}
