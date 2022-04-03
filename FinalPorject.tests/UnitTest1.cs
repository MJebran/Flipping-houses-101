using NUnit.Framework;

namespace FinalProject.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ApiHelper()
    {
        var StartClient = new HttpClient();
        Assert.AreEqual(StartClient);
    }

    [Test]
    public void HouseProcessor()
    {
        var LoudHouse = new LoudHouse();
        Assert.AreEqual(LoudHouse);
    }
}