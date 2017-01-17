using System;
using Intro;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                var blog = new Blog { Url = "http://sample1231233.com" };
                db.Blogs.Add(blog);
                db.SaveChanges();
            }

            using (var db = new BloggingContext())
            {
                foreach (var x in db.Blogs)
                {
                    Console.WriteLine("Blog Url " + "\t" + x.Url);
                }
            }
        }
    }
}
