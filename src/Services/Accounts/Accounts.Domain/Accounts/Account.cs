

namespace Accounts.Domain.Accounts;

public sealed class Account
{
    public Guid Id { get; private set; }
    public Guid CustomerId { get; private set; }
    public string AccountNumber { get; private set; } = default!;
    public string Currency { get; private set; } = default!;
    public decimal Balance { get; private set; }
    public DateTime OpenedAtUtc { get; private set; }

    private Account() { }

    public static Account Open(Guid customerId, string accountNumber, string currency)=>new ()
        {
        Id = Guid.CreateVersion7(),
        CustomerId = customerId,
        AccountNumber = accountNumber,
        Currency = currency.ToUpperInvariant(),
        Balance = 0m,
        OpenedAtUtc = DateTime.UtcNow
        };
    }


