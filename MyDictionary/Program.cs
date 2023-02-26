using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyListAndDictionary<int , string> myListAndDictionary = new MyListAndDictionary<int , string>();

            myListAndDictionary.Add(1235, "Hikmet");
            myListAndDictionary.Add(5654, "Ali");
            myListAndDictionary.Add(5465, "Selin");

            for (int i = 0; i < myListAndDictionary.NameLenght; i++)
            {
                Console.WriteLine("Kisi Id :"+ myListAndDictionary.ids[i]+"      "+"Kisi Name" + myListAndDictionary.names[i]);
            }

            Console.WriteLine("Kisi Sayisi:  "+ myListAndDictionary.NameLenght);




            Console.ReadLine();
        }
    }
}
