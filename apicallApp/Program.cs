using System;
using System.Net.Http;
using System.Threading.Tasks;

var client = new HttpClient();

Console.Write("Enter an API URL: ");
string url = Console.ReadLine();

if (url == null | url.Length == 0)
{
    Console.WriteLine("Setting to default URL: https://api.spacexdata.com/v3/capsules");
    url = "https://api.spacexdata.com/v3/capsules";
}


try
{
    HttpResponseMessage responseMessage = await client.GetAsync(url);
    responseMessage.EnsureSuccessStatusCode();

    string responseBody = await responseMessage.Content.ReadAsStringAsync();
    Console.WriteLine(responseBody);
}
catch (Exception ex)
{
    Console.WriteLine($"Request error: {ex.Message}");
}