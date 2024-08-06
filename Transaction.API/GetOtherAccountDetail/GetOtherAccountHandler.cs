using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Transaction.API.GetOtherAccountDetail;

namespace Transaction.API.Endpoints
{
    public class GetOtherAccountDetailHandler : IRequestHandler<GetOtherAccountDetailQuery, OtherAccountDetails>
    {
        private static List<OtherAccountDetails> _transactions = new List<OtherAccountDetails>
        {
            new OtherAccountDetails
            {
                Id = "5995d6a2-01b3-423c-a173-5481df49bdaf",
                Holder = new AccountHolder
                {
                    Name = "OBP",
                    IsAlias = true
                },
                Number = "123",
                Kind = "3456",
                IBAN = "UK234DB",
                SwiftBic = "UK12321DB",
                Bank = new BankDetails
                {
                    NationalIdentifier = "OBP",
                    Name = "OBP"
                },
                Metadata = new TransactionMetadata
                {
                    PublicAlias = "NONE",
                    PrivateAlias = "NONE",
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

        public async Task<OtherAccountDetails> Handle(GetOtherAccountDetailQuery request, CancellationToken cancellationToken)
        {
            var transaction = _transactions.Find(t =>
                t.Id == request.TransactionId);

            if (transaction != null)
            {
                transaction.Metadata.MoreInfo = "Updated info from API";
            }

            return await Task.FromResult(transaction);
        }
    }
}
