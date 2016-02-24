using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using JustBlog.Core.EntityDatabase.Models;

namespace JustBlog.Core.EntityDatabase
{
    public class JustBlogContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public JustBlogContext() : base("JustBlogConnectionString")
        {

        }
    }

}
