using System;
using System.Collections.Generic;
using System.Text;

namespace laba10
{
    public class ShipbuildingCompany : Organisation, IInit, IComparable
    {
        protected int numberOfShipsInStock;
        protected int everyYearSoldShipsNumber;
        public int NumberOfShipsInStock
        {
            get => numberOfShipsInStock;
            set
            {
                if (value >= 0) numberOfShipsInStock = value;
                else
                {
                    numberOfShipsInStock = 0;
                    Console.WriteLine("Количество видов судов в ассортименте не может быть меньше 0");
                }
            }
        }

        public int EveryYearSoldShipsNumber
        {
            get => everyYearSoldShipsNumber;
            set
            {
                if (value >= 0) everyYearSoldShipsNumber = value;
                else
                {
                    everyYearSoldShipsNumber = 0;
                    Console.WriteLine("Количество проданных в год кораблей не может быть меньше 0");
                }
            }
        }

        public ShipbuildingCompany() : base()
        {
            EveryYearSoldShipsNumber = 0;
            NumberOfShipsInStock = 0;
        }
        public ShipbuildingCompany(string name, int numberOFWorkerss, int _yearOld, int _yearOfShips, int _shipsInStock) : base(name, numberOFWorkerss, _yearOld)
        {
            EveryYearSoldShipsNumber = _yearOfShips;
            NumberOfShipsInStock = _shipsInStock;
        }

        public override string Show() //виртуальный метод
        {
            string str;
            str = $"{base.Show()}, {EveryYearSoldShipsNumber} - количество проданных в год кораблей, {NumberOfShipsInStock} - количество различных типов кораблей в ассортименте";

            return str;
        }

        public new string ShowWrong()
        {
            string str = $"{ base.ShowWrong()}, {EveryYearSoldShipsNumber} - количество проданных в год кораблей, {NumberOfShipsInStock} - количество различных типов кораблей в ассортименте";

            return str;

        }
        public override int CompareTo(object ob)
        {
            Organisation pl = (Organisation)ob;
            if (this.IsYearOld > pl.IsYearOld) return 1;
            if (this.IsYearOld < pl.IsYearOld) return -1;
            return 0;

        }

        public int AllShips() // метод для вычисления всех проданных кораблей за все годы
        {
            return this.EveryYearSoldShipsNumber * this.IsYearOld;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, {EveryYearSoldShipsNumber} - количество проданных в год кораблей, {NumberOfShipsInStock} - количество различных типов кораблей в ассортименте";
        }
       
        public override void Init()
        {
            base.Init();
            EveryYearSoldShipsNumber = rnd.Next(0, 10000000);
            NumberOfShipsInStock = rnd.Next(0, 1000);
        }

        public override object Clone()
        {
            return new ShipbuildingCompany("CLONE" + this.Owner, this.NumberOfEmployees, this.IsYearOld, this.EveryYearSoldShipsNumber, this.NumberOfShipsInStock);
        }
        public ShipbuildingCompany ShallowCopy()
        {
            return (ShipbuildingCompany)this.MemberwiseClone();
        }
        public override Organisation BaseOrganisation()
        {
            return new Organisation(this.Owner, this.NumberOfEmployees, this.IsYearOld);
        }

    }
}
