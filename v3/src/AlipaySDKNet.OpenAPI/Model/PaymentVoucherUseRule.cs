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
    /// PaymentVoucherUseRule
    /// </summary>
    [DataContract(Name = "PaymentVoucherUseRule")]
    public partial class PaymentVoucherUseRule : IEquatable<PaymentVoucherUseRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVoucherUseRule" /> class.
        /// </summary>
        /// <param name="availableAppIds">可核销的支付宝小程序id  限制：  1、必须是支付宝小程序 2、如果包含重复的小程序id会自动进行去重操作。.</param>
        /// <param name="availableGoods">availableGoods.</param>
        /// <param name="availableMerchant">availableMerchant.</param>
        /// <param name="availableStoreIds">可核销支付门店id。 限制：  1、available_store_ids中的门店id必须是支付宝门店id。  2、available_store_ids如果包含重复的门店id会自动进行去重操作。.</param>
        /// <param name="fixVoucher">fixVoucher.</param>
        /// <param name="unavailableGoodsIds">不可核销商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，不可以使用优惠券。  限制: 1、available_goods与unavailable_goods_ids只能二选一或者同时为空.</param>
        /// <param name="useMode">核销跳转方式,默认CAN_USE(详情页展示可使用按钮).</param>
        /// <param name="useUrl">核销跳转链接 限制: 1、只有use_mode为SELF_LINK时该值有效且必传。 2、核销跳转链接必须是支付宝小程序链接。.</param>
        /// <param name="voucherQuantityLimitPerUser">每个支付宝账号的核销次数限制。 默认不限制.</param>
        /// <param name="voucherQuantityLimitPerUserPeriodType">核销次数限制周期配置。默认值LIFE_CYCLE表示限制每个支付宝账号在整个活动期间核销次数。.</param>
        /// <param name="voucherValidPeriod">voucherValidPeriod.</param>
        public PaymentVoucherUseRule(List<string> availableAppIds = default(List<string>), PaymentVoucherAvailableGoods availableGoods = default(PaymentVoucherAvailableGoods), PaymentVoucherAvailableMerchant availableMerchant = default(PaymentVoucherAvailableMerchant), List<string> availableStoreIds = default(List<string>), PaymentFixVoucher fixVoucher = default(PaymentFixVoucher), List<string> unavailableGoodsIds = default(List<string>), string useMode = default(string), string useUrl = default(string), int voucherQuantityLimitPerUser = default(int), string voucherQuantityLimitPerUserPeriodType = default(string), PaymentVoucherValidPeriod voucherValidPeriod = default(PaymentVoucherValidPeriod))
        {
            this.AvailableAppIds = availableAppIds;
            this.AvailableGoods = availableGoods;
            this.AvailableMerchant = availableMerchant;
            this.AvailableStoreIds = availableStoreIds;
            this.FixVoucher = fixVoucher;
            this.UnavailableGoodsIds = unavailableGoodsIds;
            this.UseMode = useMode;
            this.UseUrl = useUrl;
            this.VoucherQuantityLimitPerUser = voucherQuantityLimitPerUser;
            this.VoucherQuantityLimitPerUserPeriodType = voucherQuantityLimitPerUserPeriodType;
            this.VoucherValidPeriod = voucherValidPeriod;
        }

        /// <summary>
        /// 可核销的支付宝小程序id  限制：  1、必须是支付宝小程序 2、如果包含重复的小程序id会自动进行去重操作。
        /// </summary>
        /// <value>可核销的支付宝小程序id  限制：  1、必须是支付宝小程序 2、如果包含重复的小程序id会自动进行去重操作。</value>
        [DataMember(Name = "available_app_ids", EmitDefaultValue = false)]
        public List<string> AvailableAppIds { get; set; }

        /// <summary>
        /// Gets or Sets AvailableGoods
        /// </summary>
        [DataMember(Name = "available_goods", EmitDefaultValue = false)]
        public PaymentVoucherAvailableGoods AvailableGoods { get; set; }

        /// <summary>
        /// Gets or Sets AvailableMerchant
        /// </summary>
        [DataMember(Name = "available_merchant", EmitDefaultValue = false)]
        public PaymentVoucherAvailableMerchant AvailableMerchant { get; set; }

        /// <summary>
        /// 可核销支付门店id。 限制：  1、available_store_ids中的门店id必须是支付宝门店id。  2、available_store_ids如果包含重复的门店id会自动进行去重操作。
        /// </summary>
        /// <value>可核销支付门店id。 限制：  1、available_store_ids中的门店id必须是支付宝门店id。  2、available_store_ids如果包含重复的门店id会自动进行去重操作。</value>
        [DataMember(Name = "available_store_ids", EmitDefaultValue = false)]
        public List<string> AvailableStoreIds { get; set; }

        /// <summary>
        /// Gets or Sets FixVoucher
        /// </summary>
        [DataMember(Name = "fix_voucher", EmitDefaultValue = false)]
        public PaymentFixVoucher FixVoucher { get; set; }

        /// <summary>
        /// 不可核销商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，不可以使用优惠券。  限制: 1、available_goods与unavailable_goods_ids只能二选一或者同时为空
        /// </summary>
        /// <value>不可核销商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，不可以使用优惠券。  限制: 1、available_goods与unavailable_goods_ids只能二选一或者同时为空</value>
        [DataMember(Name = "unavailable_goods_ids", EmitDefaultValue = false)]
        public List<string> UnavailableGoodsIds { get; set; }

        /// <summary>
        /// 核销跳转方式,默认CAN_USE(详情页展示可使用按钮)
        /// </summary>
        /// <value>核销跳转方式,默认CAN_USE(详情页展示可使用按钮)</value>
        [DataMember(Name = "use_mode", EmitDefaultValue = false)]
        public string UseMode { get; set; }

        /// <summary>
        /// 核销跳转链接 限制: 1、只有use_mode为SELF_LINK时该值有效且必传。 2、核销跳转链接必须是支付宝小程序链接。
        /// </summary>
        /// <value>核销跳转链接 限制: 1、只有use_mode为SELF_LINK时该值有效且必传。 2、核销跳转链接必须是支付宝小程序链接。</value>
        [DataMember(Name = "use_url", EmitDefaultValue = false)]
        public string UseUrl { get; set; }

        /// <summary>
        /// 每个支付宝账号的核销次数限制。 默认不限制
        /// </summary>
        /// <value>每个支付宝账号的核销次数限制。 默认不限制</value>
        [DataMember(Name = "voucher_quantity_limit_per_user", EmitDefaultValue = false)]
        public int VoucherQuantityLimitPerUser { get; set; }

        /// <summary>
        /// 核销次数限制周期配置。默认值LIFE_CYCLE表示限制每个支付宝账号在整个活动期间核销次数。
        /// </summary>
        /// <value>核销次数限制周期配置。默认值LIFE_CYCLE表示限制每个支付宝账号在整个活动期间核销次数。</value>
        [DataMember(Name = "voucher_quantity_limit_per_user_period_type", EmitDefaultValue = false)]
        public string VoucherQuantityLimitPerUserPeriodType { get; set; }

        /// <summary>
        /// Gets or Sets VoucherValidPeriod
        /// </summary>
        [DataMember(Name = "voucher_valid_period", EmitDefaultValue = false)]
        public PaymentVoucherValidPeriod VoucherValidPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentVoucherUseRule {\n");
            sb.Append("  AvailableAppIds: ").Append(AvailableAppIds).Append("\n");
            sb.Append("  AvailableGoods: ").Append(AvailableGoods).Append("\n");
            sb.Append("  AvailableMerchant: ").Append(AvailableMerchant).Append("\n");
            sb.Append("  AvailableStoreIds: ").Append(AvailableStoreIds).Append("\n");
            sb.Append("  FixVoucher: ").Append(FixVoucher).Append("\n");
            sb.Append("  UnavailableGoodsIds: ").Append(UnavailableGoodsIds).Append("\n");
            sb.Append("  UseMode: ").Append(UseMode).Append("\n");
            sb.Append("  UseUrl: ").Append(UseUrl).Append("\n");
            sb.Append("  VoucherQuantityLimitPerUser: ").Append(VoucherQuantityLimitPerUser).Append("\n");
            sb.Append("  VoucherQuantityLimitPerUserPeriodType: ").Append(VoucherQuantityLimitPerUserPeriodType).Append("\n");
            sb.Append("  VoucherValidPeriod: ").Append(VoucherValidPeriod).Append("\n");
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
            return this.Equals(input as PaymentVoucherUseRule);
        }

        /// <summary>
        /// Returns true if PaymentVoucherUseRule instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentVoucherUseRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentVoucherUseRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvailableAppIds == input.AvailableAppIds ||
                    this.AvailableAppIds != null &&
                    input.AvailableAppIds != null &&
                    this.AvailableAppIds.SequenceEqual(input.AvailableAppIds)
                ) && 
                (
                    this.AvailableGoods == input.AvailableGoods ||
                    (this.AvailableGoods != null &&
                    this.AvailableGoods.Equals(input.AvailableGoods))
                ) && 
                (
                    this.AvailableMerchant == input.AvailableMerchant ||
                    (this.AvailableMerchant != null &&
                    this.AvailableMerchant.Equals(input.AvailableMerchant))
                ) && 
                (
                    this.AvailableStoreIds == input.AvailableStoreIds ||
                    this.AvailableStoreIds != null &&
                    input.AvailableStoreIds != null &&
                    this.AvailableStoreIds.SequenceEqual(input.AvailableStoreIds)
                ) && 
                (
                    this.FixVoucher == input.FixVoucher ||
                    (this.FixVoucher != null &&
                    this.FixVoucher.Equals(input.FixVoucher))
                ) && 
                (
                    this.UnavailableGoodsIds == input.UnavailableGoodsIds ||
                    this.UnavailableGoodsIds != null &&
                    input.UnavailableGoodsIds != null &&
                    this.UnavailableGoodsIds.SequenceEqual(input.UnavailableGoodsIds)
                ) && 
                (
                    this.UseMode == input.UseMode ||
                    (this.UseMode != null &&
                    this.UseMode.Equals(input.UseMode))
                ) && 
                (
                    this.UseUrl == input.UseUrl ||
                    (this.UseUrl != null &&
                    this.UseUrl.Equals(input.UseUrl))
                ) && 
                (
                    this.VoucherQuantityLimitPerUser == input.VoucherQuantityLimitPerUser ||
                    this.VoucherQuantityLimitPerUser.Equals(input.VoucherQuantityLimitPerUser)
                ) && 
                (
                    this.VoucherQuantityLimitPerUserPeriodType == input.VoucherQuantityLimitPerUserPeriodType ||
                    (this.VoucherQuantityLimitPerUserPeriodType != null &&
                    this.VoucherQuantityLimitPerUserPeriodType.Equals(input.VoucherQuantityLimitPerUserPeriodType))
                ) && 
                (
                    this.VoucherValidPeriod == input.VoucherValidPeriod ||
                    (this.VoucherValidPeriod != null &&
                    this.VoucherValidPeriod.Equals(input.VoucherValidPeriod))
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
                if (this.AvailableAppIds != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableAppIds.GetHashCode();
                }
                if (this.AvailableGoods != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableGoods.GetHashCode();
                }
                if (this.AvailableMerchant != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableMerchant.GetHashCode();
                }
                if (this.AvailableStoreIds != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableStoreIds.GetHashCode();
                }
                if (this.FixVoucher != null)
                {
                    hashCode = (hashCode * 59) + this.FixVoucher.GetHashCode();
                }
                if (this.UnavailableGoodsIds != null)
                {
                    hashCode = (hashCode * 59) + this.UnavailableGoodsIds.GetHashCode();
                }
                if (this.UseMode != null)
                {
                    hashCode = (hashCode * 59) + this.UseMode.GetHashCode();
                }
                if (this.UseUrl != null)
                {
                    hashCode = (hashCode * 59) + this.UseUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VoucherQuantityLimitPerUser.GetHashCode();
                if (this.VoucherQuantityLimitPerUserPeriodType != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherQuantityLimitPerUserPeriodType.GetHashCode();
                }
                if (this.VoucherValidPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherValidPeriod.GetHashCode();
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
