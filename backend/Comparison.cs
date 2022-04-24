using FlippingProperty;
using Newtonsoft.Json;

namespace FlippingProperty;

public record GeoCoordinate(double latitude, double longitude); // class for the Geo Coordinates, my API provides lat and long

// This class comparars The price difference, square Foot, and house distance to the point of reference
public class ComparisonResult
{
    public int? PriceDifference { get; }
    public int? SquareFootDifference { get; }
    public decimal? HouseONEDistance { get; }
    public decimal? HouseTWODistance { get; }

    //Compatres the hosuse one to house two by sale price 
    public ComparisonResult(HouseModel HouseONE, HouseModel HouseTWO, GeoCoordinate pointOfReference)
    {
        PriceDifference = HouseONE.data.deeds[0].sale_price - HouseTWO.data.deeds[0].sale_price; //this is for finding the price difference of house one and house two. 
        SquareFootDifference = HouseONE.data.parcel.area_sq_ft - HouseTWO.data.parcel.area_sq_ft;//this is for finding the square Foot which is for teh are of the house. 

        var HouseONECoordinate = new GeoCoordinate(HouseONE.data.address.latitude.Value, HouseONE.data.address.longitude.Value); // Coordinates of house one. 
        var HouseTWOCoordinate = new GeoCoordinate(HouseTWO.data.address.latitude.Value, HouseTWO.data.address.longitude.Value);// Coordinates of house two.

        HouseONEDistance = CalcuteDifference(HouseONECoordinate, pointOfReference);
        HouseTWODistance = CalcuteDifference(HouseTWOCoordinate, pointOfReference);
    }

    // The below methods are for the finding the coordinates 
    public static double deg2rad(double deg) => (deg * Math.PI / 180.0); // finding Degrees 
    public static double rad2deg(double rad) => (rad / Math.PI * 180.0); // finding radians 

    // Method for calculating the Lat and long 
    public static decimal CalcuteDifference(GeoCoordinate A, GeoCoordinate B)
    {
        double theta = A.longitude - B.longitude;
        double dist = Math.Sin(deg2rad(A.latitude)) * Math.Sin(deg2rad(B.latitude)) + Math.Cos(deg2rad(A.latitude)) * Math.Cos(deg2rad(B.latitude)) * Math.Cos(deg2rad(theta));
        dist = Math.Acos(dist);
        dist = rad2deg(dist);
        dist = dist * 60 * 1.1515;
        
        return ((decimal)dist);
    }
}


