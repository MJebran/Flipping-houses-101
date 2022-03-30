namespace FlippingProperty;

public static class HouseProcessor
{
    // 
    //public async static Task<List<HouseModel>> LoudHouse()
    public async static Task<HouseModel> LoudHouse()
    {
        // The list of all houses in a list
        //var TheResultOfAllHouses = new List<HouseModel>();

        //string url = "https://api.magicthegathering.io/v1/cards?rarity=common&set=neo&type=creature|enchantment";
        // receives the response and returns the response as a list of house models
        using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
        {
            if(response.IsSuccessStatusCode)
            {
                // takes the respones and converts it to the desired result that I want, specific data 
                HouseModel result = await response.Content.ReadAsAsync<HouseModel>();
                //HouseResultModel result = await response.Content.ReadAsAsync<HouseResultModel>();
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