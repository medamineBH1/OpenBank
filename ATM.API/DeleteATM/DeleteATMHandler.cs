using MediatR;

namespace OpenBank.Services.Atm.DeleteAtm
{
    public class DeleteAtmHandler : IRequestHandler<DeleteAtmRequest, DeleteAtmResponse>
    {
        public async Task<DeleteAtmResponse> Handle(DeleteAtmRequest request, CancellationToken cancellationToken)
        {
            // Simulate ATM deletion logic
            var deletedAtm = new DeleteAtmResponse
            {
                Id = request.AtmId,
                BankId = request.BankId,
                Name = "Atm by the Lake",
                Address = new Address
                {
                    Line1 = "No 1 the Road",
                    Line2 = "The Place",
                    Line3 = "The Hill",
                    City = "Berlin",
                    State = "Brandenburg",
                    Postcode = "13359",
                    CountryCode = "DE"
                },
                Location = new Location
                {
                    Latitude = 11.45,
                    Longitude = 11.45
                },
                Meta = new Meta
                {
                    License = new License
                    {
                        Id = "ODbL-1.0",
                        Name = "Open Database License"
                    }
                },
                OpeningHours = new Dictionary<string, OpeningHours>
                {
                    { "monday", new OpeningHours { OpeningTime = "8:00", ClosingTime = "18:00" } },
                    { "tuesday", new OpeningHours { OpeningTime = "8:00", ClosingTime = "18:00" } },
                    { "wednesday", new OpeningHours { OpeningTime = "8:00", ClosingTime = "18:00" } },
                    { "thursday", new OpeningHours { OpeningTime = "8:00", ClosingTime = "18:00" } },
                    { "friday", new OpeningHours { OpeningTime = "8:00", ClosingTime = "18:00" } },
                    { "saturday", new OpeningHours { OpeningTime = "8:00", ClosingTime = "18:00" } },
                    { "sunday", new OpeningHours { OpeningTime = "8:00", ClosingTime = "18:00" } }
                },
                IsAccessible = true,
                LocatedAt = "",
                MoreInfo = "More information about this fee",
                HasDepositCapability = true,
                SupportedLanguages = new List<string> { "es", "fr", "de" },
                Services = new List<string> { "ATBP", "ATBA" },
                AccessibilityFeatures = new List<string> { "ATAC", "ATAD" },
                SupportedCurrencies = new List<string> { "EUR", "MXN", "USD" },
                Notes = new List<string> { "String1", "String2" },
                LocationCategories = new List<string> { "ATBI", "ATBE" },
                MinimumWithdrawal = "5",
                BranchIdentification = "",
                SiteIdentification = "",
                SiteName = "",
                CashWithdrawalNationalFee = "",
                CashWithdrawalInternationalFee = "",
                BalanceInquiryFee = "",
                AtmType = "",
                Phone = "",
                Attributes = new List<AtmAttribute>
                {
                    new AtmAttribute
                    {
                        BankId = request.BankId,
                        AtmId = request.AtmId,
                        AtmAttributeId = "xxaf2a-9a0f-4bfa-b30b-9003aa467f51",
                        Name = "ACCOUNT_MANAGEMENT_FEE",
                        Value = "5987953",
                        IsActive = true
                    }
                }
            };

            return await Task.FromResult(deletedAtm);
        }
    }
}
