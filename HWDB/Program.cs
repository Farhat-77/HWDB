using System;
using System.Linq;

namespace HWDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (helloappdbContext db = new helloappdbContext())
            {
                var users = db.Users.ToList();
                Console.WriteLine("Список статьи:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Articles} - {u.Categories} - {u.Authors}");
                }
            }
            Console.ReadKey();
        }
    }
}
