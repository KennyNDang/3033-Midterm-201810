using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DIRECTORY_PATH = @"C:\Users\acke9387\Source\Repos\Acke9387\3033-Midterm-201810\Input File Examples\";
            string[] courseLines = System.IO.File.ReadAllLines(DIRECTORY_PATH + "course.txt");

            Course mis3033 = ProcessCourseFile(courseLines);

            Console.WriteLine($"{mis3033.CourseName} is taught by {mis3033.Instructor}");
            Console.ReadKey();
        }

        private static Course ProcessCourseFile(string[] courseLines)
        {
            Course newCourse = new Course();
            string courseInfo = courseLines[0];
            string[] firstLineParts = courseInfo.Split(',');
            newCourse.CourseName = firstLineParts[0].Trim();
            newCourse.Instructor = firstLineParts[1].Trim();

            
            //foreach (var line in firstLineParts)
            //{
            //    Console.WriteLine(line);
            //}

            return newCourse;
        }
    }
}
