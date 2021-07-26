using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_CC_Interfaces
{
    public interface InterfaceBase1
    {
        int Name { get; set; }
        void Eat();
    }

    public interface IntrefaceSon : InterfaceBase1
    {
        //int Name { get; set; }
        //void Eat();
        void Move(int cm);
    }

    public class OnlyBase : InterfaceBase1
    {
        public int Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }

    public class AllInterfaces : IntrefaceSon
    {
        public int Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Move(int cm)
        {
            throw new NotImplementedException();
        }
    }
}
