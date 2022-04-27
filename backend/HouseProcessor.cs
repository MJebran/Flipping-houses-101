namespace FlippingProperty;

public static class HouseProcessor
{
    //public async static Task<List<HouseModel>> LoudHouse()
    public async static Task<HouseModel> LoudHouse(string street_address, string city, string state, string zip_code)
    {
        // The list of all houses in a list, if it is a list of houses use the commented code
        //var TheResultOfAllHouses = new List<HouseModel>();
        string url = $"https://apis.estated.com/v4/property?token=RUa4KZxBKXmpmXgKXS5JM6cDmIcLcF&street_address={street_address}&city={city}&state={state}&zip_code={zip_code}";
        // receives the response and returns the response as a list of house models
        using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
        {
            if (response.IsSuccessStatusCode)
            {

                var json = await response.Content.ReadAsStringAsync();
                var result = System.Text.Json.JsonSerializer.Deserialize<HouseModel>(json);
                if (result.data != null)
                {
                    var filePath = GetFileName(street_address, zip_code);
                    await File.WriteAllTextAsync(filePath, json);
                    return result;
                }
                else
                {
                    throw new Exception("Invalid address!");
                }

            }
            else
            {
                throw new Exception("The respones FAILED! in HouseProcessor, LoudHouse");
            }
        }
    }

    // new method get's house address and zip.  
    public static string GetFileName(HouseModel house)
    {
        return GetFileName(house.data.address.formatted_street_address, house.data.address.zip_code);
    }

    public static string GetFileName(string street_address, string zip_code)
    {
        return Path.Combine("searchResults", $"{street_address}.{zip_code}.json");
    }
}