
using MediatR;

namespace OpenBank.Services.Account.CreateAccount
{
    public record CreateAccountResponse(bool IsSuccess);

    public class CreateAccountEndpoint
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            _ = app.MapPost("/account/create", async (CreateAccountRequest request, ISender sender) =>
            {
                try
                {

                    // Create the account
                    var createdAccount = await sender.CreateAccountAsync(request.CreateAccountDto);

                    // Generate response
                    var response = new CreateAccountResponse(true);

                    return Results.Ok(response);
                }
                catch (Exception ex)
                {

                    return Results.Problem(detail: $"Internal server error: {ex.Message}", statusCode: StatusCodes.Status500InternalServerError);
                }
            })
            .WithName("CreateAccount")
            .Produces<CreateAccountResponse>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Create Account")
            .WithDescription("Create a new account");

        }
    }

    
}
