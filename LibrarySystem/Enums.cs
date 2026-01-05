namespace LibraryManagementSystem.LibrarySystem
{
    /// <summary>
    /// Specifies the set of roles that a user can have within the system.
    /// </summary>
    /// <remarks>Use this enumeration to assign or check user permissions and access levels. The available
    /// roles determine the actions a user is authorized to perform, such as administrative tasks, library management,
    /// or standard member activities.</remarks>
    public enum UserRole
    {
        Admin,
        Librarian,
        Member
    }
    /// <summary>
    /// Specifies the status of an item in a collection, such as a library or inventory system.
    /// </summary>
    /// <remarks>Use this enumeration to represent whether an item is available, currently borrowed, reserved
    /// for future use, or reported as lost. The status can be used to control item availability and user actions within
    /// the system.</remarks>

    public enum ItemStatus
    {
        Available,
        Borrowed,
        Reserved,
        Lost
    }
}
