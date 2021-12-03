using System.Linq;
using DavidTielke.DDC.CrossCutting.DataClasses;
using DavidTielke.DDC.Data.DataStoring;

namespace DavidTielke.DDC.Logic.PersonManagement
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _repository;

        public PersonManager(IPersonRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Person> GetAllAdults()
        {
            var result = _repository.Query.Where(p => p.Age >= 18);
            return result;
        }

        public IQueryable<Person> GetAllChildren()
        {
            var result = _repository.Query.Where(p => p.Age < 18);
            return result;
        }
    }
}
