using Microsoft.AspNetCore.Identity;

namespace Gerenciador.Models
{
    public class User:IdentityUser
    {
        public ICollection<ProjectUser> ProjectsUsers { get; set; }
        public ICollection<Activity> Activities { get; set; }
        public User():base()
        {
            
        }
    }
}
