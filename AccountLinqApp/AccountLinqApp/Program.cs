using CustomExceptionApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccountLinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            CaseStudy1();

            //TODO: Display all account holders alphatically

        }

        private static void CaseStudy1()
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new Account(101, "Kannan", 1000));
            accounts.Add(new Account(102, "Hemang", 2000));
            accounts.Add(new Account(103, "Ashish", 3000));
            accounts.Add(new Account(104, "Preeti", 4000));


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
