using System;
using System.Collections.Generic;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of CDAccounts
            var myAcc = new List<CDAcc>();
            myAcc.Add(new CDAcc()
            {
                AccNum = 45879612,
                InterestRate = 5.6,
                AccBal = 213.70,
                MaturityDate = new DateTime(2023, 11, 25)
            });
            myAcc.Add(new CDAcc()
            {
                AccNum = 89326741,
                InterestRate = 7,
                AccBal = 2413.45,
                MaturityDate = new DateTime(2025, 08, 20)
            });
            myAcc.Add(new CDAcc()
            {
                AccNum = 52671039,
                InterestRate = 4.1,
                AccBal = 16.79,
                MaturityDate = new DateTime(2026, 06, 10)
            });
            myAcc.Add(new CDAcc()
            {
                AccNum = 15975384,
                InterestRate = 3.3,
                AccBal = 713.21,
                MaturityDate = new DateTime(2027, 03, 11)
            });
            myAcc.Add(new CDAcc()
            {
                AccNum = 97863540,
                InterestRate = 7.77,
                AccBal = 530,
                MaturityDate = new DateTime(2028, 08, 5)
            });
            // Testing your deposit
            Console.WriteLine("previously deposit \n" + myAcc[0]);
            myAcc[0].Deposit(502);
            Console.WriteLine("Afterwards deposit \n " + myAcc[0]);
            // Testing your withdraw
            Console.WriteLine("\npreviously withdraw \n" + myAcc[4]);
            myAcc[4].Withdraw(14);
            Console.WriteLine("Afterwards withdraw \n " + myAcc[4]);
            // sort and print
            Console.WriteLine("\nArranged accounts");
            myAcc.Sort();
            foreach (var account in myAcc)
            {
                Console.WriteLine(account);
            }
        }
    }
}