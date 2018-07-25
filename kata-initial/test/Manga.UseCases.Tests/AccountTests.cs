namespace Manga.UseCaseTests
{
    using Xunit;
    using System;
    using Manga.Domain.Accounts;

    public class AccountTests
    {
        [Theory]
        [InlineData(100)]
        public void Account_With_Credits_Should_Not_Allow_Close(double amount)
        {
            var account = new Account(Guid.NewGuid());
            account.Deposit(amount);

            Assert.Throws<AccountCannotBeClosedException>(
                () => account.Close());
        }
    }
}
