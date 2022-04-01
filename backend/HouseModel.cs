using System.Text.Json;
namespace FlippingProperty
{
    public class HouseResultModel
    {
    //public HouseModel[] Houses {get; set;}
    }

    // (address, parcel, structure, deeds) are all taken form the API. 
    public class HouseModel
    {
        //private string[] address1; //if I want to work with index

        public string address { get; set; }
        public string parcel { get; set; }
        public string structure { get; set; }
        public string owner { get; set; }
        public int deeds { get; set; }
    }

    // Class for strings in "address" from Estated API
    public partial class Address
    {
        public string street_number { get; set;}
        public string street_name { get; set; }
        public string street_suffix { get; set; }
        public string unit_type { get; set; }
        public string unit_number { get; set; }
        public string formatted_street_address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; } 
        public string zip_plus_four_code { get; set; }
        public string carrier_code { get; set; }
        public string geocoding_accuracy { get; set; }
    }

    // Class for double in "address" from Estated API
    public partial class Address
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    // Class for Strings in "parcel" from Estated API
    public partial class Parcel
    {
        public string capn_original { get; set; }
        public string fips_code { get; set; }
        
        public string county_name { get; set; }
        public string county_land_use_code { get; set; }
        public string county_land_use_description { get; set; }
        public string standardized_land_use_category { get; set; }
        public string standardized_land_use_type { get; set; }
        public string location_descriptions { get; set; }
        public string zoning { get; set; }
        public string building_count { get; set; }
        public string tax_account_number { get; set; }
        public string legal_description { get; set; }
        public string lot_code { get; set; }
        public string lot_number { get; set; }
        public string subdivision { get; set; }
        public string municipality { get; set; }
    }
     //Class for double in "parcel" from Estated API
    public partial class Parcel
    {
        public double frontage_ft { get; set; }
        public double depth_ft { get; set; }
        public double area_sq_ft { get; set; }
        public double area_acres { get; set; }
    }

    //Class for string in "structure" from Estated API
    public partial class Structure
    {
        public string  { get; set; }
        public string  { get; set; }
        public string  { get; set; }
        public string  { get; set; }
        public string  { get; set; }
        public string  { get; set; }
        public string  { get; set; }
        public string  { get; set; }

        
        
    }
    //Class for int in "structure" from Estated API
    public partial class Structure
    {
        public int year_built { get; set; }
        public int beds_count { get; set; }
        public int partial_baths_count { get; set; }
        public int  { get; set; }
        public int  { get; set; }
        public int  { get; set; }
        public int  { get; set; }


    }
}

"structure": {
      "year_built": 1989,
      "effective_year_built": null,
      "stories": "2+B",
      "rooms_count": null,
      "beds_count": 4,
      "baths": 2.0,
      "partial_baths_count": 1,
      "units_count": null,
      "parking_type": "ATTACHED GARAGE",
      "parking_spaces_count": 2,
      "pool_type": null,
      "architecture_type": "COLONIAL",
      "construction_type": null,
      "exterior_wall_type": "ALUMINUM OR VINYL SIDING",
      "foundation_type": null,
      "roof_material_type": null,
      "roof_style_type": null,
      "heating_type": "FORCED AIR UNIT",
      "heating_fuel_type": "GAS",
      "air_conditioning_type": "CENTRAL",
      "fireplaces": "1",
      "basement_type": "FULL BASEMENT",
      "quality": "C",
      "condition": "GOOD",
      "flooring_types": [],
      "plumbing_fixtures_count": null,
      "interior_wall_type": null,
      "water_type": "MUNICIPAL",
      "sewer_type": "MUNICIPAL",
      "total_area_sq_ft": 1975,
      "other_areas": [
        {
          "type": "1ST FLOOR",
          "sq_ft": "912"
        },
        {
          "type": "2ND FLOOR",
          "sq_ft": "1063"
        },
        {
          "type": "GARAGE",
          "sq_ft": "400"
        },
        {
          "type": "COVERED PORCH",
          "sq_ft": "592"
        }
      ],
      "other_rooms": [
        "RECREATION ROOM"
      ],
      "other_features": [],
      "other_improvements": [
        {
          "type": "SHED",
          "sq_ft": "10X12"
        }
      ],
      "amenities": []
    },
    "valuation": null,
    "taxes": [
      {
        "year": 2021,
        "amount": 8868,
        "exemptions": [],
        "rate_code_area": "262601"
      }
    ],
    "assessments": [
      {
        "year": 2020,
        "land_value": 31400,
        "improvement_value": 158300,
        "total_value": 189700
      }
    ],
    "market_assessments": [
      {
        "year": 2020,
        "land_value": 32708,
        "improvement_value": 164896,
        "total_value": 197604
      }
    ],
    "owner": {
      "name": "KRISTIN N RIMES",
      "second_name": null,
      "unit_type": null,
      "unit_number": null,
      "formatted_street_address": "151 BATTLE GREEN DR",
      "city": "ROCHESTER",
      "state": "NY",
      "zip_code": "14624",
      "zip_plus_four_code": "4969",
      "owner_occupied": "YES"
    },
