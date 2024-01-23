namespace JBS.Calculator;

public partial class MainPage : ContentPage
{ 
	public MainPage()
	{
		InitializeComponent();
		Title = "Add Master Pro";
	}

    void Add_OnClick(System.Object sender, System.EventArgs e)
    {
        double firstNum; 
        double secondNum;
        double.TryParse(txtFirstNum.Text, out firstNum);
        double.TryParse(txtSecondNum.Text, out secondNum);
        double answer = firstNum + secondNum;
        lblDisplay.Text = answer.ToString();
    }

    void Clear_OnClick(System.Object sender, System.EventArgs e)
    {
        txtFirstNum.Text = "";
        txtSecondNum.Text = "";
        lblDisplay.Text = "0";
    }
}


