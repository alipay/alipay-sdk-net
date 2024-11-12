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
    /// DiscountVoucherInfo
    /// </summary>
    [DataContract(Name = "DiscountVoucherInfo")]
    public partial class DiscountVoucherInfo : IEquatable<DiscountVoucherInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountVoucherInfo" /> class.
        /// </summary>
        /// <param name="ceilingAmount">封顶金额。.</param>
        /// <param name="discount">折扣率。.</param>
        /// <param name="floorAmount">门槛金额。说明：该字段可不填，认为无门槛;.</param>
        /// <param name="voucherDeductThresholdInfo">voucherDeductThresholdInfo.</param>
        public DiscountVoucherInfo(string ceilingAmount = default(string), string discount = default(string), string floorAmount = default(string), VoucherDeductThresholdInfo voucherDeductThresholdInfo = default(VoucherDeductThresholdInfo))
        {
            this.CeilingAmount = ceilingAmount;
            this.Discount = discount;
            this.FloorAmount = floorAmount;
            this.VoucherDeductThresholdInfo = voucherDeductThresholdInfo;
        }

        /// <summary>
        /// 封顶金额。
        /// </summary>
        /// <value>封顶金额。</value>
        [DataMember(Name = "ceiling_amount", EmitDefaultValue = false)]
        public string CeilingAmount { get; set; }

        /// <summary>
        /// 折扣率。
        /// </summary>
        /// <value>折扣率。</value>
        [DataMember(Name = "discount", EmitDefaultValue = false)]
        public string Discount { get; set; }

        /// <summary>
        /// 门槛金额。说明：该字段可不填，认为无门槛;
        /// </summary>
        /// <value>门槛金额。说明：该字段可不填，认为无门槛;</value>
        [DataMember(Name = "floor_amount", EmitDefaultValue = false)]
        public string FloorAmount { get; set; }

        /// <summary>
        /// Gets or Sets VoucherDeductThresholdInfo
        /// </summary>
        [DataMember(Name = "voucher_deduct_threshold_info", EmitDefaultValue = false)]
        public VoucherDeductThresholdInfo VoucherDeductThresholdInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiscountVoucherInfo {\n");
            sb.Append("  CeilingAmount: ").Append(CeilingAmount).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  FloorAmount: ").Append(FloorAmount).Append("\n");
            sb.Append("  VoucherDeductThresholdInfo: ").Append(VoucherDeductThresholdInfo).Append("\n");
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
            return this.Equals(input as DiscountVoucherInfo);
        }

        /// <summary>
        /// Returns true if DiscountVoucherInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscountVoucherInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscountVoucherInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CeilingAmount == input.CeilingAmount ||
                    (this.CeilingAmount != null &&
                    this.CeilingAmount.Equals(input.CeilingAmount))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.FloorAmount == input.FloorAmount ||
                    (this.FloorAmount != null &&
                    this.FloorAmount.Equals(input.FloorAmount))
                ) && 
                (
                    this.VoucherDeductThresholdInfo == input.VoucherDeductThresholdInfo ||
                    (this.VoucherDeductThresholdInfo != null &&
                    this.VoucherDeductThresholdInfo.Equals(input.VoucherDeductThresholdInfo))
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
                if (this.CeilingAmount != null)
                {
                    hashCode = (hashCode * 59) + this.CeilingAmount.GetHashCode();
                }
                if (this.Discount != null)
                {
                    hashCode = (hashCode * 59) + this.Discount.GetHashCode();
                }
                if (this.FloorAmount != null)
                {
                    hashCode = (hashCode * 59) + this.FloorAmount.GetHashCode();
                }
                if (this.VoucherDeductThresholdInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDeductThresholdInfo.GetHashCode();
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
