using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Program3
{
    class SavingsAcc : IComparable<SavingsAcc>
    {
        // instance variables
        protected long AccountNum;
        protected double interestRate;
        protected double AccountBal;
        
        public long AccNum
        {
            get
            {
                return AccountNum;
            }
            set
            {
                if (value < 0) // valid your account
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(value)} it should be positive number");
                }
                else
                {
                    AccountNum = value;
                }
            }
        }
        public double InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                if (value < 0) // validate interest rate
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(value)} it should be positive number");
                }
                else
                {
                    interestRate = value;
                }
            }
        }
        public double AccBal
        {
            get
            {
                return AccountBal;
            }
            set
            {
                AccountBal = value;
                
            }
        }
        // Create default Constructor
        public SavingsAcc()
        {
            AccNum = 0;
            InterestRate = 0.0;
            AccBal = 0.0;
        }
        // Create parametrized constructor
        public SavingsAcc(long AccountNum, double InterstRate, double AccountBal)
        {
            this.AccNum = AccountNum;
            this.InterestRate = InterstRate;
            this.AccBal = AccountBal;
        }
        //  IComparable interface
        public int CompareTo(SavingsAcc other)
        {
            if (this.AccBal > other.AccBal)
            {
                return -1;
            }
            else if (this.AccBal < other.AccBal)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        // Return SavingsAccount object string representation
        public override string ToString() =>
        $"\tThe account number : {AccNum}\n" +
        $"\tThe interest rate : {InterestRate}\n" +
        $"\tThe account balance : {AccBal}";

        // permit deposit
        public void Deposit(double money)
        {
            AccBal += money;
        }

        // permit withdraw
        public void Withdraw(double money)
        {
            // money is available or not 
            if (money > AccBal)
            {
                throw new ArgumentOutOfRangeException(nameof(money),
                money, $"{nameof(money)} is more than your account balance");
                
            }
            else
            {
                AccBal -= money;
            }
        }
    }
}