using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgrammingApp.Services
{
    class PrinterService
    {
        public void Print() {

            while (true) {

                Debug.WriteLine($"time is: {DateTime.Now.ToString("hh:mm:ss")} ");
            }

        
        }

        public void Print(int seconds) { 
        
            DateTime startTime = DateTime.Now;
            TimeSpan future=  TimeSpan.FromSeconds( seconds );

            while (DateTime.Now - startTime < future) {

                Debug.WriteLine($"time is: {DateTime.Now.ToString("hh:mm:ss")} ");

            }
        
        }

        public void PrintViaThread() {


            Thread thread = new Thread(() =>
            {
                Print(10);
            });

            thread.Start();
        
        }

        public void PrintViaTask() {

            Task.Run(() =>
            {
                Print(10);
            });
        
        }

        public Task PrintViaTaskWithAwaitable() { 
        
            return Task.Run(() =>
            {
                Print(10);
            });

        }

        public Task<string> PrintViaTaskWithAwaitableAndResult()
        {

            return Task.Run(() =>
            {
                Print(10);

                return "Hello task is completed successfully";
            });

        }
    }
}
