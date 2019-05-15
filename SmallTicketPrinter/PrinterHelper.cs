using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NNHuman.Native.MODEL;
namespace SmallTicketPrinter
{
    public class PrinterHelper
    {
        public static void Print(SystemParams sp, TicketTypeEnum type = TicketTypeEnum.None)
        {
            //var pf = new FrmPrint();
            //var header = new Dictionary<string, string>();
            //var loopBody = new List<Dictionary<string, string>>();

            //// 主订单号
            //header["MainId"] =  sp.MainId;
            //// PMS系统预订单号
            //header["PmsPreOrderId"] = sp.PmsPreOrderId;
            //// 子订单号
            //header["OrderId"] = sp.OrderId;
            //// PMS入住单号
            //header["PmsSubOrderId"] = sp.PmsSubOrderId;
            //// 酒店编号
            //header["HotelId"] = sp.HotelId;
            //// 酒店名称
            //header["HotelName"] = sp.HotelName;
            //// 订单类型
            //header["OrderType"] = sp.OrderType;
            //// 预订人姓名
            //header["Name"] = sp.Name;
            //// 预订人证件类型
            //header["IdType"] = sp.IdType.ToString();
            //// 预订人证件号
            //header["IdCard"] = sp.IdCard;
            //// 预订人手机号
            //header["Mobile"] = sp.Mobile;
            //// 会员类型
            //header["MemberType"] = sp.MemberType;
            //// 会员号
            //header["MemberId"] = sp.MemberId;
            //// 房型代码
            //header["RoomTypeCode"] = sp.RoomTypeCode;
            //// 房型名称
            //header["RoomTypeName"] = sp.RoomTypeName;
            //// 楼层
            //header["BuildNo"] = sp.BuildNo;
            //// 房间号
            //header["RoomNo"] = sp.RoomNo;
            //// 门锁号
            //header["LockNo"] = sp.LockNo;
            //// 预订支付方式
            //header["PrePayType"] = sp.PrePayType;
            //// 预付金额
            //header["PrePayedAmount"] = sp.PrePayedAmount;
            //// 房价
            //header["Price"] = sp.Price.ToString();
            //// 入住数量
            //header["Count"] = sp.Count.ToString();
            //// 总房费
            //header["TotalPrice"] = sp.TotalPrice.ToString();
            //// 总押金
            //header["TotalDeposit"] = sp.TotalDeposit.ToString();
            //// 先付房费
            //header["FirstPrice"] = sp.FirstPrice.ToString();
            //// 先付押金
            //header["FirstDeposit"] = sp.FirstDeposit.ToString();
            //// 后付房费
            //header["PostPrice"] = sp.PostPrice.ToString();
            //// 早餐数量
            //header["BFCount"] = sp.BFCount.ToString();
            //// 是否隐藏房价
            //header["IsHidePrice"] = sp.IsHidePrice;
            //// 是否允许在自助机办理
            //header["CanSelfHelp"] = sp.CanSelfHelp.ToString();
            //// 到达时间
            //header["ArrivalTime"] = sp.ArrivalTime;
            //// 预离时间
            //header["PreLeaveTime"] = sp.PreLeaveTime;
            //// PMS备注
            //header["PmsRemark"] = sp.PmsRemark;
            //// 订单创建日期
            //header["OrderDate"] = sp.OrderDate;
            //// 订单状态
            //header["OrderStatus"] = sp.OrderStatus;
            //// 是否后付费
            //header["IsPostpaid"] = sp.IsPostpaid.ToString();
            //// 退房时间
            //header["LeaveTime"] = sp.LeaveTime;
            //// PMS押金描述
            //header["PMSDepositDesc"] = sp.PMSDepositDesc;
            //// PMS房费描述
            //header["PMSPriceDesc"] = sp.PMSPriceDesc;
            //// PMS早餐数描述
            //header["PMSBFDesc"] = sp.PMSBFDesc;
            //// 当前刷身份证用户证件号
            //header["CurrentIdCard"] = sp.CurrentIdCard;
            //// 当前刷身份证用户姓名
            //header["CurrentName"] = sp.CurrentName;
            //// 当前刷身份证用户性别
            //header["CurrentGender"] = sp.CurrentGender;
            //// 当前刷身份证用户名族
            //header["CurrentFolk"] = sp.CurrentFolk;
            //// 当前刷身份证用户出生年月
            //header["CurrentBorn"] = sp.CurrentBorn;

            //if (type == TicketTypeEnum.CheckIn)
            //{
            //    // 入住
            //    foreach(var person in sp.CheckInPersonList)
            //    {
            //        var d = new Dictionary<string, string>();
            //        // 入住人证件类型
            //        d["IdType"] = person.IdType;

            //        // 入住人证件号
            //        d["IdCard"] = person.IdCard;

            //        // 入住人姓名
            //        d["Name"] = person.Name;

            //        // 入住时间
            //        d["CheckInTime"] = person.CheckInTime;

            //        loopBody.Add(d);
            //    }
            //}
            //else if (type == TicketTypeEnum.BankPay)
            //{
            //    // 支付
            //    foreach (var bankPay in sp.BankPayList)
            //    {
            //        var d = new Dictionary<string, string>();
            //        // 证件号
            //        d["IdCard"] = bankPay.IdCard;

            //        // 交易类型
            //        d["TranType"] = bankPay.TranType;

            //        // 应答码
            //        d["RespCode"] = bankPay.RespCode;

            //        // 交易卡号
            //        d["RespCardNo"] = bankPay.RespCardNo;

            //        // 金额
            //        d["RespAmount"] = bankPay.RespAmount.ToString();

            //        // 终端流水号（凭证号）
            //        d["RespTrace"] = bankPay.RespTrace;

            //        // 批次号
            //        d["RespBatch"] = bankPay.RespBatch;

            //        // 交易日期
            //        d["RespTransDate"] = bankPay.RespTransDate;

            //        // 系统参考号（中心流水号）
            //        d["RespRef"] = bankPay.RespRef;

            //        // 授权号
            //        d["RespAuth"] = bankPay.RespAuth;

            //        // 商户号
            //        d["Mid"] = bankPay.Mid;

            //        // 终端号
            //        d["Tid"] = bankPay.Tid;

            //        // 全民付
            //        d["RespMemo"] = bankPay.RespMemo;

            //        // 3个校验字符
            //        d["RespLrc"] = bankPay.RespLrc;

            //        // 创建时间
            //        d["CreateTime"] = bankPay.CreateTime;

            //        loopBody.Add(d);
            //    }
            //}
            //else if (type == TicketTypeEnum.Extension)
            //{
            //    // 续房
            //    foreach (var extension in sp.ExtensionInfoList)
            //    {
            //        var d = new Dictionary<string, string>();
            //        // 续住数量
            //        d["ExtendNum"] = extension.ExtendNum.ToString();

            //        // 房费
            //        d["TotalPrice"] = extension.TotalPrice.ToString();

            //        // 押金
            //        d["TotalDeposit"] = extension.TotalDeposit.ToString();

            //        // 创建时间
            //        d["CreateTime"] = extension.CreateTime.ToString();

            //        loopBody.Add(d);
            //    }
            //}
            //pf.Header = header;
            //pf.LoopBody = loopBody;
            //pf.Show();
        }

        /// <summary>
        /// 小票类型
        /// </summary>
        public enum TicketTypeEnum
        {
            // 无重复
            None = 0,
            // 入住人信息
            CheckIn = 1,
            // 续住
            Extension = 2,
            // 支付
            BankPay = 3,
        }
    }
}
