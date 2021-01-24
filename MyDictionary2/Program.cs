using System;
using System.Collections.Generic;

namespace MyDictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomerManager customerManager = new CustomerManager();
            MyDictionary<int, Customer> myDictionary = new MyDictionary<int, Customer>();

            customerManager.Add(myDictionary);


            Console.Write("ID\t\tADI\t\tSOYADI\t\t\n");
            Console.WriteLine("----------------------------------------------");


            foreach (var cst in myDictionary._value)
            {
                Console.Write(cst.Id + "\t\t" + cst.Name + "\t\t" + cst.SurName + "\n");
            }


        }
    }
}
