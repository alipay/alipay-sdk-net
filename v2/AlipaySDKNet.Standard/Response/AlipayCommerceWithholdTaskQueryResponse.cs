using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWithholdTaskQueryResponse.
    /// </summary>
    public class AlipayCommerceWithholdTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 代扣任务ID
        /// </summary>
        [XmlElement("withhold_no")]
        public string WithholdNo { get; set; }

        /// <summary>
        /// 扣款交易列表
        /// </summary>
        [XmlArray("withhold_trades")]
        [XmlArrayItem("withhold_trade_d_t_o")]
        public List<WithholdTradeDTO> WithholdTrades { get; set; }
    }
}
