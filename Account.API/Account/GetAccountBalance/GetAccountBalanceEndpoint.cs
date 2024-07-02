using MediatR;

namespace OpenBank.Services.Account.GetAccountBalances
{
    public class GetAccountBalancesEndpoint
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/account/balances", async (HttpContext context, ISender sender) =>
            {
                // Retrieve accountId and bankId from query parameters
                var accountId = context.Request.Query["ACCOUNT_ID"].ToString();
                var bankId = context.Request.Query["BANK_ID"].ToString();

                // Prepare request
                var request = new GetAccountBalancesRequest(accountId, bankId);

                try
                {
                    // Send request to handler
                    var response = await sender.Send(request);

                    // Return successful response
                    return Results.Ok(response);
                }
                catch (Exception ex)
                {
                    
                    return Results.Problem(detail: $"Internal server error: {ex.Message}", statusCode: StatusCodes.Status500InternalServerError);
                }
            })
            .WithName("GetAccountBalances")
            .Produces<GetAccountBalancesResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status500InternalServerError)
            .WithSummary("Get Account Balances")
            .WithDescription("Retrieve balances for a specific account at a bank");
        }
    }
}
