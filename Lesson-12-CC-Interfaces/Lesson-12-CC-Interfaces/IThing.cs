using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_CC_Interfaces
{
    interface IThing
    {
        void Foo();
    }

    interface IBrakeable
    {
        void Break();
    }

    interface IElectricDevice : IBrakeable
    {
        void On();
        void Off();
    }
}
