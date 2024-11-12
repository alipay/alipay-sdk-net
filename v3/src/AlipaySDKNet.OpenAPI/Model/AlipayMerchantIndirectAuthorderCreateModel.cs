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
    /// AlipayMerchantIndirectAuthorderCreateModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantIndirectAuthorderCreateModel")]
    public partial class AlipayMerchantIndirectAuthorderCreateModel : IEquatable<AlipayMerchantIndirectAuthorderCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantIndirectAuthorderCreateModel" /> class.
        /// </summary>
        /// <param name="authIdentityInfo">authIdentityInfo.</param>
        /// <param name="benefitPersonInfo">benefitPersonInfo.</param>
        /// <param name="contactPersonInfo">contactPersonInfo.</param>
        /// <param name="extraCredentials">extraCredentials.</param>
        /// <param name="legalPersonInfo">legalPersonInfo.</param>
        /// <param name="outBizNo">外部业务号。支持out_biz_no和outBizNo两种格式.</param>
        /// <param name="source">1. 收单机构调用API提交申请单时，可选择是否指定单个服务商范围。非收单机构无需填写此字段。 2. 此字段填写单个服务商pid信息：填写（即：单服务商提交认证方式），查询申请单返回的认证二维码qr_code和填写服务商对应，仅能认证填写服务商下的商户；不填写（即：全服务商提交认证方式），查询申请单返回的认证二维码qr_code和收单机构对应，可认证收单机构下全部商户。.</param>
        public AlipayMerchantIndirectAuthorderCreateModel(AuthIdentityInfo authIdentityInfo = default(AuthIdentityInfo), IndirectBenefitPersonInfo benefitPersonInfo = default(IndirectBenefitPersonInfo), IndirectContactPersonInfo contactPersonInfo = default(IndirectContactPersonInfo), IndirectExtraCredentials extraCredentials = default(IndirectExtraCredentials), IndirectLegalPersonInfo legalPersonInfo = default(IndirectLegalPersonInfo), string outBizNo = default(string), string source = default(string))
        {
            this.AuthIdentityInfo = authIdentityInfo;
            this.BenefitPersonInfo = benefitPersonInfo;
            this.ContactPersonInfo = contactPersonInfo;
            this.ExtraCredentials = extraCredentials;
            this.LegalPersonInfo = legalPersonInfo;
            this.OutBizNo = outBizNo;
            this.Source = source;
        }

        /// <summary>
        /// Gets or Sets AuthIdentityInfo
        /// </summary>
        [DataMember(Name = "auth_identity_info", EmitDefaultValue = false)]
        public AuthIdentityInfo AuthIdentityInfo { get; set; }

        /// <summary>
        /// Gets or Sets BenefitPersonInfo
        /// </summary>
        [DataMember(Name = "benefit_person_info", EmitDefaultValue = false)]
        public IndirectBenefitPersonInfo BenefitPersonInfo { get; set; }

        /// <summary>
        /// Gets or Sets ContactPersonInfo
        /// </summary>
        [DataMember(Name = "contact_person_info", EmitDefaultValue = false)]
        public IndirectContactPersonInfo ContactPersonInfo { get; set; }

        /// <summary>
        /// Gets or Sets ExtraCredentials
        /// </summary>
        [DataMember(Name = "extra_credentials", EmitDefaultValue = false)]
        public IndirectExtraCredentials ExtraCredentials { get; set; }

        /// <summary>
        /// Gets or Sets LegalPersonInfo
        /// </summary>
        [DataMember(Name = "legal_person_info", EmitDefaultValue = false)]
        public IndirectLegalPersonInfo LegalPersonInfo { get; set; }

        /// <summary>
        /// 外部业务号。支持out_biz_no和outBizNo两种格式
        /// </summary>
        /// <value>外部业务号。支持out_biz_no和outBizNo两种格式</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 1. 收单机构调用API提交申请单时，可选择是否指定单个服务商范围。非收单机构无需填写此字段。 2. 此字段填写单个服务商pid信息：填写（即：单服务商提交认证方式），查询申请单返回的认证二维码qr_code和填写服务商对应，仅能认证填写服务商下的商户；不填写（即：全服务商提交认证方式），查询申请单返回的认证二维码qr_code和收单机构对应，可认证收单机构下全部商户。
        /// </summary>
        /// <value>1. 收单机构调用API提交申请单时，可选择是否指定单个服务商范围。非收单机构无需填写此字段。 2. 此字段填写单个服务商pid信息：填写（即：单服务商提交认证方式），查询申请单返回的认证二维码qr_code和填写服务商对应，仅能认证填写服务商下的商户；不填写（即：全服务商提交认证方式），查询申请单返回的认证二维码qr_code和收单机构对应，可认证收单机构下全部商户。</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantIndirectAuthorderCreateModel {\n");
            sb.Append("  AuthIdentityInfo: ").Append(AuthIdentityInfo).Append("\n");
            sb.Append("  BenefitPersonInfo: ").Append(BenefitPersonInfo).Append("\n");
            sb.Append("  ContactPersonInfo: ").Append(ContactPersonInfo).Append("\n");
            sb.Append("  ExtraCredentials: ").Append(ExtraCredentials).Append("\n");
            sb.Append("  LegalPersonInfo: ").Append(LegalPersonInfo).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as AlipayMerchantIndirectAuthorderCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantIndirectAuthorderCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantIndirectAuthorderCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantIndirectAuthorderCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthIdentityInfo == input.AuthIdentityInfo ||
                    (this.AuthIdentityInfo != null &&
                    this.AuthIdentityInfo.Equals(input.AuthIdentityInfo))
                ) && 
                (
                    this.BenefitPersonInfo == input.BenefitPersonInfo ||
                    (this.BenefitPersonInfo != null &&
                    this.BenefitPersonInfo.Equals(input.BenefitPersonInfo))
                ) && 
                (
                    this.ContactPersonInfo == input.ContactPersonInfo ||
                    (this.ContactPersonInfo != null &&
                    this.ContactPersonInfo.Equals(input.ContactPersonInfo))
                ) && 
                (
                    this.ExtraCredentials == input.ExtraCredentials ||
                    (this.ExtraCredentials != null &&
                    this.ExtraCredentials.Equals(input.ExtraCredentials))
                ) && 
                (
                    this.LegalPersonInfo == input.LegalPersonInfo ||
                    (this.LegalPersonInfo != null &&
                    this.LegalPersonInfo.Equals(input.LegalPersonInfo))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.AuthIdentityInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AuthIdentityInfo.GetHashCode();
                }
                if (this.BenefitPersonInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BenefitPersonInfo.GetHashCode();
                }
                if (this.ContactPersonInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ContactPersonInfo.GetHashCode();
                }
                if (this.ExtraCredentials != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraCredentials.GetHashCode();
                }
                if (this.LegalPersonInfo != null)
                {
                    hashCode = (hashCode * 59) + this.LegalPersonInfo.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
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
