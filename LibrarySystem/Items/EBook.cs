namespace LibraryManagementSystem.LibrarySystem.Items
{
    /// <summary>
    /// Represents a digital book that can be accessed and downloaded electronically within the library system.
    /// </summary>
    /// <remarks>An EBook is a type of LibraryItem that does not incur late fees and provides functionality
    /// for users to download the digital content. Use this class to manage and interact with electronic books in the
    /// library's collection.</remarks>
    public class EBook : LibraryItem
    {
        /// <summary>
        /// Displays details about the eBook item to the console.
        /// </summary>
        /// <remarks>This method writes the item type and title to the standard output. Override this
        /// method to customize the displayed details for derived item types.</remarks>
        public override void DisplayItemDetails()
        {
            Console.WriteLine("Item Type: eBook");
            Console.WriteLine($"Title: {Title}");
        }

        /// <summary>
        /// Calculates the late fee based on the number of days an item is overdue.
        /// </summary>
        /// <param name="daysLate">The number of days the item is returned after its due date. Must be zero or greater.</param>
        /// <returns>The calculated late fee as a double-precision floating-point value. Returns 0 if no fee is applicable.</returns>
        public override double CalculateLateFee(int daysLate)
        {
            return 0;
        }

        /// <summary>
        /// Downloads the eBook to the local device.
        /// </summary>
        public void Download()
        {
            Console.WriteLine("eBook downloaded successfully.");
        }
    }
}
