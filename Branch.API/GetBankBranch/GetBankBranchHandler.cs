using MediatR;

namespace OpenBank.Services.Branch.GetBankBranches
{
    // Query
    public record GetBankBranchesQuery(string BankId, int Limit = 500, int Offset = 0, string SortDirection = "DESC") : IRequest<GetBankBranchesResponse>;

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

    // Query Handler
    public class GetBankBranchesHandler : IRequestHandler<GetBankBranchesQuery, GetBankBranchesResponse>
    {
        public async Task<GetBankBranchesResponse> Handle(GetBankBranchesQuery request, CancellationToken cancellationToken)
        {
            // Fetch branch data (you can add any data source like database, external service, etc.)
            var branches = await FetchBranchesFromDataSource(request.BankId, request.Limit, request.Offset, request.SortDirection);

            return new GetBankBranchesResponse
            {
                Branches = branches
            };
        }

        private Task<List<Branch>> FetchBranchesFromDataSource(string bankId, int limit, int offset, string sortDirection)
        {
            // Simulate fetching branch data
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

    // Command
    public record CreateBranchCommand(string BankId, string Name, string Address, GeoLocation Location, string License, string Scheme) : IRequest<CreateBranchResponse>;

    public record CreateBranchResponse
    {
        public string Id { get; init; }
        public string Message { get; init; }
    }

    // Command Handler
    public class CreateBranchHandler : IRequestHandler<CreateBranchCommand, CreateBranchResponse>
    {
        public async Task<CreateBranchResponse> Handle(CreateBranchCommand request, CancellationToken cancellationToken)
        {
            // Simulate the creation of a new branch and returning the new branch ID.
            var newBranchId = Guid.NewGuid().ToString();

            return new CreateBranchResponse
            {
                Id = newBranchId,
                Message = "Branch created successfully"
            };
        }
    }
}
