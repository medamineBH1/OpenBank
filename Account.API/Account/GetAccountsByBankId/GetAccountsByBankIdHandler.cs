using MediatR;

namespace OpenBank.Services.Account.GetAccountsByBankId
{
    public class GetAccountsByBankIdHandler : IRequestHandler<GetAccountsByBankIdRequest, GetAccountsByBankIdResponse>
    {
        private readonly GetAccountById._accountRepository _accountRepository;

        public GetAccountsByBankIdHandler(GetAccountById._accountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<GetAccountsByBankIdResponse> Handle(GetAccountsByBankIdRequest request, CancellationToken cancellationToken)
        {
            var accountIds = await _accountRepository.GetAccountsByBankIdAsync(request.BankId, request.AccountTypeFilter, request.AccountTypeFilterOperation);

            return new GetAccountsByBankIdResponse(accountIds);
        }
    }
    
}
