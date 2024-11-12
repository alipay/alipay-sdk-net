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
    /// DeliveryAgencyMerchantInfo
    /// </summary>
    [DataContract(Name = "DeliveryAgencyMerchantInfo")]
    public partial class DeliveryAgencyMerchantInfo : IEquatable<DeliveryAgencyMerchantInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryAgencyMerchantInfo" /> class.
        /// </summary>
        /// <param name="businessType">合作业务类型。.</param>
        /// <param name="merchantId">商户信息.</param>
        /// <param name="merchantIdType">商户id类型。 限制: 服务商代运营模式必传 如果merchant_id_type选择SMID。则表明当前商家券活动的归属者是该SMID所绑定的支付宝PID。 因此要求该SMID必须绑定相应的支付宝PID。.</param>
        public DeliveryAgencyMerchantInfo(string businessType = default(string), string merchantId = default(string), string merchantIdType = default(string))
        {
            this.BusinessType = businessType;
            this.MerchantId = merchantId;
            this.MerchantIdType = merchantIdType;
        }

        /// <summary>
        /// 合作业务类型。
        /// </summary>
        /// <value>合作业务类型。</value>
        [DataMember(Name = "business_type", EmitDefaultValue = false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        /// <value>商户信息</value>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户id类型。 限制: 服务商代运营模式必传 如果merchant_id_type选择SMID。则表明当前商家券活动的归属者是该SMID所绑定的支付宝PID。 因此要求该SMID必须绑定相应的支付宝PID。
        /// </summary>
        /// <value>商户id类型。 限制: 服务商代运营模式必传 如果merchant_id_type选择SMID。则表明当前商家券活动的归属者是该SMID所绑定的支付宝PID。 因此要求该SMID必须绑定相应的支付宝PID。</value>
        [DataMember(Name = "merchant_id_type", EmitDefaultValue = false)]
        public string MerchantIdType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryAgencyMerchantInfo {\n");
            sb.Append("  BusinessType: ").Append(BusinessType).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  MerchantIdType: ").Append(MerchantIdType).Append("\n");
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
            return this.Equals(input as DeliveryAgencyMerchantInfo);
        }

        /// <summary>
        /// Returns true if DeliveryAgencyMerchantInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryAgencyMerchantInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryAgencyMerchantInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BusinessType == input.BusinessType ||
                    (this.BusinessType != null &&
                    this.BusinessType.Equals(input.BusinessType))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.MerchantIdType == input.MerchantIdType ||
                    (this.MerchantIdType != null &&
                    this.MerchantIdType.Equals(input.MerchantIdType))
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
                if (this.BusinessType != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessType.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.MerchantIdType != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantIdType.GetHashCode();
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
