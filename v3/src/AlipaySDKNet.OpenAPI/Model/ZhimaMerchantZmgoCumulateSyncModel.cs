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
    /// ZhimaMerchantZmgoCumulateSyncModel
    /// </summary>
    [DataContract(Name = "ZhimaMerchantZmgoCumulateSyncModel")]
    public partial class ZhimaMerchantZmgoCumulateSyncModel : IEquatable<ZhimaMerchantZmgoCumulateSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaMerchantZmgoCumulateSyncModel" /> class.
        /// </summary>
        /// <param name="agreementId">芝麻go协议号，唯一标识一个芝麻go协议。.</param>
        /// <param name="amountTypeSyncData">amountTypeSyncData.</param>
        /// <param name="bizAction">数据回传的动作类型。枚举如下： * POSITIVE：正向回传，即订单金额累加，优惠累加，任务次数累加。 * REVERSE：逆向回传，即订单金额退款，优惠退款，任务次数回退。.</param>
        /// <param name="bizTime">回传数据发生的实际时间，包括：订单交易时间，优惠核销时间，以及任务完成时间。为必传入参。 如：用户在【2019-03-08 00:00:00】核销了一个红包，但是【2019-03-10 00:00:00】才进行数据回传，此时biz_time取值红包核销的时间，也就是【2019-03-08 00:00:00】。.</param>
        /// <param name="dataType">回传数据类型，枚举： TASK - 进度型，影响进度 DISCOUNT - 优惠型.</param>
        /// <param name="discountTypeSyncData">discountTypeSyncData.</param>
        /// <param name="openId">用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。.</param>
        /// <param name="outBizNo">外部业务号，唯一标识一笔回传数据。.</param>
        /// <param name="providerPid">数据回传的商户 ID，即和用户发生业务来往的 PID 主体。商户账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。.</param>
        /// <param name="referOutBizNo">逆向对应的正向外部业务号。逆向场景为必传入参。也就是biz_action为REVERSE时为必传入参。 逆向时需通过此字段明确对应的正向的外部业务号。.</param>
        /// <param name="subBizAction">数据回传动作子类型，枚举值，为必传入参。 ADD - 新增数据 UPDATE - 修改数据 备注：UPDATE只能更新金额信息。.</param>
        /// <param name="timesTypeSyncData">timesTypeSyncData.</param>
        /// <param name="userId">用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 .</param>
        public ZhimaMerchantZmgoCumulateSyncModel(string agreementId = default(string), AmountTypeSyncData amountTypeSyncData = default(AmountTypeSyncData), string bizAction = default(string), string bizTime = default(string), string dataType = default(string), DiscountTypeSyncData discountTypeSyncData = default(DiscountTypeSyncData), string openId = default(string), string outBizNo = default(string), string providerPid = default(string), string referOutBizNo = default(string), string subBizAction = default(string), TimesTypeSyncData timesTypeSyncData = default(TimesTypeSyncData), string userId = default(string))
        {
            this.AgreementId = agreementId;
            this.AmountTypeSyncData = amountTypeSyncData;
            this.BizAction = bizAction;
            this.BizTime = bizTime;
            this.DataType = dataType;
            this.DiscountTypeSyncData = discountTypeSyncData;
            this.OpenId = openId;
            this.OutBizNo = outBizNo;
            this.ProviderPid = providerPid;
            this.ReferOutBizNo = referOutBizNo;
            this.SubBizAction = subBizAction;
            this.TimesTypeSyncData = timesTypeSyncData;
            this.UserId = userId;
        }

        /// <summary>
        /// 芝麻go协议号，唯一标识一个芝麻go协议。
        /// </summary>
        /// <value>芝麻go协议号，唯一标识一个芝麻go协议。</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// Gets or Sets AmountTypeSyncData
        /// </summary>
        [DataMember(Name = "amount_type_sync_data", EmitDefaultValue = false)]
        public AmountTypeSyncData AmountTypeSyncData { get; set; }

        /// <summary>
        /// 数据回传的动作类型。枚举如下： * POSITIVE：正向回传，即订单金额累加，优惠累加，任务次数累加。 * REVERSE：逆向回传，即订单金额退款，优惠退款，任务次数回退。
        /// </summary>
        /// <value>数据回传的动作类型。枚举如下： * POSITIVE：正向回传，即订单金额累加，优惠累加，任务次数累加。 * REVERSE：逆向回传，即订单金额退款，优惠退款，任务次数回退。</value>
        [DataMember(Name = "biz_action", EmitDefaultValue = false)]
        public string BizAction { get; set; }

        /// <summary>
        /// 回传数据发生的实际时间，包括：订单交易时间，优惠核销时间，以及任务完成时间。为必传入参。 如：用户在【2019-03-08 00:00:00】核销了一个红包，但是【2019-03-10 00:00:00】才进行数据回传，此时biz_time取值红包核销的时间，也就是【2019-03-08 00:00:00】。
        /// </summary>
        /// <value>回传数据发生的实际时间，包括：订单交易时间，优惠核销时间，以及任务完成时间。为必传入参。 如：用户在【2019-03-08 00:00:00】核销了一个红包，但是【2019-03-10 00:00:00】才进行数据回传，此时biz_time取值红包核销的时间，也就是【2019-03-08 00:00:00】。</value>
        [DataMember(Name = "biz_time", EmitDefaultValue = false)]
        public string BizTime { get; set; }

        /// <summary>
        /// 回传数据类型，枚举： TASK - 进度型，影响进度 DISCOUNT - 优惠型
        /// </summary>
        /// <value>回传数据类型，枚举： TASK - 进度型，影响进度 DISCOUNT - 优惠型</value>
        [DataMember(Name = "data_type", EmitDefaultValue = false)]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or Sets DiscountTypeSyncData
        /// </summary>
        [DataMember(Name = "discount_type_sync_data", EmitDefaultValue = false)]
        public DiscountTypeSyncData DiscountTypeSyncData { get; set; }

        /// <summary>
        /// 用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        /// <value>用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号，唯一标识一笔回传数据。
        /// </summary>
        /// <value>外部业务号，唯一标识一笔回传数据。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 数据回传的商户 ID，即和用户发生业务来往的 PID 主体。商户账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        /// <value>数据回传的商户 ID，即和用户发生业务来往的 PID 主体。商户账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。</value>
        [DataMember(Name = "provider_pid", EmitDefaultValue = false)]
        public string ProviderPid { get; set; }

        /// <summary>
        /// 逆向对应的正向外部业务号。逆向场景为必传入参。也就是biz_action为REVERSE时为必传入参。 逆向时需通过此字段明确对应的正向的外部业务号。
        /// </summary>
        /// <value>逆向对应的正向外部业务号。逆向场景为必传入参。也就是biz_action为REVERSE时为必传入参。 逆向时需通过此字段明确对应的正向的外部业务号。</value>
        [DataMember(Name = "refer_out_biz_no", EmitDefaultValue = false)]
        public string ReferOutBizNo { get; set; }

        /// <summary>
        /// 数据回传动作子类型，枚举值，为必传入参。 ADD - 新增数据 UPDATE - 修改数据 备注：UPDATE只能更新金额信息。
        /// </summary>
        /// <value>数据回传动作子类型，枚举值，为必传入参。 ADD - 新增数据 UPDATE - 修改数据 备注：UPDATE只能更新金额信息。</value>
        [DataMember(Name = "sub_biz_action", EmitDefaultValue = false)]
        public string SubBizAction { get; set; }

        /// <summary>
        /// Gets or Sets TimesTypeSyncData
        /// </summary>
        [DataMember(Name = "times_type_sync_data", EmitDefaultValue = false)]
        public TimesTypeSyncData TimesTypeSyncData { get; set; }

        /// <summary>
        /// 用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 
        /// </summary>
        /// <value>用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 </value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaMerchantZmgoCumulateSyncModel {\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  AmountTypeSyncData: ").Append(AmountTypeSyncData).Append("\n");
            sb.Append("  BizAction: ").Append(BizAction).Append("\n");
            sb.Append("  BizTime: ").Append(BizTime).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  DiscountTypeSyncData: ").Append(DiscountTypeSyncData).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  ProviderPid: ").Append(ProviderPid).Append("\n");
            sb.Append("  ReferOutBizNo: ").Append(ReferOutBizNo).Append("\n");
            sb.Append("  SubBizAction: ").Append(SubBizAction).Append("\n");
            sb.Append("  TimesTypeSyncData: ").Append(TimesTypeSyncData).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as ZhimaMerchantZmgoCumulateSyncModel);
        }

        /// <summary>
        /// Returns true if ZhimaMerchantZmgoCumulateSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaMerchantZmgoCumulateSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaMerchantZmgoCumulateSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.AmountTypeSyncData == input.AmountTypeSyncData ||
                    (this.AmountTypeSyncData != null &&
                    this.AmountTypeSyncData.Equals(input.AmountTypeSyncData))
                ) && 
                (
                    this.BizAction == input.BizAction ||
                    (this.BizAction != null &&
                    this.BizAction.Equals(input.BizAction))
                ) && 
                (
                    this.BizTime == input.BizTime ||
                    (this.BizTime != null &&
                    this.BizTime.Equals(input.BizTime))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.DiscountTypeSyncData == input.DiscountTypeSyncData ||
                    (this.DiscountTypeSyncData != null &&
                    this.DiscountTypeSyncData.Equals(input.DiscountTypeSyncData))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.ProviderPid == input.ProviderPid ||
                    (this.ProviderPid != null &&
                    this.ProviderPid.Equals(input.ProviderPid))
                ) && 
                (
                    this.ReferOutBizNo == input.ReferOutBizNo ||
                    (this.ReferOutBizNo != null &&
                    this.ReferOutBizNo.Equals(input.ReferOutBizNo))
                ) && 
                (
                    this.SubBizAction == input.SubBizAction ||
                    (this.SubBizAction != null &&
                    this.SubBizAction.Equals(input.SubBizAction))
                ) && 
                (
                    this.TimesTypeSyncData == input.TimesTypeSyncData ||
                    (this.TimesTypeSyncData != null &&
                    this.TimesTypeSyncData.Equals(input.TimesTypeSyncData))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                if (this.AmountTypeSyncData != null)
                {
                    hashCode = (hashCode * 59) + this.AmountTypeSyncData.GetHashCode();
                }
                if (this.BizAction != null)
                {
                    hashCode = (hashCode * 59) + this.BizAction.GetHashCode();
                }
                if (this.BizTime != null)
                {
                    hashCode = (hashCode * 59) + this.BizTime.GetHashCode();
                }
                if (this.DataType != null)
                {
                    hashCode = (hashCode * 59) + this.DataType.GetHashCode();
                }
                if (this.DiscountTypeSyncData != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountTypeSyncData.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.ProviderPid != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderPid.GetHashCode();
                }
                if (this.ReferOutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.ReferOutBizNo.GetHashCode();
                }
                if (this.SubBizAction != null)
                {
                    hashCode = (hashCode * 59) + this.SubBizAction.GetHashCode();
                }
                if (this.TimesTypeSyncData != null)
                {
                    hashCode = (hashCode * 59) + this.TimesTypeSyncData.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
