using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApp.Models;
public class Blog
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public List<Comment> Comments { get; set; } = new List<Comment>();
}
