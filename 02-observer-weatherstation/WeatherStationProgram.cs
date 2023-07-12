using _02_observer_weatherstation;
using _02_observer_weatherstation.System_IObserver;

const int sleep = 2500;

Console.WriteLine("*** Initializing Weather Station Provider ***");

WeatherDataProvider weatherProvider = new WeatherDataProvider();

//Indicando que os display (Observer) vão escutar as alterações no Weather Provider (Subject)
CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherProvider);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherProvider);

Console.WriteLine("");
Console.WriteLine("[WeatherData - Changing Measurements 1]");
weatherProvider.SetMeasurements(30.0f, 20.0f, 30.4f);

Thread.Sleep(sleep);

Console.WriteLine("");
Console.WriteLine("[WeatherData - Changing Measurements 2]");
weatherProvider.SetMeasurements(32.5f, 45.0f, 8.9f);

Thread.Sleep(sleep);

Console.WriteLine("");
Console.WriteLine("[WeatherData - Changing Measurements 3]");
weatherProvider.SetMeasurements(40.0f, 70.0f, 29.0f);

//Removendo o observador CurrentConditionsDisplay do Weather Provider
Console.WriteLine("****************************************");
Console.WriteLine("CurrentConditionsDisplay RemoveObserver");
Console.WriteLine("****************************************");
weatherProvider.RemoveObserver(currentConditionsDisplay);

Console.WriteLine("");
Console.WriteLine("[WeatherData - Changing Measurements 4]");
weatherProvider.SetMeasurements(30.0f, 20.0f, 30.4f);

Thread.Sleep(sleep);

//Registrando novamente o observador CurrentConditionsDisplay no Weather Provider
Console.WriteLine("****************************************");
Console.WriteLine("CurrentConditionsDisplay RegisterObserver");
Console.WriteLine("****************************************");
weatherProvider.RegisterObserver(currentConditionsDisplay);

Console.WriteLine("");
Console.WriteLine("[WeatherData - Changing Measurements 5]");
weatherProvider.SetMeasurements(32.5f, 45.0f, 8.9f);

Thread.Sleep(sleep);

Console.WriteLine("");
Console.WriteLine("[WeatherData - Changing Measurements 6]");
weatherProvider.SetMeasurements(40.0f, 70.0f, 29.0f);


Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("===========================================================");
Console.WriteLine("");
Console.WriteLine("");

//Console.WriteLine("*** Initializing Temperature Monitor using System.IObserver ***");

//TemperatureProvider tempProvider = new TemperatureProvider();

//Console.WriteLine("");
//Console.WriteLine("[Changing Measurements 0]");
//tempProvider.SetMeasurements(25.0f, DateTime.Now.AddDays(-4));

//TemperatureGeneralObserver reporter = new TemperatureGeneralObserver();
//reporter.Subscribe(tempProvider);

//TemperatureAlertObserver alert = new TemperatureAlertObserver();
//alert.Subscribe(tempProvider);

//Console.WriteLine("");
//Console.WriteLine("[Changing Measurements 1]");
//tempProvider.SetMeasurements(30.0f, DateTime.Now.AddDays(-3));

//Thread.Sleep(sleep);

//Console.WriteLine("");
//Console.WriteLine("[Changing Measurements 2]");
//tempProvider.SetMeasurements(40.0f, DateTime.Now.AddDays(-2));

//Thread.Sleep(sleep);

//Console.WriteLine("");
//Console.WriteLine("[Changing Measurements 3]");
//tempProvider.SetMeasurements(40.0f, DateTime.Now.AddDays(-1));

//Thread.Sleep(sleep);

//Console.WriteLine("");
//Console.WriteLine("[Changing Measurements 4]");
//tempProvider.SetMeasurements(20, DateTime.Now);

//Thread.Sleep(sleep);

//reporter.Unsubscribe();
//alert.Unsubscribe();

//Console.WriteLine("");
//Console.WriteLine("[Changing Measurements 5]");
//tempProvider.SetMeasurements(50, DateTime.Now);

