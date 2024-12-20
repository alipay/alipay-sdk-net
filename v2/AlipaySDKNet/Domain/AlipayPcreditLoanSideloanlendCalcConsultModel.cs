using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanSideloanlendCalcConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanSideloanlendCalcConsultModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id，客户在支付宝的身份证
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 试算总金额 单位元，保留两位小数
        /// </summary>
        [XmlElement("apply_loan_amount")]
        public string ApplyLoanAmount { get; set; }

        /// <summary>
        /// 待补充
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 支用期限，配合支用期限单位 loan_term_unit使用
        /// </summary>
        [XmlElement("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 贷款期限单位 MONTH -- "月" DAY -- "日"
        /// </summary>
        [XmlElement("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁借贷款产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 试算方式 AVERAGE_CAPITAL_PLUS_INTEREST等额本息 AVERAGE_CAPITAL等额本金 BALLOON_MORTGAGE按期付息到期还本
        /// </summary>
        [XmlElement("repayment_method")]
        public string RepaymentMethod { get; set; }
    }
}
