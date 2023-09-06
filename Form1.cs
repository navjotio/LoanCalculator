using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmSimulator
{
    public partial class Form1 : Form
    {

        double InterestRate, MonthlyInterestRate, LoanAmount, MonthlyPayment, TotalPayment;
        int NumberOfYears;
        string MonPay, TotalPay;


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            lblPin.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lblPin.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lblPin.Text += "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPin.Text += "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lblPin.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lblPin.Text += "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            lblPin.Text += "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lblPin.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lblPin.Text += "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblPin.Text += "0";
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            btnLoanSystem.Enabled = true;
            btnExit.Enabled = true;
            btnReset.Enabled = true;
            BtnRecepit.Enabled = true;
        }

        private void btnWithdrawl_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            lblPin.Text = Convert.ToString(TotalPayment);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string AtmPinStr = string.Format(lblPin.Text);
            if (AtmPinStr.Length == 4)
            {
                lblBalance.Visible = true;
                lblDeposit.Visible = true;
                lblWithdrawl.Visible = true;
                lblLoan.Visible = true;

                btnLoan.Enabled = true;
                btnDeposit.Enabled = true;
                btnWithdrawl.Enabled = true;
                btnBalance.Enabled = true;

                lblPin.Text = "";

            } else
            {
                lblPin.Text = "";
                lblPin.Text = "Please Enter a Valid Pin";
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult Exit;

            Exit = MessageBox.Show("Confirm you want to exit", "System Message" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            lblPin.Text = "";
            lblBalance.Visible = false;
            lblDeposit.Visible = false;
            lblWithdrawl.Visible = false;
            lblLoan.Visible = false;

            btnLoan.Enabled = false;
            btnDeposit.Enabled = false;
            btnWithdrawl.Enabled = false;
            btnBalance.Enabled = false;

            btnLoanSystem.Enabled = false;
            btnReset.Enabled = false;
            BtnRecepit.Enabled = false;
            btnExit.Enabled = false;
        }
        
    

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBalance.Visible = false;
            lblDeposit.Visible = false;
            lblWithdrawl.Visible = false;
            lblLoan.Visible = false;

            btnLoan.Enabled = false;
            btnDeposit.Enabled = false;
            btnWithdrawl.Enabled = false;
            btnBalance.Enabled = false;

            btnLoanSystem.Enabled = false;
            btnReset.Enabled = false;
            BtnRecepit.Enabled = false;
            btnExit.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLoanSystem_Click(object sender, EventArgs e)
        {
            InterestRate = Convert.ToDouble(textIntRate.Text);
            MonthlyInterestRate = InterestRate / 1200;
            NumberOfYears = Convert.ToInt32(textNoOfYears.Text);
            LoanAmount = Convert.ToDouble(textAmountofLoan.Text);

            MonthlyPayment = LoanAmount * MonthlyInterestRate / (1 - 1 / Math.Pow(1 + MonthlyInterestRate, NumberOfYears * 12));

            MonPay = Convert.ToString(MonthlyPayment);
            MonPay = string.Format("{0:C}", MonthlyPayment);
            lblMonthPayments.Text = (MonPay);

            TotalPayment = MonthlyPayment * NumberOfYears * 12;
            TotalPay = string.Format("{0:C}", TotalPayment);
            lblTotalPayments.Text = (TotalPay);

            textAmountofLoan.Text = string.Format("{0:C}", LoanAmount);

        }

        private void BtnRecepit_Click(object sender, EventArgs e)
        {
            ritext.AppendText("Loan Management System Calcualtor" + "\n");
            ritext.AppendText("-----------------------------------------------------" + "\n");
            ritext.AppendText("Enter Amoount of loan" + "\t" + textAmountofLoan.Text + "\n");
            ritext.AppendText("Enter number of year" + "\t" + textNoOfYears.Text + "\n");
            ritext.AppendText("Enter interest Rate" + "\t\t" + textIntRate.Text + "\n");
            ritext.AppendText("Monthly Payment" + "\t\t" + lblMonthPayments.Text + "\n");
            ritext.AppendText("Total Payment" + "\t\t\t" + lblTotalPayments.Text + "\n");
            ritext.AppendText("----------------------------------------------" + "\n");
            ritext.AppendText("-------------------Thank You-------------------" + "\n");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textAmountofLoan.Clear();
            textNoOfYears.Clear();
            textIntRate.Clear();
            lblMonthPayments.Text = "";
            lblMonthPayments.Text = "";
            ritext.Clear();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            DialogResult Exit;

            Exit = MessageBox.Show("Confirm you want to exit", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNoOfYears_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
