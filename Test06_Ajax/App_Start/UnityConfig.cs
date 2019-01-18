using System.Web.Mvc;
using Test06_Ajax.Services;
using Unity;
using Unity.Mvc5;

namespace Test06_Ajax
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            //container.RegisterType<IAlaki, Alaki>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}