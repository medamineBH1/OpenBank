using MediatR;

namespace ATM.API.GetBankATM
{
    public class GetBankATMHandler : IRequestHandler<GetBankATMRequest, GetBankATMResponse>
    {
        public async Task<GetBankATMResponse> Handle(GetBankATMRequest request, CancellationToken cancellationToken)
        {
            // Simulate fetching ATM details from a data source
            var response = new GetBankATMResponse
            {
                AccessibilityFeatures = new[] { "ATAC", "ATAD" },
                Address = "Sample Address",
                AtmAttributeId = "xxaf2a-9a0f-4bfa-b30b-9003aa467f51",
                AtmId = "atme-9a0f-4bfa-b30b-9003aa467f51",
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
