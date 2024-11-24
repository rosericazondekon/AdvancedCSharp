using Microsoft.EntityFrameworkCore;
using System.Linq;
using blogApp.Models;
using blogApp.Data;
using blogApp.Helpers;

AppDbContext context = new AppDbContext();

// Create database if it does not exist
context.Database.EnsureCreated();

while (true)
{
    Console.WriteLine("1. Create a new blog post");
    Console.WriteLine("2. View all blog posts with comments");
    Console.WriteLine("3. Add a comment to a blog post");
    Console.WriteLine("4. Update a blog post");
    Console.WriteLine("5. Delete a blog post");
    Console.WriteLine("6. Exit");
    Console.Write("Choose an option: ");
    var choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Helpers.CreateBlogPost(context);
            break;
        case "2":
            Helpers.ViewAllBlogPosts(context);
            break;
        case "3":
            Helpers.AddCommentToBlogPost(context);
            break;
        case "4":
            Helpers.UpdateBlogPost(context);
            break;
        case "5":
            Helpers.DeleteBlogPost(context);
            break;
        case "6":
            return;
        default:
            Console.WriteLine("Invalid choice. Try again.");
            break;
    }

}
