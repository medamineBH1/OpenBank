namespace Branch.API.CreateBranch
{
        public class CreateBranchEndpoint
        {
            private readonly IBranchRepository _branchRepository;

            public CreateBranchEndpoint(IBranchRepository branchRepository)
            {
                _branchRepository = branchRepository;
            }

            public void AddRoutes(IEndpointRouteBuilder app)
            {
                app.MapPost("/branch/create", async (CreateBranchRequest request) =>
                {
                    try
                    {
                        
                        var createdBranch = await _branchRepository.CreateBranchAsync(request);

                        
                        var response = new CreateBranchResponse
                        {
                            AccessibleFeatures = createdBranch.AccessibleFeatures,
                            Address = createdBranch.Address,
                            BankId = createdBranch.BankId,
                            BranchRouting = createdBranch.BranchRouting,
                            BranchType = createdBranch.BranchType,
                            City = createdBranch.City,
                            ClosingTime = createdBranch.ClosingTime,
                            CountryCode = createdBranch.CountryCode,
                            County = createdBranch.County,
                            DriveUp = createdBranch.DriveUp,
                            Friday = createdBranch.Friday,
                            Id = createdBranch.Id,
                            IsAccessible = createdBranch.IsAccessible,
                            Latitude = createdBranch.Latitude,
                            License = createdBranch.License,
                            Line1 = createdBranch.Line1,
                            Line2 = createdBranch.Line2,
                            Line3 = createdBranch.Line3,
                            Lobby = createdBranch.Lobby,
                            Location = createdBranch.Location,
                            Longitude = createdBranch.Longitude,
                            Meta = createdBranch.Meta,
                            Monday = createdBranch.Monday,
                            MoreInfo = createdBranch.MoreInfo,
                            Name = createdBranch.Name,
                            OpeningTime = createdBranch.OpeningTime,
                            PhoneNumber = createdBranch.PhoneNumber,
                            Postcode = createdBranch.Postcode,
                            Saturday = createdBranch.Saturday,
                            Scheme = createdBranch.Scheme,
                            State = createdBranch.State,
                            Sunday = createdBranch.Sunday,
                            Thursday = createdBranch.Thursday,
                            Tuesday = createdBranch.Tuesday,
                            Wednesday = createdBranch.Wednesday
                        };

                        return Results.Ok(response);
                    }
                    catch (Exception ex)
                    {
                        return Results.Problem(detail: $"Internal server error: {ex.Message}", statusCode: StatusCodes.Status500InternalServerError);
                    }
                })
                .WithName("CreateBranch")
                .Produces<CreateBranchResponse>(StatusCodes.Status201Created)
                .ProducesProblem(StatusCodes.Status400BadRequest)
                .WithSummary("Create Branch")
                .WithDescription("Create a new branch for the bank");
            }
        }
 }

