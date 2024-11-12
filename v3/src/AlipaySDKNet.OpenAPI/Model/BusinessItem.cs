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
    /// BusinessItem
    /// </summary>
    [DataContract(Name = "BusinessItem")]
    public partial class BusinessItem : IEquatable<BusinessItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessItem" /> class.
        /// </summary>
        /// <param name="businessAppid">业务归属appid.</param>
        /// <param name="businessPayeeId">业务收款pid，business_type为AGREEMENT_PAY时，此参数必传.</param>
        /// <param name="businessPid">业务归属pid.</param>
        /// <param name="businessType">业务类型ONLINE_PAY(在线缴费) 、AGREEMENT_PAY(无感停车) DEVICE_ONLINE_PAY(车机在线缴费).</param>
        public BusinessItem(string businessAppid = default(string), string businessPayeeId = default(string), string businessPid = default(string), string businessType = default(string))
        {
            this.BusinessAppid = businessAppid;
            this.BusinessPayeeId = businessPayeeId;
            this.BusinessPid = businessPid;
            this.BusinessType = businessType;
        }

        /// <summary>
        /// 业务归属appid
        /// </summary>
        /// <value>业务归属appid</value>
        [DataMember(Name = "business_appid", EmitDefaultValue = false)]
        public string BusinessAppid { get; set; }

        /// <summary>
        /// 业务收款pid，business_type为AGREEMENT_PAY时，此参数必传
        /// </summary>
        /// <value>业务收款pid，business_type为AGREEMENT_PAY时，此参数必传</value>
        [DataMember(Name = "business_payee_id", EmitDefaultValue = false)]
        public string BusinessPayeeId { get; set; }

        /// <summary>
        /// 业务归属pid
        /// </summary>
        /// <value>业务归属pid</value>
        [DataMember(Name = "business_pid", EmitDefaultValue = false)]
        public string BusinessPid { get; set; }

        /// <summary>
        /// 业务类型ONLINE_PAY(在线缴费) 、AGREEMENT_PAY(无感停车) DEVICE_ONLINE_PAY(车机在线缴费)
        /// </summary>
        /// <value>业务类型ONLINE_PAY(在线缴费) 、AGREEMENT_PAY(无感停车) DEVICE_ONLINE_PAY(车机在线缴费)</value>
        [DataMember(Name = "business_type", EmitDefaultValue = false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BusinessItem {\n");
            sb.Append("  BusinessAppid: ").Append(BusinessAppid).Append("\n");
            sb.Append("  BusinessPayeeId: ").Append(BusinessPayeeId).Append("\n");
            sb.Append("  BusinessPid: ").Append(BusinessPid).Append("\n");
            sb.Append("  BusinessType: ").Append(BusinessType).Append("\n");
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
            return this.Equals(input as BusinessItem);
        }

        /// <summary>
        /// Returns true if BusinessItem instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BusinessAppid == input.BusinessAppid ||
                    (this.BusinessAppid != null &&
                    this.BusinessAppid.Equals(input.BusinessAppid))
                ) && 
                (
                    this.BusinessPayeeId == input.BusinessPayeeId ||
                    (this.BusinessPayeeId != null &&
                    this.BusinessPayeeId.Equals(input.BusinessPayeeId))
                ) && 
                (
                    this.BusinessPid == input.BusinessPid ||
                    (this.BusinessPid != null &&
                    this.BusinessPid.Equals(input.BusinessPid))
                ) && 
                (
                    this.BusinessType == input.BusinessType ||
                    (this.BusinessType != null &&
                    this.BusinessType.Equals(input.BusinessType))
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
                if (this.BusinessAppid != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessAppid.GetHashCode();
                }
                if (this.BusinessPayeeId != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessPayeeId.GetHashCode();
                }
                if (this.BusinessPid != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessPid.GetHashCode();
                }
                if (this.BusinessType != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessType.GetHashCode();
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
