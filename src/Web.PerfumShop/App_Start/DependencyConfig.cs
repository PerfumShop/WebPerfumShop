﻿using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using S3Train.Domain;
using S3Train.Service;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI;

namespace Web.PerfumShop.App_Start
{
    public static class DependencyConfig
    {
        public static IContainer RegisterDependencyResolvers()
        {
            ContainerBuilder builder = new ContainerBuilder();
            RegisterDependencyMappingDefaults(builder);
            RegisterDependencyMappingOverrides(builder);
            IContainer container = builder.Build();
            // Set Up MVC Dependency Resolver
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            // Set Up WebAPI Resolver
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            return container;
        }

        private static void RegisterDependencyMappingDefaults(ContainerBuilder builder)
        {
            Assembly coreAssembly = Assembly.GetAssembly(typeof(IStateManager));
            Assembly webAssembly = Assembly.GetAssembly(typeof(MvcApplication));

            builder.RegisterAssemblyTypes(coreAssembly).AsImplementedInterfaces().InstancePerRequest();
            builder.RegisterAssemblyTypes(webAssembly).AsImplementedInterfaces().InstancePerRequest();

            builder.RegisterControllers(webAssembly);
            builder.RegisterModule(new AutofacWebTypesModule());
        }

        private static void RegisterDependencyMappingOverrides(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>();
            builder.RegisterType<BannerService>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<BrandService>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<CategoryService>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<OrderService>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<ProductImageService>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<ProductService>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<ProductAdvertisement>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<ShoppingCartService>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<ShoppingCartDetailService>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<VendorService>().AsImplementedInterfaces().SingleInstance();

        }
    }
}