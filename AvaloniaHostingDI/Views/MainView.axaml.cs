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
        ViewModel = App.GetService<MainViewModel>();
        DataContext = ViewModel;
        InitializeComponent();        
    }
}