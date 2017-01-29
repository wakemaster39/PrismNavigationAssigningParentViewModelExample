using System.Windows;
using Autofac;
using Prism.Autofac;
using Prism.Regions;
using PrismDataContextExample.ViewModels;
using PrismDataContextExample.Views;
using RegionNavigationService = PrismDataContextExample.Prism.RegionNavigationService;

namespace PrismDataContextExample.Startup
{
    public class BootStrapper : AutofacBootstrapper
    {
        protected override void ConfigureContainerBuilder(ContainerBuilder builder)
        {
            base.ConfigureContainerBuilder(builder);

            builder.RegisterTypeForNavigation<SecondContentView>();
            builder.RegisterType<RegionNavigationService>().As<IRegionNavigationService>();
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<ShellView>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (ShellView)this.Shell;
            Application.Current.MainWindow.DataContext = Container.Resolve<ShellViewModel>();
            Application.Current.MainWindow.Show();

            Container.Resolve<IRegionManager>().RegisterViewWithRegion("ExampleRegion", typeof(ExampleContentView));
        }
    }
}
