using System;
using System.Collections.Generic;
using System.Text;

namespace laba10
{
    public class InsuranceCompany : Organisation, IInit, IComparable
    {
        protected int numberOfCustomers;
        public int NumberOfCustomers
        {
            get => numberOfCustomers;
            set
            {
                if (value >= 0) numberOfCustomers = value;
                else
                {
                    numberOfCustomers = 0;
                    Console.WriteLine("Количество клиентов страховой организации не может быть меньше 0");
                }
            }
        }


        public InsuranceCompany() : base()
        {
            NumberOfCustomers = 0;
        }

        public InsuranceCompany(string _name, int _numberOfWorkers, int _year, int _numberOfCustomers) : base(_name, _numberOfWorkers, _year)
        {
            NumberOfCustomers = _numberOfCustomers;
        }

        public override string Show() //виртуальный метод
        {
            string str;
            str = $"{base.Show()}, {NumberOfCustomers} - количество застрахованных клиентов в страховой компании";
            return str;
        }

        public new string ShowWrong()
        {
            string str;
            str = $"{base.ShowWrong()}, {NumberOfCustomers} - количество застрахованных клиентов в страховой компании";
            return str;

        }
        public override int CompareTo(object ob)
        {
            Organisation pl = (Organisation)ob;
            if (this.IsYearOld > pl.IsYearOld) return 1;
            if (this.IsYearOld < pl.IsYearOld) return -1;
            return 0;

        }
        public int NumberOfClientsEveryYear()
        {
            return this.NumberOfCustomers / this.isYearOld;
        }
        public override void Init()
        {
            base.Init();
            NumberOfCustomers = rnd.Next(0, 10000000);
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {NumberOfCustomers} - количество застрахованных клиентов в страховой компании ";
        }

        public override object Clone()
        {
            return new InsuranceCompany("CLONE" + this.Owner, this.NumberOfEmployees, this.IsYearOld, this.NumberOfCustomers);
        }
        public InsuranceCompany ShallowCopy()
        {
            return (InsuranceCompany)this.MemberwiseClone();
        }
        public override Organisation BaseOrganisation()
        {
            return new Organisation(this.Owner, this.NumberOfEmployees, this.IsYearOld);
        }
    }
}

