using System;
using System.Collections.Generic;

namespace Zad6
{
    public class Person
    {
       public string Imie { get; set; }
       public string Nazwisko { get; set; }
        public uint ID { get; set; }
        public string Adres { get; set; }


    }

    public class Employee : Person
    {
        public double zarobki { get; set; }

        public override string ToString()
        {
            return "Stanowisko:" + GetType().Name + " Imie:" + Imie + " Nazwisko:" + Nazwisko + " ID:" + ID + "Adres:" + Adres + "Zarobki:" + zarobki;
        }
    }

    public class Guest : Person
    {
       public DateTime Date { get; set; }

        public override string ToString()
        {
            return "Stanowisko:" + GetType().Name + " Imie:" + Imie + " Nazwisko:" + Nazwisko + " ID:" + ID + "Adres:" + Adres + "Data wyjazdu:" + Date;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> company = new List<Person>();
            Employee employee1 = new Employee()
            {
                Imie = "Paweł",
                Nazwisko = "Nowak",
                ID = 1,
                Adres = "84-300 Lebork, ul. nijaka 88",
                zarobki = 1200.00
            };

            Employee employee2 = new Employee()
            {
                Imie = "Andrzej",
                Nazwisko = "Kowalski",
                ID = 2,
                Adres = "12-123 Paryż, ul. wierzowa 1",
                zarobki = 5430.00
            };

            Guest guest = new Guest()
            {
                Imie = "Grzegorz",
                Nazwisko = "Brzeczyszczykiewicz",
                ID = 1,
                Adres = "99-666  Mszczonowieścice 882, gmina Grzmiszczosławice, powiat Trzcinogrzechotnikowo ",
                Date = DateTime.Now.Add(new TimeSpan(3,0,0,0))
            };

            company.Add(employee1);
            company.Add(employee2);
            company.Add(guest);

            foreach (var s in company)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
            
        }
    }

}
