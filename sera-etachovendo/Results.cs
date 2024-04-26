namespace sera_etachovendo;

public class Results
	{
		public int temp{get; set;}
		public int humidity{get; set;}

		public string date{get; set;}
		public string sunset{get; set;}
		public string sunrise {get; set;}
		public string time{get; set;}
		public string description{get; set;}
		public string currently{get; set;}
		public string city{get; set;}
		public string wind_cardial{get; set;}
		public string moon_phase{get; set;}
		public string wind_speedy{get; set;}
		
		//public int img_id{get; set;}
		public double cloudiness{get; set;}
        public double rain{get; set;} 
		public List <Forecast> forecast {get; set;}
		    
	}