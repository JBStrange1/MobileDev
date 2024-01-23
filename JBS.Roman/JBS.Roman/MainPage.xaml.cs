namespace JBS.Roman;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void btnConvert_OnClick(System.Object sender, System.EventArgs e)
    {
        int Input;
        bool isNumber;
        Converter converter = new Converter();
        isNumber = int.TryParse(txtInput.Text, out Input);

        if (isNumber)
        {
            lblDisplay.Text = converter.NumberToRoman(Input);
        }
        else
        {
            lblDisplay.Text = converter.RomanToNumber(txtInput.Text).ToString();
        }
    }

    void btnClear_OnClick(System.Object sender, System.EventArgs e)
    {
        txtInput.Text = "";
        lblDisplay.Text = "0";
    }

}


