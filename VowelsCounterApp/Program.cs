using System;

namespace VowelsCounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputTextToVowelCount();
        }
        public static void InputTextToVowelCount()
        {

            string input = string.Empty;
            while (input != "N")
            {
                Console.WriteLine("Escriba un texto para contentar sus vocales.");
                input = Console.ReadLine();
                var vowels = Counter.VowelsCounter.Count(input);
                if (vowels.Count == 0)
                {
                    Console.WriteLine($"Esta lista esta vacia su entrada fue ({input})");
                }
                else
                {
                    foreach (var item in vowels)
                    {
                        Console.WriteLine($"{{{item.Key}:{item.Value}}}\n");
                    }
                }
                Console.WriteLine("Para Salir Digite la letra *(N)*");
                input = Console.ReadLine();
            }

        }
    }
}
