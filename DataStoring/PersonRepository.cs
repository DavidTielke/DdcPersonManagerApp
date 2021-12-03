using System.Collections.Generic;
using System.Linq;
using DavidTielke.DDC.CrossCutting.DataClasses;

namespace DavidTielke.DDC.Data.DataStoring
{
    public class PersonRepository : IPersonRepository
    {
        public IQueryable<Person> Query => new List<Person>
        {
            new Person(1,"David",37),
            new Person(2,"Lena",34),
            new Person(3,"Maximlian",8),
            new Person(4,"Hasi",8),
            new Person(5,"Teddy",7),
        }.AsQueryable();
    }
}
