using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace PrismDataContextExample.ViewModels
{
    public class ShellViewModel : BindableBase, INavigationAware
    {
        private readonly IRegionManager _regionManager;
        public ICommand Navigate { get; set; }

        public ShellViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            Navigate = new DelegateCommand(() => 
            regionManager.RequestNavigate("ExampleRegion", new Uri("SecondContentView", UriKind.Relative))
            );
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            throw new NotImplementedException();
        }
    }
}
