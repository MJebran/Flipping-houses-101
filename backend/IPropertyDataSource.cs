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
            var fileName = $"{address}.json";
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException(fileName);
                fileName = "apiCallResult.json";
            }
            var json = await File.ReadAllTextAsync(fileName); //reads the file
            var houseModel = System.Text.Json.JsonSerializer.Deserialize<HouseModel>(json);//convering to an object
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


    // I tried this but it didn't work.
    // public class ApiDataSource : IPropertyDataSource
    // {
    //     public async Task<HouseModel> GetPropertyData(string address, string city, string state, string zip_code)
    //     {
    //         //TODO
    //        return HouseProcessor.LoudHouse(address, city, state, zip_code); // call the api

    //     }
    // }
}

