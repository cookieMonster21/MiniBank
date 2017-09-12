using InterfacesTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank
{
    public class BankAccount : IBankAccount
    {
        public BankAccount(int accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public int AccountNumber { get; private set; }

        public double Balance { get; private set; }

        public double InterestRate { get;  set; }

        public IList<ITransaction> TransactionList { get; private set; }

        public IList<ICustomer> CustomerList { get; private set; }
    }
}
