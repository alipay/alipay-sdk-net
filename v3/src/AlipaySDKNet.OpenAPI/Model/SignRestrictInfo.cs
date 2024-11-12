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
    /// SignRestrictInfo
    /// </summary>
    [DataContract(Name = "SignRestrictInfo")]
    public partial class SignRestrictInfo : IEquatable<SignRestrictInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignRestrictInfo" /> class.
        /// </summary>
        /// <param name="restrictProduct">产品码，支付宝定义的产品码.</param>
        /// <param name="restrictReason">受限的原因.</param>
        /// <param name="restrictReasonCode">受限原因编码.</param>
        /// <param name="restrictVersion">受限版本，02-受限版 04-极速版.</param>
        public SignRestrictInfo(string restrictProduct = default(string), string restrictReason = default(string), string restrictReasonCode = default(string), string restrictVersion = default(string))
        {
            this.RestrictProduct = restrictProduct;
            this.RestrictReason = restrictReason;
            this.RestrictReasonCode = restrictReasonCode;
            this.RestrictVersion = restrictVersion;
        }

        /// <summary>
        /// 产品码，支付宝定义的产品码
        /// </summary>
        /// <value>产品码，支付宝定义的产品码</value>
        [DataMember(Name = "restrict_product", EmitDefaultValue = false)]
        public string RestrictProduct { get; set; }

        /// <summary>
        /// 受限的原因
        /// </summary>
        /// <value>受限的原因</value>
        [DataMember(Name = "restrict_reason", EmitDefaultValue = false)]
        public string RestrictReason { get; set; }

        /// <summary>
        /// 受限原因编码
        /// </summary>
        /// <value>受限原因编码</value>
        [DataMember(Name = "restrict_reason_code", EmitDefaultValue = false)]
        public string RestrictReasonCode { get; set; }

        /// <summary>
        /// 受限版本，02-受限版 04-极速版
        /// </summary>
        /// <value>受限版本，02-受限版 04-极速版</value>
        [DataMember(Name = "restrict_version", EmitDefaultValue = false)]
        public string RestrictVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignRestrictInfo {\n");
            sb.Append("  RestrictProduct: ").Append(RestrictProduct).Append("\n");
            sb.Append("  RestrictReason: ").Append(RestrictReason).Append("\n");
            sb.Append("  RestrictReasonCode: ").Append(RestrictReasonCode).Append("\n");
            sb.Append("  RestrictVersion: ").Append(RestrictVersion).Append("\n");
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
            return this.Equals(input as SignRestrictInfo);
        }

        /// <summary>
        /// Returns true if SignRestrictInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SignRestrictInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignRestrictInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RestrictProduct == input.RestrictProduct ||
                    (this.RestrictProduct != null &&
                    this.RestrictProduct.Equals(input.RestrictProduct))
                ) && 
                (
                    this.RestrictReason == input.RestrictReason ||
                    (this.RestrictReason != null &&
                    this.RestrictReason.Equals(input.RestrictReason))
                ) && 
                (
                    this.RestrictReasonCode == input.RestrictReasonCode ||
                    (this.RestrictReasonCode != null &&
                    this.RestrictReasonCode.Equals(input.RestrictReasonCode))
                ) && 
                (
                    this.RestrictVersion == input.RestrictVersion ||
                    (this.RestrictVersion != null &&
                    this.RestrictVersion.Equals(input.RestrictVersion))
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
                if (this.RestrictProduct != null)
                {
                    hashCode = (hashCode * 59) + this.RestrictProduct.GetHashCode();
                }
                if (this.RestrictReason != null)
                {
                    hashCode = (hashCode * 59) + this.RestrictReason.GetHashCode();
                }
                if (this.RestrictReasonCode != null)
                {
                    hashCode = (hashCode * 59) + this.RestrictReasonCode.GetHashCode();
                }
                if (this.RestrictVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RestrictVersion.GetHashCode();
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
