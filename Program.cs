using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConAppGenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList arrayList = new ArrayList()
            //{ 1,"Sam","A",DateTime.Now};
            //Console.WriteLine("item \t DataType");
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item+"\t"+item.GetType());
            //}
            //ArrayList nameList = new ArrayList() { "Raj", "Ravi", "Amit" };
            //Console.WriteLine("Name List as Follows");
            //foreach(var item in nameList)
            //{
            //    Console.WriteLine(item);
            //}
            //nameList.Add(12);
            //nameList.Add(DateTime.Now);
            //Console.WriteLine("Name List as follows");
            //foreach(var item in nameList)
            //{
            //    Console.WriteLine(item);
            //}

            List<string> listNames = new List<string>() { "Sam", "Ravi", "Amit" };
            Console.WriteLine("*** Name List ***");
            foreach(var item in listNames)
            {
                Console.WriteLine(item);
            }
            listNames.Add("Renu");
            Console.WriteLine("*** Name List after adding one more item ***");
            foreach(var item in listNames)
            {
                Console.WriteLine(item);
            }
            List<int> listNumbers = new List<int>()
            { 12,23,45,56};
            Console.WriteLine("*** Number List ***");
            foreach(var item in listNumbers)
            {
                Console.WriteLine(item);
            }
            listNumbers.Add(145);
            Console.WriteLine("*** Number List after adding 145 ***");
            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
