using B8_Learning.interfaceClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8_Learning.common
{
    internal class C : AI, BI
    {
        A a = new A();
        B b = new B();

        public void ShowLanguage()
        {
            a.ShowLanguage();
        }

        public void ShowCourse()
        {
            b.ShowCourse();
        }
    }
}
