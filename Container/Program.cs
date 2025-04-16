using DryIoc;
using Ninject;
using Task2;

namespace Container
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var container = new DryIoc.Container();

            container.Register<IMyService, MyService>();
            container.Register<MyService>();
            container.Register<SqlFileManager>();

            IKernel kernel = new StandardKernel();
            kernel.Bind<SqlFileManager>().ToSelf();
            kernel.Bind<IMyService>().To<MyService>();

            var service1 = container.Resolve<IMyService>();
            var service2 = kernel.Get<IMyService>();

            Console.WriteLine("Service 1 Output:");
            service1.Run();

            Console.WriteLine("Service 2 Output:");
            service2.Run();

        }
    }
}
