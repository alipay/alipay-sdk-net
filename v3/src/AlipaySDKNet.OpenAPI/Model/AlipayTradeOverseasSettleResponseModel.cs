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
    /// AlipayTradeOverseasSettleResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeOverseasSettleResponseModel")]
    public partial class AlipayTradeOverseasSettleResponseModel : IEquatable<AlipayTradeOverseasSettleResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeOverseasSettleResponseModel" /> class.
        /// </summary>
        /// <param name="exchangeRate">本笔跨境结算使用的汇率，精度 8 位小数.</param>
        /// <param name="foreignSettleAmount">本次跨境结算的实际结算外币金额.</param>
        /// <param name="foreignSettleCurrency">本笔跨境结算实际结算的外币币种.</param>
        /// <param name="outRequestNo">请求流水号，开发者自行生成并保证唯一性，作为业务幂等性控制.</param>
        /// <param name="settleAmount">本次跨境结算的实际结算人民币金额.</param>
        /// <param name="tradeNo">支付宝交易号.</param>
        public AlipayTradeOverseasSettleResponseModel(string exchangeRate = default(string), string foreignSettleAmount = default(string), string foreignSettleCurrency = default(string), string outRequestNo = default(string), string settleAmount = default(string), string tradeNo = default(string))
        {
            this.ExchangeRate = exchangeRate;
            this.ForeignSettleAmount = foreignSettleAmount;
            this.ForeignSettleCurrency = foreignSettleCurrency;
            this.OutRequestNo = outRequestNo;
            this.SettleAmount = settleAmount;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 本笔跨境结算使用的汇率，精度 8 位小数
        /// </summary>
        /// <value>本笔跨境结算使用的汇率，精度 8 位小数</value>
        [DataMember(Name = "exchange_rate", EmitDefaultValue = false)]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 本次跨境结算的实际结算外币金额
        /// </summary>
        /// <value>本次跨境结算的实际结算外币金额</value>
        [DataMember(Name = "foreign_settle_amount", EmitDefaultValue = false)]
        public string ForeignSettleAmount { get; set; }

        /// <summary>
        /// 本笔跨境结算实际结算的外币币种
        /// </summary>
        /// <value>本笔跨境结算实际结算的外币币种</value>
        [DataMember(Name = "foreign_settle_currency", EmitDefaultValue = false)]
        public string ForeignSettleCurrency { get; set; }

        /// <summary>
        /// 请求流水号，开发者自行生成并保证唯一性，作为业务幂等性控制
        /// </summary>
        /// <value>请求流水号，开发者自行生成并保证唯一性，作为业务幂等性控制</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次跨境结算的实际结算人民币金额
        /// </summary>
        /// <value>本次跨境结算的实际结算人民币金额</value>
        [DataMember(Name = "settle_amount", EmitDefaultValue = false)]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        /// <value>支付宝交易号</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeOverseasSettleResponseModel {\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  ForeignSettleAmount: ").Append(ForeignSettleAmount).Append("\n");
            sb.Append("  ForeignSettleCurrency: ").Append(ForeignSettleCurrency).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  SettleAmount: ").Append(SettleAmount).Append("\n");
            sb.Append("  TradeNo: ").Append(TradeNo).Append("\n");
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
            return this.Equals(input as AlipayTradeOverseasSettleResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeOverseasSettleResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeOverseasSettleResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeOverseasSettleResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.ForeignSettleAmount == input.ForeignSettleAmount ||
                    (this.ForeignSettleAmount != null &&
                    this.ForeignSettleAmount.Equals(input.ForeignSettleAmount))
                ) && 
                (
                    this.ForeignSettleCurrency == input.ForeignSettleCurrency ||
                    (this.ForeignSettleCurrency != null &&
                    this.ForeignSettleCurrency.Equals(input.ForeignSettleCurrency))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.SettleAmount == input.SettleAmount ||
                    (this.SettleAmount != null &&
                    this.SettleAmount.Equals(input.SettleAmount))
                ) && 
                (
                    this.TradeNo == input.TradeNo ||
                    (this.TradeNo != null &&
                    this.TradeNo.Equals(input.TradeNo))
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
                if (this.ExchangeRate != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeRate.GetHashCode();
                }
                if (this.ForeignSettleAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignSettleAmount.GetHashCode();
                }
                if (this.ForeignSettleCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.ForeignSettleCurrency.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.SettleAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SettleAmount.GetHashCode();
                }
                if (this.TradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNo.GetHashCode();
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
