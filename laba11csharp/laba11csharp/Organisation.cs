using System;
using System.Collections.Generic;
using System.Text;

namespace laba10
{
    public class Organisation : IComparable, IInit
    {

        protected static string[] names = new string[] { "Maria", "Venera", "Lusi", "Tamara", "Sara", "Kony", "Mila", "Katrina", "Renesme", "Klara", "Tina", "Mina", "Fiona", "Faina", "Sonya", "Erik", "John", "Silvestr", "Don", "Ostin", "George", "Michael", "Frederick", "Harry", "Tim", "Daniel", "William", "Anton", "Alex", "Ivan" };
        protected static string[] surnames = new string[] { "Kim", "Li", "Ford", "Klow", "North", "West", "Gold", "Kopfer", "Grossfield", "Grass", "Niko", "Valentine", "Hope", "Kong", "Hips", "Duck", "MacFly", "Kelvin" };
        protected static Random rnd = new Random();
        protected string owner;
        protected int isYearOld;
        protected int numberOfEmployees;

        public string Owner
        {
            get => owner;
            set
            {
                if (value != "") owner = value;
                else owner = "NoName";
            }
        }

        public int NumberOfEmployees
        {
            get => numberOfEmployees;
            set
            {
                if (value >= 0) numberOfEmployees = value;
                else
                {
                    Console.WriteLine("Количество работников не может быть меньше 0");
                    numberOfEmployees = 0;
                }
            }
        }

        public int IsYearOld
        {
            get => isYearOld;
            set
            {
                if (value >= 0) isYearOld = value;
                else
                {
                    Console.WriteLine("Организация не может существовать меньше 0 лет");
                    isYearOld = value;
                }

            }

        }
        public Organisation()
        {
            Owner = "";
            NumberOfEmployees = 0;
            IsYearOld = 0;
        }

        public Organisation(string _name, int _numberOfWorkers, int _isYearOld)
        {
            Owner = _name;
            NumberOfEmployees = _numberOfWorkers;
            IsYearOld = _isYearOld;
        }


        public virtual string Show()
        {
            string s = $"Организация: владелец - {Owner}, количество работникой в организации - {NumberOfEmployees}, {IsYearOld} - кол-во лет существования организации";
            return s;
        }
        public string ShowWrong()
        {
            string s = $"Организация: владелец - {Owner}, количество работникой в организации - {NumberOfEmployees}, {IsYearOld} - кол-во лет существования организации";
            return s;
        }
        public override string ToString()
        {
            return $"Организация: владелец - {Owner}, количество работникой в организации - {NumberOfEmployees}, {IsYearOld} - кол-во лет существования организации";
        }

        public virtual object Clone()
        {
            return new Organisation("CLONE" + this.Owner, this.NumberOfEmployees, this.IsYearOld);
        }
        public virtual int CompareTo(object ob)
        {
            Organisation pl = (Organisation)ob;
            if (this.IsYearOld > pl.IsYearOld) return 1;
            if (this.IsYearOld < pl.IsYearOld) return -1;
            return 0;

        }

        public virtual void Init()
        {
            int size = names.Length - 1;
            int size1 = surnames.Length - 1;
            Owner = names[rnd.Next(0, size)] + " " + surnames[rnd.Next(0, size1)];
            NumberOfEmployees = rnd.Next(0, 300);
            IsYearOld = rnd.Next(0, 100);
        }
     
        public virtual Organisation BaseOrganisation()
        {
            return new Organisation(this.Owner, this.NumberOfEmployees, this.IsYearOld);
        }

    }
}

