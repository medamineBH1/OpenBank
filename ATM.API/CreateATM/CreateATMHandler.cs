using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace OpenBank.Services.Atm.CreateAtm
{
    public class CreateATMHandler : IRequestHandler<CreateAtmCommand, CreateAtmResponse>
    {
        public async Task<CreateAtmResponse> Handle(CreateAtmCommand request, CancellationToken cancellationToken)
        {
            // Simulate ATM creation logic
            var createdAtm = new CreateAtmResponse
            {
                AccessibilityFeatures = request.AccessibilityFeatures,
                Address = request.Address,
                AtmAttributeId = Guid.NewGuid().ToString(),
                AtmId = Guid.NewGuid().ToString(),
                AtmType = request.AtmType,
                BalanceInquiryFee = request.BalanceInquiryFee,
                BankId = request.BankId,
                BranchIdentification = request.BranchIdentification,
                CashWithdrawalInternationalFee = request.CashWithdrawalInternationalFee,
                CashWithdrawalNationalFee = request.CashWithdrawalNationalFee,
                City = request.City,
                ClosingTime = request.ClosingTime.ToString("yyyy-MM-dd"),
                CountryCode = request.CountryCode,
                County = request.County,
                Friday = request.Friday,
                HasDepositCapability = request.HasDepositCapability,
                IsAccessible = request.IsAccessible,
                Latitude = request.Latitude,
                License = request.License,
                Line1 = request.Line1,
                Line2 = request.Line2,
                Line3 = request.Line3,
                LocatedAt = request.LocatedAt,
                Location = request.Location,
                LocationCategories = request.LocationCategories,
                Longitude = request.Longitude,
                Meta = request.Meta,
                MinimumWithdrawal = request.MinimumWithdrawal,
                Monday = request.Monday,
                MoreInfo = request.MoreInfo,
                Name = request.Name,
                Notes = request.Notes,
                OpeningTime = request.OpeningTime.ToString("yyyy-MM-dd"),
                Phone = request.Phone,
                Postcode = request.Postcode,
                Saturday = request.Saturday,
                Services = request.Services,
                SiteIdentification = request.SiteIdentification,
                SiteName = request.SiteName,
                State = request.State,
                Sunday = request.Sunday,
                SupportedCurrencies = request.SupportedCurrencies,
                SupportedLanguages = request.SupportedLanguages,
                Thursday = request.Thursday,
                Tuesday = request.Tuesday,
                Wednesday = request.Wednesday,
                IsActive = true
            };

            return await Task.FromResult(createdAtm);
        }
    }
}

