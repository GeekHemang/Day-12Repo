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
    }
}
