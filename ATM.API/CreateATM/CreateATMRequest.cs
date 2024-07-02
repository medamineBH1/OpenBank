namespace OpenBank.Services.Atm.CreateAtm
{
    public record CreateAtmRequest
    {
        public List<string> AccessibilityFeatures { get; init; }
        public string Address { get; init; }
        public string AtmType { get; init; }
        public decimal BalanceInquiryFee { get; init; }
        public string BankId { get; init; }
        public string BranchIdentification { get; init; }
        public decimal CashWithdrawalInternationalFee { get; init; }
        public decimal CashWithdrawalNationalFee { get; init; }
        public string City { get; init; }
        public DateTime ClosingTime { get; init; }
        public string CountryCode { get; init; }
        public string County { get; init; }
        public string Friday { get; init; }
        public bool HasDepositCapability { get; init; }
        public Guid Id { get; init; }
        public bool IsAccessible { get; init; }
        public double Latitude { get; init; }
        public string License { get; init; }
        public string Line1 { get; init; }
        public string Line2 { get; init; }
        public string Line3 { get; init; }
        public string LocatedAt { get; init; }
        public string Location { get; init; }
        public string LocationCategories { get; init; }
        public double Longitude { get; init; }
        public string Meta { get; init; }
        public decimal MinimumWithdrawal { get; init; }
        public string Monday { get; init; }
        public string MoreInfo { get; init; }
        public string Name { get; init; }
        public string Notes { get; init; }
        public DateTime OpeningTime { get; init; }
        public string Phone { get; init; }
        public string Postcode { get; init; }
        public string Saturday { get; init; }
        public string Services { get; init; }
        public string SiteIdentification { get; init; }
        public string SiteName { get; init; }
        public string State { get; init; }
        public string Sunday { get; init; }
        public List<string> SupportedCurrencies { get; init; }
        public List<string> SupportedLanguages { get; init; }
        public string Thursday { get; init; }
        public string Tuesday { get; init; }
        public string Wednesday { get; init; }
        public List<AtmAttribute> Attributes { get; init; }
    }

    public record AtmAttribute
    {
        public string Name { get; init; }
        public string Value { get; init; }
    }
}
