using System.Net.Http.Headers;



// This is to convet html to json
namespace FlippingProperty;
public static partial class ApiHelper
{
    public static HttpClient ApiClient { get; set; }

    public static void StartClient()
    {
        ApiClient = new HttpClient();
        ApiClient.DefaultRequestHeaders.Accept.Clear();
        ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));// This give us the json file 
    }
}