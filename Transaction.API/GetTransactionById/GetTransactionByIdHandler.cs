using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Transaction.API.Endpoints
{
    public class GetTransactionByIdHandler : IRequestHandler<GetTransactionByIdQuery, TransactionDetails>
    {
        private static List<TransactionDetails> _transactions = new List<TransactionDetails>
        {
            new TransactionDetails
            {
                Id = "5995d6a2-01b3-423c-a173-5481df49bdaf",
                ThisAccount = new AccountDetails
                {
                    Id = "5995d6a2-01b3-423c-a173-5481df49bdaf",
                    Holders = new List<AccountHolder>
                    {
                        new AccountHolder { Name = "OBP", IsAlias = true }
                    },
                    Number = "123",
                    Kind = "AC",
                    IBAN = "UK1234AD",
                    SwiftBic = "UK1234AD",
                    Bank = new BankDetails { NationalIdentifier = "OBP", Name = "OBP" }
                },
                OtherAccount = new AccountDetails
                {
                    Id = "5995d6a2-01b3-423c-a173-5481df49bdaf",
                    Holders = new List<AccountHolder>
                    {
                        new AccountHolder { Name = "OBP", IsAlias = true }
                    },
                    Number = "123",
                    Kind = "3456",
                    IBAN = "UK234DB",
                    SwiftBic = "UK12321DB",
                    Bank = new BankDetails { NationalIdentifier = "OBP", Name = "OBP" }
                },
                Details = new TransactionDetailsInfo
                {
                    Type = "AC",
                    Description = "This is for family",
                    Posted = "1100-01-01T00:00:00Z",
                    Completed = "1100-01-01T00:00:00Z",
                    NewBalance = new Balance { Currency = "EUR", Amount = "0" },
                    Value = new Balance { Currency = "EUR", Amount = "0" }
                },
                Metadata = new TransactionMetadata
                {
                    MoreInfo = "www.openbankproject.com",
                    URL = "www.openbankproject.com",
                    ImageURL = "www.openbankproject.com",
                    OpenCorporatesURL = "www.openbankproject.com",
                    CorporateLocation = new Location
                    {
                        Latitude = 1.231,
                        Longitude = 1.231,
                        Date = "1100-01-01T00:00:00Z",
                        User = new User
                        {
                            Id = "5995d6a2-01b3-423c-a173-5481df49bdaf",
                            Provider = "http://127.0.0.1:8080",
                            DisplayName = "OBP"
                        }
                    },
                    PhysicalLocation = new Location
                    {
                        Latitude = 1.231,
                        Longitude = 1.231,
                        Date = "1100-01-01T00:00:00Z",
                        User = new User
                        {
                            Id = "5995d6a2-01b3-423c-a173-5481df49bdaf",
                            Provider = "http://127.0.0.1:8080",
                            DisplayName = "OBP"
                        }
                    }
                }
            }
        };

        public async Task<TransactionDetails> Handle(GetTransactionByIdQuery request, CancellationToken cancellationToken)
        {
            var transaction = _transactions.Find(t =>
                t.Id == request.TransactionId &&
                t.ThisAccount.Id == request.AccountId);

            if (transaction != null)
            {
                transaction.Metadata.MoreInfo = "Updated info from API";
            }

            return await Task.FromResult(transaction);
        }
    }
}
