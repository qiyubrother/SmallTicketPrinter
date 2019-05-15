using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SmallTicketPrinter
{
    public class PrinterAPI
    {
        // 设置默认打印机
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(String Name);
        //// 读取默认打印机
        //[DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        //public static extern bool GetDefaultPrinter(ref StringBuilder pszBuffer, ref Int32 len);
    }
}
