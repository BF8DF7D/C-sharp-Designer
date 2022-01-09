using System;

namespace С_sharp_Designer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");

            Console.WriteLine(" Конструкторы со всеми параметрами" +
                    "\n Создание параметров:");
            Date date = new Date();
            Time time = new Time();
            int kabinet = Talon.InputFormatInt();
            Doctor medic = new Doctor();

            Console.WriteLine("\n Объект");
            Talon one = new Talon(date, time, kabinet, medic);
            one.PrintInfo();
            Console.WriteLine();

            Console.WriteLine(" Конструкторы с одним параметром");
            one = new Talon(medic);
            Console.WriteLine();
            one.PrintInfo();

            Console.WriteLine("\n");

            Console.WriteLine(" Конструкторы без параметров");
            one = new Talon();
            Console.WriteLine();
            one.PrintInfo();

            Console.WriteLine("\n");

            Console.WriteLine(" Инициализация массива через конструктор с одним параметром" +
                    "\n Создание параметра:");
            Doctor for_array = new Doctor();
            Console.WriteLine();
            Console.WriteLine(" Инициализация массива:");
            Talon[] array = new Talon[3];
            for (int number = 0; number < array.Length; number++)
            {
                array[number] = new Talon(for_array);
                Console.WriteLine();
            }
            Console.WriteLine(" Печать массива:");
            for (int number = 0; number < array.Length; number++)
                array[number].PrintInfo();
            Console.ReadKey();
        }
    }
}
