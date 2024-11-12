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
    /// DeliveryContentInfo
    /// </summary>
    [DataContract(Name = "DeliveryContentInfo")]
    public partial class DeliveryContentInfo : IEquatable<DeliveryContentInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryContentInfo" /> class.
        /// </summary>
        /// <param name="deliveryActivityContent">deliveryActivityContent.</param>
        /// <param name="deliveryAppContent">deliveryAppContent.</param>
        /// <param name="deliveryContentType">运营内容类型。.</param>
        /// <param name="deliveryDisplayInfo">deliveryDisplayInfo.</param>
        /// <param name="deliveryItemContent">deliveryItemContent.</param>
        public DeliveryContentInfo(DeliveryActivityContentInfo deliveryActivityContent = default(DeliveryActivityContentInfo), DeliveryMiniAppContentInfo deliveryAppContent = default(DeliveryMiniAppContentInfo), string deliveryContentType = default(string), DeliveryDisplayInfo deliveryDisplayInfo = default(DeliveryDisplayInfo), DeliveryItemContentInfo deliveryItemContent = default(DeliveryItemContentInfo))
        {
            this.DeliveryActivityContent = deliveryActivityContent;
            this.DeliveryAppContent = deliveryAppContent;
            this.DeliveryContentType = deliveryContentType;
            this.DeliveryDisplayInfo = deliveryDisplayInfo;
            this.DeliveryItemContent = deliveryItemContent;
        }

        /// <summary>
        /// Gets or Sets DeliveryActivityContent
        /// </summary>
        [DataMember(Name = "delivery_activity_content", EmitDefaultValue = false)]
        public DeliveryActivityContentInfo DeliveryActivityContent { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAppContent
        /// </summary>
        [DataMember(Name = "delivery_app_content", EmitDefaultValue = false)]
        public DeliveryMiniAppContentInfo DeliveryAppContent { get; set; }

        /// <summary>
        /// 运营内容类型。
        /// </summary>
        /// <value>运营内容类型。</value>
        [DataMember(Name = "delivery_content_type", EmitDefaultValue = false)]
        public string DeliveryContentType { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryDisplayInfo
        /// </summary>
        [DataMember(Name = "delivery_display_info", EmitDefaultValue = false)]
        public DeliveryDisplayInfo DeliveryDisplayInfo { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryItemContent
        /// </summary>
        [DataMember(Name = "delivery_item_content", EmitDefaultValue = false)]
        public DeliveryItemContentInfo DeliveryItemContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryContentInfo {\n");
            sb.Append("  DeliveryActivityContent: ").Append(DeliveryActivityContent).Append("\n");
            sb.Append("  DeliveryAppContent: ").Append(DeliveryAppContent).Append("\n");
            sb.Append("  DeliveryContentType: ").Append(DeliveryContentType).Append("\n");
            sb.Append("  DeliveryDisplayInfo: ").Append(DeliveryDisplayInfo).Append("\n");
            sb.Append("  DeliveryItemContent: ").Append(DeliveryItemContent).Append("\n");
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
            return this.Equals(input as DeliveryContentInfo);
        }

        /// <summary>
        /// Returns true if DeliveryContentInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryContentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryContentInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryActivityContent == input.DeliveryActivityContent ||
                    (this.DeliveryActivityContent != null &&
                    this.DeliveryActivityContent.Equals(input.DeliveryActivityContent))
                ) && 
                (
                    this.DeliveryAppContent == input.DeliveryAppContent ||
                    (this.DeliveryAppContent != null &&
                    this.DeliveryAppContent.Equals(input.DeliveryAppContent))
                ) && 
                (
                    this.DeliveryContentType == input.DeliveryContentType ||
                    (this.DeliveryContentType != null &&
                    this.DeliveryContentType.Equals(input.DeliveryContentType))
                ) && 
                (
                    this.DeliveryDisplayInfo == input.DeliveryDisplayInfo ||
                    (this.DeliveryDisplayInfo != null &&
                    this.DeliveryDisplayInfo.Equals(input.DeliveryDisplayInfo))
                ) && 
                (
                    this.DeliveryItemContent == input.DeliveryItemContent ||
                    (this.DeliveryItemContent != null &&
                    this.DeliveryItemContent.Equals(input.DeliveryItemContent))
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
                if (this.DeliveryActivityContent != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryActivityContent.GetHashCode();
                }
                if (this.DeliveryAppContent != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryAppContent.GetHashCode();
                }
                if (this.DeliveryContentType != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryContentType.GetHashCode();
                }
                if (this.DeliveryDisplayInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryDisplayInfo.GetHashCode();
                }
                if (this.DeliveryItemContent != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryItemContent.GetHashCode();
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
