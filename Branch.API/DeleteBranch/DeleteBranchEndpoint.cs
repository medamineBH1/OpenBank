using Branch.API.CreateBranch;


namespace Branch.API.DeleteBranch
{
    public class DeleteBranchEndpoint
    {
        private readonly IBranchRepository _branchRepository;

        public DeleteBranchEndpoint(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
        }

        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/branch/delete/{BankId}/{BranchId}", async (string BankId, string BranchId) =>
            {
                try
                {
                    // Perform the delete operation
                    var deletedBranch = await _branchRepository.deleteBranch(BankId, BranchId);

                    if (deletedBranch == null)
                    {
                        return Results.NotFound();
                    }

                    // Create the response
                    var response = new DeleteBranchResponse
                    {
                        Id = deletedBranch.Id,
                        BankId = deletedBranch.BankId,
                        Name = deletedBranch.Name,
                        Address = deletedBranch.Address,
                        Location = deletedBranch.Location,
                        Meta = deletedBranch.Meta,
                        Lobby = deletedBranch.Lobby,
                        DriveUp = deletedBranch.DriveUp,
                        BranchRouting = deletedBranch.BranchRouting,
                        IsAccessible = deletedBranch.IsAccessible,
                        AccessibleFeatures = deletedBranch.AccessibleFeatures,
                        BranchType = deletedBranch.BranchType,
                        MoreInfo = deletedBranch.MoreInfo,
                        PhoneNumber = deletedBranch.PhoneNumber
                    };

                    return Results.Ok(response);
                }
                catch (Exception ex)
                {
                    return Results.Problem(detail: $"Internal server error: {ex.Message}", statusCode: StatusCodes.Status500InternalServerError);
                }
            })
            .WithName("DeleteBranch")
            .Produces<DeleteBranchResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Delete Branch")
            .WithDescription("Delete a branch from the bank");
        }
    }
}
