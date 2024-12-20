using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandBizaccessOrderCreateResponse.
    /// </summary>
    public class AntMerchantExpandBizaccessOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [XmlArray("fail_reasons")]
        [XmlArrayItem("isv_biz_open_order_fail_reason")]
        public List<IsvBizOpenOrderFailReason> FailReasons { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 业务开通主单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
