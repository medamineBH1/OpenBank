using MediatR;

namespace OpenBank.Services.Account.GetAccountsByBankId
{
    public class GetAccountsByBankIdEndpoint
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/banks/{bankId}/accounts/account_ids/private", async (string bankId, string accountTypeFilter, string accountTypeFilterOperation, ISender sender) =>
            {
                try
                {
                    var request = new GetAccountsByBankIdRequest(bankId, accountTypeFilter, accountTypeFilterOperation);
                    var response = await sender.Send(request);

                    return Results.Ok(response);
                }
                catch (Exception ex)
                {
                    return Results.Problem(detail: $"Internal server error: {ex.Message}", statusCode: StatusCodes.Status500InternalServerError);
                }
            })
            .WithName("GetAccountsByBankId")
            .Produces<GetAccountsByBankIdResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status500InternalServerError)
            .WithSummary("Get Accounts by Bank ID")
            .WithDescription("Get the list of account IDs at a bank that the user has access to");
        }
    }
}
