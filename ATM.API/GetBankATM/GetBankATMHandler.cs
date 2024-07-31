using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ATM.API.GetBankATM
{
    // Query
    public record GetBankATMQuery(string AtmId) : IRequest<GetBankATMResponse>;

    public record GetBankATMResponse
    {
        public string[] AccessibilityFeatures { get; init; }
        public string Address { get; init; }
        public string AtmAttributeId { get; init; }
        public string AtmId { get; init; }
        public string AtmType { get; init; }
        public string BalanceInquiryFee { get; init; }
        public string BankId { get; init; }
        public string BranchIdentification { get; init; }
        public string CashWithdrawalInternationalFee { get; init; }
        public string CashWithdrawalNationalFee { get; init; }
        public string City { get; init; }
        public string ClosingTime { get; init; }
        public string CountryCode { get; init; }
        public string County { get; init; }
        public string Friday { get; init; }
        public bool HasDepositCapability { get; init; }
        public string Id { get; init; }
        public bool IsAccessible { get; init; }
        public double Latitude { get; init; }
        public string License { get; init; }
        public string Line1 { get; init; }
        public string Line2 { get; init; }
        public string Line3 { get; init; }
        public string LocatedAt { get; init; }
        public string Location { get; init; }
        public string[] LocationCategories { get; init; }
        public double Longitude { get; init; }
        public string Meta { get; init; }
        public string MinimumWithdrawal { get; init; }
        public string Monday { get; init; }
        public string MoreInfo { get; init; }
        public string Name { get; init; }
        public string Notes { get; init; }
        public string OpeningTime { get; init; }
        public string Phone { get; init; }
        public string Postcode { get; init; }
        public string Saturday { get; init; }
        public string Services { get; init; }
        public string SiteIdentification { get; init; }
        public string SiteName { get; init; }
        public string State { get; init; }
        public string Sunday { get; init; }
        public string[] SupportedCurrencies { get; init; }
        public string[] SupportedLanguages { get; init; }
        public string Thursday { get; init; }
        public string Tuesday { get; init; }
        public string Type { get; init; }
        public int Value { get; init; }
        public string Wednesday { get; init; }
        public string[] Attributes { get; init; }
        public bool IsActive { get; init; }
    }

    // Handler
    public class GetBankATMHandler : IRequestHandler<GetBankATMQuery, GetBankATMResponse>
    {
        public async Task<GetBankATMResponse> Handle(GetBankATMQuery request, CancellationToken cancellationToken)
        {
            // Simulate fetching ATM details from a data source
            var response = new GetBankATMResponse
            {
                AccessibilityFeatures = new[] { "ATAC", "ATAD" },
                Address = "Sample Address",
                AtmAttributeId = "xxaf2a-9a0f-4bfa-b30b-9003aa467f51",
                AtmId = request.AtmId,
                AtmType = "Sample Type",
                BalanceInquiryFee = "1.00",
                BankId = "gh.29.uk",
                BranchIdentification = "Branch ID",
                CashWithdrawalInternationalFee = "2.00",
                CashWithdrawalNationalFee = "0.50",
                City = "Berlin",
                ClosingTime = "2020-01-27",
                CountryCode = "1254",
                County = "Sample County",
                Friday = "10:00-18:00",
                HasDepositCapability = true,
                Id = "d8839721-ad8f-45dd-9f78-2080414b93f9",
                IsAccessible = true,
                Latitude = 38.8951,
                License = "Sample License",
                Line1 = "Line 1",
                Line2 = "Line 2",
                Line3 = "Line 3",
                LocatedAt = "Sample Location",
                Location = "Sample Location",
                LocationCategories = new[] { "Category1", "Category2" },
                Longitude = -77.0364,
                Meta = "Sample Meta",
                MinimumWithdrawal = "10.00",
                Monday = "10:00-18:00",
                MoreInfo = "More information about this fee",
                Name = "ATM Name",
                Notes = "Notes",
                OpeningTime = "10:00",
                Phone = "1234567890",
                Postcode = "13359",
                Saturday = "10:00-18:00",
                Services = "Services",
                SiteIdentification = "Site ID",
                SiteName = "Site Name",
                State = "Brandenburg",
                Sunday = "10:00-18:00",
                SupportedCurrencies = new[] { "EUR", "MXN", "USD" },
                SupportedLanguages = new[] { "es", "fr", "de" },
                Thursday = "10:00-18:00",
                Tuesday = "10:00-18:00",
                Type = "Sample Type",
                Value = 5987953,
                Wednesday = "10:00-18:00",
                Attributes = new[] { "Attribute1", "Attribute2" },
                IsActive = true
            };

            return await Task.FromResult(response);
        }
    }
}
