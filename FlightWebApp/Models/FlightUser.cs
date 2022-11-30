using Microsoft.AspNetCore.Identity;

namespace FlightWebApp.Models
{
    public class FlightUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
