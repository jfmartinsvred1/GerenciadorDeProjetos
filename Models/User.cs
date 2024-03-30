using Microsoft.AspNetCore.Identity;

namespace Gerenciador.Models
{
    public class User:IdentityUser
    {
        public ICollection<ProjectUser> ProjectsUsers { get; set; }
        public User():base()
        {
            
        }
    }
}
