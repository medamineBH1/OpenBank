using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Branch.API.CreateBranch
{
    // Command
    public record CreateBranchCommand(
        string BankId, string[] AccessibleFeatures, string Address, string BranchRouting, string BranchType,
        string City, string ClosingTime, string CountryCode, string County, string DriveUp, string Friday,
        string Id, bool IsAccessible, string Latitude, string License, string Line1, string Line2,
        string Line3, string Lobby, string Location, string Longitude, string Meta, string Monday,
        string MoreInfo, string Name, string OpeningTime, string PhoneNumber, string Postcode,
        string Saturday, string Scheme, string State, string Sunday, string Thursday, string Tuesday,
        string Wednesday) : IRequest<CreateBranchResponse>;

    public record CreateBranchResponse
    {
        public string[] AccessibleFeatures { get; init; }
        public string Address { get; init; }
        public string BankId { get; init; }
        public string BranchRouting { get; init; }
        public string BranchType { get; init; }
        public string City { get; init; }
        public string ClosingTime { get; init; }
        public string CountryCode { get; init; }
        public string County { get; init; }
        public string DriveUp { get; init; }
        public string Friday { get; init; }
        public string Id { get; init; }
        public bool IsAccessible { get; init; }
        public string Latitude { get; init; }
        public string License { get; init; }
        public string Line1 { get; init; }
        public string Line2 { get; init; }
        public string Line3 { get; init; }
        public string Lobby { get; init; }
        public string Location { get; init; }
        public string Longitude { get; init; }
        public string Meta { get; init; }
        public string Monday { get; init; }
        public string MoreInfo { get; init; }
        public string Name { get; init; }
        public string OpeningTime { get; init; }
        public string PhoneNumber { get; init; }
        public string Postcode { get; init; }
        public string Saturday { get; init; }
        public string Scheme { get; init; }
        public string State { get; init; }
        public string Sunday { get; init; }
        public string Thursday { get; init; }
        public string Tuesday { get; init; }
        public string Wednesday { get; init; }
    }

    // Handler
    public class CreateBranchHandler : IRequestHandler<CreateBranchCommand, CreateBranchResponse>
    {
        private readonly IBranchRepository _branchRepository;

        public CreateBranchHandler(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public async Task<CreateBranchResponse> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            var response = await _branchRepository.CreateBranchAsync(request);
            return response;
        }
    }

    public interface IBranchRepository
    {
        Task<CreateBranchResponse> CreateBranchAsync(CreateBranchCommand request);
        Task deleteBranch(string bankId, string branchId);
    }

    public class BranchRepository : IBranchRepository
    {
        public Task<CreateBranchResponse> CreateBranchAsync(CreateBranchCommand request)
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
