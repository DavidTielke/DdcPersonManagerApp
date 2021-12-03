using System;
using System.Linq;
using DavidTielke.DDC.CrossCutting.DataClasses;
using DavidTielke.DDC.Data.DataStoring;
using DavidTielke.DDC.Logic.PersonManagement;

namespace DavidTielke.DDC.UI.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new PersonRepository();
            var manager = new PersonManager(repo);

            var adults = manager.GetAllAdults().ToList();
            var children = manager.GetAllChildren().ToList();

            Console.WriteLine($"## Erwachsene ({adults.Count})");
            adults.ForEach(a => Console.WriteLine(a.Name));

            Console.WriteLine($"## Kinder ({children.Count})");
            children.ForEach(c => Console.WriteLine(c.Name));

        }
    }
}
