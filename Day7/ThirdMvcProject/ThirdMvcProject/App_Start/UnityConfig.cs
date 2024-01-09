using System.ComponentModel;
using System.Web.Mvc;
using ThirdMvcProject.Dal;
using ThirdMvcProject.Models;
using Unity;
using Unity.Mvc5;

namespace ThirdMvcProject
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<SecurityDal, SecurityDal>();
            container.RegisterType<EmployeeDal, EmployeeDal>();
            container.RegisterType<EventDal, EventDal>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}