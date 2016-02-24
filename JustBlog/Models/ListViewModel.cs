using JustBlog.Core.EntityDatabase;
using JustBlog.Core.EntityDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Models
{
    public class ListViewModel
    {
        public ListViewModel(int pageNo = 1, int pageSize = 10)
        {
            using (var db = new JustBlogContext())
            {
                Posts = db.Posts.Include("Category").Include("Tags").Take(pageSize).ToList();
                //Posts = db.Posts.Where(p => p.Published)
                //                .OrderByDescending(p => p.PostedOn)
                //                .Skip(pageNo * pageSize)
                //                .Take(pageSize)
                //                .ToList();
                TotalPosts = Posts.Count;
            }
        }
        public IList<Post> Posts { get; private set; }
        public int TotalPosts { get; private set; }
    }
}
