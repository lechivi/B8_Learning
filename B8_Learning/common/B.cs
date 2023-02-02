using B8_Learning.interfaceClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8_Learning.common
{
    internal class B : BI
    {
        //Viết code cho các phương thức mà implement từ interface
        public void ShowCourse()
        {
            ArrayList myList = new ArrayList();
            myList.Add("Lap trinh Python");
            myList.Add("java cho Android");
            myList.Add("Laravel");
            myList.Add("AI");

            Console.WriteLine("List of Course:");
            foreach (string child in myList)
            {
                Console.WriteLine(child);
            }

            Console.WriteLine("List of Course:");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
