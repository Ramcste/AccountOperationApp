using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountOperation : Form
    {
        Account account = new Account();
        public AccountOperation()
        {
            InitializeComponent();
        }

       
        private void createAccountButton_Click(object sender, EventArgs e)
        {
          

            account.accountNumber = accountNumberTextBox.Text;

            account.customerName = customerNameTextBox.Text;

            MessageBox.Show(account.customerName+", Your Account Number is :"+account.accountNumber);

            GetTextBoxesClear();
        }

        private void depositAmountButton_Click(object sender, EventArgs e)
        {
      

            account.depositAmount = double.Parse(amountTextBox.Text);
            account.balance += account.depositAmount;

            MessageBox.Show("You have deposited " + account.depositAmount + " in your account.  and your deposit amount is added to balance");
            
            amountTextBox.Text = "";
        }

        private void withDrawAmountButton_Click(object sender, EventArgs e)
        {
   
            account.withdrawAmount = double.Parse(amountTextBox.Text);

            if (account.balance<account.withdrawAmount)
            {
                MessageBox.Show("You balance  amount is less than  withdraw amount");
            }
            else
            {
                account.balance -= account.withdrawAmount;
                MessageBox.Show("You have withdraw " + account.withdrawAmount + " from your account and and your  balance is reduced.");
                amountTextBox.Text = "";
                
            }
         
        

        }

        private void reportcreateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(account.customerName+", your account Number is "+account.accountNumber+" and is balance is :"+account.balance);
        }

        public void GetTextBoxesClear()
        {
            accountNumberTextBox.Text = "";
            customerNameTextBox.Text = "";
        }



    }
}
