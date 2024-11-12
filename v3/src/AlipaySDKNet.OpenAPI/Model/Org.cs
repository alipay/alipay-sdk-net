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
    /// Org
    /// </summary>
    [DataContract(Name = "Org")]
    public partial class Org : IEquatable<Org>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Org" /> class.
        /// </summary>
        /// <param name="orgIdNumber">企业证件号.</param>
        /// <param name="orgIdType">企业证件类型，（证件号不为空时必填，详见企业证件类型）.</param>
        /// <param name="orgLegalIdNumber">法定代表人证件号.</param>
        /// <param name="orgLegalIdType">法定代表人证件类型.</param>
        /// <param name="orgLegalName">法定代表人名称.</param>
        /// <param name="orgName">企业名称.</param>
        /// <param name="thirdPartyUserId">企业唯一标识：可传入平台机构id、企业证件号、企业邮箱等（个人用户与企业的唯一标识不可重复）.</param>
        public Org(string orgIdNumber = default(string), string orgIdType = default(string), string orgLegalIdNumber = default(string), string orgLegalIdType = default(string), string orgLegalName = default(string), string orgName = default(string), string thirdPartyUserId = default(string))
        {
            this.OrgIdNumber = orgIdNumber;
            this.OrgIdType = orgIdType;
            this.OrgLegalIdNumber = orgLegalIdNumber;
            this.OrgLegalIdType = orgLegalIdType;
            this.OrgLegalName = orgLegalName;
            this.OrgName = orgName;
            this.ThirdPartyUserId = thirdPartyUserId;
        }

        /// <summary>
        /// 企业证件号
        /// </summary>
        /// <value>企业证件号</value>
        [DataMember(Name = "org_id_number", EmitDefaultValue = false)]
        public string OrgIdNumber { get; set; }

        /// <summary>
        /// 企业证件类型，（证件号不为空时必填，详见企业证件类型）
        /// </summary>
        /// <value>企业证件类型，（证件号不为空时必填，详见企业证件类型）</value>
        [DataMember(Name = "org_id_type", EmitDefaultValue = false)]
        public string OrgIdType { get; set; }

        /// <summary>
        /// 法定代表人证件号
        /// </summary>
        /// <value>法定代表人证件号</value>
        [DataMember(Name = "org_legal_id_number", EmitDefaultValue = false)]
        public string OrgLegalIdNumber { get; set; }

        /// <summary>
        /// 法定代表人证件类型
        /// </summary>
        /// <value>法定代表人证件类型</value>
        [DataMember(Name = "org_legal_id_type", EmitDefaultValue = false)]
        public string OrgLegalIdType { get; set; }

        /// <summary>
        /// 法定代表人名称
        /// </summary>
        /// <value>法定代表人名称</value>
        [DataMember(Name = "org_legal_name", EmitDefaultValue = false)]
        public string OrgLegalName { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        /// <value>企业名称</value>
        [DataMember(Name = "org_name", EmitDefaultValue = false)]
        public string OrgName { get; set; }

        /// <summary>
        /// 企业唯一标识：可传入平台机构id、企业证件号、企业邮箱等（个人用户与企业的唯一标识不可重复）
        /// </summary>
        /// <value>企业唯一标识：可传入平台机构id、企业证件号、企业邮箱等（个人用户与企业的唯一标识不可重复）</value>
        [DataMember(Name = "third_party_user_id", EmitDefaultValue = false)]
        public string ThirdPartyUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Org {\n");
            sb.Append("  OrgIdNumber: ").Append(OrgIdNumber).Append("\n");
            sb.Append("  OrgIdType: ").Append(OrgIdType).Append("\n");
            sb.Append("  OrgLegalIdNumber: ").Append(OrgLegalIdNumber).Append("\n");
            sb.Append("  OrgLegalIdType: ").Append(OrgLegalIdType).Append("\n");
            sb.Append("  OrgLegalName: ").Append(OrgLegalName).Append("\n");
            sb.Append("  OrgName: ").Append(OrgName).Append("\n");
            sb.Append("  ThirdPartyUserId: ").Append(ThirdPartyUserId).Append("\n");
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
            return this.Equals(input as Org);
        }

        /// <summary>
        /// Returns true if Org instances are equal
        /// </summary>
        /// <param name="input">Instance of Org to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Org input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrgIdNumber == input.OrgIdNumber ||
                    (this.OrgIdNumber != null &&
                    this.OrgIdNumber.Equals(input.OrgIdNumber))
                ) && 
                (
                    this.OrgIdType == input.OrgIdType ||
                    (this.OrgIdType != null &&
                    this.OrgIdType.Equals(input.OrgIdType))
                ) && 
                (
                    this.OrgLegalIdNumber == input.OrgLegalIdNumber ||
                    (this.OrgLegalIdNumber != null &&
                    this.OrgLegalIdNumber.Equals(input.OrgLegalIdNumber))
                ) && 
                (
                    this.OrgLegalIdType == input.OrgLegalIdType ||
                    (this.OrgLegalIdType != null &&
                    this.OrgLegalIdType.Equals(input.OrgLegalIdType))
                ) && 
                (
                    this.OrgLegalName == input.OrgLegalName ||
                    (this.OrgLegalName != null &&
                    this.OrgLegalName.Equals(input.OrgLegalName))
                ) && 
                (
                    this.OrgName == input.OrgName ||
                    (this.OrgName != null &&
                    this.OrgName.Equals(input.OrgName))
                ) && 
                (
                    this.ThirdPartyUserId == input.ThirdPartyUserId ||
                    (this.ThirdPartyUserId != null &&
                    this.ThirdPartyUserId.Equals(input.ThirdPartyUserId))
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
                if (this.OrgIdNumber != null)
                {
                    hashCode = (hashCode * 59) + this.OrgIdNumber.GetHashCode();
                }
                if (this.OrgIdType != null)
                {
                    hashCode = (hashCode * 59) + this.OrgIdType.GetHashCode();
                }
                if (this.OrgLegalIdNumber != null)
                {
                    hashCode = (hashCode * 59) + this.OrgLegalIdNumber.GetHashCode();
                }
                if (this.OrgLegalIdType != null)
                {
                    hashCode = (hashCode * 59) + this.OrgLegalIdType.GetHashCode();
                }
                if (this.OrgLegalName != null)
                {
                    hashCode = (hashCode * 59) + this.OrgLegalName.GetHashCode();
                }
                if (this.OrgName != null)
                {
                    hashCode = (hashCode * 59) + this.OrgName.GetHashCode();
                }
                if (this.ThirdPartyUserId != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdPartyUserId.GetHashCode();
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
