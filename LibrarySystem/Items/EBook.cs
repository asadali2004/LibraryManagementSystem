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
        public override void DisplayItemDetails()
        {
            Console.WriteLine("Item Type: eBook");
            Console.WriteLine($"Title: {Title}");
        }

        public override double CalculateLateFee(int daysLate)
        {
            return 0;
        }

        public void Download()
        {
            Console.WriteLine("eBook downloaded successfully.");
        }
    }
}
