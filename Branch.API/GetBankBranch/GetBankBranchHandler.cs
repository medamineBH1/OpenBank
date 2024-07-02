using MediatR;

namespace OpenBank.Services.Branch.GetBankBranches
{
    public record GetBankBranchesRequest(string BankId, int Limit = 500, int Offset = 0, string SortDirection = "DESC") : IRequest<GetBankBranchesResponse>;

    public record GetBankBranchesResponse
    {
        public List<Branch> Branches { get; init; }
    }

    public record Branch
    {
        public string Id { get; init; }
        public string Name { get; init; }
        public string Address { get; init; }
        public GeoLocation Location { get; init; }
        public string License { get; init; }
        public string Scheme { get; init; }
    }

    public record GeoLocation
    {
        public double Latitude { get; init; }
        public double Longitude { get; init; }
    }

    public class GetBankBranchesHandler : IRequestHandler<GetBankBranchesRequest, GetBankBranchesResponse>
    {
        public async Task<GetBankBranchesResponse> Handle(GetBankBranchesRequest request, CancellationToken cancellationToken)
        {
            // Simulate fetching branch data from a data source or external service
            var branches = await FetchBranchesFromDataSource(request.BankId, request.Limit, request.Offset, request.SortDirection);

            return new GetBankBranchesResponse
            {
                Branches = branches
            };
        }

        private Task<List<Branch>> FetchBranchesFromDataSource(string bankId, int limit, int offset, string sortDirection)
        {
            // Simulate fetching branch data based on bankId, limit, offset, and sort direction
            // Replace with actual logic to fetch data from a data source or service
            var branches = new List<Branch>
            {
                new Branch
                {
                    Id = "d8839721-ad8f-45dd-9f78-2080414b93f9",
                    Name = "Main Branch",
                    Address = "123 Main St, City, Country",
                    Location = new GeoLocation { Latitude = 38.8951, Longitude = -77.0364 },
                    License = "Sample License",
                    Scheme = "Sample Scheme"
                }
                // Add more branches as needed
            };

            return Task.FromResult(branches);
        }
    }
    public interface IRequestHandler<T1, T2>
    {
    }
}
