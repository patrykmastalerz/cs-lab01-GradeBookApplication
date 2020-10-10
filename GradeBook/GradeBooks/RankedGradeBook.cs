using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool param) : base(name,  param)
        {
            Type = Enums.GradeBookType.Ranked;
        }


        public override char GetLetterGrade(double averageGrade)
        {

        
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

        
            int Fist20ProcentOfStudents = Students.Count / 5;
           
            int counter = 1;
            foreach (var student in Students)
            {
                if (student.AverageGrade < averageGrade)
                {
                    counter++;
                }
            }
            int grade = counter / Fist20ProcentOfStudents;

            if (grade == 5)
                return 'A';
            else if (grade == 4)
                return 'B';
            else if (grade == 3)
                return 'C';
            else if (grade == 2)
                return 'D';
            else
                return 'F';

        }
 

        public override void CalculateStatistics()
        {
            
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }



        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }


    }
}
