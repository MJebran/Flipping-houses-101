using NUnit.Framework;
using System;
using FlippingProperty;

namespace FinalProject.tests;

public class Tests
{

    [SetUp]
    public void Setup()
    {

    }

    //[Test]
    // public void deg2radTest()
    // {  

    //     var rads = ComparisonResult.deg2rad(45.789);
    //     Assert.AreEqual( deg * Math.PI / 180.0);
    // }
    [Test]
    public void deg2radTest()
    {
        double deg = 180;
        deg = (deg / Math.PI) * 45.54;
        deg = ComparisonResult.deg2rad(45.789);
    }
    [Test]
    public void rad2degTest()
    {
        double rads = 54.3434;
        rads = (rads * Math.PI / 180.0);
        rads = ComparisonResult.deg2rad(45.789);
    }
    [Test]
    public void CalcuteDifferenceOfCoordinatesTest()
    {
        double latitudeA = 12.34343;
        double latitudeB = 13.12232;
        double longitudeA = 14.33434;
        double longitudeB = 15.00008;

        double rads = 54.3434;
        rads = ComparisonResult.deg2rad(45.789);
        rads = (rads * Math.PI / 180.0);

        double deg = 180;
        deg = (deg / Math.PI) * 45.54;
        deg = ComparisonResult.deg2rad(45.789);

        double theta = longitudeA - longitudeB;
        double dist = Math.Sin(deg2rad(latitudeA)) * Math.Sin(deg2rad(latitudeB)) + Math.Cos(deg2rad(latitudeA)) * Math.Cos(deg2rad(latitudeB)) * Math.Cos(deg2rad(theta));
        dist = Math.Acos(dist);
        dist = rad2deg(dist);
        dist = dist * 60 * 1.1515;
    }

    private double rad2deg(double dist)
    {
        double deg = 180;
        deg = (deg / Math.PI) * 45.54;
        return deg;
    }

    private double deg2rad(double latitudeA)
    {
        double rads = 54.3434;
        rads = ComparisonResult.deg2rad(45.789);
        rads = (rads * Math.PI / 180.0);
        return rads;
    }
}