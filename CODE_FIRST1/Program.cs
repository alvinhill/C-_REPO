using LinqToDB;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_FIRST1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        DataContext Sdata = new DataContext("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=entitytestDb;Data Source=EARTH\\SQLEXPRESS");


        // THE CODE IS GOOD THE FORMAT I AM USING IS FROM AN MVC PROJECT
        // TRY PUTTING THIS CODE INTO A SIMPLER FORMAT !!!!
        // IS SHOULD WORK
        User user = new User()

        {
            StudentName = "Stan",

           
        };

        Sdata.Users.Add(user);
        Sdata.SaveChanges();




}

 



}
