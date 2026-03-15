

using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TodoApp.ViewModel;

public partial class MainViewMode:ObservableObject
{
     public MainViewMode()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [ICommand]
     void Add()
    {
        // add our item
        Text = string.Empty;
    }

}
