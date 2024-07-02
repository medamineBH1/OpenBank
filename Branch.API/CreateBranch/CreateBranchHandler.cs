namespace Branch.API.CreateBranch
{
    public class CreateBranchRequest
    {
        public string BankId { get; set; }
        public string[] AccessibleFeatures { get; set; }
        public string Address { get; set; }
        public string BranchRouting { get; set; }
        public string BranchType { get; set; }
        public string City { get; set; }
        public string ClosingTime { get; set; }
        public string CountryCode { get; set; }
        public string County { get; set; }
        public string DriveUp { get; set; }
        public string Friday { get; set; }
        public string Id { get; set; }
        public bool IsAccessible { get; set; }
        public string Latitude { get; set; }
        public string License { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Lobby { get; set; }
        public string Location { get; set; }
        public string Longitude { get; set; }
        public string Meta { get; set; }
        public string Monday { get; set; }
        public string MoreInfo { get; set; }
        public string Name { get; set; }
        public string OpeningTime { get; set; }
        public string PhoneNumber { get; set; }
        public string Postcode { get; set; }
        public string Saturday { get; set; }
        public string Scheme { get; set; }
        public string State { get; set; }
        public string Sunday { get; set; }
        public string Thursday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
    }

    public class CreateBranchResponse
    {
        public string[] AccessibleFeatures { get; set; }
        public string Address { get; set; }
        public string BankId { get; set; }
        public string BranchRouting { get; set; }
        public string BranchType { get; set; }
        public string City { get; set; }
        public string ClosingTime { get; set; }
        public string CountryCode { get; set; }
        public string County { get; set; }
        public string DriveUp { get; set; }
        public string Friday { get; set; }
        public string Id { get; set; }
        public bool IsAccessible { get; set; }
        public string Latitude { get; set; }
        public string License { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Lobby { get; set; }
        public string Location { get; set; }
        public string Longitude { get; set; }
        public string Meta { get; set; }
        public string Monday { get; set; }
        public string MoreInfo { get; set; }
        public string Name { get; set; }
        public string OpeningTime { get; set; }
        public string PhoneNumber { get; set; }
        public string Postcode { get; set; }
        public string Saturday { get; set; }
        public string Scheme { get; set; }
        public string State { get; set; }
        public string Sunday { get; set; }
        public string Thursday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
    }

    public interface IBranchRepository
    {
        Task<CreateBranchResponse> CreateBranchAsync(CreateBranchRequest request);
        Task DeleteBranchAsync(string bankId, string branchId);
    }

    public class BranchRepository : IBranchRepository
    {
        public Task<CreateBranchResponse> CreateBranchAsync(CreateBranchRequest request)
        {
            // Simulate a branch creation operation
            var response = new CreateBranchResponse
            {
                AccessibleFeatures = request.AccessibleFeatures,
                Address = request.Address,
                BankId = request.BankId,
                BranchRouting = request.BranchRouting,
                BranchType = request.BranchType,
                City = request.City,
                ClosingTime = request.ClosingTime,
                CountryCode = request.CountryCode,
                County = request.County,
                DriveUp = request.DriveUp,
                Friday = request.Friday,
                Id = request.Id,
                IsAccessible = request.IsAccessible,
                Latitude = request.Latitude,
                License = request.License,
                Line1 = request.Line1,
                Line2 = request.Line2,
                Line3 = request.Line3,
                Lobby = request.Lobby,
                Location = request.Location,
                Longitude = request.Longitude,
                Meta = request.Meta,
                Monday = request.Monday,
                MoreInfo = request.MoreInfo,
                Name = request.Name,
                OpeningTime = request.OpeningTime,
                PhoneNumber = request.PhoneNumber,
                Postcode = request.Postcode,
                Saturday = request.Saturday,
                Scheme = request.Scheme,
                State = request.State,
                Sunday = request.Sunday,
                Thursday = request.Thursday,
                Tuesday = request.Tuesday,
                Wednesday = request.Wednesday
            };

            return Task.FromResult(response);
        }
    }
}
