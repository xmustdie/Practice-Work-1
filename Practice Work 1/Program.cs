using System;
using System.Globalization;

namespace Practice_Work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch;
            do
            {
                ConsoleHelper.ShowMenu();
                caseSwitch = ConsoleHelper.ReadInt();
                if (caseSwitch > 0 && caseSwitch < 9)
                {
                    Console.WriteLine("\n---------------------------------");
                    Console.WriteLine("\n Результат выполнения задачи № " + caseSwitch + ":");
                    Console.WriteLine("\n---------------------------------" + "\n");
                    switch (caseSwitch)
                    {
                        case 1: task1(); break;
                        case 2: task2(); break;
                        case 3: task3(); break;
                        case 4: task4(); break;
                        case 5: task5(); break;
                        case 6: task6(); break;
                        case 7: task7(); break;
                        case 8: task8(); break;
                    }
                    Console.WriteLine("\n---------------------------------");
                }
                else if (caseSwitch != 0)
                {
                    ConsoleHelper.PrintError();
                }
            } while (caseSwitch != 0);

        }

        // блок методов с решениями
        private static void task1()
        {
            double num1 = +5.5e-2;
            float num2 = 7.8f;
            int num3 = 0;
            long num4 = 200000000L;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
        }

        private static void task2()
        {
            double pi = Math.PI;
            int tenThousand = 10000;
            double tenThousandPi = pi * tenThousand;
            int roundedTenThousandPi = (int)Math.Round(tenThousandPi);
            int integerPartOfTenThousandPi = (int)tenThousandPi;
            Console.WriteLine(integerPartOfTenThousandPi);
            Console.WriteLine(roundedTenThousandPi);
        }

        private static void task3()
        {
            double amount = 1.11;
            int peopleCount = 60;
            int totalMoney = (int)Math.Round(amount * peopleCount);
            Console.WriteLine(totalMoney);
        }

        private static void task4()
        {
            string doubleNumber = "894376.243643";
            double number = Double.Parse(doubleNumber,CultureInfo.InvariantCulture);
            Console.WriteLine(number + 1);
        }

        private static void task5()
        {
            var a = 5.0;
            a += 0.5;
            Console.WriteLine(a);
        }

        private static void task6()
        {
            Console.WriteLine(GetGreetingMessage("Student", 10.01));
            Console.WriteLine(GetGreetingMessage("Bill Gates", 100000000.5));
            Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
        }
        private static string GetGreetingMessage(string name, double salary)
        {
            return ("Hello, " + name + ", your salary is " + Math.Ceiling(salary));
        }


        private static void task7()
        {
            Print(GetSquare(42));

        }
        private static void Print(int myString)
        {
            Console.WriteLine(myString);
        }

        private static int GetSquare(int number)
        {
            return (number * number);
        }

        private static void task8()
        {
            Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));

        }

        private static string GetLastHalf(string text)
        {
            return text.Substring(text.Length / 2).Replace(" ", "");
        }
    }

    // вспомогательный класс
    public class ConsoleHelper
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Выберите номер задачи для просмотра результата выполнения кода: \n");

            Console.WriteLine("1 - Задание 1. Неверный тип данных");
            Console.WriteLine("2 - Задание 2. Ошибки преобразования типов");
            Console.WriteLine("3 - Задание 3. Биткоины в массы");
            Console.WriteLine("4 - Задание 4. Преобразование строки в число");
            Console.WriteLine("5 - Задание 5. Использование var");
            Console.WriteLine("6 - Задание 6. Добрый работодатель");
            Console.WriteLine("7 - Задание 7. Главный вопрос Вселенной");
            Console.WriteLine("8 - Задание 8. Разыскиваются методы!");
            Console.WriteLine("0 - Закончить работу");
        }

        public static int ReadInt()
        {
            int result;
            string inputString = Console.ReadLine();

            try
            {
                result = int.Parse(inputString);
            }
            catch (Exception e)
            {
                result = -1;
            }

            return result;
        }

        public static void PrintError()
        {
            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("\nНекорректный ввод. Введите пожалуйста цифру 0..8");
            Console.WriteLine("\n---------------------------------");
        }
    }
}
