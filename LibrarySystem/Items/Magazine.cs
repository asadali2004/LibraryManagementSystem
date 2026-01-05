namespace LibraryManagementSystem.LibrarySystem.Items
{
    /// <summary>
    /// Represents a magazine item in the library collection.
    /// </summary>
    /// <remarks>A magazine is a type of library item that typically contains articles, stories, and
    /// illustrations published on a regular schedule. This class extends the base LibraryItem type to provide
    /// magazine-specific behavior, such as a distinct late fee calculation.</remarks>
    public class Magazine : LibraryItem
    {
        /// <summary>
        /// Displays the details of the magazine item to the console.
        /// </summary>
        /// <remarks>This method writes the item type, title, author, and item ID to the standard output.
        /// Use this method to present magazine information in a console application.</remarks>
        public override void DisplayItemDetails()
        {
            Console.WriteLine("Item Type: Magazine");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item ID: {ItemID}");
        }

        /// <summary>
        /// Calculates the late fee based on the number of days an item is overdue.
        /// </summary>
        /// <param name="daysLate">The number of days the item is overdue. Must be zero or greater.</param>
        /// <returns>The total late fee, in monetary units, calculated as 0.5 per day late. Returns 0 if the item is not overdue.</returns>
        public override double CalculateLateFee(int daysLate)
        {
            return daysLate * 0.5;
        }
    }
}
