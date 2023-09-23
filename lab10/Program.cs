using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace MyApp //
{
    class Date
    {
        public DateTime now;

        public Date(DateTime now)
        {
            this.now = now;
        }
    }
    class Person : Date
    {
        public string name;
        public DateTime hireDate;

        public Person(string name, DateTime hireDate): base(hireDate) 
        {
            this.name = name;
            this.hireDate = hireDate;
        }

        public int year() 
        {
            var zeroTime = new DateTime(1, 1, 1);
            DateTime currentDate = DateTime.Now;
            
            return (zeroTime + (currentDate - hireDate)).Year - 1;
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date(DateTime.Now);
            

            Person p = new Person("Иван Иванович Петраков",new DateTime(2020,05,05));
            
            // Console.WriteLine(d.now.Subtract(p.hireDate)) ;

            Console.WriteLine(p.year());
        }
        

    }
}
