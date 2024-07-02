namespace OpenBank.Services.Account.GetAccountById
{
    public record GetAccountByIdResponse(
        string Id,
        string Number,
        string Label,
        List<string> Owners,
        string Type,
        decimal Balance,
        string Currency,
        List<AccountRouting> AccountRoutings,
        List<AccountRule> AccountRules,
        List<string> Tags
    );
}
