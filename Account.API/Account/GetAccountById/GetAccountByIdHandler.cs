using MediatR;


namespace OpenBank.Services.Account.GetAccountById
{
    public class GetAccountByIdHandler : IRequestHandler<GetAccountByIdRequest, GetAccountByIdResponse>
    {
        private readonly _accountRepository _accountRepository;

        public GetAccountByIdHandler(_accountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<GetAccountByIdResponse> Handle(GetAccountByIdRequest request, CancellationToken cancellationToken)
        {
            var account = await GetAccountById._accountRepository.GetAccountByIdAsync(request.BankId, request.AccountId);

            if (account == null)
            {
                return null;
            }

            return new GetAccountByIdResponse(
                account.Id,
                account.Number,
                account.Label,
                account.Owners,
                account.Type,
                account.Balance,
                account.Currency,
                account.AccountRoutings,
                account.AccountRules,
                account.Tags
            );
        }
    }

    public interface _accountRepository
    {
        Task GetAccountByIdAsync(string bankId, string accountId);
        Task<List<string>> GetAccountsByBankIdAsync(string bankId, string accountTypeFilter, string accountTypeFilterOperation);
    }

   
}
