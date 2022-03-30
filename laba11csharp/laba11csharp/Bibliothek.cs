using System;
using System.Collections.Generic;
using System.Text;

namespace laba10
{
    public class Bibliothek : Organisation, ICloneable, IInit, IComparable
    {
        protected int numberOfBooksInStock;
        protected int numberOfEveryMonthNewCustomers;
        protected int year;
        public int NumberOfEveryMonthNewCustomers
        {
            get => numberOfEveryMonthNewCustomers;
            set
            {
                if (value >= 0) numberOfEveryMonthNewCustomers = value;
                else
                {
                    numberOfEveryMonthNewCustomers = 0;
                    Console.WriteLine("Количество клиентов библиотеки не может быть меньше 0");
                }
            }
        }
        public int NumberOfBooksInStock
        {
            get => numberOfBooksInStock;
            set
            {
                if (value >= 0) numberOfBooksInStock = value;
                else
                {
                    numberOfBooksInStock = 0;
                    Console.WriteLine("Количество различных книг в библиотеке не может быть меньше 0");
                }
            }
        }

        public Bibliothek() : base()
        {
            NumberOfBooksInStock = 0;
            NumberOfEveryMonthNewCustomers = 0;
        }

        public Bibliothek(string _name, int _numberOfWorkers, int _year, int _numberOfBooksInStock, int _numberOfEveryMonthCustomers) : base(_name, _numberOfWorkers, _year)
        {
            NumberOfBooksInStock = _numberOfBooksInStock;
            NumberOfEveryMonthNewCustomers = _numberOfEveryMonthCustomers;
        }
        public override int CompareTo(object ob)
        {
            Organisation pl = (Organisation)ob;
            if (this.IsYearOld > pl.IsYearOld) return 1;
            if (this.IsYearOld < pl.IsYearOld) return -1;
            return 0;

        }
        public override string Show() //виртуальный метод
        {
            string str;
            str = $"{base.Show()}, {NumberOfBooksInStock} - количество различных книг в библиотеке, {NumberOfEveryMonthNewCustomers} - количество новых пользователей каждый месяц";
            return str;
        }

        public new string ShowWrong() //не виртуальный метод, чтобы показать разницу между ним и виртуальным
        {
            string str;
            str = $"{base.ShowWrong()}, {NumberOfBooksInStock} - количество различных книг в библиотеке, {NumberOfEveryMonthNewCustomers} - количество новых пользователей каждый месяц";
            return str;

        }

        public override string ToString() //перегруженный метод для вывода через Console.WriteLine()
        {
            return $"{base.ToString()}, {NumberOfBooksInStock} - количество различных книг в библиотеке, {NumberOfEveryMonthNewCustomers} - количество новых пользователей каждый месяц";
        }

        public int AllCustomers() // для вычисления всех посетителей библиотеки за время ее существования
        {
            return this.NumberOfEveryMonthNewCustomers * 12 * this.IsYearOld;
        }

        public override void Init()
        {
            base.Init();
            NumberOfBooksInStock = rnd.Next(0, 100000);
            NumberOfEveryMonthNewCustomers = rnd.Next(0, 1000);
        }
        public override object Clone()
        {
            return new Bibliothek( this.Owner, this.NumberOfEmployees, this.IsYearOld, this.NumberOfBooksInStock, this.NumberOfEveryMonthNewCustomers);
        }
        public Bibliothek ShallowCopy() //метод для создания поверхностной копии объекта
        {
            return (Bibliothek)this.MemberwiseClone();
        }

        public override Organisation BaseOrganisation()
        {
            return new Organisation(this.Owner, this.NumberOfEmployees, this.IsYearOld);
        }

    }
}
