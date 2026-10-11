namespace LearnDotNet
{
    public class Profile
    {
        public int Id { get; set; }
        public string ProfileName { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
    public class ProfileDTO
    {
        public int Id { get; set; }
        public string ProfileName { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
    public class ProfileCreateDTO
    {
        public string ProfileName { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
