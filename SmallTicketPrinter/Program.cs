using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallTicketPrinter;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Driver
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //var printerName = "PDFill PDF&Image Writer";
            //var ps = new PrinterSettings();
            //// 保存现有默认打印机名
            //var originPrinterName = ps.PrinterName;
            //// 设置默认打印机
            //PrinterAPI.SetDefaultPrinter(printerName);
            // 打印
            Application.Run(new FrmPrint());
            //// 还原默认打印机
            //PrinterAPI.SetDefaultPrinter(originPrinterName);

        }
    }
}
