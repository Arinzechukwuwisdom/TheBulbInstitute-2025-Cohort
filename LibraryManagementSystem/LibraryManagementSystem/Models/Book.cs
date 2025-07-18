using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "Nvarchar(30)")]
        public required string Title { get; set; }
        [Column(TypeName = "Nvarchar(30)")]
        public required string Author { get; set; }
        public DateTimeOffset PublishedDate { get; set; }
        [Column(TypeName = "Nvarchar(30)")]
        public required string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int CopiesAvailable { get; set; } = 1;
    }
}
