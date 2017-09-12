using InterfacesTypes;
using MiniBank;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest
{
    class BankAccountTest
    {
        [Test]
        public void CreateBankAccountTestAccountNumber()
        {
            int accountNumber = 1;
            IBankAccount bankaccount = new BankAccount(accountNumber);
            Assert.AreEqual(accountNumber, bankaccount.AccountNumber);

        }
    }

    

    
}
