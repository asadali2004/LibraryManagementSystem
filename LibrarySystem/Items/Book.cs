using LibraryManagementSystem.LibrarySystem.Interfaces;

namespace LibraryManagementSystem.LibrarySystem.Items
{
    /// <summary>
    /// Represents a book item in the library system, providing functionality for display, late fee calculation,
    /// reservation, and notifications.
    /// </summary>
    /// <remarks>The Book class extends LibraryItem and implements the IReservable and INotifiable interfaces,
    /// enabling it to be reserved and to receive notifications. Use this class to model books within the library's
    /// inventory and to interact with reservation and notification features.</remarks>
    public class Book : LibraryItem, IReservable, INotifiable
    {
        public override void DisplayItemDetails()
        {
            Console.WriteLine("Item Type: Book");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item ID: {ItemID}");
        }

        public override double CalculateLateFee(int daysLate)
        {
            return daysLate * 1.0;
        }

        // Explicit interface implementation
        void IReservable.Reserve()
        {
            Console.WriteLine("Book reserved successfully.");
        }

        void INotifiable.Notify(string message)
        {
            Console.WriteLine($"Notification sent: {message}");
        }
    }
}
