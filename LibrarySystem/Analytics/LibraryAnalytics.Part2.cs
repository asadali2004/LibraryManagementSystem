namespace LibraryManagementSystem.LibrarySystem.Analytics
{
    /// <summary>
    /// Provides analytics functionality for the library system.
    /// </summary>
    public partial class LibraryAnalytics
    {
        public static void DisplayAnalytics()
        {
            Console.WriteLine($"Total Items Borrowed: {TotalBorrowedItems}");
        }
    }
}
