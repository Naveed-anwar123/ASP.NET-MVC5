using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using aspFirstApp.Repository;

namespace aspFirstApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<HomeInterface, Home>();
            container.RegisterType<CategoryInterface, Category2>();
            container.RegisterType<SignInterface, Signup>();
            container.RegisterType<ProfileInterface, Profile>();
            container.RegisterType<BookInterface, Books>();
            container.RegisterType<RecordsInterface, Records>();
            container.RegisterType<AlluserInterface, Alluser>();
            container.RegisterType<vRecordsInterface, vRecords>();
            container.RegisterType<RequestInterface, Requestclass>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}