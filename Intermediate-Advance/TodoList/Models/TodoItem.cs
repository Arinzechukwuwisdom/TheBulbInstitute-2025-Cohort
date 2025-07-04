using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text), Column(TypeName = "Nvarchar(100)")]
        public required string Title { get; set; }
        [DataType(DataType.Text), Column(TypeName = "Nvarchar(200)")]
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? CompletedAt { get; set; }
        [ForeignKey(nameof(User))]
        //[Required(ErrorMessage = "User ID is required.")]
        public required int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
