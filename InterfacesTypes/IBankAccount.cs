using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesTypes
{
    public interface IBankAccount
    {
        int AccountNumber { get; }
        double Balance { get; }
        double InterestRate { get; set; }  //Zinsen
        IList<ITransaction> TransactionList { get; }
        IList<ICustomer> CustomerList { get; }
    }
}
