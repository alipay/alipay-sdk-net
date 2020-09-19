using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderExternalPaychannelSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderExternalPaychannelSyncModel : AopObject
    {
        /// <summary>
        /// 业务单号，微信、支付宝交易号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务单状态
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 买家实付金额 - 仅针对支付
        /// </summary>
        [XmlElement("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 平台优惠金额 - 仅针对支付
        /// </summary>
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 交易支付使用的资金渠道
        /// </summary>
        [XmlElement("fund_bill_list")]
        public string FundBillList { get; set; }

        /// <summary>
        /// 支付成功时间 - 仅针对支付
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 商家优惠金额 - 仅针对支付
        /// </summary>
        [XmlElement("mdiscount_amount")]
        public string MdiscountAmount { get; set; }

        /// <summary>
        /// 通知时间
        /// </summary>
        [XmlElement("notify_time")]
        public string NotifyTime { get; set; }

        /// <summary>
        /// 通知类型
        /// </summary>
        [XmlElement("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部请求号 - 仅针对退款
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 支付渠道，微信：wechat，支付宝：alipay - 仅针对支付
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 实收金额 - 仅针对支付
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 本次退款金额（非累计） - 仅针对退款
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 累计退款总金额 - 仅针对退款
        /// </summary>
        [XmlElement("refund_total_amount")]
        public string RefundTotalAmount { get; set; }

        /// <summary>
        /// 业务单总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
