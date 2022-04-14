namespace FlippingProperty
{
    public interface IPropertyDataSource
    {
        Task<HouseModel> GetPropertyData(string address, string city, string state, string zip_code);
    }
    public class StaticFileDataSource : IPropertyDataSource
    {
        public async Task<HouseModel> GetPropertyData(string address, string city, string state, string zip_code)
        {
            var fileName = Path.Combine("searchResults",$"{address}.{zip_code}.json");
            
            if (!File.Exists(fileName))
            {
                return await HouseProcessor.LoudHouse(address, city, state, zip_code);
            }

            var json = await File.ReadAllTextAsync(fileName); //reads the file
            var houseModel = System.Text.Json.JsonSerializer.Deserialize<HouseModel>(json);//converting to an object
            return houseModel;
        }
    }

    public class ApiDataSource : IPropertyDataSource
    {
        public async Task<HouseModel> GetPropertyData(string address, string city, string state, string zip_code)
        {
            return await HouseProcessor.LoudHouse(address, city, state, zip_code); // calls the api
        }
    }
}

