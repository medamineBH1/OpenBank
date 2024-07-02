using MediatR;

namespace Branch.API.DeleteBranch
{

    public class DeleteBranchRequest : IRequestHandler<DeleteBranchRequest, DeleteBranchResponse>
    {
        public async Task<DeleteBranchResponse> Handle(DeleteBranchRequest request, CancellationToken cancellationToken)
        {
            
            if (string.IsNullOrEmpty(request.BANK_ID) || string.IsNullOrEmpty(request.BRANCH_ID))
            {
                throw new ArgumentException("BANK_ID and BRANCH_ID are mandatory.");
            }

         
            var response = new DeleteBranchResponse
            {
                Id = "branch-id-123",
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
