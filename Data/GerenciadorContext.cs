using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gerenciador.Data
{
    public class GerenciadorContext:IdentityDbContext<IdentityUser>
    {
        public GerenciadorContext(DbContextOptions<GerenciadorContext> opts):base(opts)
        {
            
        }
    }
}
