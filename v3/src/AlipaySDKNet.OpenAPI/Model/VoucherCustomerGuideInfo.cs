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
    /// VoucherCustomerGuideInfo
    /// </summary>
    [DataContract(Name = "VoucherCustomerGuideInfo")]
    public partial class VoucherCustomerGuideInfo : IEquatable<VoucherCustomerGuideInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherCustomerGuideInfo" /> class.
        /// </summary>
        /// <param name="voucherSendGuideInfo">voucherSendGuideInfo.</param>
        /// <param name="voucherUseGuideInfo">voucherUseGuideInfo.</param>
        public VoucherCustomerGuideInfo(VoucherSendGuideInfo voucherSendGuideInfo = default(VoucherSendGuideInfo), VoucherUseGuideInfo voucherUseGuideInfo = default(VoucherUseGuideInfo))
        {
            this.VoucherSendGuideInfo = voucherSendGuideInfo;
            this.VoucherUseGuideInfo = voucherUseGuideInfo;
        }

        /// <summary>
        /// Gets or Sets VoucherSendGuideInfo
        /// </summary>
        [DataMember(Name = "voucher_send_guide_info", EmitDefaultValue = false)]
        public VoucherSendGuideInfo VoucherSendGuideInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherUseGuideInfo
        /// </summary>
        [DataMember(Name = "voucher_use_guide_info", EmitDefaultValue = false)]
        public VoucherUseGuideInfo VoucherUseGuideInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherCustomerGuideInfo {\n");
            sb.Append("  VoucherSendGuideInfo: ").Append(VoucherSendGuideInfo).Append("\n");
            sb.Append("  VoucherUseGuideInfo: ").Append(VoucherUseGuideInfo).Append("\n");
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
            return this.Equals(input as VoucherCustomerGuideInfo);
        }

        /// <summary>
        /// Returns true if VoucherCustomerGuideInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherCustomerGuideInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherCustomerGuideInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VoucherSendGuideInfo == input.VoucherSendGuideInfo ||
                    (this.VoucherSendGuideInfo != null &&
                    this.VoucherSendGuideInfo.Equals(input.VoucherSendGuideInfo))
                ) && 
                (
                    this.VoucherUseGuideInfo == input.VoucherUseGuideInfo ||
                    (this.VoucherUseGuideInfo != null &&
                    this.VoucherUseGuideInfo.Equals(input.VoucherUseGuideInfo))
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
                if (this.VoucherSendGuideInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherSendGuideInfo.GetHashCode();
                }
                if (this.VoucherUseGuideInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherUseGuideInfo.GetHashCode();
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
