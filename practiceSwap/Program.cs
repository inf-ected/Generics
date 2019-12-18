using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceSwap
{
    class Test<T>{

        public static void Swap(ref T x,ref T y)
        {
            T tmp;
            tmp = x;
            x = y;
            y = tmp;
            //return tmp;
        }
    }
    public class test_obj<T>
    {
        public T MyProperty { get; set; }
        public test_obj(T x) { MyProperty = x; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 2;
            Console.WriteLine($"x={x} y={y}");
            Test<int>.Swap(ref x,ref y);
            Console.WriteLine($"x={x} y={y}");
            string xx = "privet", yy = "poka";
            Console.WriteLine($"xx={xx} yy={yy}");
            Test<string>.Swap(ref xx, ref yy);
            Console.WriteLine($"xx={xx} yy={yy}");

            test_obj<int> xxx = new test_obj<int>(101);
            test_obj<int> xxy = new test_obj<int>(999);

           //test_obj<string> yyy = new test_obj<string>("PRIVEEEEET!");

            Test<test_obj<int>>.Swap(ref xxx,ref xxy);
           //Test<object>.Swap(ref xxx,ref yyy); 


            Console.ReadKey();

        }
    }
}
