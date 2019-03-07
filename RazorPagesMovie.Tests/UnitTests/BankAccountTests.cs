using System;
using Xunit;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Tests.UnitTests
{
    public class BankAccountTests
    {
        [Fact]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            //Assert.Equal(expected, actual, 0.001, "Account not debited correctly");
            Assert.Equal(expected, actual, 3);
        }
    }
}
