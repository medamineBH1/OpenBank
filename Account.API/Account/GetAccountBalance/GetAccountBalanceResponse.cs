namespace OpenBank.Services.Account.GetAccountBalances
{
    public record GetAccountBalancesResponse
    {
        public string AccountId { get; init; }
        public List<Balance> Balances { get; init; }
    }

    public record Balance
    {
        public decimal Amount { get; init; }
        public string Currency { get; init; }
        public string Type { get; init; }
    }
}