using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12_CC_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            TV t = new TV();
            //OnClickPowerButton(t);
            Computer c = new Computer();
            //OnClickPowerButton(c);
            Phone p = new Phone();
            //OnClickPowerButton(p);
            IOnable[] onables = new IOnable[3]
            {
                t,c,p
            };
            for (int i = 0; i < onables.Length; i++)
            {
                OnClickPowerButton(onables[i]);
            }
        }

        public static void OnClickPowerButton(IOnable onable)
        {
            onable.On();
        }

        //public static void OnClickPowerButton(Computer comp)
        //{
        //    comp.On();
        //}

        //public static void OnClickPowerButton(Phone phone)
        //{
        //    phone.On();
        //}
    }

    public interface IOnable
    {
        void On();
    }
    public class TV : IOnable
    {
        public void On()
        {
            Console.WriteLine("This Tv ON");
        }
    }

    public class Computer : IOnable
    {
        public void On()
        {
            Console.WriteLine("This Computer ON");
        }
    }

    public class Phone : IOnable
    {
        public void On()
        {
            Console.WriteLine("This Phone ON");
        }
    }
    //public interface IElectricDevice
    //{
    //    void On();
    //}
}
