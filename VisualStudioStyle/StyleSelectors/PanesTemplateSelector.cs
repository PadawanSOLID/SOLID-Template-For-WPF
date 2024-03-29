using System.Windows.Controls;
using System.Windows;
using AvalonDock.Layout;
using VisualStudioStyle.ViewModels;

namespace VisualStudioStyle.StyleSelectors
{
    class PanesTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CommomFile
        {
            get;
            set;
        }

        public DataTemplate XamlFile
        {
            get;
            set;
        }

        public DataTemplate SolutionResource
        {
            get;
            set;
        }

        public DataTemplate CSFile
        {
            get;
            set;
        }

        public DataTemplate ToolBox
        {
            get;
            set;
        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            return item switch
            {
                CSFileViewModel => CSFile,
                ToolBoxViewModel => ToolBox,
                XamlFileViewModel => XamlFile,
                SolutionResourceViewModel => SolutionResource,
                _ => CommomFile,
            };
        }
    }
}
