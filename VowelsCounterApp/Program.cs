using System;

namespace VowelsCounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputValueToVowelCounted();
        }
        
        public static void InputValueToVowelCounted()
        {
            string ValueT = "";
            while(ValueT != "S")
            {
                Console.WriteLine("Escriba Cualquier palabra");
                ValueT = Console.ReadLine();

                var Vowels = Counter.VowelsCounter.Count(ValueT);
                if (Vowels.Count == 0)
                {
                    Console.WriteLine($"Lista vacia Entrada: ({ValueT})");
                }
                else
                {
                    foreach (var item in Vowels)
                    {
                        Console.WriteLine($"++{item.Key} : {item.Value}++");
                    }
                }
                Console.WriteLine("Salir Presione ++{S}++");
                ValueT = Console.ReadLine();
            }
        }
    }
}
