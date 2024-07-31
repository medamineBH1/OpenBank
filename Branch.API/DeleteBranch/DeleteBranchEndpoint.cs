using Branch.API.CreateBranch;

namespace Branch.API.DeleteBranch
{
    public class DeleteBranchEndpoint
    {
        private readonly IBranchRepository _branchRepository;

        public DeleteBranchEndpoint(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository ?? throw new ArgumentNullException(nameof(branchRepository));
        }

        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/branch/delete/{BankId}/{BranchId}", async (string BankId, string BranchId) =>
            {
                try
                {
                    // Perform the delete operation
                    var deletedBranch = await _branchRepository.DeleteBranch(BankId, BranchId);

                    if (deletedBranch == null)
                    {
                        return Results.NotFound();
                    }

                    return Results.Ok(deletedBranch);
                }
                catch (Exception ex)
                {
                    // Handle the exception (you can log it or return a specific error result)
                    return Results.Problem("An error occurred while deleting the branch: " + ex.Message);
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
