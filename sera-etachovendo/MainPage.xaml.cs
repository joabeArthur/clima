namespace sera_etachovendo;

public partial class MainPage : ContentPage
{	
	Results resultado;
	public MainPage()
	{
		InitializeComponent();

		TestarLayout();
		PrencherTela();
	}
	

//------------------------------------------------------------------------------------------------------------------------------------------------------\\
	
	void PrencherTela()
	{
		LabelTemperatura.Text = resultado.temp.ToString();
		LabelCity.Text = resultado.city;
		LabelChuvaDia.Text = resultado.description;

	}
	
//------------------------------------------------------------------------------------------------------------------------------------------------------\\

	void TestarLayout()
	{
		resultado = new Results();

		resultado.temp = 20;
		resultado.city = "PR, Apucarana";
		resultado.description = "Chuva";

//------------------------------------------------------------------------------------------------------------------------------------------------------\\

		if (resultado.description == "Chuva")
		{
			imgFundo.Source = "chuvanoite.jpg";
		}
		
	}
	
}

