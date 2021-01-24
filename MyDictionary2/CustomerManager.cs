using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary2
{
    public class CustomerManager
    {
        public int i = 0;
        public string ans;




        public void Add(MyDictionary<int,Customer> myDictionary)
        {
            do
            {

                Customer customer = new Customer();

                customer.Id = i;
                i++;

                Console.WriteLine("Müşterinin Adını Giriniz...");
                customer.Name = Console.ReadLine();

                Console.WriteLine("Müşterinin Soyadını Giriniz...");
                customer.SurName = Console.ReadLine();

                //cstmr.Add(customer);

                myDictionary.Add(customer.Id, customer);


                Console.WriteLine("Başka müşteri ekleyecek misiniz...(Evet=E  Hayır=H)");
                ans = Console.ReadLine();


            } while (ans == "E");

            

        }

        public void Find(MyDictionary<int, Customer> myDictionary)
        {

            Console.WriteLine("Bulmak istediğiniz kişinin id sini giriniz");

        }
    }
}
