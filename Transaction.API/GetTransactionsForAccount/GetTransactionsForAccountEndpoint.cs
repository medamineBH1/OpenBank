using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Transaction.API.GetOtherAccountDetail
{
    [ApiController]
    [Route("transaction")]
    public class GetTransactionForAccountEndpoint : ControllerBase
    {
        private readonly IMediator _mediator;

        public GetTransactionForAccountEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{bankId}/{accountId}/transactions")]
        public async Task<IActionResult> GetTransactionsForAccount(string bankId, string accountId, [FromQuery] int limit = 500, [FromQuery] int offset = 0, [FromQuery] string sortDirection = "DESC", [FromQuery] string fromDate = null, [FromQuery] string toDate = null)
        {
            var query = new GetTransactionsForAccountQuery(bankId, accountId, limit, offset, sortDirection, fromDate, toDate);
            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }

    public class GetTransactionsForAccountQuery : IRequest<TransactionsResponse>
    {
        public string BankId { get; }
        public string AccountId { get; }
        public int Limit { get; }
        public int Offset { get; }
        public string SortDirection { get; }
        public string FromDate { get; }
        public string ToDate { get; }

        public GetTransactionsForAccountQuery(string bankId, string accountId, int limit, int offset, string sortDirection, string fromDate, string toDate)
        {
            BankId = bankId;
            AccountId = accountId;
            Limit = limit;
            Offset = offset;
            SortDirection = sortDirection;
            FromDate = fromDate;
            ToDate = toDate;
        }
    }

    public class TransactionsResponse
    {
        public List<TransactionDetails> Transactions { get; set; }
    }

    public class TransactionDetails
    {
        public string Id { get; set; }
        public AccountDetails Account { get; set; }
        public CounterpartyDetails Counterparty { get; set; }
        public TransactionInfo Details { get; set; }
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

    public class CounterpartyDetails
    {
        public string Id { get; set; }
        public AccountHolder Holder { get; set; }
        public string Number { get; set; }
        public string Kind { get; set; }
        public string IBAN { get; set; }
        public string SwiftBic { get; set; }
        public BankDetails Bank { get; set; }
    }

    public class TransactionInfo
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

    public class BankDetails
    {
        public string NationalIdentifier { get; set; }
        public string Name { get; set; }
    }
}

