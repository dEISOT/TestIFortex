using TestTask.Enums;

namespace TestTask.Models.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public UserStatus Status { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
