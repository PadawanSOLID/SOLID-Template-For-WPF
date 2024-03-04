using Prism.Ioc;
using Prism.Unity;
using RibbonStyle.ViewModels;
using RibbonStyle.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace RibbonStyle
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            //return     Container.Resolve<ShellWindow>();
            return Container.Resolve<ShellRibbonWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ShellWindow, ShellViewModel>();
        }
    }

}
