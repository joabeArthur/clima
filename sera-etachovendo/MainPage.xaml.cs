using System.Text.Json;

namespace sera_etachovendo;

public partial class MainPage : ContentPage
{	
	Results results;
	Resposta resposta;
	const string Url="https://api.hgbrasil.com/weather?woeid=455927&key=ecb23073";
	public MainPage()
	{
		InitializeComponent();

		
		
		PuxarDoServidor();
	}
	

//------------------------------------------------------------------------------------------------------------------------------------------------------\\
	
	void PrencherTela()
	{
		LabelTemperatura.Text = resposta.results.temp + "C°".ToString();
		LabelCity.Text = resposta.results.city;
		LabelClima.Text = resposta.results.description;
		LabelHumidade.Text = resposta.results.humidity.ToString();
		LabelAmanhecer.Text = resposta.results.sunrise;
		LabelAnoitecer.Text = resposta.results.sunset;
		LabelForça.Text = resposta.results.wind_speedy;
		LabelDireção.Text = resposta.results.wind_cardial;
		LabelFase.Text = resposta.results.moon_phase;
		


		if (resposta.results.currently == "dia")
		{
			if (resposta.results.rain >= 1)
			{
				imgFundo.Source = "chuvadia.jpg";
			}
			else if(resposta.results.cloudiness >= 1)
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
			if (resposta.results.rain >= 1)
			{
				imgFundo.Source = "chuvanoite.jpg";
			}
			else if (resposta.results.cloudiness >= 1)
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
			var httpClient = new HttpClient();
			var response = await httpClient.GetAsync(Url);
			if (response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();
				resposta = JsonSerializer.Deserialize<Resposta>(content);
				PrencherTela();
			}
		}
		catch(Exception e)
		{
		System.Diagnostics.Debug.WriteLine(e);
		}

		
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

