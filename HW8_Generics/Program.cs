using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_Generics
{
    /*Напишите программу, в которой есть статический обобщенный метод.
     * Аргументом методу передается массив из элементов обобщенного типа.
     * Результатом метод возвращает значение наибольшего/наименьшего элемента 
     * в массиве. 
     * Чтобы можно было сравнивать значения обобщенного типа, 
     * на этот обобщенный тип следует наложить ограничение: тип должен быть 
     * таким, что реализует интерфейс IComparable. 
     * Если так, то для сравнения
     * значений может использоваться метод CompareTo(). Метод вызывается из 
     * одного объекта (первый объект) обобщенного типа, а аргументом ему 
     * передается другой (второй) объект обобщенного типа (сравниваемые объекты).
     * Результатом метода является целое число. Отрицательное число возвращается, 
     * если первый объект «меньше» второго. Положительное число возвращается, 
     * если первый объект «больше» второго. Если объекты равны друг другу,
     * то результатом метода CompareTo() является нулевое значение.*/
    class Program
    {
        //where T: IComparable
        public static T testMethod<T> (T[] arr) where T : IComparable
        {
            T tmp = arr.Max();

            return tmp;
        }



        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine($"{testMethod<int>(arr)}");


            person[] groupe = {
                new person("Ivanov","Ivan",23),
                new person("Petrov","Petr",18),
                new person("Sidorov","Sidor",33)
            };
            Console.WriteLine($"{testMethod<person>(groupe)}");


            Console.ReadKey();
        }
    }
}
