
using MediatR;

namespace Branch.API.DeleteBranch
{
    // Command
    public record DeleteBranchCommand(string BANK_ID, string BRANCH_ID) : IRequest<DeleteBranchResponse>;

    public record DeleteBranchResponse
    {
        public string Id { get; init; }
        public string BankId { get; init; }
        public string Name { get; init; }
        public Address Address { get; init; }
        public Location Location { get; init; }
        public Meta Meta { get; init; }
        public Lobby Lobby { get; init; }
        public DriveUp DriveUp { get; init; }
        public BranchRouting BranchRouting { get; init; }
        public string IsAccessible { get; init; }
        public string AccessibleFeatures { get; init; }
        public string BranchType { get; init; }
        public string MoreInfo { get; init; }
        public string PhoneNumber { get; init; }
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

    public record Lobby
    {
        public List<DayOpeningHours> Monday { get; init; }
        public List<DayOpeningHours> Tuesday { get; init; }
        public List<DayOpeningHours> Wednesday { get; init; }
        public List<DayOpeningHours> Thursday { get; init; }
        public List<DayOpeningHours> Friday { get; init; }
        public List<DayOpeningHours> Saturday { get; init; }
        public List<DayOpeningHours> Sunday { get; init; }
    }

    public record DriveUp
    {
        public DayOpeningHours Monday { get; init; }
        public DayOpeningHours Tuesday { get; init; }
        public DayOpeningHours Wednesday { get; init; }
        public DayOpeningHours Thursday { get; init; }
        public DayOpeningHours Friday { get; init; }
        public DayOpeningHours Saturday { get; init; }
        public DayOpeningHours Sunday { get; init; }
    }

    public record DayOpeningHours
    {
        public string OpeningTime { get; init; }
        public string ClosingTime { get; init; }
    }

    public record BranchRouting
    {
        public string Scheme { get; init; }
        public string Address { get; init; }
    }

    // Handler
    public class DeleteBranchHandler : IRequestHandler<DeleteBranchCommand, DeleteBranchResponse>
    {
        public async Task<DeleteBranchResponse> Handle(DeleteBranchCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.BANK_ID) || string.IsNullOrEmpty(request.BRANCH_ID))
            {
                throw new ArgumentException("BANK_ID and BRANCH_ID are mandatory.");
            }

            // Simulate deletion process and return a response
            var response = new DeleteBranchResponse
            {
                Id = request.BRANCH_ID,
                BankId = request.BANK_ID,
                Name = "Branch by the Lake",
                Address = new Address
                {
                    Line1 = "No 1 the Road",
                    Line2 = "The Place",
                    Line3 = "The Hill",
                    City = "Berlin",
                    County = "String",
                    State = "Brandenburg",
                    Postcode = "13359",
                    CountryCode = "DE"
                },
                Location = new Location
                {
                    Latitude = 10,
                    Longitude = 10
                },
                Meta = new Meta
                {
                    License = new License
                    {
                        Id = "ODbL-1.0",
                        Name = "Open Database License"
                    }
                },
                Lobby = new Lobby
                {
                    Monday = new List<DayOpeningHours>
                    {
                        new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" }
                    },
                    Tuesday = new List<DayOpeningHours>
                    {
                        new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" }
                    },
                    Wednesday = new List<DayOpeningHours>
                    {
                        new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" }
                    },
                    Thursday = new List<DayOpeningHours>
                    {
                        new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" }
                    },
                    Friday = new List<DayOpeningHours>
                    {
                        new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" }
                    },
                    Saturday = new List<DayOpeningHours>
                    {
                        new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" }
                    },
                    Sunday = new List<DayOpeningHours>
                    {
                        new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" }
                    }
                },
                DriveUp = new DriveUp
                {
                    Monday = new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" },
                    Tuesday = new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" },
                    Wednesday = new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" },
                    Thursday = new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" },
                    Friday = new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" },
                    Saturday = new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" },
                    Sunday = new DayOpeningHours { OpeningTime = "10:00", ClosingTime = "18:00" }
                },
                BranchRouting = new BranchRouting
                {
                    Scheme = "OBP",
                    Address = "123abc"
                },
                IsAccessible = "true",
                AccessibleFeatures = "wheelchair, atm usable by the visually impaired",
                BranchType = "Full service store",
                MoreInfo = "short walk to the lake from here",
                PhoneNumber = "+381631954907"
            };

            return await Task.FromResult(response);
        }
    }
}
