namespace Manga.Application.UseCases
{
    using Manga.Domain.Customers;
    using Manga.Domain.ValueObjects;
    using System;
    using System.Collections.Generic;

    public sealed class CustomerOutput
    {
        public Guid CustomerId { get; }
        public SSN SSN { get; }
        public Name Name { get; }
        public IReadOnlyList<AccountOutput> Accounts { get; }

        public CustomerOutput(
            Customer customer,
            List<AccountOutput> accounts)
        {
            CustomerId = customer.Id;
            SSN = customer.SSN;
            Name = customer.Name;
            Accounts = accounts;
        }
    }
}
