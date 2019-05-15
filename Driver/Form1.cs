using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallTicketPrinter;
using NNHuman.Native.MODEL;
namespace Driver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
#if false
            //var pf = new FrmPrint();
            //var header = new Dictionary<string, string>();
            //header["酒店名称"] = "北京饭店";
            //var loopBody = new List<Dictionary<string, string>>();

            //{
            //    var d = new Dictionary<string, string>();
            //    d["姓名"] = "刘振华";
            //    d["房号"] = "801";
            //    d["押金"] = "1,000";
            //    loopBody.Add(d);
            //}
            //{
            //    var d = new Dictionary<string, string>();
            //    d["姓名"] = "舒蕾";
            //    d["房号"] = "506";
            //    d["押金"] = "1,200";
            //    loopBody.Add(d);
            //}
            //{
            //    var d = new Dictionary<string, string>();
            //    d["姓名"] = "钱涛";
            //    d["房号"] = "201";
            //    d["押金"] = "900";
            //    loopBody.Add(d);
            //}
            //pf.Header = header;
            //pf.LoopBody = loopBody;
            //pf.Show();
#else
            //var sp = new SystemParams
            //{
            //    HotelName = "敦煌大酒店",
            //    PMSPriceDesc = "test",
            //    RoomNo = "155",
            //    TotalDeposit = 1600,
            //    CheckInPersonList = new List<CheckInPerson>()
            //};
            //sp.CheckInPersonList.AddRange(new[]
            //{
            //    new CheckInPerson
            //    {
            //        IdCard = "110226198908281416",
            //        IdType = "身份证",
            //        Name = "Liuzhenhua",
            //        CheckInTime = "2018/11/31"
            //    },
            //    new CheckInPerson
            //    {
            //        IdCard = "110226198308281428",
            //        IdType = "身份证",
            //        Name = "刘振华",
            //        CheckInTime = "2018/12/01"
            //    }
            //});
            //PrinterHelper.Print(sp, PrinterHelper.TicketTypeEnum.CheckIn);
#endif
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    //var printerName = "HP Color LaserJet MFP M281fdw UPD PS";
        //    var printerName = "Microsoft XPS Document Writer";
        //    var ps = new PrinterSettings();
        //    // 保存现有默认打印机名
        //    var originPrinterName = ps.PrinterName;
        //    // 设置默认打印机
        //    PrinterAPI.SetDefaultPrinter(printerName);

        //    button1_Click(null, null);

        //    // 还原默认打印机
        //    PrinterAPI.SetDefaultPrinter(originPrinterName);
        //}
    }
}
