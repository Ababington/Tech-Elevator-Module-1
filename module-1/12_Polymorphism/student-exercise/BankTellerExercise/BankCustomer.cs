using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Net.Sockets;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer
    {
        private List<IAccountable> accountables = new List<IAccountable>();
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                int total = 0;

                for (int i = 0; i < accountables.Count; i++)
                {
                    total += accountables[i].Balance;
                }
                if (total >= 25000M)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
               
        }
        public void AddAccount(IAccountable newAccount)
        {
            accountables.Add(newAccount);
        }
        public IAccountable[] GetAccounts()
        {
            return accountables.ToArray();
        }
    }
}


