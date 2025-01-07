using RibbonStyle.Interfaces;
using RibbonStyle.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RibbonStyle.Views
{
    /// <summary>
    /// Win10RibbonView.xaml 的交互逻辑
    /// </summary>
    public partial class Win10RibbonView : UserControl
    {
        public Win10RibbonView()
        {
            InitializeComponent();
            DataContext = new RibbonViewModel();

        }

        private void DockPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton==MouseButtonState.Pressed)
            {
                App.Current.MainWindow.DragMove();
            }
        }

        private void PART_Min_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.WindowState= WindowState.Minimized;
        }

        private void PART_Max_Click(object sender, RoutedEventArgs e)
        {
            var window=App.Current.MainWindow;
            if (window.WindowState==WindowState.Maximized)
            {
                window.WindowState = WindowState.Normal;
            }
            else
            {
                window.WindowState= WindowState.Maximized;
            }
        }
    }
}
