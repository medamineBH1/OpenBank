using MediatR;

namespace OpenBank.Services.Atm.DeleteAtm
{
    public class DeleteAtmEndpoint
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/bank/{BANK_ID}/atms/{ATM_ID}", async (string BANK_ID, string ATM_ID, ISender sender) =>
            {
                try
                {
                    var request = new DeleteAtmRequest(BANK_ID, ATM_ID);
                    var response = await sender.Send(request);
                    return Results.Ok(response);
                }
                catch (Exception ex)
                {
                    return Results.Problem(detail: $"Internal server error: {ex.Message}", statusCode: StatusCodes.Status500InternalServerError);
                }
            })
            .WithName("DeleteAtm")
            .Produces<DeleteAtmResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status500InternalServerError)
            .WithSummary("Delete ATM")
            .WithDescription("Delete an ATM and all its attributes for a specified bank.");
        }
    }
}
