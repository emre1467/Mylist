using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<String> Person = new MyList<string>();
            Console.WriteLine(Person.Count);
            Person.Add("emre");
            Console.WriteLine(Person.Count);
            Person.Add("ali");
            Console.WriteLine(Person.Count);
            Person.Add("veli");
            Console.WriteLine(Person.Count);

        }
    }
    class MyList<T>
    {
        T[] persons;
        public MyList()
        {
            persons = new T[0];
        }
        public void Add(T name)
        {
            T[] TempPersons = persons;

            persons = new T[persons.Length + 1];
            for (int i = 0; i < TempPersons.Length; i++)
            {
                persons[i] = TempPersons[i];
            }
            persons[persons.Length - 1] = name;
        }
        public int Count
        {
            get { return persons.Length; }
        }
    }
}
