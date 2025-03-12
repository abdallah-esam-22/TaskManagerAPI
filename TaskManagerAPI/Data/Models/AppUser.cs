using Microsoft.AspNetCore.Identity;

namespace TaskManagerAPI.Data.Models
{
    public class AppUser : IdentityUser
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
