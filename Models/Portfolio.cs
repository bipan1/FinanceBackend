

using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("Portfolios")]
    public class Portfolio
    {
        public string AppuserId { get; set; }
        public int StockId { get; set; }
        public AppUser AppUser { get; set; }
        public Stock Stock { get; set; }
    }
}