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
    /// AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel")]
    public partial class AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel : IEquatable<AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel" /> class.
        /// </summary>
        /// <param name="accountId">企业共同账户ID.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="enterpriseId">企业ID.</param>
        /// <param name="invoiceRuleId">开票规则ID.</param>
        /// <param name="standardIdList">费控规则ID列表.</param>
        public AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel(string accountId = default(string), string agreementNo = default(string), string enterpriseId = default(string), string invoiceRuleId = default(string), List<string> standardIdList = default(List<string>))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.EnterpriseId = enterpriseId;
            this.InvoiceRuleId = invoiceRuleId;
            this.StandardIdList = standardIdList;
        }

        /// <summary>
        /// 企业共同账户ID
        /// </summary>
        /// <value>企业共同账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 开票规则ID
        /// </summary>
        /// <value>开票规则ID</value>
        [DataMember(Name = "invoice_rule_id", EmitDefaultValue = false)]
        public string InvoiceRuleId { get; set; }

        /// <summary>
        /// 费控规则ID列表
        /// </summary>
        /// <value>费控规则ID列表</value>
        [DataMember(Name = "standard_id_list", EmitDefaultValue = false)]
        public List<string> StandardIdList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  InvoiceRuleId: ").Append(InvoiceRuleId).Append("\n");
            sb.Append("  StandardIdList: ").Append(StandardIdList).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEnterpriseconsumeOpenrulerelationCreateModel input)
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
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.InvoiceRuleId == input.InvoiceRuleId ||
                    (this.InvoiceRuleId != null &&
                    this.InvoiceRuleId.Equals(input.InvoiceRuleId))
                ) && 
                (
                    this.StandardIdList == input.StandardIdList ||
                    this.StandardIdList != null &&
                    input.StandardIdList != null &&
                    this.StandardIdList.SequenceEqual(input.StandardIdList)
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
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.InvoiceRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceRuleId.GetHashCode();
                }
                if (this.StandardIdList != null)
                {
                    hashCode = (hashCode * 59) + this.StandardIdList.GetHashCode();
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
