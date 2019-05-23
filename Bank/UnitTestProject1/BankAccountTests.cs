using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank;
using System;


namespace UnitTestProject1 {
    [TestClass]
    public class UnitTest1 {
        // This test method is to expect a correct calculation from the method
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance() {
            // Set up to mirror the values of Main()
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44; // the expected outcome variable and value is here
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act the method
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "@@@@@@@@@@@@@@@@@ account not debited correctly");
            // third argument is called delta, it is needed because of the floating point precision problems
        }

        // This test method catches an exception message
        [TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))] // the expected outcome "variable" and its "value" is here  // No need for assert when looking for a type of
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange() {
            // Arrange (set-up)
            double beginningBalance = 11.99;
            double debitAmount = 20;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act the method
            try {
                account.Debit(debitAmount);
            } catch (ArgumentOutOfRangeException e) {
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown");
        }
    }
}
