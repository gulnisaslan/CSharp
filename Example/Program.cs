using System;

namespace Example
{
    class Program
    {
        private static bool value;

        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(10, "Buket");
            myDictionary.Add(15, "Ceylin");
            myDictionary.Add(20, "Bertan");
            myDictionary.Add(25, "Gülsevim");
            myDictionary.Add(30, "Bülent");

            myDictionary.ListAllValue();
            Console.WriteLine("********");
            myDictionary.ListValueByKey(20);
            myDictionary.ListValueByKey(10);

            //MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            //myDictionary.Add("Pencil", "Kurşun Kalem");
            //myDictionary.Add("Eraser", "Silgi");
            //myDictionary.Add("Pencil Case", "Kalemlik");


            //foreach (var value in myDictionary.Values)
            //{
            //    Console.WriteLine(value);
            //}

            //myDictionary.Add("School Bag", "Okul Çantası");
            //foreach (var value in myDictionary.Values)
            //{
            //    Console.WriteLine(value);
            //}

            //myDictionary.Add("Glass", "Bardak");
            //foreach (var value in myDictionary.Values)
            //{
            //    Console.WriteLine(value);
            //}


        }
    }
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;

        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }

        public void Add(Tkey keyItem, Tvalue valueItem)
        {
            Tkey[] tempKeys = keys;
            Tvalue[] tempValues = values;

            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = keyItem;
            values[values.Length - 1] = valueItem;

        }

        public void ListValueByKey(Tkey keyItem)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(keyItem))
                {
                    Console.WriteLine("bulundu: " + keys[i] + " " + values[i]);
                }

            }
        }

        public void ListAllValue()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " " + values[i]);
            }


        }

    }
    //class MyDictionary<TKey, TValue>
    //{
    //    TKey[] keys;
    //    TValue[] values;
    //    public MyDictionary()
    //    {
    //        keys = new TKey[0];
    //        values = new TValue[0];
    //    }

    //    public void Add(TKey key, TValue value)
    //    {
    //        TKey[] tempKeys = keys;
    //        TValue[] tempValues = values;

    //        keys = new TKey[keys.Length + 1];
    //        values = new TValue[values.Length + 1];

    //        int i = 0;
    //        while (i < tempKeys.Length)
    //        {
    //            keys[i] = tempKeys[i];
    //            values[i] = tempValues[i];
    //            i++;
    //        }

    //        keys[keys.Length - 1] = key;
    //        values[values.Length - 1] = value;

    //    }

    //    public TKey[] Keys
    //    {
    //        get { return keys; }
    //    }

    //    public TValue[] Values
    //    {
    //        get { return values; }
    //    }

    //}
}
