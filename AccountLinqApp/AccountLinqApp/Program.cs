using CustomExceptionApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccountLinqApp
{
    internal class Program
    {

<<<<<<< HEAD
            CaseStudy3();
            //CaseStudy2();
            //CaseStudy1();

            //TODO: Display all account holders alphatically

        }
        private static void CaseStudy2()
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new Account(101, "Kannan", 1000));
            accounts.Add(new Account(102, "Hemang", 2000));
            accounts.Add(new Account(103, "Ashish", 3000));
            accounts.Add(new Account(104, "Preeti", 4000));


            //write linq query to get the names in descending order.

            var accountnamequerry = accounts.OrderByDescending(a => a.Name);
            var accountnamesZtoA = accountnamequerry.ToList();
            accountnamesZtoA.ForEach(MyPrintDetails);

        }
        private static void CaseStudy3()
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new Account(101, "Kannan", 1000));
            accounts.Add(new Account(102, "Hemang", 2000));
            accounts.Add(new Account(103, "Ashish", 3000));
            accounts.Add(new Account(104, "Preeti", 4000));

            var namesWithI = accounts.
                Where(a => a.Name.Contains('i'))
                .ToList();
            namesWithI.ForEach(a=> Console.WriteLine(a.Name));

            var balancegreaterthan3000 = accounts.
                Where(a => a.Balance > 3000)
                .ToList();
            balancegreaterthan3000.ForEach(a => Console.WriteLine(a.Name));


        }
        private static void CaseStudy1()
        {
=======

       static List<Account> GetAccounts() {

>>>>>>> ac9854c336fc54eeca891e393a9e3e1ff0586f14
            List<Account> accounts = new List<Account>();
            accounts.Add(new Account(101, "Kannan", 1000));
            accounts.Add(new Account(102, "Hemang", 2000));
            accounts.Add(new Account(103, "Ashish", 3000));
            accounts.Add(new Account(104, "Preeti", 4000));

            return accounts;
        }

<<<<<<< HEAD
            //write linq query to get the names in descending order.
=======
      
        static void Main(string[] args)
        {

            var accounts = GetAccounts();
            var namesWithI =accounts
                    .Where(DoesNameContainI)
                    .ToList();

            namesWithI.ForEach(PrintDetails);

            //Console.WriteLine();
            var balanceGreaterThan3000 = accounts
                                    .Where(IsBalanceGreaterThan3k)
                                    .ToList();
            balanceGreaterThan3000.ForEach(PrintDetails);


            // CaseStudy1();

            //TODO: Display all account holders alphatically

            //TODO: display all account holders name container i

            //TODO: all account holders whose balance above 3000

        }
        static void PrintDetails(Account account)
        {
            Console.WriteLine(account.Name);
        }
        static bool IsBalanceGreaterThan3k(Account account)
        {
            return account.Balance > 3000;
        }
        static bool DoesNameContainI(Account acc) {
            return acc.Name.Contains("i");
                
        }

        private static void CaseStudy1()
        {
            IEnumerable<Account> accounts = GetAccounts();

           

            //write linq query to get the top 3 richesh acc holders
>>>>>>> ac9854c336fc54eeca891e393a9e3e1ff0586f14

            var accountnamequerry = accounts.OrderByDescending(a => a.Name);
            var accountnamesZtoA = accountnamequerry.ToList();
            accountnamesZtoA.ForEach(MyPrintDetails);


            //write linq query to get the top 2 richesh acc holders
            var orderedAccountQuery = accounts.OrderByDescending(MySortingAlgorithm);//this differed

            var top2query = orderedAccountQuery.Take(3);

            var toprichestList = top2query.ToList();
            toprichestList.ForEach(MyPrintDetails);

            //foreach (var account in top2query)
            //{
            //    Console.WriteLine(account.Name);
            //    Console.WriteLine(account.Balance);
            //}
        }

        static double MySortingAlgorithm(Account account) {

            return account.Balance;
        }
        static void MyPrintDetails(Account acc) {
            Console.WriteLine(acc.Name);
        }
    }
}
