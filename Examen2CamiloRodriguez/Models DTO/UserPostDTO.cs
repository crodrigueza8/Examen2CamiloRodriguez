namespace Examen2CamiloRodriguez.Models_DTO
{
    public class UserPostDTO
    {

        public string UserName { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public int StrikeCount { get; set; }

        public string BackUpEmail { get; set; } = null!;

        public string? JobDescription { get; set; }

        public int UserStatusId { get; set; }

        public int CountryId { get; set; }

        public int UserRoleId { get; set; }
    }
}
