using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    public class Course
    {
        public string CourseName { get; set; }

        public string Instructor { get; set; }

        public double HomeworkPercentage { get; set; }

        public double QuizPercentage { get; set; }

        public double ParticipationPercentage { get; set; }

        public double ExamPercentage { get; set; }

        public double FinalExamPercentage { get; set; }

        public override string ToString()
        {
            return $" {this.CourseName} taught by {this.Instructor} has the following weights:\n Homework: { this.HomeworkPercentage}\n Quiz: { this.QuizPercentage}\n Participation: { this.ParticipationPercentage}\n Exam: { this.ExamPercentage}\n Final Exam: { this.FinalExamPercentage}";
        }

    }
}
