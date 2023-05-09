using Microsoft.AspNetCore.Identity;

namespace DesignPattern.Observer.Data
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string? City { get; set; } 
        public string? District { get; set; } 

    }
}
