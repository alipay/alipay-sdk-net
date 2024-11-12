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
    /// PaymentInfoWithId
    /// </summary>
    [DataContract(Name = "PaymentInfoWithId")]
    public partial class PaymentInfoWithId : IEquatable<PaymentInfoWithId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInfoWithId" /> class.
        /// </summary>
        /// <param name="paymentIds">支付单id.</param>
        /// <param name="type">支付资金类型.</param>
        public PaymentInfoWithId(List<string> paymentIds = default(List<string>), string type = default(string))
        {
            this.PaymentIds = paymentIds;
            this.Type = type;
        }

        /// <summary>
        /// 支付单id
        /// </summary>
        /// <value>支付单id</value>
        [DataMember(Name = "payment_ids", EmitDefaultValue = false)]
        public List<string> PaymentIds { get; set; }

        /// <summary>
        /// 支付资金类型
        /// </summary>
        /// <value>支付资金类型</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentInfoWithId {\n");
            sb.Append("  PaymentIds: ").Append(PaymentIds).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PaymentInfoWithId);
        }

        /// <summary>
        /// Returns true if PaymentInfoWithId instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentInfoWithId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInfoWithId input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentIds == input.PaymentIds ||
                    this.PaymentIds != null &&
                    input.PaymentIds != null &&
                    this.PaymentIds.SequenceEqual(input.PaymentIds)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.PaymentIds != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentIds.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
