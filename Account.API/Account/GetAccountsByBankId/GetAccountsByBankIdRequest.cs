namespace OpenBank.Services.Account.GetAccountsByBankId
{
    public record GetAccountsByBankIdRequest(string BankId, string AccountTypeFilter = null, string AccountTypeFilterOperation = null);
}
