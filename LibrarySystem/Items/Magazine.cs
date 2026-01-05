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
        public override void DisplayItemDetails()
        {
            Console.WriteLine("Item Type: Magazine");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Item ID: {ItemID}");
        }

        public override double CalculateLateFee(int daysLate)
        {
            return daysLate * 0.5;
        }
    }
}
