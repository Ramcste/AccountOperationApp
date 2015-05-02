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
        


            MessageBox.Show("You have deposited " + double.Parse(amountTextBox.Text) + " in your account.  and your deposit amount is added to balance");
          
            account.balance = account.GetDepositAmount(double.Parse(amountTextBox.Text));
            
            amountTextBox.Text = "";
        }

        private void withDrawAmountButton_Click(object sender, EventArgs e)
        {
   
       

            if (account.balance<double.Parse(amountTextBox.Text))
            {
                MessageBox.Show("You balance  amount is less than  withdraw amount");
            }
            else
            
            {
            
           MessageBox.Show("You have withdraw " + double.Parse(amountTextBox.Text) + " from your account and and your  balance is reduced.");

                account.balance=account.GetWithdrawAmount(double.Parse(amountTextBox.Text));
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
