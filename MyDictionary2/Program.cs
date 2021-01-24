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
            customerManager.List(myDictionary);
            customerManager.Find(myDictionary);
            customerManager.Delete(myDictionary);



        }
    }
}
