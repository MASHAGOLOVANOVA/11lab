using System;
using System.Collections.Generic;
using System.Text;

namespace laba10
{
    public class Plant : Organisation, ICloneable, IInit, IComparable
    {
        protected string style;
        static public string[] PlantStyles = new string[] { "Автомобильный завод", "Кирпичный завод", "Шоколадная фабрика", "Молочный завод", "Ювелирный завод", "Форфоровый завод", "Механический завод", "Железобетонный завод", "Цементный завод", "Сахарный завод", "Пивной завод", "Часовой завод", "Оружейный завод", "Колбасный завод" };
        public string Style
        {
            get => style;
            set
            {
                if (value != "") style = value;
                else style = "NoStyle";
            }
        }

        public Plant() : base()
        {
            Style = "NoStyle";
        }

        public Plant(string nname, int nnumberOfWorkers, int _year, string _style) : base(nname, nnumberOfWorkers, _year)
        {
            Style = _style;
        }

        public override string Show() //виртуальный метод
        {
            string str;
            str = $"{Style}, {base.Show()}";
            return str;
        }
        public override int CompareTo(object ob)
        {
            Organisation pl = (Organisation)ob;
            if (this.IsYearOld > pl.IsYearOld) return 1;
            if (this.IsYearOld < pl.IsYearOld) return -1;
            return 0;

        }
        public new string ShowWrong()
        {
            string str;
            str = $"{Style}, {base.ShowWrong()}";
            return str;

        }
        public override string ToString() //перегруженный метод для вывода через Console.WriteLine()
        {
            return $"{base.ToString()},  {Style}";
        }
        public override void Init()
        {
            base.Init();
            Style = PlantStyles[rnd.Next(0, PlantStyles.Length - 1)];
        }
        public override object Clone()
        {
            return new Plant("CLONE" + this.Owner, this.NumberOfEmployees, this.IsYearOld, this.Style);
        }
        public Plant ShallowCopy()
        {
            return (Plant)this.MemberwiseClone();
        }
        public override Organisation BaseOrganisation()
        {
            return new Organisation(this.Owner, this.NumberOfEmployees, this.IsYearOld);
        }
    }
}
