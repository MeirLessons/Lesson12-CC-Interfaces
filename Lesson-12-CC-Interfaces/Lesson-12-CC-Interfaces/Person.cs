using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_CC_Interfaces
{
    class Person : IPerson
    {
        private int age;
        public int Age { get { return age; } set { age = value; } }
        public string Name { get; set; }

        public void Work()
        {

        }

    }
}
