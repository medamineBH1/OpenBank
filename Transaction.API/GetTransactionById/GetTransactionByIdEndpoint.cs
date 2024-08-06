using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using MediatR;

namespace Transaction.API.GetTransactionById
{
    [ApiController]
    [Route("transaction")]
    public class GetTransactionByIdEndpoint : ControllerBase
    {
        private readonly IMediator _mediator;

        public GetTransactionByIdEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{bankId}/{accountId}/{transactionId}/{viewId}")]
        public async Task<IActionResult> GetTransactionById(string bankId, string accountId, string transactionId, string viewId)
        {
            var query = new GetTransactionByIdQuery(bankId, accountId, transactionId, viewId);
            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }

    public class GetTransactionByIdQuery : IRequest<TransactionDetails>
    {
        public string BankId { get; }
        public string AccountId { get; }
        public string TransactionId { get; }
        public string ViewId { get; }

        public GetTransactionByIdQuery(string bankId, string accountId, string transactionId, string viewId)
        {
            BankId = bankId;
            AccountId = accountId;
            TransactionId = transactionId;
            ViewId = viewId;
        }
    }

    public class TransactionDetails
    {
        public string Id { get; set; }
        public AccountDetails ThisAccount { get; set; }
        public AccountDetails OtherAccount { get; set; }
        public TransactionMetadata Metadata { get; set; }
        public TransactionDetailsInfo Details { get; set; }
    }

    public class AccountDetails
    {
        public string Id { get; set; }
        public List<AccountHolder> Holders { get; set; }
        public string Number { get; set; }
        public string Kind { get; set; }
        public string IBAN { get; set; }
        public string SwiftBic { get; set; }
        public BankDetails Bank { get; set; }
    }

    public class AccountHolder
    {
        public string Name { get; set; }
        public bool IsAlias { get; set; }
    }

    public class BankDetails
    {
        public string NationalIdentifier { get; set; }
        public string Name { get; set; }
    }

    public class TransactionMetadata
    {
        public string PublicAlias { get; set; }
        public string PrivateAlias { get; set; }
        public string MoreInfo { get; set; }
        public string URL { get; set; }
        public string ImageURL { get; set; }
        public string OpenCorporatesURL { get; set; }
        public Location CorporateLocation { get; set; }
        public Location PhysicalLocation { get; set; }
    }

    public class Location
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Date { get; set; }
        public User User { get; set; }
    }

    public class User
    {
        public string Id { get; set; }
        public string Provider { get; set; }
        public string DisplayName { get; set; }
    }

    public class TransactionDetailsInfo
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string Posted { get; set; }
        public string Completed { get; set; }
        public Balance NewBalance { get; set; }
        public Balance Value { get; set; }
    }

    public class Balance
    {
        public string Currency { get; set; }
        public string Amount { get; set; }
    }
}
