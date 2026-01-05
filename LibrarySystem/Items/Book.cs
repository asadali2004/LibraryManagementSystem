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

        /// <summary>
        /// Displays the details of the book item to the console, including its type, title, author, and item ID.
        /// </summary>
        /// <remarks>Use this method to output a formatted summary of the book's key information for
        /// display or debugging purposes. The output is written directly to the standard console.</remarks>
        public override void DisplayItemDetails()
        {
            Console.WriteLine("Item Type: Book");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item ID: {ItemID}");
        }

        /// <summary>
        /// Calculates the late fee based on the number of days an item is overdue.
        /// </summary>
        /// <param name="daysLate">The number of days the item is returned after its due date. Must be zero or greater.</param>
        /// <returns>The total late fee, in monetary units, for the specified number of overdue days. Returns 0 if no days are
        /// late.</returns>
        public override double CalculateLateFee(int daysLate)
        {
            return daysLate * 1.0;
        }

        /// <summary>
        /// Reserves the item, marking it as unavailable for other reservations.
        /// </summary>
        void IReservable.Reserve()
        {
            Console.WriteLine("Book reserved successfully.");
        }

        /// <summary>
        /// Sends a notification with the specified message.
        /// </summary>
        /// <param name="message">The message to include in the notification. Cannot be null.</param>
        void INotifiable.Notify(string message)
        {
            Console.WriteLine($"Notification sent: {message}");
        }
    }
}
