using MahApps.Metro.Controls;
using System.Windows.Input;
using System.Windows;

namespace RibbonStyle.Views
{
    /// <summary>
    /// ShellRibbonWindow.xaml 的交互逻辑
    /// </summary>
    public partial class Win10ShellWindow : MetroWindow
    {
        public Win10ShellWindow()
        {
             InitializeComponent();
        }
        private void DockPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void PART_Min_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void PART_Max_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
               WindowState = WindowState.Normal;
            }
            else
            {
                WindowState = WindowState.Maximized;
            }
        }
    }
}
