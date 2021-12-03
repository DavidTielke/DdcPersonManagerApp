using System.Linq;
using DavidTielke.DDC.CrossCutting.DataClasses;

namespace DavidTielke.DDC.Logic.PersonManagement
{
    public interface IPersonManager
    {
        IQueryable<Person> GetAllAdults();
        IQueryable<Person> GetAllChildren();
    }
}