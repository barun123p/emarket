﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        private static object Gradebook;

        static void Main(string[] args)
        {
            
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);

            GradeBook book2 = new GradeBook();
            book2.AddGrade(75);



            

        }
    }
}
