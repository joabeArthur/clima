using System.Text.Json;

namespace sera_etachovendo;

public partial class MainPage : ContentPage
{	
	Results resultado;
	Resposta resposta;
	const string Url="https://hgbrasil.com/weather?woeid=455927&key=ecb23073";
	public MainPage()
	{
		InitializeComponent();

		
		PuxarDoServidor();
	}
	

//------------------------------------------------------------------------------------------------------------------------------------------------------\\
	
	void PrencherTela()
	{
		LabelTemperatura.Text = resposta.results.temp.ToString();
		LabelCity.Text = resposta.results.city;
		LabelChuva.Text = resposta.results.description;
		LabelHumidade.Text = resposta.results.cloudiness.ToString();
		LabelAmanhecer.Text = resposta.results.sunrise.ToString();
		LabelAnoitecer.Text = resposta.results.sunset.ToString();
		LabelForça.Text = resposta.results.wind_soeedy.ToString();
		LabelDireção.Text = resposta.results.wind_direction.ToString();
		LabelFase.Text = resposta.results.moon_phase;


		if (resposta.results.currently == "dia")
		{
			if (resposta.results.rain >= 10)
			{
				imgFundo.Source = "chuvadia.jpg";
			}
			else if(resposta.results.cloudiness >= 10)
			{
				imgFundo.Source = "nubladodia.jpg";
			}
			else
			{
				imgFundo.Source = "ensolarado.jpg";
			}
		}
		else
		{
			if (resposta.results.rain >= 10)
			{
				imgFundo.Source = "chuvanoite.jpg";
			}
			else if (resposta.results.cloudiness >= 10)
			{
				imgFundo.Source = "noitenubladdad.jpg";
			}
			else
			{
				imgFundo.Source = "noite.jpg";
			}
		}

	}

//------------------------------------------------------------------------------------------------------------------------------------------------------\\
	async void PuxarDoServidor()
	{
		try
		{
			var HttpClient = new HttpClient();
			var response = await HttpClient.GetAsync(Url);
			if (response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();
				resultado = JsonSerializer.Deserialize<Results>(content);
			}
		}
		catch(Exception e)
		{
			//Erro
		}

		PrencherTela();
	 }
//------------------------------------------------------------------------------------------------------------------------------------------------------\\
	//void TestarLayout()
	//{
	//	resultado = new Results();

	//	resposta.results.temp = 20;
	//	resposta.results.city = "PR, Apucarana";
	///	resposta.results.description = "Chuva";
	//	resposta.results.currently = "noite";
	//	resposta.results.rain = 9;	
	//	resposta.results.cloudiness = 10;	
	//	resposta.results.sunrise = 10;
	//}
	
}

