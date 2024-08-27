
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("Comments")]
    public class Comment
    {
        public int Id { get; set; }
        public int? StockId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public Stock? Stock { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}