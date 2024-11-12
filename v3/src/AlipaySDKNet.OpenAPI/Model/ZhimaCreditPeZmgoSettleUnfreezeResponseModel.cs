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
    /// ZhimaCreditPeZmgoSettleUnfreezeResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPeZmgoSettleUnfreezeResponseModel")]
    public partial class ZhimaCreditPeZmgoSettleUnfreezeResponseModel : IEquatable<ZhimaCreditPeZmgoSettleUnfreezeResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoSettleUnfreezeResponseModel" /> class.
        /// </summary>
        /// <param name="failReaseon">失败原因.</param>
        /// <param name="retry">是否可以重试.</param>
        /// <param name="unfreezeAmount">解冻金额字符串.</param>
        /// <param name="unfreezeStatus">解冻状态.</param>
        public ZhimaCreditPeZmgoSettleUnfreezeResponseModel(string failReaseon = default(string), string retry = default(string), string unfreezeAmount = default(string), string unfreezeStatus = default(string))
        {
            this.FailReaseon = failReaseon;
            this.Retry = retry;
            this.UnfreezeAmount = unfreezeAmount;
            this.UnfreezeStatus = unfreezeStatus;
        }

        /// <summary>
        /// 失败原因
        /// </summary>
        /// <value>失败原因</value>
        [DataMember(Name = "fail_reaseon", EmitDefaultValue = false)]
        public string FailReaseon { get; set; }

        /// <summary>
        /// 是否可以重试
        /// </summary>
        /// <value>是否可以重试</value>
        [DataMember(Name = "retry", EmitDefaultValue = false)]
        public string Retry { get; set; }

        /// <summary>
        /// 解冻金额字符串
        /// </summary>
        /// <value>解冻金额字符串</value>
        [DataMember(Name = "unfreeze_amount", EmitDefaultValue = false)]
        public string UnfreezeAmount { get; set; }

        /// <summary>
        /// 解冻状态
        /// </summary>
        /// <value>解冻状态</value>
        [DataMember(Name = "unfreeze_status", EmitDefaultValue = false)]
        public string UnfreezeStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPeZmgoSettleUnfreezeResponseModel {\n");
            sb.Append("  FailReaseon: ").Append(FailReaseon).Append("\n");
            sb.Append("  Retry: ").Append(Retry).Append("\n");
            sb.Append("  UnfreezeAmount: ").Append(UnfreezeAmount).Append("\n");
            sb.Append("  UnfreezeStatus: ").Append(UnfreezeStatus).Append("\n");
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
            return this.Equals(input as ZhimaCreditPeZmgoSettleUnfreezeResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPeZmgoSettleUnfreezeResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPeZmgoSettleUnfreezeResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPeZmgoSettleUnfreezeResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FailReaseon == input.FailReaseon ||
                    (this.FailReaseon != null &&
                    this.FailReaseon.Equals(input.FailReaseon))
                ) && 
                (
                    this.Retry == input.Retry ||
                    (this.Retry != null &&
                    this.Retry.Equals(input.Retry))
                ) && 
                (
                    this.UnfreezeAmount == input.UnfreezeAmount ||
                    (this.UnfreezeAmount != null &&
                    this.UnfreezeAmount.Equals(input.UnfreezeAmount))
                ) && 
                (
                    this.UnfreezeStatus == input.UnfreezeStatus ||
                    (this.UnfreezeStatus != null &&
                    this.UnfreezeStatus.Equals(input.UnfreezeStatus))
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
                if (this.FailReaseon != null)
                {
                    hashCode = (hashCode * 59) + this.FailReaseon.GetHashCode();
                }
                if (this.Retry != null)
                {
                    hashCode = (hashCode * 59) + this.Retry.GetHashCode();
                }
                if (this.UnfreezeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.UnfreezeAmount.GetHashCode();
                }
                if (this.UnfreezeStatus != null)
                {
                    hashCode = (hashCode * 59) + this.UnfreezeStatus.GetHashCode();
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
