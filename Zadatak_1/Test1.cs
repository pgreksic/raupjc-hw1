using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_1
{
    class Test1
    {
        static void Main(string[] args)
        {
            IntegerList lista = new IntegerList();
            
            ListExample(lista);
            
            
        }

        public static void ListExample(IIntegerList listOfIntegers)
        {
            listOfIntegers.Add(1); // [1]
            listOfIntegers.Add(2); // [1 ,2]
            listOfIntegers.Add(3); // [1 ,2 ,3]
            listOfIntegers.Add(4); // [1 ,2 ,3 ,4]
            listOfIntegers.Add(5); // [1 ,2 ,3 ,4 ,5]
            listOfIntegers.RemoveAt(0); // [2 ,3 ,4 ,5]
            listOfIntegers.Remove(5); //[2 ,3 ,4]
            Console.WriteLine(listOfIntegers.GetElement(0).ToString() + listOfIntegers.GetElement(1).ToString() + listOfIntegers.GetElement(2).ToString());
            Console.WriteLine(listOfIntegers.Count); // 3
            try
            {
                Console.WriteLine(listOfIntegers.Remove(100)); // false
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine("false, exception was caught");
            }
            try
            {
                Console.WriteLine(listOfIntegers.RemoveAt(5)); // false
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine("false, exception was caught");
            }
            listOfIntegers.Clear(); // []
            Console.WriteLine(listOfIntegers.Count); // 0
            Console.Read();
        }


}
}



