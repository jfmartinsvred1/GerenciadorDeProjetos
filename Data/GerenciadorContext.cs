using Gerenciador.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gerenciador.Data
{
    public class GerenciadorContext:IdentityDbContext<User>
    {
        public GerenciadorContext(DbContextOptions<GerenciadorContext> opts):base(opts)
        {
            
        }
        public DbSet<State> States { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectUser> ProjectsUsers { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Working>()
        //        .HasKey(working => new { working.ProjectId, working.Id });

        //    builder.Entity<Working>()
        //        .HasOne(working => working.User)
        //        .WithMany(user => user.Workers)
        //        .HasForeignKey(working => working.Id);

        //    builder.Entity<Working>()
        //        .HasOne(working => working.Project)
        //        .WithMany(project => project.Workers)
        //        .HasForeignKey(working => working.Id);
        //}
    }
}
