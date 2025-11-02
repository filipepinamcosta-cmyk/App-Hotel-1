using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace AppHotel;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new MainPage());
    }
}
