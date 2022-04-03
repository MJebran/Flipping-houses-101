namespace FlippingProperty;

public static class HouseProcessor
{
    // 
    //public async static Task<List<HouseModel>> LoudHouse()
    public async static Task<HouseModel> LoudHouse(string street_address, string city, string state, string zip_code)
    {
        // The list of all houses in a list //if it is a list of houses use the commented code
        //var TheResultOfAllHouses = new List<HouseModel>();
        // Estated API like that works uncommenting it will use your limited calls 
        //string url = $"https://apis.estated.com/v4/property?token=RUa4KZxBKXmpmXgKXS5JM6cDmIcLcF&street_address={street_address}&city={city}&state={state}&zip_code={zip_code}";
        // receives the response and returns the response as a list of house models
        string url = "";
        using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
        {
            if(response.IsSuccessStatusCode)
            {
                // takes the respones and converts it to the desired result that I want, specific data 
                HouseModel result = await response.Content.ReadAsAsync<HouseModel>();
                //if it is a list of houses use the commented code
                // HouseResultModel result = await response.Content.ReadAsAsync<HouseResultModel>();
                // foreach (var House in result.Houses)
                // {
                //     TheResultOfAllHouses.Add(House);
                // }
                return result;
            }
            else
            {
                throw new Exception("The respones FAILED! in HouseProcessor, LoudHouse");
            }
        }
    }
}