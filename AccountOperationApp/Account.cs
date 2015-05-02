using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    internal class Account
    {
        public string customerName;

        public string accountNumber;

        public double balance = 0;

        public double GetWithdrawAmount(double withdrawAmount)
        {
            return balance - withdrawAmount;

        }

        public double GetDepositAmount(double depositAmount)
        {
            return balance + depositAmount;
        }


    }
}
