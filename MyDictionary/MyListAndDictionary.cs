using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyListAndDictionary<TKey,TValue>
    {
        TKey[] Id;
        TValue[] Name;
        TKey[] tempId;
        TValue[] tempName;

        public MyListAndDictionary()
        {
            Id = new TKey[0];
            Name = new TValue[0];
            
        }

        public void Add(TKey id , TValue name)
        {
            tempId = Id;
            tempName = Name;

            Id = new TKey[Id.Length + 1];
            Name = new TValue[Name.Length + 1];

            for (int i = 0; i < tempId.Length; i++)
            {
                Id[i] = tempId[i];

                Name[i] = name;

            }

            Id[Id.Length - 1] = id;
            Name[Id.Length - 1] = name;


        }
        public TKey[] ids
        {
            get { return Id; }
        }

        public TValue[] names
        { 
            get { return Name; } 
        }

        public int NameLenght 
        { 
            get { return Name.Length; } 
        }



    }
}
