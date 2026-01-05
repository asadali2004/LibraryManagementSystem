using LibraryManagementSystem.LibrarySystem;
using LibraryManagementSystem.LibrarySystem.Analytics;
using LibraryManagementSystem.LibrarySystem.Interfaces;
using LibraryManagementSystem.LibrarySystem.Users;
using ItemsAlias = LibraryManagementSystem.LibrarySystem.Items;

/// <summary>
/// Provides the entry point for the Library Management System application.
/// </summary>
/// <remarks>The Program class contains the Main method, which demonstrates key object-oriented programming
/// concepts such as abstract classes, interfaces, polymorphism, static and partial classes, and enums within the
/// context of a library management system. The application showcases various tasks including late fee calculation,
/// reservation and notification features, dynamic method dispatch, analytics, and role-based notifications.</remarks>
class Program
{
    /// <summary>
    /// Serves as the entry point for the Library Management System application.
    /// </summary>
    /// <remarks>This method demonstrates various object-oriented programming concepts, including abstract
    /// classes, interfaces, dynamic polymorphism, static and partial classes, and enums, within the context of a
    /// library management system. It showcases example usage of library items, member roles, and analytics features.
    /// This method is intended to be called automatically by the runtime and should not be invoked directly.</remarks>
    static void Main()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("           LIBRARY MANAGEMENT SYSTEM");
        Console.WriteLine("==================================================\n");

        // ---------------- TASK 1 ----------------
        Console.WriteLine("------------------ TASK 1 -------------------------");
        Console.WriteLine("        ABSTRACT CLASS & LATE FEE LOGIC");
        Console.WriteLine("--------------------------------------------------\n");

        var book = new ItemsAlias.Book 
        {
            Title = "C# Fundamentals",
            Author = "John Doe",
            ItemID = 101
        };

        var magazine = new ItemsAlias.Magazine
        {
            Title = "Tech Today",
            Author = "Jane Doe",
            ItemID = 201
        };

        Console.WriteLine("Item Type  : Book");
        Console.WriteLine($"Title      : {book.Title}");
        Console.WriteLine($"Author     : {book.Author}");
        Console.WriteLine($"Item ID    : {book.ItemID}");
        Console.WriteLine($"Late Fee (3 days): {book.CalculateLateFee(3)}\n");

        Console.WriteLine("--------------------------------------------------\n");

        Console.WriteLine("Item Type  : Magazine");
        Console.WriteLine($"Title      : {magazine.Title}");
        Console.WriteLine($"Author     : {magazine.Author}");
        Console.WriteLine($"Item ID    : {magazine.ItemID}");
        Console.WriteLine($"Late Fee (3 days): {magazine.CalculateLateFee(3)}\n");

        // ---------------- TASK 2 ----------------
        Console.WriteLine("------------------ TASK 2 -------------------------");
        Console.WriteLine("        INTERFACES & MULTIPLE INHERITANCE");
        Console.WriteLine("--------------------------------------------------\n");

        IReservable reservable = book;
        INotifiable notifiable = book;

        reservable.Reserve();
        notifiable.Notify("Your reserved book is ready for pickup.");

        // ---------------- TASK 3 ----------------
        Console.WriteLine("\n------------------ TASK 3 -------------------------");
        Console.WriteLine("           DYNAMIC POLYMORPHISM");
        Console.WriteLine("--------------------------------------------------\n");

        List<LibraryItem> items = new()
        {
            book,
            magazine
        };

        Console.WriteLine("Displaying items using parent reference:\n");

        foreach (LibraryItem item in items)
        {
            item.DisplayItemDetails();
        }

        Console.WriteLine("\nExplanation: Method selection happens at runtime.");

        // ---------------- TASK 6 ----------------
        Console.WriteLine("\n------------------ TASK 6 -------------------------");
        Console.WriteLine("         STATIC & PARTIAL CLASS");
        Console.WriteLine("--------------------------------------------------\n");

        LibraryAnalytics.TotalBorrowedItems = 5;
        LibraryAnalytics.DisplayAnalytics();

        // ---------------- TASK 7 ----------------
        Console.WriteLine("\n------------------ TASK 7 -------------------------");
        Console.WriteLine("               ENUMS");
        Console.WriteLine("--------------------------------------------------\n");

        var member = new Member
        {
            Name = "Ali",
            Role = UserRole.Member
        };

        ItemStatus status = ItemStatus.Borrowed;

        Console.WriteLine($"User Role   : {member.Role}");
        Console.WriteLine($"Item Status : {status}");
        Console.WriteLine("Explanation: Enums improve readability and prevent invalid values.");

        // ---------------- BONUS ----------------
        Console.WriteLine("\n------------------ BONUS TASK ---------------------");
        Console.WriteLine("        ROLE-BASED NOTIFICATION & EBOOK");
        Console.WriteLine("--------------------------------------------------\n");

        if (member.Role == UserRole.Admin)
            Console.WriteLine("Admin Alert: System maintenance scheduled.");
        else
            Console.WriteLine("Member Notification: Your borrowed item is due tomorrow.");

        var ebook = new ItemsAlias.EBook
        {
            Title = "Learn .NET"
        };

        ebook.Download();

        Console.WriteLine("\n==================================================");
        Console.WriteLine("                END OF EXECUTION");
        Console.WriteLine("==================================================");
    }
}
