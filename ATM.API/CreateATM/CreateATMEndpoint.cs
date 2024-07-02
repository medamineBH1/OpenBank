using MediatR;

namespace OpenBank.Services.Atm.CreateAtm
{
    public class CreateAtmEndpoint
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/bank/{BANK_ID}/atms", async (string BANK_ID, CreateAtmRequest request, ISender sender) =>
            {
                try
                {
                    request = request with { BankId = BANK_ID };
                    var response = await sender.Send(request);
                    return Results.Ok(response);
                }
                catch (Exception ex)
                {
                    return Results.Problem(detail: $"Internal server error: {ex.Message}", statusCode: StatusCodes.Status500InternalServerError);
                }
            })
            .WithName("CreateAtm")
            .Produces<CreateAtmResponse>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status500InternalServerError)
            .WithSummary("Create ATM")
            .WithDescription("Create a new ATM for a specified bank.");
        }
    }
}
