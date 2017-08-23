using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public GradeBook()
        {
            grades1 = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades1.Add(grade);
        }

        List<float> grades1;
    }
}
