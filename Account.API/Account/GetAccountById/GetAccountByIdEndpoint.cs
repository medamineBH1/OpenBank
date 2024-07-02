using MediatR;

namespace OpenBank.Services.Account.GetAccountById
{
    public class GetAccountByIdEndpoint
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/account/{bankId}/{accountId}", async (string bankId, string accountId, ISender sender) =>
            {
                try
                {
                    var request = new GetAccountByIdRequest(bankId, accountId);
                    var response = await sender.Send(request);

                    if (response == null)
                    {
                        return Results.NotFound();
                    }

                    return Results.Ok(response);
                }
                catch (Exception ex)
                {
                    return Results.Problem(detail: $"Internal server error: {ex.Message}", statusCode: StatusCodes.Status500InternalServerError);
                }
            })
            .WithName("GetAccountById")
            .Produces<GetAccountByIdResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .ProducesProblem(StatusCodes.Status500InternalServerError)
            .WithSummary("Get Account by ID")
            .WithDescription("Get details of an account by its ID and Bank ID");
        }
    }
}
