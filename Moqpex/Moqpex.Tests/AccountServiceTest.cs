// <copyright file="AccountServiceTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoqPex;
using Moq;


namespace MoqPex.Tests
{
    /// <summary>This class contains parameterized unit tests for AccountService</summary>
    [PexClass(typeof(AccountService))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AccountServiceTest
    {
        /// <summary>Test stub for ComputeInterest(Account, Double, Int32)</summary>
        [PexMethod]
        public decimal ComputeInterestTest(
            [PexAssumeUnderTest]AccountService target,
            Account account,
            double annualRate,
            int months
        )
        {
 
            var mock = new Mock<Account>();
            PexAssume.IsTrue(mock.Object.Balance >= 0m && mock.Object.Balance <= 1000m);

            decimal result = target.ComputeInterest(account, annualRate, months);
            return result;
            // TODO: add assertions to method AccountServiceTest.ComputeInterestTest(AccountService, Account, Double, Int32)
        }

        /// <summary>Test stub for .ctor(Account, Account)</summary>
        [PexMethod]
        public AccountService ConstructorTest(Account a, Account b)
        {
            AccountService target = new AccountService(a, b);
            return target;
            // TODO: add assertions to method AccountServiceTest.ConstructorTest(Account, Account)
        }

        /// <summary>Test stub for MakeTransfer(Account, Account, Decimal)</summary>
        [PexMethod]
        public void MakeTransferTest(
            [PexAssumeUnderTest]AccountService target,
            Account sourceAccount,
            Account destinationAccount,
            decimal amount
        )
        {
            target.MakeTransfer(sourceAccount, destinationAccount, amount);
            // TODO: add assertions to method AccountServiceTest.MakeTransferTest(AccountService, Account, Account, Decimal)
        }
    }
}
