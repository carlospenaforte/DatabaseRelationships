using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseRelationships.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }


        [ForeignKey("User")]
        public int UserId { get; set; } // foreign key

        // navigation property
        public User User { get; set; }
    }
}
