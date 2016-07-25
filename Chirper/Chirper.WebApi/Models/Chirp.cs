using System;
using System.Collections.Generic;


namespace Chirper.WebApi.Models
{
    public class Chirp
    {
        // Primary key
        public int ChirpId { get; set; }

        // Foreign key
        public string UserId { get; set; }

        // Chirp fields
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LikedCount { get; set; }

        // Entity relationships
        public virtual ICollection<Comment> Comments { get; set; }  //Association with Comments
        public virtual ChirperUser User { get; set; }
    }
}