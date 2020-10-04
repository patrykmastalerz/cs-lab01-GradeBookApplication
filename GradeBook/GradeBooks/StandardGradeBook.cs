using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
 
    public class StandardGradeBook : BaseGradeBook
    {
        //public GradeBookType Type; 
        public StandardGradeBook(string name, bool param) : base(name, param)
        {

            Type = GradeBookType.Standard;
        }
    }
}
