using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3._2._1
{
    class Tovar : MyArray<Tovar>
    {
        string name;
        int code, term;
        DateTime date;
        public Tovar() { }
        public Tovar(string name, int code, DateTime date, int term)
        {
            this.name = name;
            this.code = code;
            this.date = date;
            this.term = term;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Term
        {
            get { return term; }
            set { term = value; }
        }

        public static void LastDay(Tovar tov)
        {
            DateTime date2;
            date2 = tov.Date.AddDays(tov.Term);
            Console.WriteLine("Кінцевий строк споживання товару: " + date2.ToString("D"));
        }
        public static void Usable(Tovar tov)
        {
            if (tov.Date.AddDays(tov.Term) >= DateTime.Now)
            {
                Console.WriteLine("Товар придатний");
            }
            else Console.WriteLine("Товар непридатний");
        }
        public static void Info(Tovar tovar)
        {
            Console.WriteLine("Назва товару: " + tovar.Name);
            Console.WriteLine("Код товару: " + tovar.Code);
            Console.WriteLine("Дата виготовлення: " + tovar.Date.ToString("D"));
            Console.WriteLine("Термін придатності: " + tovar.Term + " днів");
        }
        public override int CompareTo(Tovar x)
        {
            if (this.Term>x.Term)
            { return 1; }
            else if (this.Term == x.Term)
            { return 0; }
            else return -1;
        }

    }
}
