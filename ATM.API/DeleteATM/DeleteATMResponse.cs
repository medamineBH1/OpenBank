namespace OpenBank.Services.Atm.DeleteAtm
{
    public record DeleteAtmResponse
    {
        public string Id { get; init; }
        public string BankId { get; init; }
        public string Name { get; init; }
        public Address Address { get; init; }
        public Location Location { get; init; }
        public Meta Meta { get; init; }
        public Dictionary<string, OpeningHours> OpeningHours { get; init; }
        public bool IsAccessible { get; init; }
        public string LocatedAt { get; init; }
        public string MoreInfo { get; init; }
        public bool HasDepositCapability { get; init; }
        public List<string> SupportedLanguages { get; init; }
        public List<string> Services { get; init; }
        public List<string> AccessibilityFeatures { get; init; }
        public List<string> SupportedCurrencies { get; init; }
        public List<string> Notes { get; init; }
        public List<string> LocationCategories { get; init; }
        public string MinimumWithdrawal { get; init; }
        public string BranchIdentification { get; init; }
        public string SiteIdentification { get; init; }
        public string SiteName { get; init; }
        public string CashWithdrawalNationalFee { get; init; }
        public string CashWithdrawalInternationalFee { get; init; }
        public string BalanceInquiryFee { get; init; }
        public string AtmType { get; init; }
        public string Phone { get; init; }
        public List<AtmAttribute> Attributes { get; init; }
    }

    public record Address
    {
        public string Line1 { get; init; }
        public string Line2 { get; init; }
        public string Line3 { get; init; }
        public string City { get; init; }
        public string County { get; init; }
        public string State { get; init; }
        public string Postcode { get; init; }
        public string CountryCode { get; init; }
    }

    public record Location
    {
        public double Latitude { get; init; }
        public double Longitude { get; init; }
    }

    public record Meta
    {
        public License License { get; init; }
    }

    public record License
    {
        public string Id { get; init; }
        public string Name { get; init; }
    }

    public record OpeningHours
    {
        public string OpeningTime { get; init; }
        public string ClosingTime { get; init; }
    }

    public record AtmAttribute
    {
        public string BankId { get; init; }
        public string AtmId { get; init; }
        public string AtmAttributeId { get; init; }
        public string Name { get; init; }
        public string Type { get; init; }
        public string Value { get; init; }
        public bool IsActive { get; init; }
    }
}
