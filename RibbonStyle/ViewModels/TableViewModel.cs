using CommunityToolkit.Mvvm.ComponentModel;
using RibbonStyle.Models;
using System.Collections.ObjectModel;

namespace RibbonStyle.ViewModels
{
    public  class TableViewModel:ObservableObject
    {
        public ObservableCollection<TableItem> TableDatas { get; set; } = new(Enumerable.Range(1, 40).Select(n => new TableItem() { Index = n }));

    }
}
