using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_Generics_Part2
{
    /*Задание 2. Программа «Статистика». Подсчитать, сколько раз каждое слово 
     * встречается в заданном тексте. Результат записать 
     * в коллекцию Dictionary<TKey, TValue>. Текст использовать из приложения 1. 
     * Вывести статистику по тексту в виде таблицы (рисунок 1).
Приложение 1.
Вот дом, 
Который построил Джек.
А это пшеница,
Которая в темном чулане хранится 
В доме, Который построил
Джек. 
А это веселая птица-синица, 
Которая часто ворует
пшеницу,
Которая в темном чулане хранится 
В доме,
Который построил Джек.
*/
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Вот дом," +
                         "Который построил Джек." +
                         "А это пшеница," +
                        "Которая в темном чулане хранится " +
                        "В доме, Который построил " +
                        "Джек." +
                        "А это веселая птица-синица," +
                        "Которая часто ворует " +
                        "пшеницу, " +
                        "Которая в темном чулане хранится " +
                        "В доме," +
                        "Который построил Джек.";
            string[] words =   str.ToLower().Split(new char[]{',','.',' ','-' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsMap = new Dictionary<string, int>();

            foreach (var x in words)
                if (wordsMap.ContainsKey(x))
                    wordsMap[x]++;
                else
                    wordsMap.Add(x, 1);
            int i = 1;
            foreach (var x in wordsMap)
                Console.WriteLine($"{i++}\t{x.Key}\t\t{x.Value}");

            Console.ReadKey();
        }
    }
}
