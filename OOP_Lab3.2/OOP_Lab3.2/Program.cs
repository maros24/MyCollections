using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Lab3._2._1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2018, 10, 15);
            DateTime date2 = new DateTime(2018, 09, 09);
            DateTime date3 = new DateTime(2018, 08, 24);
            DateTime date4 = new DateTime(2018, 10, 12);
            Tovar tov = new Tovar("Lemon", 835467, date4, 40);
            Tovar tov1 = new Tovar("Apple", 835467, date4, 30);
            Tovar tov2 = new Tovar("Orange", 835467, date4, 30);


            //List<Tovar> tovList = new List<Tovar>(3);
            //tovList.Add(new Tovar("Apple", 552235, date1, 45));
            //tovList.Add(new Tovar("Orange", 029357, date2, 30));
            //tovList.Add(new Tovar("Banana", 347598, date3, 15));

            //foreach (Tovar t in tovList)
            //{
            //    Console.WriteLine(t.Name);
            //}
            //Console.WriteLine();
            //tovList.Insert(1, tov);
            //tovList.RemoveAt(3);
            //foreach (Tovar t in tovList)
            //{
            //    Console.WriteLine(t.Name);
            //}
            //Console.WriteLine();

            MyArray<Tovar> myarr = new MyArray<Tovar>(3);
            myarr.Add(tov);
            myarr.Add(tov1);
            myarr.Add(tov2);

            foreach (Tovar t in myarr)
            {
                Console.WriteLine(t.Name);
            }
            Console.WriteLine(tov.CompareTo(tov1));

            Console.ReadKey();
        }
    }
}
