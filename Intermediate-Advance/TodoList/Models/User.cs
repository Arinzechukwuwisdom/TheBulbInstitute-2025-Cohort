using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Text), Column(TypeName = "Nvarchar(80)")]
        public required string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
        [Range(18, 50)]
        public int Age { get; set; }
        public List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
        // Relationships
        //One to one
        //One use can only have one todoitem, and one todo item can only belong to one user
        //One to many
        //one user can have many todo items, but one todo item can only belong to one user
        //Many to Many
        // //Many users can have many todo items, and one todo item can belong to many users
    }
}
