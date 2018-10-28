using Autofac;
using FriendOrganizer.Core.Interfaces;
using FriendOrganizer.Infrastructure;
using FriendOrganizer.Infrastructure.Persistence;
using FriendOrganizer.Infrastructure.Repositories;
using FriendOrganizer.UI.ViewModels;
using Prism.Events;

namespace FriendOrganizer.UI.StartUp
{
    public class Bootstrapper
    {
        public IContainer BootStrap()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();
            builder.RegisterType<FriendOrganizerDbContext>().AsSelf();


            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<NavigationViewModel>().As<INavigationViewModel>();
            builder.RegisterType<FriendDetailViewModel>().As<IFriendDetailViewModel>();



            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            builder.RegisterType<FriendRepository>().As<IFriendRepository>();
            return builder.Build();
        }
    }
}
