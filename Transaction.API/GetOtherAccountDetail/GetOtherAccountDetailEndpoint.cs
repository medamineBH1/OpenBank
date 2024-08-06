using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Transaction.API.GetOtherAccountDetail
{
    [ApiController]
    [Route("transaction")]
    public class GetOtherAccountDetailEndpoint : ControllerBase
    {
        private readonly IMediator _mediator;

        public GetOtherAccountDetailEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{bankId}/{accountId}/{transactionId}/{viewId}/other-account")]
        public async Task<IActionResult> GetOtherAccountDetail(string bankId, string accountId, string transactionId, string viewId)
        {
            var query = new GetOtherAccountDetailQuery(bankId, accountId, transactionId, viewId);
            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }

    public class GetOtherAccountDetailQuery : IRequest<OtherAccountDetails>
    {
        public string BankId { get; }
        public string AccountId { get; }
        public string TransactionId { get; }
        public string ViewId { get; }

        public GetOtherAccountDetailQuery(string bankId, string accountId, string transactionId, string viewId)
        {
            BankId = bankId;
            AccountId = accountId;
            TransactionId = transactionId;
            ViewId = viewId;
        }
    }

    public class OtherAccountDetails
    {
        public string Id { get; set; }
        public AccountHolder Holder { get; set; }
        public string Number { get; set; }
        public string Kind { get; set; }
        public string IBAN { get; set; }
        public string SwiftBic { get; set; }
        public BankDetails Bank { get; set; }
        public TransactionMetadata Metadata { get; set; }
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
}

