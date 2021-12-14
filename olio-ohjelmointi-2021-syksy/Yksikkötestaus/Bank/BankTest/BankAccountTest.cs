using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankTest
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;

            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //Act
            account.Debit(debitAmount);


            //
            double actual = account.Balance;

            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumenOutOfRange()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //Act and assert
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => account.Debit(debitAmount));
        }

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 20.0;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                //Assert
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown");
        }

        [TestMethod]
        public void Debit_WithNegativeAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 104.52;
            double debitAmount = -4.55;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //Act
            try
            {
                account.Debit(debitAmount);
            }
            catch(System.ArgumentOutOfRangeException e)
            {
                return;
            }
            //Assert
            Assert.Fail("No exception thrown for negative debit.");

        }

        [TestMethod]
        public void Debit_WithTooGreatAmount_Throws()
        {
            //Arrange
            double beginningBalance = 104.52;
            double debitAmount = 110;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                return;
            }
            //Assert
            Assert.Fail("No exception thrown for debit amount > balance.");
        }

        [TestMethod]
        public void OmaTesti_KotiTehtava_CantDebitMoreThan100()
        {
            //Arrange
            double beginningBalance = 110.52;
            double debitAmount = 101;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            //Act
            try
            {
                account.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceeds100Dollar);
                return;
            }
            //Assert
            Assert.Fail("No exception thrown for trying to debit more than 100.");
        }
    }
}
