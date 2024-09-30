namespace La_Cafeteria2;

public partial class CrearCuentaPage : ContentPage
{
	public CrearCuentaPage()
	{
		InitializeComponent();
	}

   
    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());

    }
}