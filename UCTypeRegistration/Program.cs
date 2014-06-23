using System;
using Microsoft.Practices.Unity;
using UCTypeRegistration.AppCode;

namespace UCTypeRegistration
{
    class Program
    {
        static void Main()
        {
            var container = new UnityContainer();

            //Earlier
            //container.RegisterType<IDeveloper, Developer>();
            //container.RegisterType<ITester, Tester>();

            //Registering by convention 
            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies(),
                WithMappings.FromMatchingInterface,
                WithName.Default);
            

            var developer = container.Resolve<IDeveloper>();
            developer.Name = "Srivatsa";
            Console.WriteLine(developer.Name);

            var tester = container.Resolve<ITester>();
            tester.Name = "Prasad";
            Console.WriteLine(tester.Name);
        }
    }
}
