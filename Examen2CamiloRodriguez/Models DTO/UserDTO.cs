namespace Examen2CamiloRodriguez.Models_DTO
{
    public class UserDTO
    {

        public string UserName { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public string UserPassword { get; set; } = null!;

        public int StrikeCount { get; set; }

        public string BackUpEmail { get; set; } = null!;

        public string? JobDescription { get; set; }

        public int UserStatusId { get; set; }

        public int CountryId { get; set; }

        public int UserRoleId { get; set; }

        public string UserRole1 { get; set; }
    }
}
