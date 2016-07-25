using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;


namespace Chirper.WebApi.Models
{
    //Building relationship for Chirps and Comments
    public class ChirperUser : IdentityUser
    {
        public virtual ICollection<Chirp> Chirps { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}