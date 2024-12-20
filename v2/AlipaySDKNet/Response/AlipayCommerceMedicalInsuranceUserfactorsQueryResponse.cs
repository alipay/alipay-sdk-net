using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceUserfactorsQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceUserfactorsQueryResponse : AopResponse
    {
        /// <summary>
        /// 证件号，例如：身份证证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 用户在中国大陆使用的标识个人身份的证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 用户真实姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
