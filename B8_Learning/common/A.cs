using B8_Learning.interfaceClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8_Learning.common
{
    internal class A : AI
    {
        public void ShowLanguage()
        {
            ArrayList myList = new ArrayList();
            myList.Add("C++");
            myList.Add("C#");
            myList.Add("java");
            myList.Add("Python");

            Console.WriteLine("List of language:");
            foreach(string child in myList)
            {
                Console.WriteLine(child);
            }

            Console.WriteLine("List of language:");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
