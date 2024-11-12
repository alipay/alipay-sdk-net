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
    /// BizfundSettleInfo
    /// </summary>
    [DataContract(Name = "BizfundSettleInfo")]
    public partial class BizfundSettleInfo : IEquatable<BizfundSettleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BizfundSettleInfo" /> class.
        /// </summary>
        /// <param name="settleMode">请款|账期 模式.</param>
        /// <param name="settleTargetType">结算的目标对象类型.</param>
        public BizfundSettleInfo(string settleMode = default(string), string settleTargetType = default(string))
        {
            this.SettleMode = settleMode;
            this.SettleTargetType = settleTargetType;
        }

        /// <summary>
        /// 请款|账期 模式
        /// </summary>
        /// <value>请款|账期 模式</value>
        [DataMember(Name = "settle_mode", EmitDefaultValue = false)]
        public string SettleMode { get; set; }

        /// <summary>
        /// 结算的目标对象类型
        /// </summary>
        /// <value>结算的目标对象类型</value>
        [DataMember(Name = "settle_target_type", EmitDefaultValue = false)]
        public string SettleTargetType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BizfundSettleInfo {\n");
            sb.Append("  SettleMode: ").Append(SettleMode).Append("\n");
            sb.Append("  SettleTargetType: ").Append(SettleTargetType).Append("\n");
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
            return this.Equals(input as BizfundSettleInfo);
        }

        /// <summary>
        /// Returns true if BizfundSettleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BizfundSettleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BizfundSettleInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SettleMode == input.SettleMode ||
                    (this.SettleMode != null &&
                    this.SettleMode.Equals(input.SettleMode))
                ) && 
                (
                    this.SettleTargetType == input.SettleTargetType ||
                    (this.SettleTargetType != null &&
                    this.SettleTargetType.Equals(input.SettleTargetType))
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
                if (this.SettleMode != null)
                {
                    hashCode = (hashCode * 59) + this.SettleMode.GetHashCode();
                }
                if (this.SettleTargetType != null)
                {
                    hashCode = (hashCode * 59) + this.SettleTargetType.GetHashCode();
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
