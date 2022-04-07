using System.Text.Json;
namespace FlippingProperty
{
    public class HouseModel
    {

        //private string[] address1; //if I want to work with index
        public Metadata metadata { get; set; }
        public Address address { get; set; }
        public Parcel parcel { get; set; }
        public OtherArea otherArea { get; set; }
        public OtherImprovement otherImprovement { get; set; }
        public Structure structure { get; set; }
        public Tax tax { get; set; }
        public Assessment assessment { get; set; }
        public MarketAssessment marketAssessment { get; set; }
        public Owner owner { get; set; }
        public Deed deed { get; set; }
        public Data data { get; set; }
        public Root root { get; set; }

    }

    // Class for strings in "address" from Estated API
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Metadata
    {
        public string publishing_date { get; set; }
        public DateTime timestamp { get; set; }
        public string version { get; set; }
    }

    public class Address
    {
        public string street_number { get; set; }
        public object street_pre_direction { get; set; }
        public string street_name { get; set; }
        public string street_suffix { get; set; }
        public object street_post_direction { get; set; }
        public object unit_type { get; set; }
        public object unit_number { get; set; }
        public string formatted_street_address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
        public string zip_plus_four_code { get; set; }
        public string carrier_code { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public string geocoding_accuracy { get; set; }
        public string census_tract { get; set; }
    }

    public class Parcel
    {
        public string apn_original { get; set; }
        public string apn_unformatted { get; set; }
        public object apn_previous { get; set; }
        public string fips_code { get; set; }
        public double? frontage_ft { get; set; }
        public double? depth_ft { get; set; }
        public int? area_sq_ft { get; set; }
        public double? area_acres { get; set; }
        public string county_name { get; set; }
        public string county_land_use_code { get; set; }
        public string county_land_use_description { get; set; }
        public string standardized_land_use_category { get; set; }
        public string standardized_land_use_type { get; set; }
        public List<object> location_descriptions { get; set; }
        public string zoning { get; set; }
        public object building_count { get; set; }
        public string tax_account_number { get; set; }
        public string legal_description { get; set; }
        public object lot_code { get; set; }
        public string lot_number { get; set; }
        public object subdivision { get; set; }
        public string municipality { get; set; }
        public object section_township_range { get; set; }
    }

    public class OtherArea
    {
        public string type { get; set; }
        public string sq_ft { get; set; }
    }

    public class OtherImprovement
    {
        public string type { get; set; }
        public string sq_ft { get; set; }
    }

    public class Structure
    {
        public int? year_built { get; set; }
        public object effective_year_built { get; set; }
        public string stories { get; set; }
        public object rooms_count { get; set; }
        public int? beds_count { get; set; }
        public double? baths { get; set; }
        public int? partial_baths_count { get; set; }
        public object units_count { get; set; }
        public string parking_type { get; set; }
        public int? parking_spaces_count { get; set; }
        public object pool_type { get; set; }
        public string architecture_type { get; set; }
        public object construction_type { get; set; }
        public string exterior_wall_type { get; set; }
        public object foundation_type { get; set; }
        public object roof_material_type { get; set; }
        public object roof_style_type { get; set; }
        public string heating_type { get; set; }
        public string heating_fuel_type { get; set; }
        public string air_conditioning_type { get; set; }
        public string fireplaces { get; set; }
        public string basement_type { get; set; }
        public string quality { get; set; }
        public string condition { get; set; }
        public List<object> flooring_types { get; set; }
        public object plumbing_fixtures_count { get; set; }
        public object interior_wall_type { get; set; }
        public string water_type { get; set; }
        public string sewer_type { get; set; }
        public int? total_area_sq_ft { get; set; }
        public List<OtherArea> other_areas { get; set; }
        public List<string> other_rooms { get; set; }
        public List<object> other_features { get; set; }
        public List<OtherImprovement> other_improvements { get; set; }
        public List<object> amenities { get; set; }
    }

    public class Tax
    {
        public int? year { get; set; }
        public int? amount { get; set; }
        public List<object> exemptions { get; set; }
        public string rate_code_area { get; set; }
    }

    public class Assessment
    {
        public int? year { get; set; }
        public int? land_value { get; set; }
        public int? improvement_value { get; set; }
        public int? total_value { get; set; }
    }

    public class MarketAssessment
    {
        public int? year { get; set; }
        public int? land_value { get; set; }
        public int? improvement_value { get; set; }
        public int? total_value { get; set; }
    }

    public class Owner
    {
        public string name { get; set; }
        public object second_name { get; set; }
        public object unit_type { get; set; }
        public object unit_number { get; set; }
        public string formatted_street_address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }
        public string zip_plus_four_code { get; set; }
        public string owner_occupied { get; set; }
    }

    public class Deed
    {
        public string document_type { get; set; }
        public string recording_date { get; set; }
        public string original_contract_date { get; set; }
        public string deed_book { get; set; }
        public string deed_page { get; set; }
        public string document_id { get; set; }
        public int? sale_price { get; set; }
        public string sale_price_description { get; set; }
        public double? transfer_tax { get; set; }
        public bool? distressed_sale { get; set; }
        public string real_estate_owned { get; set; }
        public string seller_first_name { get; set; }
        public string seller_last_name { get; set; }
        public object seller2_first_name { get; set; }
        public object seller2_last_name { get; set; }
        public object seller_address { get; set; }
        public object seller_unit_number { get; set; }
        public object seller_city { get; set; }
        public object seller_state { get; set; }
        public object seller_zip_code { get; set; }
        public object seller_zip_plus_four_code { get; set; }
        public string buyer_first_name { get; set; }
        public string buyer_last_name { get; set; }
        public object buyer2_first_name { get; set; }
        public object buyer2_last_name { get; set; }
        public string buyer_address { get; set; }
        public object buyer_unit_type { get; set; }
        public object buyer_unit_number { get; set; }
        public string buyer_city { get; set; }
        public string buyer_state { get; set; }
        public string buyer_zip_code { get; set; }
        public string buyer_zip_plus_four_code { get; set; }
        public object lender_name { get; set; }
        public object lender_type { get; set; }
        public object loan_amount { get; set; }
        public object loan_type { get; set; }
        public object loan_due_date { get; set; }
        public object loan_finance_type { get; set; }
        public object loan_interest_rate { get; set; }
    }

    public class Data
    {
        public Metadata metadata { get; set; }
        public Address address { get; set; }
        public Parcel parcel { get; set; }
        public Structure structure { get; set; }
        public object valuation { get; set; }
        public List<Tax> taxes { get; set; }
        public List<Assessment> assessments { get; set; }
        public List<MarketAssessment> market_assessments { get; set; }
        public Owner owner { get; set; }
        public List<Deed> deeds { get; set; }
    }

    public class Root
    {
        public Data data { get; set; }
        public Metadata metadata { get; set; }
        public List<object> warnings { get; set; }
    }
}