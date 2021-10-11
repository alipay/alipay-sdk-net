using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseQuotaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseQuotaInfo : AopObject
    {
        /// <summary>
        /// 额度失效时间
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 额度生效时间
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 额度所属者ID owner_type为员工时为员工支付宝ID
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 额度所属者类型 EMPLOYEE 员工
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 可用额度（单位分）
        /// </summary>
        [XmlElement("quota_available")]
        public string QuotaAvailable { get; set; }

        /// <summary>
        /// 额度ID
        /// </summary>
        [XmlElement("quota_id")]
        public string QuotaId { get; set; }

        /// <summary>
        /// 锁定额度（单位分）
        /// </summary>
        [XmlElement("quota_locked")]
        public string QuotaLocked { get; set; }

        /// <summary>
        /// 总额度（单位分）
        /// </summary>
        [XmlElement("quota_total")]
        public string QuotaTotal { get; set; }

        /// <summary>
        /// 已用额度（单位分）
        /// </summary>
        [XmlElement("quota_used")]
        public string QuotaUsed { get; set; }

        /// <summary>
        /// 额度类型ID
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 额度类型 EXPENSE_TYPE: 场景盖帽额度
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
