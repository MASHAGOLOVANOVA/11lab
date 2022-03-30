using System;
using System.Collections.Generic;
using System.Text;
using laba10;

namespace laba10
{
    public class InputOutputClass
    {
        static public void MainMenu()
        {
            Console.WriteLine("`````````````````````````````````````");
            Console.WriteLine("Давайте поработаем с коллекциями иерархии классов Организация!");
            Console.WriteLine("Выберите команду");
            Console.WriteLine("1) Поработать с коллекцией");
            Console.WriteLine("2) Поработать с обобщенной коллекцией");
            Console.WriteLine("3) Поработать с классом TestCollections");
            Console.WriteLine("4) Выход из программы");
            Console.WriteLine("`````````````````````````````````````");
        }

        static public void OrganisationMenu()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Выберите команду");
            Console.WriteLine("1) Создать коллекцию");
            Console.WriteLine("2) Добавление объекта коллекции");
            Console.WriteLine("3) Вывести количество элементов типа Организация");
            Console.WriteLine("4) Вывести элементы типа Библиотека");
            Console.WriteLine("5) Вывести количество каждого типа в массиве");
            Console.WriteLine("6) Выполнить клонирование коллекции.");
            Console.WriteLine("7) Выполнить сортировку коллекции");
            Console.WriteLine("8) Выполнить поиск элемента по индексу");
            Console.WriteLine("9) Назад");
        }

        static public void TestCollectionsMenu()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Выберите команду");
            Console.WriteLine("1) Создать коллекции случайным образом");
            Console.WriteLine("2) Добавление и удаление объекта коллекций");
            Console.WriteLine("3) Вывести первый,последний и средний элемент в коллекции и узнать время которое было потрачено на поиск их и не входящего в коллекцию элемента");
            Console.WriteLine("4) Назад");
        }

        static public string CollectionCondition()
        {
            return "Будет случайным образом создана коллекция из 1000 элементов, где есть объекты из производных классов и базового класса Организация";
        }
        static public int MainInput()
        {
            MainMenu();
            string variant = Console.ReadLine();
            if (Check(variant, 0, 5))
            {
                int result = int.Parse(variant);
                return result;
            }
            else
            {
                Console.WriteLine("Введено неправильно, попробуйте снова!");
                return 0;
            }
        }

        static public int OperationsInput12()
        {
            OrganisationMenu();
            string variant = Console.ReadLine();
            if (Check(variant, 0, 10))
            {
                int result = int.Parse(variant);
                return result;
            }
            else
            {
                Console.WriteLine("Введено неправильно, попробуйте снова!");
                return 0;
            }
        }
        static public int OperationsInput3()
        {
            TestCollectionsMenu();
            string variant = Console.ReadLine();
            if (Check(variant, 0, 5))
            {
                int result = int.Parse(variant);
                return result;
            }
            else
            {
                Console.WriteLine("Введено неправильно, попробуйте снова!");
                return 0;
            }
        }

        static public bool Check(string variant, int a, int b)
        {
            int result = 0;
            bool isRight;
            try
            {
                result = int.Parse(variant);
                isRight = true;
            }
            catch
            {
                isRight = false;
            }
            if (!isRight)
                return false;
            else
            if (a < result && result < b)
                return true;
            else
                return false;
        }

        static public int LightCheck(string variant)
        {
            int result = 0;
            bool isRight;
            try
            {
                result = int.Parse(variant);
                isRight = true;
            }
            catch
            {
                isRight = false;
            }
            if (isRight)
                return result;
            else
                return -1;
        }


    }
}

