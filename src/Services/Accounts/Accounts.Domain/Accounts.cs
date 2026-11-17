using System;
using System.Collections.Generic;
using System.Text;

namespace Accounts.Domain
{
    public sealed class Accounts
    {
        public Guid Id { get; private set; }
        public Guid CustomerId { get; private set; }
        public string AccountNumber { get; private set; } = default!;
        public string Currency { get; private set; } = default!;
        public decimal Balance { get; private set; }
        public DateTime OpenedAtUtc { get; private set; }

        public Accounts(){}
        public Accounts(Guid id, Guid customerId, string accountNumber, string currency, decimal balance, DateTime openedAtUtc)
        {
            Id = id;
            CustomerId = customerId;
            AccountNumber = accountNumber;
            Currency = currency;
            Balance = balance;
            OpenedAtUtc = openedAtUtc;
        }

    }
}
