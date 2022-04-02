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
        // This give us the json file 
        ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //Root myDeserializedClass = JsonConvert.DeserializeObject(myJsonResponse); 
    }
}