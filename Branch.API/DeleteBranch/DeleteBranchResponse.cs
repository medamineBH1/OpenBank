namespace Branch.API
{
    public class DeleteBranchResponse
    {
        public string Id { get; set; }
        public string BankId { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public Location Location { get; set; }
        public Meta Meta { get; set; }
        public Lobby Lobby { get; set; }
        public DriveUp DriveUp { get; set; }
        public BranchRouting BranchRouting { get; set; }
        public string IsAccessible { get; set; }
        public string AccessibleFeatures { get; set; }
        public string BranchType { get; set; }
        public string MoreInfo { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string CountryCode { get; set; }
    }

    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class Meta
    {
        public License License { get; set; }
    }

    public class License
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Lobby
    {
        public List<DayOpeningHours> Monday { get; set; }
        public List<DayOpeningHours> Tuesday { get; set; }
        public List<DayOpeningHours> Wednesday { get; set; }
        public List<DayOpeningHours> Thursday { get; set; }
        public List<DayOpeningHours> Friday { get; set; }
        public List<DayOpeningHours> Saturday { get; set; }
        public List<DayOpeningHours> Sunday { get; set; }
    }

    public class DriveUp
    {
        public DayOpeningHours Monday { get; set; }
        public DayOpeningHours Tuesday { get; set; }
        public DayOpeningHours Wednesday { get; set; }
        public DayOpeningHours Thursday { get; set; }
        public DayOpeningHours Friday { get; set; }
        public DayOpeningHours Saturday { get; set; }
        public DayOpeningHours Sunday { get; set; }
    }

    public class DayOpeningHours
    {
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
    }

    public class BranchRouting
    {
        public string Scheme { get; set; }
        public string Address { get; set; }
    }
}
