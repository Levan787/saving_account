using System;
using System.Collections.Generic;
using System.Text;
namespace Program3
{
    class CDAcc : SavingsAcc
    {
        // Class's variable
        protected DateTime maturityDate;
        
        public DateTime MaturityDate
        {
            get
            {
                return maturityDate;
            }
            set
            {
                maturityDate = value;
            }
        }
        // Create default constructor
        // default constructor call to base call
        public CDAcc()
        : base()
        {
            MaturityDate = default(DateTime);
        }
        // Create parametrized constructor
        // parametrized constructor call to base class
        public CDAcc(long AccountNum, double InterstRate, double AccountBal, DateTime
       MaturityDate)
        : base(AccountNum, InterstRate, AccountBal)
        {
            this.MaturityDate = MaturityDate;
        }
        // CDacc's object return string
        public override string ToString() =>
        $"{base.ToString()}\n" +
        $"\tyour account maturity date : {MaturityDate}\n";
    }
}