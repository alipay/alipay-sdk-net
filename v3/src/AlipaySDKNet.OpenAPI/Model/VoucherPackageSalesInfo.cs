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
    /// VoucherPackageSalesInfo
    /// </summary>
    [DataContract(Name = "VoucherPackageSalesInfo")]
    public partial class VoucherPackageSalesInfo : IEquatable<VoucherPackageSalesInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherPackageSalesInfo" /> class.
        /// </summary>
        /// <param name="budget">券包售卖预算，单位是份数.</param>
        /// <param name="payChannel">券包购买支付渠道 pcredit：花呗 creditCard：信用卡 credit_group：花呗与信用卡 为空则不限渠道.</param>
        /// <param name="purchaseUrl">券包购买链接.</param>
        /// <param name="saleCountLimitInPeriod">券包售卖期限内最大购买次数.</param>
        /// <param name="salePeriodLimit">券包购买期限类型 NO：不限制  ALL：售卖时间内  DAY：天  WEEK：周  MONTH：月.</param>
        /// <param name="salePrice">券包售卖价格，单位是元.</param>
        public VoucherPackageSalesInfo(int budget = default(int), string payChannel = default(string), string purchaseUrl = default(string), int saleCountLimitInPeriod = default(int), string salePeriodLimit = default(string), string salePrice = default(string))
        {
            this.Budget = budget;
            this.PayChannel = payChannel;
            this.PurchaseUrl = purchaseUrl;
            this.SaleCountLimitInPeriod = saleCountLimitInPeriod;
            this.SalePeriodLimit = salePeriodLimit;
            this.SalePrice = salePrice;
        }

        /// <summary>
        /// 券包售卖预算，单位是份数
        /// </summary>
        /// <value>券包售卖预算，单位是份数</value>
        [DataMember(Name = "budget", EmitDefaultValue = false)]
        public int Budget { get; set; }

        /// <summary>
        /// 券包购买支付渠道 pcredit：花呗 creditCard：信用卡 credit_group：花呗与信用卡 为空则不限渠道
        /// </summary>
        /// <value>券包购买支付渠道 pcredit：花呗 creditCard：信用卡 credit_group：花呗与信用卡 为空则不限渠道</value>
        [DataMember(Name = "pay_channel", EmitDefaultValue = false)]
        public string PayChannel { get; set; }

        /// <summary>
        /// 券包购买链接
        /// </summary>
        /// <value>券包购买链接</value>
        [DataMember(Name = "purchase_url", EmitDefaultValue = false)]
        public string PurchaseUrl { get; set; }

        /// <summary>
        /// 券包售卖期限内最大购买次数
        /// </summary>
        /// <value>券包售卖期限内最大购买次数</value>
        [DataMember(Name = "sale_count_limit_in_period", EmitDefaultValue = false)]
        public int SaleCountLimitInPeriod { get; set; }

        /// <summary>
        /// 券包购买期限类型 NO：不限制  ALL：售卖时间内  DAY：天  WEEK：周  MONTH：月
        /// </summary>
        /// <value>券包购买期限类型 NO：不限制  ALL：售卖时间内  DAY：天  WEEK：周  MONTH：月</value>
        [DataMember(Name = "sale_period_limit", EmitDefaultValue = false)]
        public string SalePeriodLimit { get; set; }

        /// <summary>
        /// 券包售卖价格，单位是元
        /// </summary>
        /// <value>券包售卖价格，单位是元</value>
        [DataMember(Name = "sale_price", EmitDefaultValue = false)]
        public string SalePrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherPackageSalesInfo {\n");
            sb.Append("  Budget: ").Append(Budget).Append("\n");
            sb.Append("  PayChannel: ").Append(PayChannel).Append("\n");
            sb.Append("  PurchaseUrl: ").Append(PurchaseUrl).Append("\n");
            sb.Append("  SaleCountLimitInPeriod: ").Append(SaleCountLimitInPeriod).Append("\n");
            sb.Append("  SalePeriodLimit: ").Append(SalePeriodLimit).Append("\n");
            sb.Append("  SalePrice: ").Append(SalePrice).Append("\n");
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
            return this.Equals(input as VoucherPackageSalesInfo);
        }

        /// <summary>
        /// Returns true if VoucherPackageSalesInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherPackageSalesInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherPackageSalesInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Budget == input.Budget ||
                    this.Budget.Equals(input.Budget)
                ) && 
                (
                    this.PayChannel == input.PayChannel ||
                    (this.PayChannel != null &&
                    this.PayChannel.Equals(input.PayChannel))
                ) && 
                (
                    this.PurchaseUrl == input.PurchaseUrl ||
                    (this.PurchaseUrl != null &&
                    this.PurchaseUrl.Equals(input.PurchaseUrl))
                ) && 
                (
                    this.SaleCountLimitInPeriod == input.SaleCountLimitInPeriod ||
                    this.SaleCountLimitInPeriod.Equals(input.SaleCountLimitInPeriod)
                ) && 
                (
                    this.SalePeriodLimit == input.SalePeriodLimit ||
                    (this.SalePeriodLimit != null &&
                    this.SalePeriodLimit.Equals(input.SalePeriodLimit))
                ) && 
                (
                    this.SalePrice == input.SalePrice ||
                    (this.SalePrice != null &&
                    this.SalePrice.Equals(input.SalePrice))
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
                hashCode = (hashCode * 59) + this.Budget.GetHashCode();
                if (this.PayChannel != null)
                {
                    hashCode = (hashCode * 59) + this.PayChannel.GetHashCode();
                }
                if (this.PurchaseUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PurchaseUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SaleCountLimitInPeriod.GetHashCode();
                if (this.SalePeriodLimit != null)
                {
                    hashCode = (hashCode * 59) + this.SalePeriodLimit.GetHashCode();
                }
                if (this.SalePrice != null)
                {
                    hashCode = (hashCode * 59) + this.SalePrice.GetHashCode();
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
