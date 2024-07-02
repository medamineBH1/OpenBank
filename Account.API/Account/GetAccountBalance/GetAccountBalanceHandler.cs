using MediatR;

namespace OpenBank.Services.Account.GetAccountBalances
{
    public class GetAccountBalancesHandler : IRequestHandler<GetAccountBalancesRequest, GetAccountBalancesResponse>
    {
        public async Task<GetAccountBalancesResponse> Handle(GetAccountBalancesRequest request, CancellationToken cancellationToken)
        {
            var balances = await FetchAccountBalancesFromDataSource(request.AccountId);

            return new GetAccountBalancesResponse
            {
                AccountId = request.AccountId,
                Balances = balances
            };
        }

        private Task<List<Balance>> FetchAccountBalancesFromDataSource(string accountId)
        {
            var balances = new List<Balance>
            {
                new Balance { Amount = 120, Currency = "TND", Type = "Primary" }
                // Add more balances as needed
            };

            return Task.FromResult(balances);
        }
    }
    public record GetAccountBalancesRequest(string AccountId, string BankId);
}
