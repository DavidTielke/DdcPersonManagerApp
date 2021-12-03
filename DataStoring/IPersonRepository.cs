using System.Linq;
using DavidTielke.DDC.CrossCutting.DataClasses;

namespace DavidTielke.DDC.Data.DataStoring
{
    public interface IPersonRepository
    {
        IQueryable<Person> Query { get; }
    }
}