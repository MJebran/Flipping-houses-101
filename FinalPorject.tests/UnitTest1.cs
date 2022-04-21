using NUnit.Framework;
using System.Net.Http.Headers;

using FlippingProperty;

namespace FinalProject.tests;

public class Tests
{
    public HouseModel theHouse;
    [SetUp]
    public void Setup()
    {
        
    }
    [Test]
    public async void ApiDataSourceTest()
    {
        var ApiDataSourceVar = new ApiDataSource();
        theHouse = await ApiDataSourceVar.GetPropertyData("135 W Center St", "Ephraim", "UT", "84627");
        Assert.Pass();

        // string Task<HouseModel> ApiDataSourcetest.GetPropertyData(string address, string city, string state, string zip_code);
        // Assert.Equals(HouseProcessor.LoudHouse(address, city, state, zip_code));
    }
    [Test]
    public void addressTest()
    {
        Assert.AreEqual("135 W Center St", theHouse.data.address.formatted_street_address);
    }
    // [Test]
    // public void APICallTest()
    // {
    //     var HouseProcessor = new HouseModel();
    //     FlippingProperty.
    // }

    // [Test]
    // public void ApiHelperTest()
    // {
    //     var HttpClient = new ApiHelper();
    //     HttpClient.StartClient();
    //     Assert.AreEqual(HttpClient.HttpClient, new MediaTypeWithQualityHeaderValue("application/json"));
    // }
    // [Test]
    // public void StaticFileDataSource()
    // {
    //     var HouseModel GetPropertyData = new 

    // }

    
}