namespace AccountOperationApp
{
    partial class AccountOperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.withDrawAmountButton = new System.Windows.Forms.Button();
            this.depositAmountButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportcreateButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerNameTextBox);
            this.groupBox1.Controls.Add(this.accountNumberTextBox);
            this.groupBox1.Controls.Add(this.createAccountButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Creation";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(171, 85);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.customerNameTextBox.TabIndex = 4;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(171, 31);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(250, 20);
            this.accountNumberTextBox.TabIndex = 3;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(346, 144);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(75, 23);
            this.createAccountButton.TabIndex = 2;
            this.createAccountButton.Text = "Create";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.amountTextBox);
            this.groupBox2.Controls.Add(this.withDrawAmountButton);
            this.groupBox2.Controls.Add(this.depositAmountButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(25, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transcation";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(147, 50);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(230, 20);
            this.amountTextBox.TabIndex = 3;
            // 
            // withDrawAmountButton
            // 
            this.withDrawAmountButton.Location = new System.Drawing.Point(256, 111);
            this.withDrawAmountButton.Name = "withDrawAmountButton";
            this.withDrawAmountButton.Size = new System.Drawing.Size(121, 32);
            this.withDrawAmountButton.TabIndex = 2;
            this.withDrawAmountButton.Text = "Withdraw";
            this.withDrawAmountButton.UseVisualStyleBackColor = true;
            this.withDrawAmountButton.Click += new System.EventHandler(this.withDrawAmountButton_Click);
            // 
            // depositAmountButton
            // 
            this.depositAmountButton.Location = new System.Drawing.Point(147, 111);
            this.depositAmountButton.Name = "depositAmountButton";
            this.depositAmountButton.Size = new System.Drawing.Size(75, 32);
            this.depositAmountButton.TabIndex = 1;
            this.depositAmountButton.Text = "Deposit";
            this.depositAmountButton.UseVisualStyleBackColor = true;
            this.depositAmountButton.Click += new System.EventHandler(this.depositAmountButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // reportcreateButton
            // 
            this.reportcreateButton.Location = new System.Drawing.Point(172, 458);
            this.reportcreateButton.Name = "reportcreateButton";
            this.reportcreateButton.Size = new System.Drawing.Size(203, 23);
            this.reportcreateButton.TabIndex = 2;
            this.reportcreateButton.Text = "Report";
            this.reportcreateButton.UseVisualStyleBackColor = true;
            this.reportcreateButton.Click += new System.EventHandler(this.reportcreateButton_Click);
            // 
            // AccountOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 493);
            this.Controls.Add(this.reportcreateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountOperation";
            this.Text = "Account Operation UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button withDrawAmountButton;
        private System.Windows.Forms.Button depositAmountButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reportcreateButton;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

