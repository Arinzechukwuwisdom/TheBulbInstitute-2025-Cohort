namespace TodoList.DTOs
{
    public class UserCreateDTO
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public int Age { get; set; }
    }
}
