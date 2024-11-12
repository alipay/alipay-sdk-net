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
    /// BankcardExtInfo
    /// </summary>
    [DataContract(Name = "BankcardExtInfo")]
    public partial class BankcardExtInfo : IEquatable<BankcardExtInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankcardExtInfo" /> class.
        /// </summary>
        /// <param name="accountType">收款账户类型。 1：对公（在金融机构开设的公司账户） 2：对私（在金融机构开设的个人账户）.</param>
        /// <param name="bankCode">银行支行联行号.</param>
        /// <param name="instBranchName">收款银行所属支行.</param>
        /// <param name="instCity">收款银行所在市.</param>
        /// <param name="instName">机构名称.</param>
        /// <param name="instProvince">银行所在省.</param>
        public BankcardExtInfo(string accountType = default(string), string bankCode = default(string), string instBranchName = default(string), string instCity = default(string), string instName = default(string), string instProvince = default(string))
        {
            this.AccountType = accountType;
            this.BankCode = bankCode;
            this.InstBranchName = instBranchName;
            this.InstCity = instCity;
            this.InstName = instName;
            this.InstProvince = instProvince;
        }

        /// <summary>
        /// 收款账户类型。 1：对公（在金融机构开设的公司账户） 2：对私（在金融机构开设的个人账户）
        /// </summary>
        /// <value>收款账户类型。 1：对公（在金融机构开设的公司账户） 2：对私（在金融机构开设的个人账户）</value>
        [DataMember(Name = "account_type", EmitDefaultValue = false)]
        public string AccountType { get; set; }

        /// <summary>
        /// 银行支行联行号
        /// </summary>
        /// <value>银行支行联行号</value>
        [DataMember(Name = "bank_code", EmitDefaultValue = false)]
        public string BankCode { get; set; }

        /// <summary>
        /// 收款银行所属支行
        /// </summary>
        /// <value>收款银行所属支行</value>
        [DataMember(Name = "inst_branch_name", EmitDefaultValue = false)]
        public string InstBranchName { get; set; }

        /// <summary>
        /// 收款银行所在市
        /// </summary>
        /// <value>收款银行所在市</value>
        [DataMember(Name = "inst_city", EmitDefaultValue = false)]
        public string InstCity { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        /// <value>机构名称</value>
        [DataMember(Name = "inst_name", EmitDefaultValue = false)]
        public string InstName { get; set; }

        /// <summary>
        /// 银行所在省
        /// </summary>
        /// <value>银行所在省</value>
        [DataMember(Name = "inst_province", EmitDefaultValue = false)]
        public string InstProvince { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankcardExtInfo {\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  InstBranchName: ").Append(InstBranchName).Append("\n");
            sb.Append("  InstCity: ").Append(InstCity).Append("\n");
            sb.Append("  InstName: ").Append(InstName).Append("\n");
            sb.Append("  InstProvince: ").Append(InstProvince).Append("\n");
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
            return this.Equals(input as BankcardExtInfo);
        }

        /// <summary>
        /// Returns true if BankcardExtInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BankcardExtInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankcardExtInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
                ) && 
                (
                    this.InstBranchName == input.InstBranchName ||
                    (this.InstBranchName != null &&
                    this.InstBranchName.Equals(input.InstBranchName))
                ) && 
                (
                    this.InstCity == input.InstCity ||
                    (this.InstCity != null &&
                    this.InstCity.Equals(input.InstCity))
                ) && 
                (
                    this.InstName == input.InstName ||
                    (this.InstName != null &&
                    this.InstName.Equals(input.InstName))
                ) && 
                (
                    this.InstProvince == input.InstProvince ||
                    (this.InstProvince != null &&
                    this.InstProvince.Equals(input.InstProvince))
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
                if (this.AccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                }
                if (this.BankCode != null)
                {
                    hashCode = (hashCode * 59) + this.BankCode.GetHashCode();
                }
                if (this.InstBranchName != null)
                {
                    hashCode = (hashCode * 59) + this.InstBranchName.GetHashCode();
                }
                if (this.InstCity != null)
                {
                    hashCode = (hashCode * 59) + this.InstCity.GetHashCode();
                }
                if (this.InstName != null)
                {
                    hashCode = (hashCode * 59) + this.InstName.GetHashCode();
                }
                if (this.InstProvince != null)
                {
                    hashCode = (hashCode * 59) + this.InstProvince.GetHashCode();
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
