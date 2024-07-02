using MediatR;

public class CreateAccountRequest
{
    public string BankId { get; set; }
    public string[] AccountRoutings { get; set; }
    public string Address { get; set; }
    public decimal Amount { get; set; }
    public decimal Balance { get; set; }
    public string BranchId { get; set; }
    public string Currency { get; set; }
    public string Label { get; set; }
    public string ProductCode { get; set; }
    public string Scheme { get; set; }
    public string UserId { get; set; }
    public object CreateAccountDto { get; internal set; }
}

public class CreateAccountResponse
{
    public string AccountAttributeId { get; set; }
    public string[] AccountAttributes { get; set; }
    public string BankId { get; set; }
    public string AccountId { get; set; }
    public string[] AccountRoutings { get; set; }
    public string Address { get; set; }
    public decimal Amount { get; set; }
    public decimal Balance { get; set; }
    public string BranchId { get; set; }
    public string Currency { get; set; }
    public string Label { get; set; }
    public string Name { get; set; }
    public string ProductCode { get; set; }
    public string Scheme { get; set; }
    public string Type { get; set; }
    public string UserId { get; set; }
    public int Value { get; set; }
    public string ProductInstanceCode { get; set; }
}

public class CreateAccountHandler : IRequestHandler<CreateAccountRequest, CreateAccountResponse>
{
    public async Task<CreateAccountResponse> Handle(CreateAccountRequest request, CancellationToken cancellationToken)
    {
        try
        {
            // Simulate account creation logic
            var accountId = Guid.NewGuid().ToString(); // Generate a new account ID

            // Simulate response
            var response = new CreateAccountResponse
            {
                AccountId = accountId,
                BankId = request.BankId,
                AccountRoutings = request.AccountRoutings,
                Address = request.Address,
                Amount = request.Amount,
                Balance = request.Balance,
                BranchId = request.BranchId,
                Currency = request.Currency,
                Label = request.Label,
                ProductCode = request.ProductCode,
                Scheme = request.Scheme,
                UserId = request.UserId,
                Name = "Account Name",
                Type = "Account Type",
                Value = 123456,
                ProductInstanceCode = "ABC123"
                // Add more properties as needed
            };

            return response;
        }
        catch (Exception ex)
        {
            // Handle exceptions
            throw new Exception("Failed to create account", ex);
        }
    }
}
