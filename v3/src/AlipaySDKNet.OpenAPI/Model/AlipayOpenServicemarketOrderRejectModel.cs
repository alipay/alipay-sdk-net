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
    /// AlipayOpenServicemarketOrderRejectModel
    /// </summary>
    [DataContract(Name = "AlipayOpenServicemarketOrderRejectModel")]
    public partial class AlipayOpenServicemarketOrderRejectModel : IEquatable<AlipayOpenServicemarketOrderRejectModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenServicemarketOrderRejectModel" /> class.
        /// </summary>
        /// <param name="commodityOrderId">订购服务商品订单ID.</param>
        /// <param name="rejectReason">拒绝接单原因.</param>
        public AlipayOpenServicemarketOrderRejectModel(string commodityOrderId = default(string), string rejectReason = default(string))
        {
            this.CommodityOrderId = commodityOrderId;
            this.RejectReason = rejectReason;
        }

        /// <summary>
        /// 订购服务商品订单ID
        /// </summary>
        /// <value>订购服务商品订单ID</value>
        [DataMember(Name = "commodity_order_id", EmitDefaultValue = false)]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 拒绝接单原因
        /// </summary>
        /// <value>拒绝接单原因</value>
        [DataMember(Name = "reject_reason", EmitDefaultValue = false)]
        public string RejectReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenServicemarketOrderRejectModel {\n");
            sb.Append("  CommodityOrderId: ").Append(CommodityOrderId).Append("\n");
            sb.Append("  RejectReason: ").Append(RejectReason).Append("\n");
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
            return this.Equals(input as AlipayOpenServicemarketOrderRejectModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenServicemarketOrderRejectModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenServicemarketOrderRejectModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenServicemarketOrderRejectModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CommodityOrderId == input.CommodityOrderId ||
                    (this.CommodityOrderId != null &&
                    this.CommodityOrderId.Equals(input.CommodityOrderId))
                ) && 
                (
                    this.RejectReason == input.RejectReason ||
                    (this.RejectReason != null &&
                    this.RejectReason.Equals(input.RejectReason))
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
                if (this.CommodityOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.CommodityOrderId.GetHashCode();
                }
                if (this.RejectReason != null)
                {
                    hashCode = (hashCode * 59) + this.RejectReason.GetHashCode();
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
