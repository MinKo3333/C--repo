using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Media
{
    internal class Current_User
    {
        public static Profile CurrentUser { get; set; }

         public Current_User()
        {
            // Assuming Login.CurrentUser is a static property that holds the currently logged-in user
            // You might need to adjust this based on your actual implementation of the Login class
            if (Login.CurrentUser == null)
            {
                throw new InvalidOperationException("No user is currently logged in.");
            }

            // Initialize CurrentUser with the currently logged-in user's profile
            CurrentUser = Login.CurrentUser;
        }

    }
}
