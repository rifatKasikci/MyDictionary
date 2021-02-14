using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> isimler = new Dictionary<int, string>();
            isimler.Add(1,"Helin");
            isimler.Add(2, "Selin");
            isimler.Add(3, "Gizem");
            isimler.Add(4, "Alp");
            isimler.Add(5, "Bekir");
            Console.WriteLine("Dictionary : " + isimler.Count);
            Console.WriteLine("****************************************");
            MyDictionary<int, string> isimler2 = new MyDictionary<int, string>();
            isimler2.Add(1,"Ali");
            isimler2.Add(2, "Mehmet");
            isimler2.Add(3, "Ayşe");
            isimler2.Add(4, "Fatma");
            isimler2.Add(5, "Huriye");
            isimler2.Add(6, "Salih");
            Console.WriteLine("MyDictionary : " + isimler2.Count);


            /*ÇIKTI:
            
          Dictionary : 5
          ****************************************
          MyDictionary : 6
          
            */
        }
    }
}
