using Chirper.WebApi.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Web.Http;

namespace Chirper.WebApi.Infrastructure
{
    [Authorize]
    public class DataContext : IdentityDbContext<ChirperUser>  //Extending data context
    {
        public DataContext() : base("Chirper")
        {

        }
            public IDbSet<Chirp> Chirps { get; set; }  //IDbSets to indicate they both in same domain
            public IDbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chirp>()
                .HasMany(c => c.Comments) //One chirp has many comments
                .WithRequired(c => c.Chirp)  //Parent chirp required
                .HasForeignKey(c => c.ChirpId);

            modelBuilder.Entity<ChirperUser>()
                .HasMany(u => u.Chirps)
                .WithRequired(c => c.User)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<ChirperUser>()
                .HasMany(u => u.Comments)
                .WithRequired(c => c.User)
                .HasForeignKey(c => c.UserId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }

    }
}