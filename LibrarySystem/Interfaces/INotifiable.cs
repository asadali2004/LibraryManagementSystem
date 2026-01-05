namespace LibraryManagementSystem.LibrarySystem.Interfaces
{
    /// <summary>
    /// Defines a contract for objects that can receive notification messages.
    /// </summary>
    /// <remarks>Implement this interface to provide custom notification handling logic, such as displaying
    /// messages to users, logging, or forwarding notifications to other systems.</remarks>
    public interface INotifiable
    {
        void Notify(string message);
    }
}
