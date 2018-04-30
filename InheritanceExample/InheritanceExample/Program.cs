using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person test = new Person("Joe", "Bull", 11);

            Console.WriteLine(test.Talk());
            Console.ReadKey();
        }
    }
}
