using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_CC_Interfaces
{
    class Calculator : ICalc
    {
        public int Calc(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
