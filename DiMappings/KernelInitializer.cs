using System;
using System.Security.Cryptography.X509Certificates;
using DavidTielke.DDC.Data.DataStoring;
using DavidTielke.DDC.Logic.PersonManagement;
using Ninject;

namespace DiMappings
{
    public class KernelInitializer
    {
        public void Initialize(IKernel kernel)
        {
            kernel.Bind<IPersonManager>().To<PersonManager>();
            kernel.Bind<IPersonRepository>().To<PersonRepository>();
        }
    }
}
