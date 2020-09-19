using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromotePage Data Structure.
    /// </summary>
    [Serializable]
    public class PromotePage : AopObject
    {
        /// <summary>
        /// 留资页页面ID
        /// </summary>
        [XmlElement("page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// 留资页名称
        /// </summary>
        [XmlElement("page_name")]
        public string PageName { get; set; }

        /// <summary>
        /// 留资页状态
        /// </summary>
        [XmlElement("page_status")]
        public string PageStatus { get; set; }
    }
}
