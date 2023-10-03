using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_CGPA.GradePoint
{
  static class Grade
    {
        static public double gradePoint(int mark)
        {
            double point;
    
            if (mark >= 80 && mark <= 100)
            {
                point = 4.00;
            }
            else if (mark >= 75 && mark <= 79)
            {
                point = 3.75;
            }
            else if (mark >= 70 && mark <= 74)
            {
                point = 3.50;
            }
            else if (mark >= 65 && mark <= 69)
            {
                point = 3.25;
            }
            else if (mark >= 60 && mark <= 64)
            {
                point = 3.00;
            }
            else if (mark >= 55 && mark <= 59)
            {
                point = 2.75;
            }
            else if (mark >= 50 && mark <= 54)
            {
                point = 2.50;
            }
            else if (mark >= 45 && mark <= 49)
            {
                point = 2.25;
            }
            else if (mark >= 40 && mark <= 44)
            {
                point = 2.00;
            }
            else 
            {
                point = 0.0;
            }
            return point;
        }
    }
}
