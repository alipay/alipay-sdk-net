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
    /// PaymentVoucherAlipayBalanceRechargeInfo
    /// </summary>
    [DataContract(Name = "PaymentVoucherAlipayBalanceRechargeInfo")]
    public partial class PaymentVoucherAlipayBalanceRechargeInfo : IEquatable<PaymentVoucherAlipayBalanceRechargeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVoucherAlipayBalanceRechargeInfo" /> class.
        /// </summary>
        /// <param name="logonId">出资的支付宝登录账号 限制: 1、登录账号和用户ID必须且只能二选一.</param>
        /// <param name="userId">出资的支付宝用户id 限制: 1、登录账号和用户ID必须且只能二选一.</param>
        public PaymentVoucherAlipayBalanceRechargeInfo(string logonId = default(string), string userId = default(string))
        {
            this.LogonId = logonId;
            this.UserId = userId;
        }

        /// <summary>
        /// 出资的支付宝登录账号 限制: 1、登录账号和用户ID必须且只能二选一
        /// </summary>
        /// <value>出资的支付宝登录账号 限制: 1、登录账号和用户ID必须且只能二选一</value>
        [DataMember(Name = "logon_id", EmitDefaultValue = false)]
        public string LogonId { get; set; }

        /// <summary>
        /// 出资的支付宝用户id 限制: 1、登录账号和用户ID必须且只能二选一
        /// </summary>
        /// <value>出资的支付宝用户id 限制: 1、登录账号和用户ID必须且只能二选一</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentVoucherAlipayBalanceRechargeInfo {\n");
            sb.Append("  LogonId: ").Append(LogonId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as PaymentVoucherAlipayBalanceRechargeInfo);
        }

        /// <summary>
        /// Returns true if PaymentVoucherAlipayBalanceRechargeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentVoucherAlipayBalanceRechargeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentVoucherAlipayBalanceRechargeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LogonId == input.LogonId ||
                    (this.LogonId != null &&
                    this.LogonId.Equals(input.LogonId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.LogonId != null)
                {
                    hashCode = (hashCode * 59) + this.LogonId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
