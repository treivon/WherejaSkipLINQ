using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Marko1",
                Age = 12,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new People()
            {
                Id = 2,
                Name = "Marko2",
                Age = 16,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
            new People()
            {
                Id = 3,
                Name = "Marko3",
                Age = 18,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
             new People()
            {
                Id = 4,
                Name = "Jaanus",
                Age = 19,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
              new People()
            {
                Id = 5,
                Name = "Jaanus2",
                Age = 5,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
               new People()
            {
                Id = 6,
                Name = "Jaanus3",
                Age = 30,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
                new People()
            {
                Id = 7,
                Name = "Markus",
                Age = 20,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
        };
    }
}
