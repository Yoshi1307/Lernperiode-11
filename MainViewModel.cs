using CommunityToolkit.Mvvm.ComponentModel;

namespace TestProjekt1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
}
