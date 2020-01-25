using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbFirst
{
    public enum Level : byte
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var dbContext = new PlutoDbContext();

            dbContext.GetAuthorCourses(1);

            var courses = dbContext.GetCourses();
            foreach (var c in courses)
            {
                Console.WriteLine(c.Title);
                Console.ReadLine();
            }

            var course = new Course();
            //course.Level = CourseLevel.Advanced; //3
            course.Level = Level.Advanced; //2
        }
    }
}