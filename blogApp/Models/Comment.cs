using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogApp.Models;
public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public DateTime DateCreated { get; set; } = DateTime.Now;
    public int? BlogId { get; set; }
}
