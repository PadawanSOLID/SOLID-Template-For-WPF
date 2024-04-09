using Prism.Ioc;
using Prism.Unity;
using System.Configuration;
using System.Data;
using System.Windows;
using VisualStudioStyle.Services;
using VisualStudioStyle.ViewModels;
using VisualStudioStyle.Views;

namespace VisualStudioStyle
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell() => Container.Resolve<ShellWindow>();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ShellWindow, ShellViewModel>();
            containerRegistry.Register<GitService>();
        }
    }

}
