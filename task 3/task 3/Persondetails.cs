using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    public class Persondetails
    {
        public string Name {get;set;}
        public int Age { get;set;}
        public string City { get;set;}

    }
    public class personallist
    {
        public static void Main(string[] args)
        {
            List<Persondetails> newperson = new List<Persondetails>()
            {
                new Persondetails{Name="Tom",Age=32 ,City="New-york"},
                new Persondetails{Name="Seleina",Age=25 ,City="los-Angeles"},
                new Persondetails{Name="Messi",Age=34 ,City="Balselona"},
                new Persondetails{Name="Ronalodas",Age= 43,City="Spain"},
                new Persondetails{Name="Angeli",Age=21 ,City="Delhi"}

            };
            var FilterPdetail=from p in newperson where p.Age>25 && p.City == "Spain" select p;
            foreach(var p in FilterPdetail)
            {
                Console.WriteLine($"{p.Name}---{p.Age}");
            }
        }
    }
}
