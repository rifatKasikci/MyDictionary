using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey,Tvalue>
    {


        Tkey[] Tkey_Array;
        Tvalue[] Tvalue_Array;


        Tkey[] Tkey_tempArray;
        Tvalue[] Tvalue_tempArray;

        public MyDictionary()
        {
           Tkey_Array = new Tkey[0];
            Tvalue_Array = new Tvalue[0];
        }

        public void Add(Tkey tkey , Tvalue tvalue)
        {
            Tkey_tempArray = Tkey_Array;
            Tvalue_tempArray = Tvalue_Array;

            Tkey_Array = new Tkey[Tkey_Array.Length + 1];
            Tvalue_Array = new Tvalue[Tvalue_Array.Length + 1];

            for (int i = 0; i < Tkey_tempArray.Length; i++)
            {
                Tkey_Array[i] = Tkey_tempArray[i];
                
            }

            for (int i = 0; i < Tvalue_tempArray.Length; i++)
            {
                Tvalue_Array[i] = Tvalue_tempArray[i];
            }

            Tkey_Array[Tkey_Array.Length - 1] = tkey;
            Tvalue_Array[Tvalue_Array.Length - 1] = tvalue;

        }

        public int Count
        {

            get { return Tkey_Array.Length; }

        }

       

    }
}
