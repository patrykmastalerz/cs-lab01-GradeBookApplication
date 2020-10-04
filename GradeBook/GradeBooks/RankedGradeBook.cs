using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
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
            if (averageGrade > 20)
                return 'A';
            else if (averageGrade > 40)
                return 'B';
            else if (averageGrade >= 50)
                return 'C';
            else if (averageGrade >= 80)
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
