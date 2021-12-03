using Ninject;

namespace DiMappings
{
    public static class KernelFactory
    {
        public static IKernel Create()
        {
            var kernel = new StandardKernel();

            new KernelInitializer().Initialize(kernel);

            return kernel;
        }
    }
}