namespace StylingIssues.Maui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		BindingContext = new MainPageViewModel();
		InitializeComponent();
	}


}


