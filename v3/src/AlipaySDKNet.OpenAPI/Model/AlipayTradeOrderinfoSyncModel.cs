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
    /// AlipayTradeOrderinfoSyncModel
    /// </summary>
    [DataContract(Name = "AlipayTradeOrderinfoSyncModel")]
    public partial class AlipayTradeOrderinfoSyncModel : IEquatable<AlipayTradeOrderinfoSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeOrderinfoSyncModel" /> class.
        /// </summary>
        /// <param name="bizType">交易信息同步对应的业务类型，具体值与支付宝约定；  信用授权场景下传CREDIT_AUTH  信用代扣场景下传CREDIT_DEDUCT.</param>
        /// <param name="orderBizInfo">商户传入同步信息，具体值要和支付宝约定；用于芝麻信用租车、单次授权等信息同步场景，格式为json格式。 状态枚举如下：  COMPLETE：同步用户已履约 适用场景：发起扣款后，芝麻生成待履约记录，如果用户通过其他方式完成订单支付，请反馈该状态，芝麻将完结待履约记录对用户形成一条良好履约记录；同步该状态时需要同步调用 取消扣款 接口关闭交易订单。  CLOSED： 同步履约已取消 适用场景：发起扣款后，芝麻生成待履约记录，如果发现该笔扣款无效需要取消，请反馈该状态，芝麻将取消用户待履约记录；同步该状态时需要同步调用 取消扣款 接口关闭交易订单。.</param>
        /// <param name="origRequestNo">原始业务请求单号。如对某一次退款进行履约时，该字段传退款时的退款请求号.</param>
        /// <param name="outRequestNo">外部请求号，商家自定义且保证商家系统中唯一。需要注意的是，支付宝会对外部请求号做幂等控制，如果一笔交易再次使用相同的外部请求号发起请求，订单信息不会更新。.</param>
        /// <param name="tradeNo">支付宝交易号.</param>
        public AlipayTradeOrderinfoSyncModel(string bizType = default(string), string orderBizInfo = default(string), string origRequestNo = default(string), string outRequestNo = default(string), string tradeNo = default(string))
        {
            this.BizType = bizType;
            this.OrderBizInfo = orderBizInfo;
            this.OrigRequestNo = origRequestNo;
            this.OutRequestNo = outRequestNo;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 交易信息同步对应的业务类型，具体值与支付宝约定；  信用授权场景下传CREDIT_AUTH  信用代扣场景下传CREDIT_DEDUCT
        /// </summary>
        /// <value>交易信息同步对应的业务类型，具体值与支付宝约定；  信用授权场景下传CREDIT_AUTH  信用代扣场景下传CREDIT_DEDUCT</value>
        [DataMember(Name = "biz_type", EmitDefaultValue = false)]
        public string BizType { get; set; }

        /// <summary>
        /// 商户传入同步信息，具体值要和支付宝约定；用于芝麻信用租车、单次授权等信息同步场景，格式为json格式。 状态枚举如下：  COMPLETE：同步用户已履约 适用场景：发起扣款后，芝麻生成待履约记录，如果用户通过其他方式完成订单支付，请反馈该状态，芝麻将完结待履约记录对用户形成一条良好履约记录；同步该状态时需要同步调用 取消扣款 接口关闭交易订单。  CLOSED： 同步履约已取消 适用场景：发起扣款后，芝麻生成待履约记录，如果发现该笔扣款无效需要取消，请反馈该状态，芝麻将取消用户待履约记录；同步该状态时需要同步调用 取消扣款 接口关闭交易订单。
        /// </summary>
        /// <value>商户传入同步信息，具体值要和支付宝约定；用于芝麻信用租车、单次授权等信息同步场景，格式为json格式。 状态枚举如下：  COMPLETE：同步用户已履约 适用场景：发起扣款后，芝麻生成待履约记录，如果用户通过其他方式完成订单支付，请反馈该状态，芝麻将完结待履约记录对用户形成一条良好履约记录；同步该状态时需要同步调用 取消扣款 接口关闭交易订单。  CLOSED： 同步履约已取消 适用场景：发起扣款后，芝麻生成待履约记录，如果发现该笔扣款无效需要取消，请反馈该状态，芝麻将取消用户待履约记录；同步该状态时需要同步调用 取消扣款 接口关闭交易订单。</value>
        [DataMember(Name = "order_biz_info", EmitDefaultValue = false)]
        public string OrderBizInfo { get; set; }

        /// <summary>
        /// 原始业务请求单号。如对某一次退款进行履约时，该字段传退款时的退款请求号
        /// </summary>
        /// <value>原始业务请求单号。如对某一次退款进行履约时，该字段传退款时的退款请求号</value>
        [DataMember(Name = "orig_request_no", EmitDefaultValue = false)]
        public string OrigRequestNo { get; set; }

        /// <summary>
        /// 外部请求号，商家自定义且保证商家系统中唯一。需要注意的是，支付宝会对外部请求号做幂等控制，如果一笔交易再次使用相同的外部请求号发起请求，订单信息不会更新。
        /// </summary>
        /// <value>外部请求号，商家自定义且保证商家系统中唯一。需要注意的是，支付宝会对外部请求号做幂等控制，如果一笔交易再次使用相同的外部请求号发起请求，订单信息不会更新。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

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
            sb.Append("class AlipayTradeOrderinfoSyncModel {\n");
            sb.Append("  BizType: ").Append(BizType).Append("\n");
            sb.Append("  OrderBizInfo: ").Append(OrderBizInfo).Append("\n");
            sb.Append("  OrigRequestNo: ").Append(OrigRequestNo).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
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
            return this.Equals(input as AlipayTradeOrderinfoSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeOrderinfoSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeOrderinfoSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeOrderinfoSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizType == input.BizType ||
                    (this.BizType != null &&
                    this.BizType.Equals(input.BizType))
                ) && 
                (
                    this.OrderBizInfo == input.OrderBizInfo ||
                    (this.OrderBizInfo != null &&
                    this.OrderBizInfo.Equals(input.OrderBizInfo))
                ) && 
                (
                    this.OrigRequestNo == input.OrigRequestNo ||
                    (this.OrigRequestNo != null &&
                    this.OrigRequestNo.Equals(input.OrigRequestNo))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
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
                if (this.BizType != null)
                {
                    hashCode = (hashCode * 59) + this.BizType.GetHashCode();
                }
                if (this.OrderBizInfo != null)
                {
                    hashCode = (hashCode * 59) + this.OrderBizInfo.GetHashCode();
                }
                if (this.OrigRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OrigRequestNo.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
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
