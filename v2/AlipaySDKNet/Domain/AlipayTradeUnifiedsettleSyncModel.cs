using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeUnifiedsettleSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeUnifiedsettleSyncModel : AopObject
    {
        /// <summary>
        /// 收单模式，目前仅支持PLATFORM_BUSINESS
        /// </summary>
        [XmlElement("acquire_mode")]
        public string AcquireMode { get; set; }

        /// <summary>
        /// 同步流水的类型，支付为PAY_SYNC，退款为REFUND_SYNC
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extend_params")]
        public UnifiedSettleExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 实际外部支付渠道支付或退款发生时间
        /// </summary>
        [XmlElement("external_inst_biz_date")]
        public string ExternalInstBizDate { get; set; }

        /// <summary>
        /// 外部支付渠道
        /// </summary>
        [XmlElement("external_inst_channel")]
        public string ExternalInstChannel { get; set; }

        /// <summary>
        /// 实际外部支付渠道交易创建时间
        /// </summary>
        [XmlElement("external_inst_create_date")]
        public string ExternalInstCreateDate { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 签约产品码，目前仅支持UNIFIED_SETTLE
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }
    }
}
