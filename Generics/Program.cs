using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
           cities.Add("Gaziantep");
            cities.Add("Gaziantep");
            cities.Add("Gaziantep");
            cities.Add("Gaziantep");
            cities.Add("Gaziantep");


            Console.WriteLine(cities.Count);
            
           
            
            MyList<string> cities1 = new MyList<string>();
           cities1.Add("İstanbul");
            cities1.Add("İstanbul");
            cities1.Add("İstanbul");
            cities1.Add("İstanbul");
            cities1.Add("İstanbul");
            cities1.Add("İstanbul");


            Console.WriteLine(cities1.Count);

            

        }
    }
    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
            
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length-1] = item;
        }
        

        public int Count
        {
            get { return _array.Length; }
            
        } 


    }
}
