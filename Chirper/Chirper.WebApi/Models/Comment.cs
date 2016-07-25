using System;

namespace Chirper.WebApi.Models
{
    public class Comment
    {
        // Primary key
        public int CommentId { get; set; }

        // Foreign key
        public string UserId { get; set; }

        // Comment fields
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LikedCount { get; set; }

        // Entity relationships

        public int ChirpId { get; set; }
        public virtual Chirp Chirp { get; set; }  //Instance of chirp
        public virtual ChirperUser User { get; set; }

    }
}