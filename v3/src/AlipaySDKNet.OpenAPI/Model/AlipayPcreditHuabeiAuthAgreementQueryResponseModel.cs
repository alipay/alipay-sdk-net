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
    /// AlipayPcreditHuabeiAuthAgreementQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayPcreditHuabeiAuthAgreementQueryResponseModel")]
    public partial class AlipayPcreditHuabeiAuthAgreementQueryResponseModel : IEquatable<AlipayPcreditHuabeiAuthAgreementQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayPcreditHuabeiAuthAgreementQueryResponseModel" /> class.
        /// </summary>
        /// <param name="agreementName">协议名称.</param>
        /// <param name="agreementNo">支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员协议号。.</param>
        /// <param name="agreementStatus">协议状态。Y表示状态有效，N表示状态失效.</param>
        /// <param name="alipayUserId">支付宝用户userId.</param>
        /// <param name="authScene">花芝轻会员签约场景，商户和支付宝签约时确定，商户接入时需要咨询技术支持。.</param>
        /// <param name="externalLogonId">用户在商户网站的登录账号.</param>
        /// <param name="gmtSign">签约时间。如果是在签状态，返回签约时间。.</param>
        /// <param name="gmtUnsign">花芝轻会员协议解约时间。如果是解约状态，才返回该字段。.</param>
        /// <param name="openId">支付宝用户userId.</param>
        /// <param name="outBizType">外部业务类型，用于区分本次业务交互在商户侧具体的业务类别，提供给商家进行特定逻辑的处理.</param>
        /// <param name="outSignNo">外部签约号，由商户提供，花芝轻会员协议中标识用户的唯一签约号（确保在商户系统中唯一）。由商户签约时传入，最终返回给商户。.</param>
        /// <param name="restFreezeAmount">用户在本花芝轻会员协议中，剩余的总冻结额度（资金池总余额），数值能实时准确，可以用于核对。两位小数，单位元。.</param>
        public AlipayPcreditHuabeiAuthAgreementQueryResponseModel(string agreementName = default(string), string agreementNo = default(string), string agreementStatus = default(string), string alipayUserId = default(string), string authScene = default(string), string externalLogonId = default(string), string gmtSign = default(string), string gmtUnsign = default(string), string openId = default(string), string outBizType = default(string), string outSignNo = default(string), string restFreezeAmount = default(string))
        {
            this.AgreementName = agreementName;
            this.AgreementNo = agreementNo;
            this.AgreementStatus = agreementStatus;
            this.AlipayUserId = alipayUserId;
            this.AuthScene = authScene;
            this.ExternalLogonId = externalLogonId;
            this.GmtSign = gmtSign;
            this.GmtUnsign = gmtUnsign;
            this.OpenId = openId;
            this.OutBizType = outBizType;
            this.OutSignNo = outSignNo;
            this.RestFreezeAmount = restFreezeAmount;
        }

        /// <summary>
        /// 协议名称
        /// </summary>
        /// <value>协议名称</value>
        [DataMember(Name = "agreement_name", EmitDefaultValue = false)]
        public string AgreementName { get; set; }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员协议号。
        /// </summary>
        /// <value>支付宝系统中用以唯一标识用户签约记录的编号，即花芝轻会员协议号。</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 协议状态。Y表示状态有效，N表示状态失效
        /// </summary>
        /// <value>协议状态。Y表示状态有效，N表示状态失效</value>
        [DataMember(Name = "agreement_status", EmitDefaultValue = false)]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        /// <value>支付宝用户userId</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 花芝轻会员签约场景，商户和支付宝签约时确定，商户接入时需要咨询技术支持。
        /// </summary>
        /// <value>花芝轻会员签约场景，商户和支付宝签约时确定，商户接入时需要咨询技术支持。</value>
        [DataMember(Name = "auth_scene", EmitDefaultValue = false)]
        public string AuthScene { get; set; }

        /// <summary>
        /// 用户在商户网站的登录账号
        /// </summary>
        /// <value>用户在商户网站的登录账号</value>
        [DataMember(Name = "external_logon_id", EmitDefaultValue = false)]
        public string ExternalLogonId { get; set; }

        /// <summary>
        /// 签约时间。如果是在签状态，返回签约时间。
        /// </summary>
        /// <value>签约时间。如果是在签状态，返回签约时间。</value>
        [DataMember(Name = "gmt_sign", EmitDefaultValue = false)]
        public string GmtSign { get; set; }

        /// <summary>
        /// 花芝轻会员协议解约时间。如果是解约状态，才返回该字段。
        /// </summary>
        /// <value>花芝轻会员协议解约时间。如果是解约状态，才返回该字段。</value>
        [DataMember(Name = "gmt_unsign", EmitDefaultValue = false)]
        public string GmtUnsign { get; set; }

        /// <summary>
        /// 支付宝用户userId
        /// </summary>
        /// <value>支付宝用户userId</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务类型，用于区分本次业务交互在商户侧具体的业务类别，提供给商家进行特定逻辑的处理
        /// </summary>
        /// <value>外部业务类型，用于区分本次业务交互在商户侧具体的业务类别，提供给商家进行特定逻辑的处理</value>
        [DataMember(Name = "out_biz_type", EmitDefaultValue = false)]
        public string OutBizType { get; set; }

        /// <summary>
        /// 外部签约号，由商户提供，花芝轻会员协议中标识用户的唯一签约号（确保在商户系统中唯一）。由商户签约时传入，最终返回给商户。
        /// </summary>
        /// <value>外部签约号，由商户提供，花芝轻会员协议中标识用户的唯一签约号（确保在商户系统中唯一）。由商户签约时传入，最终返回给商户。</value>
        [DataMember(Name = "out_sign_no", EmitDefaultValue = false)]
        public string OutSignNo { get; set; }

        /// <summary>
        /// 用户在本花芝轻会员协议中，剩余的总冻结额度（资金池总余额），数值能实时准确，可以用于核对。两位小数，单位元。
        /// </summary>
        /// <value>用户在本花芝轻会员协议中，剩余的总冻结额度（资金池总余额），数值能实时准确，可以用于核对。两位小数，单位元。</value>
        [DataMember(Name = "rest_freeze_amount", EmitDefaultValue = false)]
        public string RestFreezeAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayPcreditHuabeiAuthAgreementQueryResponseModel {\n");
            sb.Append("  AgreementName: ").Append(AgreementName).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  AgreementStatus: ").Append(AgreementStatus).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  AuthScene: ").Append(AuthScene).Append("\n");
            sb.Append("  ExternalLogonId: ").Append(ExternalLogonId).Append("\n");
            sb.Append("  GmtSign: ").Append(GmtSign).Append("\n");
            sb.Append("  GmtUnsign: ").Append(GmtUnsign).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutBizType: ").Append(OutBizType).Append("\n");
            sb.Append("  OutSignNo: ").Append(OutSignNo).Append("\n");
            sb.Append("  RestFreezeAmount: ").Append(RestFreezeAmount).Append("\n");
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
            return this.Equals(input as AlipayPcreditHuabeiAuthAgreementQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayPcreditHuabeiAuthAgreementQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayPcreditHuabeiAuthAgreementQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayPcreditHuabeiAuthAgreementQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementName == input.AgreementName ||
                    (this.AgreementName != null &&
                    this.AgreementName.Equals(input.AgreementName))
                ) && 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
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
                    this.AuthScene == input.AuthScene ||
                    (this.AuthScene != null &&
                    this.AuthScene.Equals(input.AuthScene))
                ) && 
                (
                    this.ExternalLogonId == input.ExternalLogonId ||
                    (this.ExternalLogonId != null &&
                    this.ExternalLogonId.Equals(input.ExternalLogonId))
                ) && 
                (
                    this.GmtSign == input.GmtSign ||
                    (this.GmtSign != null &&
                    this.GmtSign.Equals(input.GmtSign))
                ) && 
                (
                    this.GmtUnsign == input.GmtUnsign ||
                    (this.GmtUnsign != null &&
                    this.GmtUnsign.Equals(input.GmtUnsign))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OutBizType == input.OutBizType ||
                    (this.OutBizType != null &&
                    this.OutBizType.Equals(input.OutBizType))
                ) && 
                (
                    this.OutSignNo == input.OutSignNo ||
                    (this.OutSignNo != null &&
                    this.OutSignNo.Equals(input.OutSignNo))
                ) && 
                (
                    this.RestFreezeAmount == input.RestFreezeAmount ||
                    (this.RestFreezeAmount != null &&
                    this.RestFreezeAmount.Equals(input.RestFreezeAmount))
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
                if (this.AgreementName != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementName.GetHashCode();
                }
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.AgreementStatus != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementStatus.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.AuthScene != null)
                {
                    hashCode = (hashCode * 59) + this.AuthScene.GetHashCode();
                }
                if (this.ExternalLogonId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalLogonId.GetHashCode();
                }
                if (this.GmtSign != null)
                {
                    hashCode = (hashCode * 59) + this.GmtSign.GetHashCode();
                }
                if (this.GmtUnsign != null)
                {
                    hashCode = (hashCode * 59) + this.GmtUnsign.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OutBizType != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizType.GetHashCode();
                }
                if (this.OutSignNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutSignNo.GetHashCode();
                }
                if (this.RestFreezeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RestFreezeAmount.GetHashCode();
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
