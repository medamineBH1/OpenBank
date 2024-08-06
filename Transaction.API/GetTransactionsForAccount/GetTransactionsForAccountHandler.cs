using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Transaction.API.GetOtherAccountDetail;

namespace Transaction.API.Endpoints
{
    public class GetTransactionForAccountHandler : IRequestHandler<GetTransactionsForAccountQuery, TransactionsResponse>
    {
        private static List<TransactionDetails> _transactions = new List<TransactionDetails>
        {
            new TransactionDetails
            {
                Id = "123",
                Account = new AccountDetails
                {
                    Id = "5995d6a2-01b3-423c-a173-5481df49bdaf",
                    Holders = new List<AccountHolder>
                    {
                        new AccountHolder
                        {
                            Name = "OBP",
                            IsAlias = true
                        }
                    },
                    Number = "123",
                    Kind = "AC",
                    IBAN = "UK1234AD",
                    SwiftBic = "UK1234AD",
                    Bank = new BankDetails
                    {
                        NationalIdentifier = "OBP",
                        Name = "OBP"
                    }
                },
                Counterparty = new CounterpartyDetails
                {
                    Id = "123",
                    Holder = new AccountHolder
                    {
                        Name = "ZACK"
                    },
                    Number = "1234",
                    Kind = "AV",
                    IBAN = "UK12344DB",
                    SwiftBic = "UK12344DB",
                    Bank = new BankDetails
                    {
                        NationalIdentifier = "OBP",
                        Name = "OBP"
                    }
                },
                Details = new TransactionInfo
                {
                    Type = "AC",
                    Description = "OBP",
                    Posted = "1100-01-01T00:00:00Z",
                    Completed = "1100-01-01T00:00:00Z",
                    NewBalance = new Balance
                    {
                        Currency = "EUR",
                        Amount = "0"
                    },
                    Value = new Balance
                    {
                        Currency = "EUR",
                        Amount = "0"
                    }
                }
            }
        };

        public async Task<TransactionsResponse> Handle(GetTransactionsForAccountQuery request, CancellationToken cancellationToken)
        {
          

            var filteredTransactions = _transactions; // Apply filtering logic here if necessary

            var response = new TransactionsResponse
            {
                Transactions = filteredTransactions
            };

            return await Task.FromResult(response);
        }
    }
}
