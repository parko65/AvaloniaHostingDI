using Avalonia.Controls;
using AvaloniaHostingDI.ViewModels;

namespace AvaloniaHostingDI;

public partial class MainView : UserControl
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainView()
    {
        // The App.GetService<T>() method is used to retrieve services from the DI container.
        ViewModel = App.GetService<MainViewModel>();
        DataContext = ViewModel;
        InitializeComponent();        
    }
}