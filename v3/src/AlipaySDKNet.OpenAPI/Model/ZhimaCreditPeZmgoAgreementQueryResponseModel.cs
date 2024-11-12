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
    /// ZhimaCreditPeZmgoAgreementQueryResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPeZmgoAgreementQueryResponseModel")]
    public partial class ZhimaCreditPeZmgoAgreementQueryResponseModel : IEquatable<ZhimaCreditPeZmgoAgreementQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoAgreementQueryResponseModel" /> class.
        /// </summary>
        /// <param name="agreementId">支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员协议号。.</param>
        /// <param name="agreementName">协议名称.</param>
        /// <param name="agreementStatus">协议状态。Y表示状态有效，P表示状态失效中，N表示状态已失效.</param>
        /// <param name="alipayUserId">支付宝用户userId.</param>
        /// <param name="bizType">代表签约芝麻GO所属业务类型.</param>
        /// <param name="openId">支付宝用户userId.</param>
        /// <param name="signTime">该条芝麻GO协议签约时间.</param>
        /// <param name="startTime">该芝麻GO协议开始时间.</param>
        public ZhimaCreditPeZmgoAgreementQueryResponseModel(string agreementId = default(string), string agreementName = default(string), string agreementStatus = default(string), string alipayUserId = default(string), string bizType = default(string), string openId = default(string), string signTime = default(string), string startTime = default(string))
        {
            this.AgreementId = agreementId;
            this.AgreementName = agreementName;
            this.AgreementStatus = agreementStatus;
            this.AlipayUserId = alipayUserId;
            this.BizType = bizType;
            this.OpenId = openId;
            this.SignTime = signTime;
            this.StartTime = startTime;
        }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员协议号。
        /// </summary>
        /// <value>支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员协议号。</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 协议名称
        /// </summary>
        /// <value>协议名称</value>
        [DataMember(Name = "agreement_name", EmitDefaultValue = false)]
        public string AgreementName { get; set; }

        /// <summary>
        /// 协议状态。Y表示状态有效，P表示状态失效中，N表示状态已失效
        /// </summary>
        /// <value>协议状态。Y表示状态有效，P表示状态失效中，N表示状态已失效</value>
        [DataMember(Name = "agreement_status", EmitDefaultValue = false)]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        /// <value>支付宝用户userId</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 代表签约芝麻GO所属业务类型
        /// </summary>
        /// <value>代表签约芝麻GO所属业务类型</value>
        [DataMember(Name = "biz_type", EmitDefaultValue = false)]
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        /// <value>支付宝用户userId</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 该条芝麻GO协议签约时间
        /// </summary>
        /// <value>该条芝麻GO协议签约时间</value>
        [DataMember(Name = "sign_time", EmitDefaultValue = false)]
        public string SignTime { get; set; }

        /// <summary>
        /// 该芝麻GO协议开始时间
        /// </summary>
        /// <value>该芝麻GO协议开始时间</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPeZmgoAgreementQueryResponseModel {\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  AgreementName: ").Append(AgreementName).Append("\n");
            sb.Append("  AgreementStatus: ").Append(AgreementStatus).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  BizType: ").Append(BizType).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  SignTime: ").Append(SignTime).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(input as ZhimaCreditPeZmgoAgreementQueryResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPeZmgoAgreementQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPeZmgoAgreementQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPeZmgoAgreementQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.AgreementName == input.AgreementName ||
                    (this.AgreementName != null &&
                    this.AgreementName.Equals(input.AgreementName))
                ) && 
                (
                    this.AgreementStatus == input.AgreementStatus ||
                    (this.AgreementStatus != null &&
                    this.AgreementStatus.Equals(input.AgreementStatus))
                ) && 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.BizType == input.BizType ||
                    (this.BizType != null &&
                    this.BizType.Equals(input.BizType))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.SignTime == input.SignTime ||
                    (this.SignTime != null &&
                    this.SignTime.Equals(input.SignTime))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                if (this.AgreementName != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementName.GetHashCode();
                }
                if (this.AgreementStatus != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementStatus.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.BizType != null)
                {
                    hashCode = (hashCode * 59) + this.BizType.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.SignTime != null)
                {
                    hashCode = (hashCode * 59) + this.SignTime.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
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
