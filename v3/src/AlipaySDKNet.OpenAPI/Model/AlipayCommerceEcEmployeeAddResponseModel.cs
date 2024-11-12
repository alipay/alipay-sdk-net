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
    /// AlipayCommerceEcEmployeeAddResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcEmployeeAddResponseModel")]
    public partial class AlipayCommerceEcEmployeeAddResponseModel : IEquatable<AlipayCommerceEcEmployeeAddResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEmployeeAddResponseModel" /> class.
        /// </summary>
        /// <param name="employeeId">企业码生成的员工ID.</param>
        /// <param name="iotUniqueId">员工开通IOT企业刷脸付的唯一流水号.</param>
        /// <param name="shareCode">员工签约激活吱口令.</param>
        /// <param name="signUrl">员工签约激活页面链接.</param>
        public AlipayCommerceEcEmployeeAddResponseModel(string employeeId = default(string), string iotUniqueId = default(string), string shareCode = default(string), string signUrl = default(string))
        {
            this.EmployeeId = employeeId;
            this.IotUniqueId = iotUniqueId;
            this.ShareCode = shareCode;
            this.SignUrl = signUrl;
        }

        /// <summary>
        /// 企业码生成的员工ID
        /// </summary>
        /// <value>企业码生成的员工ID</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 员工开通IOT企业刷脸付的唯一流水号
        /// </summary>
        /// <value>员工开通IOT企业刷脸付的唯一流水号</value>
        [DataMember(Name = "iot_unique_id", EmitDefaultValue = false)]
        public string IotUniqueId { get; set; }

        /// <summary>
        /// 员工签约激活吱口令
        /// </summary>
        /// <value>员工签约激活吱口令</value>
        [DataMember(Name = "share_code", EmitDefaultValue = false)]
        public string ShareCode { get; set; }

        /// <summary>
        /// 员工签约激活页面链接
        /// </summary>
        /// <value>员工签约激活页面链接</value>
        [DataMember(Name = "sign_url", EmitDefaultValue = false)]
        public string SignUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcEmployeeAddResponseModel {\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  IotUniqueId: ").Append(IotUniqueId).Append("\n");
            sb.Append("  ShareCode: ").Append(ShareCode).Append("\n");
            sb.Append("  SignUrl: ").Append(SignUrl).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcEmployeeAddResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcEmployeeAddResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcEmployeeAddResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcEmployeeAddResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.IotUniqueId == input.IotUniqueId ||
                    (this.IotUniqueId != null &&
                    this.IotUniqueId.Equals(input.IotUniqueId))
                ) && 
                (
                    this.ShareCode == input.ShareCode ||
                    (this.ShareCode != null &&
                    this.ShareCode.Equals(input.ShareCode))
                ) && 
                (
                    this.SignUrl == input.SignUrl ||
                    (this.SignUrl != null &&
                    this.SignUrl.Equals(input.SignUrl))
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
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                if (this.IotUniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.IotUniqueId.GetHashCode();
                }
                if (this.ShareCode != null)
                {
                    hashCode = (hashCode * 59) + this.ShareCode.GetHashCode();
                }
                if (this.SignUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SignUrl.GetHashCode();
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
