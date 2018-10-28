using Autofac;
using FriendOrganizer.Core.Interfaces;
using FriendOrganizer.Infrastructure.Persistence;
using FriendOrganizer.Infrastructure.Repositories;
using FriendOrganizer.UI.ViewModels;

namespace FriendOrganizer.UI.StartUp
{
    public class Bootstrapper
    {
        public IContainer BootStrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<FriendOrganizerDbContext>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<FriendRepository>().As<IFriendRepository>();
            return builder.Build();
        }
    }
}
