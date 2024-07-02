

using ATM.API.GetBankATM;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

public class GetBankATMEndpoint
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Register services
        builder.Services.AddMediatR(typeof(GetBankATMEndpoint).Assembly);

        var app = builder.Build();

        // Configure endpoints
        ConfigureEndpoints(app);

        app.Run();
    }

    private static void ConfigureEndpoints(WebApplication app)
    {
        app.MapGet("/banks/{bankId}/atms/{atmId}", async (string bankId, string atmId, IMediator mediator) =>
        {
            var request = new GetBankATMRequest { BankId = bankId, AtmId = atmId };
            var response = await mediator.Send(request);
            return Results.Ok(response);
        })
        .WithName("GetBankATM")
        .Produces<GetBankATMResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status404NotFound)
        .WithSummary("Get Bank ATM")
        .WithDescription("Returns information about an ATM for a single bank specified by BANK_ID and ATM_ID");
    }
}
