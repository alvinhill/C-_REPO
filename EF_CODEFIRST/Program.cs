using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;




namespace EF_CODEFIRST
{
    class Program
    {
        static void Main(string[] args)
        {
            // I HAD TO INSTALL ENTITY FRAMEWORK 5.02 INTO THIS PROJECT (GO FIGURE)
            // I GOT ALL COMPILE ERRORS HANDLED MOSTLY WITH THE EF INSTALL
            using( var db = new BlogContext())
            {
                Console.Write("Enter a name for a new blog: ");
                var name = Console.ReadLine();// name is name of the blog

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);// getting no database error here
                db.SaveChanges();

                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                foreach (var item in query)
                {

                    Console.Write(item.Name);
                }

            }
        }
    }

    public class Blog
    {

        //SCALAR UP PROPERTIES
        public int BlogId { get; set; }
        public string Name { get; set; }
        

        // NAVIGATION PROPERTY
        public virtual List<Post> Posts { get; set; }

    }
    // NAVIGATION PROPERTIES defines relationships between classes   
        public class Post
        {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; } 
        

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set;}



          }
        
    public class BlogContext:DbContext
    {// DB CONTEXT BASE CLASS IS ALL THE DATABASE INTERACTION
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

    }

   
         }






