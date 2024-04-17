namespace sera_etachovendo;

public partial class MainPage : ContentPage
{	
	ClassPai atual;
	Chuvanoite chuvanoite;

	public MainPage()
	{
		InitializeComponent();

		atual = new ClassPai();

		chuvanoite = new Chuvanoite();
	}
	public class Results
	{
		public int tmp{get; set;}
		public int date{get; set;}
		public int condition_code{get; set;}
		public string description{get; set;}
		public string currently{get; set;}
		public string city{get; set;}
		public int img_id{get; set;}
		public int humidity{get; set;}
		public int cloudiness{get; set;}
		public string moon_phase{get; set;}
		public forecast fore{get; set;} = new forecast();
	}

//------------------------------------------------------------------------------------------------------------------------------------------------------\\
	public class forecast
	{

	}
//------------------------------------------------------------------------------------------------------------------------------------------------------\\
	void MudaImg(object sender, EventArgs args)
	{
		if (description == true)
		{
			imgFundo = chuvanoite;
		}
	}
	
}

