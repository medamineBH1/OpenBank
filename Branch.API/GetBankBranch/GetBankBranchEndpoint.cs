using MediatR;

namespace OpenBank.Services.Branch.GetBankBranches
{
    public class GetBankBranchesEndpoint
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/bank/{BANK_ID}/branches", async (string BANK_ID, int limit, int offset, string sortDirection, ISender sender) =>
            {
                var request = new GetBankBranchesRequest(BANK_ID, limit, offset, sortDirection);

                try
                {
                    var response = await sender.Send(request);
                    return Results.Ok(response);
                }
                catch (Exception ex)
                {
                    return Results.Problem(detail: $"Internal server error: {ex.Message}", statusCode: StatusCodes.Status500InternalServerError);
                }
            })
            .WithName("GetBankBranches")
            .Produces<GetBankBranchesResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status500InternalServerError)
            .WithSummary("Get Bank Branches")
            .WithDescription("Retrieve branch information for a specific bank with pagination and sorting options");
        }
    }
}
