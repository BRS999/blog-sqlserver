using System;
using Intro;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            addBlog(new Blog { Url = "www.cnn.com" });
            getBlogs();
        }

        public static void getBlogs()
        {
            using (var db = new BloggingContext())
            {
                foreach (var x in db.Blogs)
                {
                    Console.WriteLine("Blog Id " + "\t" + x.BlogId + "\t" + "Blog Url " + "\t" + x.Url);
                }
            }
        }

        public static void addBlog(Blog blog)
        {
            using (var db = new BloggingContext())
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
            }
        }
    }
}
