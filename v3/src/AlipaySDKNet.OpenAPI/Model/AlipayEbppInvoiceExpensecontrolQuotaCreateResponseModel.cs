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
    /// AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel")]
    public partial class AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel : IEquatable<AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel" /> class.
        /// </summary>
        /// <param name="issueBatchId">发放批次id.</param>
        /// <param name="quotaId">创建的额度ID.</param>
        public AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel(string issueBatchId = default(string), string quotaId = default(string))
        {
            this.IssueBatchId = issueBatchId;
            this.QuotaId = quotaId;
        }

        /// <summary>
        /// 发放批次id
        /// </summary>
        /// <value>发放批次id</value>
        [DataMember(Name = "issue_batch_id", EmitDefaultValue = false)]
        public string IssueBatchId { get; set; }

        /// <summary>
        /// 创建的额度ID
        /// </summary>
        /// <value>创建的额度ID</value>
        [DataMember(Name = "quota_id", EmitDefaultValue = false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel {\n");
            sb.Append("  IssueBatchId: ").Append(IssueBatchId).Append("\n");
            sb.Append("  QuotaId: ").Append(QuotaId).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceExpensecontrolQuotaCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IssueBatchId == input.IssueBatchId ||
                    (this.IssueBatchId != null &&
                    this.IssueBatchId.Equals(input.IssueBatchId))
                ) && 
                (
                    this.QuotaId == input.QuotaId ||
                    (this.QuotaId != null &&
                    this.QuotaId.Equals(input.QuotaId))
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
                if (this.IssueBatchId != null)
                {
                    hashCode = (hashCode * 59) + this.IssueBatchId.GetHashCode();
                }
                if (this.QuotaId != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaId.GetHashCode();
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
