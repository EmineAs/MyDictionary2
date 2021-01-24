using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary2
{
    class CustomerManager
    {
         int i = 0;
         string ans;
         int id ;
         int index;




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

        public void List(MyDictionary<int, Customer> myDictionary) 
        {

            Console.Write("ID\t\tADI\t\tSOYADI\t\t\n");
            Console.WriteLine("----------------------------------------------");


            foreach (var cst in myDictionary._value)
            {
                Console.Write(cst.Id + "\t\t" + cst.Name + "\t\t" + cst.SurName + "\n");
            }
        }



        public void Find(MyDictionary<int, Customer> myDictionary)
        {
            do
            {

            Console.WriteLine("Bulmak istediğiniz kişinin id sini giriniz");
            id = Convert.ToInt32( Console.ReadLine());

           

            for (int i = 0; i < myDictionary._key.Count; i++)

            {
                if (id == myDictionary._key[i])
                {

                    index = i;

                }

            }


            Console.Write("ID\t\tADI\t\tSOYADI\t\t\n");
            Console.WriteLine("----------------------------------------------");

            Console.Write(myDictionary._value[index].Id+"\t\t"+myDictionary._value[index].Name+"\t\t"+myDictionary._value[index].SurName+"\n");

            Console.WriteLine("Başka arama yapmak istermisiniz...(Evet=E  Hayır=H)");
            ans = Console.ReadLine();


            } while (ans == "E");


        }

        public void Delete(MyDictionary<int, Customer> myDictionary) 
        {
            do
            {

                Console.WriteLine("Silmek istediğiniz kişinin id sini giriniz");
                id = Convert.ToInt32(Console.ReadLine());



                for (int i = 0; i < myDictionary._key.Count; i++)

                {
                    if (id == myDictionary._key[i])
                    {

                        index = i;

                    }

                }


                myDictionary._key.Remove(index);
                myDictionary._value.RemoveAt(index);


                List(myDictionary);







                Console.WriteLine("Başka silme yapmak istermisiniz...(Evet=E  Hayır=H)");
                ans = Console.ReadLine();


            } while (ans == "E");

        }
    }
}
