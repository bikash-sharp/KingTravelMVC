using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingTravel_Common
{
    #region HotelAPI

    public class DropDownCL
    {
        public string DataText { get; set; }
        public string DataValue { get; set; }
    }
    public class AuthenticateCL
    {
        public string ClientId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EndUserIp { get; set; }
        public AuthenticateCL() { }
    }

    public class Error
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public Error() { }
    }

    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int MemberId { get; set; }
        public int AgencyId { get; set; }
        public string LoginName { get; set; }
        public string LoginDetails { get; set; }
        public Boolean isPrimaryAgent { get; set; }
    }

    public class AuthenticateResponse
    {
        public int Status { get; set; }
        public string TokenId { get; set; }
        public Error Error { get; set; }
        public Member Member { get; set; }

        public AuthenticateResponse()
        {
            Error = new Error();
            Member = new Member();
        }
    }

    public class LogoutRequest
    {
        public string ClientId { get; set; }
        public string EndUserIp { get; set; }
        public int TokenAgencyId { get; set; }
        public int TokenMemberId { get; set; }
        public string TokenId { get; set; }
    }

    public class LogoutResponse
    {
        public Error Error { get; set; }
        public int Status { get; set; }

        public LogoutResponse()
        {
            Error = new Error();
        }
    }

    public class GetAgencyBalanceRequest
    {
        public string ClientId { get; set; }
        public string EndUserIp { get; set; }
        public int TokenAgencyId { get; set; }
        public int TokenMemberId { get; set; }
        public string TokenId { get; set; }
    }

    public class GetAgencyBalanceReponse
    {
        public int AgencyType { get; set; }
        public double CashBalance { get; set; }
        public object CashBalanceInPrefCurrency { get; set; }
        public double CreditBalance { get; set; }
        public object CreditBalanceInPrefCurrency { get; set; }
        public Error Error { get; set; }
        public object PreferredCurrency { get; set; }
        public int Status { get; set; }

        public GetAgencyBalanceReponse()
        {
            CashBalance = 0.00;
            CreditBalance = 0.00;
            Error = new Error();
        }
    }

    #region Country
    public class CountryListRequest
    {
        public string TokenId { get; set; }
        public string ClientId { get; set; }
        public string EndUserIp { get; set; }
    }

    public class CountryListResponse
    {
        public string CountryList { get; set; }
        public Error Error { get; set; }
        public int Status { get; set; }
        public string TokenId { get; set; }

        public CountryListResponse()
        {
            Error = new Error();
        }
    }

    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
    #endregion

    #region City
    public class DestinationCityListRequest
    {
        public string TokenId { get; set; }
        public string ClientId { get; set; }
        public string EndUserIp { get; set; }
        public string CountryCode { get; set; }
    }

    public class DestinationCityListResponse
    {
        public string TopDestination { get; set; }
        public string DestinationCityList { get; set; }
        public Error Error { get; set; }
        public int Status { get; set; }
        public string TokenId { get; set; }

        public DestinationCityListResponse()
        {
            Error = new Error();
        }
    }

    public class City
    {
        public string CityId { get; set; }
        public string CityName { get; set; }
        public bool IsActive { get; set; }
        public string CountryCode { get; set; }

        public string cityId { get; set; }
        public string cityName { get; set; }
        public string countryName { get; set; }
        public string countryCode { get; set; }

    }

    public class TopCity
    {
        public string cityId { get; set; }
        public string cityName { get; set; }
        public string countryName { get; set; }
        public string countryCode { get; set; }
    }


    #endregion

    #region HotelSearch
    public class RoomGuest
    {
        public int NoOfAdults { get; set; }
        public int NoOfChild { get; set; }
        public object ChildAge { get; set; }
        public RoomGuest()
        {
            ChildAge = null;
        }
    }
    public class HotelSearchRequest
    {
        public string CheckInDate { get; set; }
        public string NoOfNights { get; set; }
        public string CountryCode { get; set; }
        public string CityId { get; set; }
        public object ResultCount { get; set; }
        public string PreferredCurrency { get; set; }
        public string GuestNationality { get; set; }
        public string NoOfRooms { get; set; }
        public List<RoomGuest> RoomGuests { get; set; }
        public string PreferredHotel { get; set; }
        public int MaxRating { get; set; }
        public int MinRating { get; set; }
        public object ReviewScore { get; set; }
        public bool IsNearBySearchAllowed { get; set; }
        public string EndUserIp { get; set; }
        public string TokenId { get; set; }
        public HotelSearchRequest()
        {
            RoomGuests = new List<RoomGuest>();
            ReviewScore = null;
            ResultCount = null;
        }
    }

    public class Price
    {
        public string CurrencyCode { get; set; }
        public double RoomPrice { get; set; }
        public double Tax { get; set; }
        public int ExtraGuestCharge { get; set; }
        public int ChildCharge { get; set; }
        public int OtherCharges { get; set; }
        public double Discount { get; set; }
        public double PublishedPrice { get; set; }
        public int PublishedPriceRoundedOff { get; set; }
        public double OfferedPrice { get; set; }
        public int OfferedPriceRoundedOff { get; set; }
        public double AgentCommission { get; set; }
        public double AgentMarkUp { get; set; }
        public int ServiceTax { get; set; }
        public int TDS { get; set; }
        public Price() { }
    }

    public class TripAdvisor
    {
        public double Rating { get; set; }
        public string ReviewURL { get; set; }
        public TripAdvisor() { }
    }

    public class HotelResult
    {
        public int ResultIndex { get; set; }
        public string HotelCode { get; set; }
        public string HotelName { get; set; }
        public string HotelCategory { get; set; }
        public int StarRating { get; set; }
        public string HotelDescription { get; set; }
        public string HotelPromotion { get; set; }
        public string HotelPolicy { get; set; }
        public Price Price { get; set; }
        public string HotelPicture { get; set; }
        public string HotelAddress { get; set; }
        public string HotelContactNo { get; set; }
        public object HotelMap { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public object HotelLocation { get; set; }
        public object SupplierPrice { get; set; }
        public List<object> RoomDetails { get; set; }
        public TripAdvisor TripAdvisor { get; set; }

        public HotelResult()
        {
            TripAdvisor = new TripAdvisor();
            RoomDetails = new List<object>();
            Price = new Price();
        }
    }

    public class HotelSearchResult
    {
        public int ResponseStatus { get; set; }
        public Error Error { get; set; }
        public string TraceId { get; set; }
        public string CityId { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public string PreferredCurrency { get; set; }
        public int NoOfRooms { get; set; }
        public List<RoomGuest> RoomGuests { get; set; }
        public List<HotelResult> HotelResults { get; set; }

        public HotelSearchResult()
        {
            RoomGuests = new List<RoomGuest>();
            HotelResults = new List<HotelResult>();
            Error = new Error();
        }
    }

    public class HotelSearchList
    {
        public HotelSearchResult HotelSearchResult { get; set; }
        public HotelSearchList()
        {
            HotelSearchResult = new HotelSearchResult();
        }
    }

    public class HotelInfoRequest
    {
        public string ResultIndex { get; set; }
        public string HotelCode { get; set; }
        public string EndUserIp { get; set; }
        public string TokenId { get; set; }
        public string TraceId { get; set; }
        public HotelInfoRequest() { }
    }

    public class Attraction
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public Attraction() { }
    }

    public class HotelDetails
    {
        public string HotelCode { get; set; }
        public string HotelName { get; set; }
        public int StarRating { get; set; }
        public object HotelURL { get; set; }
        public string Description { get; set; }
        public List<Attraction> Attractions { get; set; }
        public List<string> HotelFacilities { get; set; }
        public object HotelPolicy { get; set; }
        public object SpecialInstructions { get; set; }
        public object HotelPicture { get; set; }
        public List<string> Images { get; set; }
        public string Address { get; set; }
        public string CountryName { get; set; }
        public object PinCode { get; set; }
        public string HotelContactNo { get; set; }
        public string FaxNumber { get; set; }
        public object Email { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public object RoomData { get; set; }
        public object RoomFacilities { get; set; }
        public object Services { get; set; }

        public HotelDetails()
        {
            Attractions = new List<Attraction>();
            Images = new List<string>();
            HotelFacilities = new List<string>();
        }
    }

    public class HotelInfoResult
    {
        public int ResponseStatus { get; set; }
        public Error Error { get; set; }
        public string TraceId { get; set; }
        public HotelDetails HotelDetails { get; set; }

        public HotelInfoResult()
        {
            HotelDetails = new HotelDetails();
            Error = new Error();
        }
    }

    public class HotelInfoResponse
    {
        public HotelInfoResult HotelInfoResult { get; set; }
        public HotelInfoResponse()
        {
            HotelInfoResult = new HotelInfoResult();
        }
    }

    #endregion


    #endregion


    #region AirlineAPI

    public class Segment
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string FlightCabinClass { get; set; }
        public string PreferredArrivalTime { get; set; }
        public string PreferredDepartureTime { get; set; }
        public Segment() { }
    }

    public class SearchRequest
    {
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public int InfantCount { get; set; }
        public bool IsDomestic { get; set; }
        public bool DirectFlight { get; set; }
        public bool OneStopFlight { get; set; }
        public string JourneyType { get; set; }
        public string EndUserIp { get; set; }
        public string TokenId { get; set; }
        public object PreferredAirlines { get; set; }
        public List<Segment> Segments { get; set; }
        public object Sources { get; set; }

        public SearchRequest()
        {
            Segments = new List<Segment>();
        }
    }

    #endregion

    class DataTransfer
    {
    }
}
