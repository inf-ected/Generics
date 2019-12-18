using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> darr_i = new DynamicArray<int>(7);
            for (int i = 0; i < darr_i.Capacity; i++)
            {
                darr_i.AddItem(i);
            }

            darr_i["first"] = 99;
            darr_i["last"] = 99;

            Console.WriteLine( "!!! ");
            for (int i = 0; i < darr_i.Count; i++)
            {
                Console.WriteLine(darr_i[i] + " ");
            }
            Console.WriteLine("!!! ");


            DynamicArray<string> str = new DynamicArray<string>(7);


           
            for (int i = 0; i < str.Capacity; i++)
            {
                str.AddItem(i+"@");
            }
            str["first"] = "Privet";
            str["last"] = "Medved";
            for (int i = 0; i < str.Count; i++)
            {
                Console.WriteLine(str[i] + " ");
            }






            Console.ReadKey();

        }
    }
}
