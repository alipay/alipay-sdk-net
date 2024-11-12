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
    /// VoucherUseDetailResultInfo
    /// </summary>
    [DataContract(Name = "VoucherUseDetailResultInfo")]
    public partial class VoucherUseDetailResultInfo : IEquatable<VoucherUseDetailResultInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherUseDetailResultInfo" /> class.
        /// </summary>
        /// <param name="voucherMaxUnUseTimes">剩余可核销次数.</param>
        public VoucherUseDetailResultInfo(int voucherMaxUnUseTimes = default(int))
        {
            this.VoucherMaxUnUseTimes = voucherMaxUnUseTimes;
        }

        /// <summary>
        /// 剩余可核销次数
        /// </summary>
        /// <value>剩余可核销次数</value>
        [DataMember(Name = "voucher_max_un_use_times", EmitDefaultValue = false)]
        public int VoucherMaxUnUseTimes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherUseDetailResultInfo {\n");
            sb.Append("  VoucherMaxUnUseTimes: ").Append(VoucherMaxUnUseTimes).Append("\n");
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
            return this.Equals(input as VoucherUseDetailResultInfo);
        }

        /// <summary>
        /// Returns true if VoucherUseDetailResultInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherUseDetailResultInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherUseDetailResultInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VoucherMaxUnUseTimes == input.VoucherMaxUnUseTimes ||
                    this.VoucherMaxUnUseTimes.Equals(input.VoucherMaxUnUseTimes)
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
                hashCode = (hashCode * 59) + this.VoucherMaxUnUseTimes.GetHashCode();
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
