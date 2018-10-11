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

            Console.WriteLine($"{mis3033}");
            Console.ReadKey();
        }

        private static Course ProcessCourseFile(string[] courseLines)
        {
            Course newCourse = new Course();
            string courseInfo = courseLines[0];
            string[] firstLineParts = courseInfo.Split(',');
            newCourse.CourseName = firstLineParts[0].Trim();
            newCourse.Instructor = firstLineParts[1].Trim();

            for (int i = 1; i < courseLines.Length; i++)
            {
                string line = courseLines[i].Trim();

                if (line != string.Empty)
                {
                    var lineParts = line.Split(':');  // Separate the line so we have Homework/Quiz/etc. 

                    var area = lineParts[0].Trim(); // The area's for the percent is always before the :, so it will always be at index 0
                    double gradePercent = Convert.ToDouble(lineParts[1].Trim().Replace("%", "")) / 100; // There is only one grade to the right so we do not need to split any further.  It is also a string because there is a % at the end which is not a number but a character so we need to remove it

                    switch (area.ToLower())
                    {
                        case "homework":
                            newCourse.HomeworkPercentage = gradePercent;
                            break;
                        case "quiz":
                            newCourse.QuizPercentage = gradePercent;
                            break;
                        case "participation":
                            newCourse.ParticipationPercentage = gradePercent;
                            break;
                        case "exams":
                            newCourse.ExamPercentage = gradePercent;
                            break;
                        case "final exam":
                            newCourse.FinalExamPercentage = gradePercent;
                            break;
                        default:
                            break;
                    }
                }

            }

            return newCourse;
        }
    }
}
