namespace LibraryManagementSystem.LibrarySystem
{
    /// <summary>
    /// Represents a base class for items in a library collection, such as books, magazines, or media.
    /// </summary>
    /// <remarks>This abstract class defines common properties and methods for all library items. Derived
    /// classes should implement the abstract methods to provide item-specific details and late fee
    /// calculations.</remarks>
    public abstract class LibraryItem
    {
        public string Title { get; set; } = string.Empty; // Title of the library item
        public string Author { get; set; } = string.Empty; // Author of the library item
        public int ItemID { get; set; } // Unique identifier for the library item

        public abstract void DisplayItemDetails(); // Abstract method to display item details
        public abstract double CalculateLateFee(int daysLate); // Abstract method to calculate late fee
    }
}
