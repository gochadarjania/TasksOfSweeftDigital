// See https://aka.ms/new-console-template for more information
using CountriesAPI.Domain;
using Newtonsoft.Json;
using System.Net;

var url = "https://restcountries.com/v3.1/all";//Paste ur url here  

WebRequest request = HttpWebRequest.Create(url);

WebResponse response = request.GetResponse();

StreamReader reader = new StreamReader(response.GetResponseStream());

string responseText = reader.ReadToEnd();

var countryList = JsonConvert.DeserializeObject<List<Country>>(responseText) ?? new List<Country>();



foreach (var item in countryList)
{
    var filePath = @$"C:\Users\user\source\repos\TasksOfSweeftDigital\CountriesAPI\File\{item.name.common}.txt";

    var countryDetail =
        new CountryDetails()
        {
            area = item.area,
            latlng = item.latlng,
            population = item.population,
            region = item.region,
            subregion = item.subregion
        };
    string json = JsonConvert.SerializeObject(countryDetail, Formatting.Indented);

    using (StreamWriter sw = File.CreateText(filePath))
    {
        sw.Write(json);
    }

}

Console.WriteLine("Done!");