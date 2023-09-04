using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODEFIRST2
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
         
            User user = new User()

            {
                StudentName = "Stan",


            };
            string connectionString = ("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=entitytestDb;Data Source=EARTH\\SQLEXPRESS");
            using (var entitytestDb = new DataContext(connectionString))

            entitytestDb.Users.Add(user);
           // entitytestDb.SaveChanges();

        }


        class User
        {
            public int Id { get; set; }
            public string StudentName { get; set; }


        }

        class DataContext : DbContext

        {
          


            public DataContext(string connectionString) : base(connectionString)
            {
               
            }
            public virtual DbSet<User> Users { get; set; }

        }



    }
}
