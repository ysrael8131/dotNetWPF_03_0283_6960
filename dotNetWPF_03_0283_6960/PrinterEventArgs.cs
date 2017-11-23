using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetWPF_03_0283_6960
{
    class PrinterEventArgs
    {
        bool critic;
        DateTime date;
        string errorMessage;
        string printerName;
        PrinterEventArgs(bool c, string e, string p)
        {
            this.critic = c;
            this.errorMessage = e;
            this.printerName = p;
            this.date = DateTime.Now;
        }
    }
}
