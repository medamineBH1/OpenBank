using MediatR;
namespace OpenBank.Services.Atm.DeleteAtm
{
    public record DeleteAtmRequest(string BankId, string AtmId) : IRequest<DeleteAtmResponse>;
}
