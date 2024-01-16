namespace HelloWorld;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		if(lblDisplay.Text == "Hello World")
		{
			lblDisplay.Text = "Good Day";
		}
		else
		{
			lblDisplay.Text = "Hello World";
		}
	}
}


