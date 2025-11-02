using Microsoft.Maui.Controls;

namespace AppHotel;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new ReservaViewModel();
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }
}
