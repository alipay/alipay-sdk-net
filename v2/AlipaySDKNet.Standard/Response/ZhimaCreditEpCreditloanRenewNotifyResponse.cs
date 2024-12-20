using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditloanRenewNotifyResponse.
    /// </summary>
    public class ZhimaCreditEpCreditloanRenewNotifyResponse : AopResponse
    {
        /// <summary>
        /// 返回结果。结构视financial_code的不同而定
        /// </summary>
        [XmlElement("result_content")]
        public string ResultContent { get; set; }
    }
}
