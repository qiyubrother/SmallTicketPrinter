using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTicketPrinter
{
    public class CSmallTicketPrinter
    {
        private string _configFileName = string.Empty;
        public CSmallTicketPrinter(string configFileName)
        {
            _configFileName = configFileName;
        }

        public void Print(CSmallTicketPrinterData data)
        {
            
        }
    }

    public class CSmallTicketPrinterData
    {
        // 商户名称
        public string 商户名称 { get; set; }
        public string 商户编号 { get; set; }
        public string 终端编号 { get; set; }
        public string 操作号 { get; set; }
        public string 收单行 { get; set; }
        public string 银联商务 { get; set; }
        public string 银行卡号 { get; set; }
        public string 交易类型 { get; set; }
        public string 批次号 { get; set; }
        public string 凭证号 { get; set; }
        public string 参考号 { get; set; }
        public string 授权号 { get; set; }
        public string 日期时间 { get; set; }
        public string 交易金额 { get; set; }
        public string 备注 { get; set; }
        public string 持卡人存根 { get; set; }


        public string 早餐券 { get; set; }
        public string 酒店名称 { get; set; }
        public string 早餐券说明 { get; set; }
        public string 早餐券有效期 { get; set; }
        public string 用餐地址 { get; set; }
        public string 房号 { get; set; }

        public string 酒店服务电话 { get; set; }
        public string 前台座机号 { get; set; }

        public string 楼层 { get; set; }
        public string 性别 { get; set; }
        public string 交房型易类型 { get; set; }
        public string 房价 { get; set; }
        public string 证件类型 { get; set; }
        public string 证件号码 { get; set; }
        public string 到店时间 { get; set; }
        public string 宾客序号 { get; set; }
        public string 入住类型 { get; set; }
        public string 入住方式 { get; set; }
        public string 付款方式 { get; set; }
        public string 付款金额 { get; set; }
        public string 付款时间 { get; set; }
        public string 离店时间 { get; set; }
        public string 打印时间 { get; set; }
    }
}
