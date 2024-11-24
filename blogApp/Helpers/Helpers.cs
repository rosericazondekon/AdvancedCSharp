using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using blogApp.Data;
using blogApp.Models;


namespace blogApp.Helpers
{
    public class Helpers
    {
        public static void CreateBlogPost(AppDbContext context)
        {
            Console.Write("Enter blog title: ");
            var title = Console.ReadLine();
            Console.Write("Enter blog content: ");
            var content = Console.ReadLine();
            var blog = new Blog
            {
                Title = title,
                Content = content
            };
            context.Blogs.Add(blog);
            context.SaveChanges();
            Console.WriteLine("Blog post created successfully!");
        }

        public static void ViewAllBlogPosts(AppDbContext context)
        {
            var blogs = context.Blogs.Include(b => b.Comments).ToList();
            foreach (var blog in blogs)
            {
                Console.WriteLine($"Title: {blog.Title}");
                Console.WriteLine($"Content: {blog.Content}");
                Console.WriteLine($"Date Created: {blog.DateCreated}");
                Console.WriteLine("Comments:");
                foreach (var comment in blog.Comments)
                {
                    Console.WriteLine($"  - {comment.Content} ({comment.DateCreated})");
                }
                Console.WriteLine();
            }
        }

        public static void AddCommentToBlogPost(AppDbContext context)
        {
            Console.Write("Enter blog post Id: ");
            if (int.TryParse(Console.ReadLine(), out int blogId))
            {
                var blog = context.Blogs.Find(blogId);
                if (blog != null)
                {
                    Console.Write("Enter comment content: ");
                    var content = Console.ReadLine();
                    var comment = new Comment
                    {
                        Content = content,
                        BlogId = blog.Id
                    };
                    context.Comments.Add(comment);
                    context.SaveChanges();
                    Console.WriteLine("Comment added successfully!");
                }
                else
                {
                    Console.WriteLine("Blog post not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public static void UpdateBlogPost(AppDbContext context)
        {
            Console.Write("Enter blog post Id to update: ");
            if (int.TryParse(Console.ReadLine(), out int blogId))
            {
                var blog = context.Blogs.Find(blogId);
                if (blog != null)
                {
                    Console.Write("Enter new blog title: ");
                    var newTitle = Console.ReadLine();
                    Console.Write("Enter new blog content: ");
                    var newContent = Console.ReadLine();
                    blog.Title = newTitle;
                    blog.Content = newContent;
                    context.SaveChanges();
                    Console.WriteLine("Blog post updated successfully!");
                }
                else
                {
                    Console.WriteLine("Blog post not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        public static void DeleteBlogPost(AppDbContext context)
        {
            Console.Write("Enter blog post Id to delete: ");
            if (int.TryParse(Console.ReadLine(), out int blogId))
            {
                var blog = context.Blogs.Find(blogId);
                if (blog != null)
                {
                    context.Blogs.Remove(blog);
                    context.SaveChanges();
                    Console.WriteLine("Blog post deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Blog post not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}