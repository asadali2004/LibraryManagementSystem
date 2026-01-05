namespace LibraryManagementSystem.LibrarySystem.Users
{
/// <summary>
/// Represents a user or participant with an associated name and role within the system.
/// </summary>
    public class Member
    {
        public string Name { get; set; } = string.Empty;
        public UserRole Role { get; set; }
    }
}
