using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_CC_Interfaces
{
    interface IPerson
    {
        int Age { get; set; }
        string Name { get; set; }

        void Work();
    }
}
