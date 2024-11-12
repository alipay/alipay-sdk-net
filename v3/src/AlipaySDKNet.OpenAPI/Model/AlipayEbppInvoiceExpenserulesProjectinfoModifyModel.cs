/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-11-12
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectinfoModifyModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceExpenserulesProjectinfoModifyModel")]
    public partial class AlipayEbppInvoiceExpenserulesProjectinfoModifyModel : IEquatable<AlipayEbppInvoiceExpenserulesProjectinfoModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpenserulesProjectinfoModifyModel" /> class.
        /// </summary>
        /// <param name="accountId">企业ID.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="effectiveEndDate">有效期截止（yyyy-MM-dd HH:mm:ss） 特殊说明： 1）与起始时间必须同时传，且大于起始时间 2）不传则默认不修改.</param>
        /// <param name="effectiveStartDate">有效期起始（yyyy-MM-dd HH:mm:ss） 特殊说明： 1）与截止时间必须同时传，且小于截止时间 2）不传入则默认不修改.</param>
        /// <param name="projectId">项目ID.</param>
        /// <param name="projectName">项目名 特殊说明：不传入则默认不修改.</param>
        public AlipayEbppInvoiceExpenserulesProjectinfoModifyModel(string accountId = default(string), string agreementNo = default(string), string effectiveEndDate = default(string), string effectiveStartDate = default(string), string projectId = default(string), string projectName = default(string))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.EffectiveEndDate = effectiveEndDate;
            this.EffectiveStartDate = effectiveStartDate;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
        }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 有效期截止（yyyy-MM-dd HH:mm:ss） 特殊说明： 1）与起始时间必须同时传，且大于起始时间 2）不传则默认不修改
        /// </summary>
        /// <value>有效期截止（yyyy-MM-dd HH:mm:ss） 特殊说明： 1）与起始时间必须同时传，且大于起始时间 2）不传则默认不修改</value>
        [DataMember(Name = "effective_end_date", EmitDefaultValue = false)]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始（yyyy-MM-dd HH:mm:ss） 特殊说明： 1）与截止时间必须同时传，且小于截止时间 2）不传入则默认不修改
        /// </summary>
        /// <value>有效期起始（yyyy-MM-dd HH:mm:ss） 特殊说明： 1）与截止时间必须同时传，且小于截止时间 2）不传入则默认不修改</value>
        [DataMember(Name = "effective_start_date", EmitDefaultValue = false)]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        /// <value>项目ID</value>
        [DataMember(Name = "project_id", EmitDefaultValue = false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名 特殊说明：不传入则默认不修改
        /// </summary>
        /// <value>项目名 特殊说明：不传入则默认不修改</value>
        [DataMember(Name = "project_name", EmitDefaultValue = false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceExpenserulesProjectinfoModifyModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ProjectName: ").Append(ProjectName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlipayEbppInvoiceExpenserulesProjectinfoModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceExpenserulesProjectinfoModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceExpenserulesProjectinfoModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceExpenserulesProjectinfoModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.EffectiveEndDate == input.EffectiveEndDate ||
                    (this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(input.EffectiveEndDate))
                ) && 
                (
                    this.EffectiveStartDate == input.EffectiveStartDate ||
                    (this.EffectiveStartDate != null &&
                    this.EffectiveStartDate.Equals(input.EffectiveStartDate))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.EffectiveEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveEndDate.GetHashCode();
                }
                if (this.EffectiveStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveStartDate.GetHashCode();
                }
                if (this.ProjectId != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectId.GetHashCode();
                }
                if (this.ProjectName != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectName.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
