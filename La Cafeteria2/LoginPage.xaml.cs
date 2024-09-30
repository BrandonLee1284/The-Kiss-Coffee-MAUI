namespace La_Cafeteria2;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await DisplayAlert("Iniciar Sesion", "Funcionalidad no implementada", "OK");

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CrearCuentaPage());



    }
}