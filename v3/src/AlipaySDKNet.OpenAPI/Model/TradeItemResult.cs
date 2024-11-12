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
    /// TradeItemResult
    /// </summary>
    [DataContract(Name = "TradeItemResult")]
    public partial class TradeItemResult : IEquatable<TradeItemResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeItemResult" /> class.
        /// </summary>
        /// <param name="alipayOrderNo">支付宝订单号。对账使用，不脱敏.</param>
        /// <param name="gmtCreate">交易创建时间.</param>
        /// <param name="gmtPay">交易支付时间.</param>
        /// <param name="gmtRefund">交易退款时间.</param>
        /// <param name="goodsMemo">商品备注信息.</param>
        /// <param name="goodsTitle">商品名称.</param>
        /// <param name="merchantOrderNo">商户订单号，创建支付宝交易时传入的信息。对账使用，不脱敏.</param>
        /// <param name="netMdiscount">商家优惠金额.</param>
        /// <param name="otherAccount">对方账户.</param>
        /// <param name="refundAmount">订单退款金额.</param>
        /// <param name="serviceFee">服务费金额.</param>
        /// <param name="storeName">门店名称.</param>
        /// <param name="storeNo">门店编号.</param>
        /// <param name="totalAmount">订单金额.</param>
        /// <param name="tradeStatus">订单状态(待付款,成功,关闭,待发货,待确认收货,已预付,进行中).</param>
        /// <param name="tradeType">业务类型，帮助商户作为对账参考.</param>
        public TradeItemResult(string alipayOrderNo = default(string), string gmtCreate = default(string), string gmtPay = default(string), string gmtRefund = default(string), string goodsMemo = default(string), string goodsTitle = default(string), string merchantOrderNo = default(string), string netMdiscount = default(string), string otherAccount = default(string), string refundAmount = default(string), string serviceFee = default(string), string storeName = default(string), string storeNo = default(string), string totalAmount = default(string), string tradeStatus = default(string), string tradeType = default(string))
        {
            this.AlipayOrderNo = alipayOrderNo;
            this.GmtCreate = gmtCreate;
            this.GmtPay = gmtPay;
            this.GmtRefund = gmtRefund;
            this.GoodsMemo = goodsMemo;
            this.GoodsTitle = goodsTitle;
            this.MerchantOrderNo = merchantOrderNo;
            this.NetMdiscount = netMdiscount;
            this.OtherAccount = otherAccount;
            this.RefundAmount = refundAmount;
            this.ServiceFee = serviceFee;
            this.StoreName = storeName;
            this.StoreNo = storeNo;
            this.TotalAmount = totalAmount;
            this.TradeStatus = tradeStatus;
            this.TradeType = tradeType;
        }

        /// <summary>
        /// 支付宝订单号。对账使用，不脱敏
        /// </summary>
        /// <value>支付宝订单号。对账使用，不脱敏</value>
        [DataMember(Name = "alipay_order_no", EmitDefaultValue = false)]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        /// <value>交易创建时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        /// <value>交易支付时间</value>
        [DataMember(Name = "gmt_pay", EmitDefaultValue = false)]
        public string GmtPay { get; set; }

        /// <summary>
        /// 交易退款时间
        /// </summary>
        /// <value>交易退款时间</value>
        [DataMember(Name = "gmt_refund", EmitDefaultValue = false)]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 商品备注信息
        /// </summary>
        /// <value>商品备注信息</value>
        [DataMember(Name = "goods_memo", EmitDefaultValue = false)]
        public string GoodsMemo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <value>商品名称</value>
        [DataMember(Name = "goods_title", EmitDefaultValue = false)]
        public string GoodsTitle { get; set; }

        /// <summary>
        /// 商户订单号，创建支付宝交易时传入的信息。对账使用，不脱敏
        /// </summary>
        /// <value>商户订单号，创建支付宝交易时传入的信息。对账使用，不脱敏</value>
        [DataMember(Name = "merchant_order_no", EmitDefaultValue = false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        /// <value>商家优惠金额</value>
        [DataMember(Name = "net_mdiscount", EmitDefaultValue = false)]
        public string NetMdiscount { get; set; }

        /// <summary>
        /// 对方账户
        /// </summary>
        /// <value>对方账户</value>
        [DataMember(Name = "other_account", EmitDefaultValue = false)]
        public string OtherAccount { get; set; }

        /// <summary>
        /// 订单退款金额
        /// </summary>
        /// <value>订单退款金额</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 服务费金额
        /// </summary>
        /// <value>服务费金额</value>
        [DataMember(Name = "service_fee", EmitDefaultValue = false)]
        public string ServiceFee { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        /// <value>门店名称</value>
        [DataMember(Name = "store_name", EmitDefaultValue = false)]
        public string StoreName { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        /// <value>门店编号</value>
        [DataMember(Name = "store_no", EmitDefaultValue = false)]
        public string StoreNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        /// <value>订单金额</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 订单状态(待付款,成功,关闭,待发货,待确认收货,已预付,进行中)
        /// </summary>
        /// <value>订单状态(待付款,成功,关闭,待发货,待确认收货,已预付,进行中)</value>
        [DataMember(Name = "trade_status", EmitDefaultValue = false)]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 业务类型，帮助商户作为对账参考
        /// </summary>
        /// <value>业务类型，帮助商户作为对账参考</value>
        [DataMember(Name = "trade_type", EmitDefaultValue = false)]
        public string TradeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradeItemResult {\n");
            sb.Append("  AlipayOrderNo: ").Append(AlipayOrderNo).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtPay: ").Append(GmtPay).Append("\n");
            sb.Append("  GmtRefund: ").Append(GmtRefund).Append("\n");
            sb.Append("  GoodsMemo: ").Append(GoodsMemo).Append("\n");
            sb.Append("  GoodsTitle: ").Append(GoodsTitle).Append("\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  NetMdiscount: ").Append(NetMdiscount).Append("\n");
            sb.Append("  OtherAccount: ").Append(OtherAccount).Append("\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  ServiceFee: ").Append(ServiceFee).Append("\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
            sb.Append("  StoreNo: ").Append(StoreNo).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  TradeStatus: ").Append(TradeStatus).Append("\n");
            sb.Append("  TradeType: ").Append(TradeType).Append("\n");
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
            return this.Equals(input as TradeItemResult);
        }

        /// <summary>
        /// Returns true if TradeItemResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeItemResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeItemResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlipayOrderNo == input.AlipayOrderNo ||
                    (this.AlipayOrderNo != null &&
                    this.AlipayOrderNo.Equals(input.AlipayOrderNo))
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtPay == input.GmtPay ||
                    (this.GmtPay != null &&
                    this.GmtPay.Equals(input.GmtPay))
                ) && 
                (
                    this.GmtRefund == input.GmtRefund ||
                    (this.GmtRefund != null &&
                    this.GmtRefund.Equals(input.GmtRefund))
                ) && 
                (
                    this.GoodsMemo == input.GoodsMemo ||
                    (this.GoodsMemo != null &&
                    this.GoodsMemo.Equals(input.GoodsMemo))
                ) && 
                (
                    this.GoodsTitle == input.GoodsTitle ||
                    (this.GoodsTitle != null &&
                    this.GoodsTitle.Equals(input.GoodsTitle))
                ) && 
                (
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.NetMdiscount == input.NetMdiscount ||
                    (this.NetMdiscount != null &&
                    this.NetMdiscount.Equals(input.NetMdiscount))
                ) && 
                (
                    this.OtherAccount == input.OtherAccount ||
                    (this.OtherAccount != null &&
                    this.OtherAccount.Equals(input.OtherAccount))
                ) && 
                (
                    this.RefundAmount == input.RefundAmount ||
                    (this.RefundAmount != null &&
                    this.RefundAmount.Equals(input.RefundAmount))
                ) && 
                (
                    this.ServiceFee == input.ServiceFee ||
                    (this.ServiceFee != null &&
                    this.ServiceFee.Equals(input.ServiceFee))
                ) && 
                (
                    this.StoreName == input.StoreName ||
                    (this.StoreName != null &&
                    this.StoreName.Equals(input.StoreName))
                ) && 
                (
                    this.StoreNo == input.StoreNo ||
                    (this.StoreNo != null &&
                    this.StoreNo.Equals(input.StoreNo))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.TradeStatus == input.TradeStatus ||
                    (this.TradeStatus != null &&
                    this.TradeStatus.Equals(input.TradeStatus))
                ) && 
                (
                    this.TradeType == input.TradeType ||
                    (this.TradeType != null &&
                    this.TradeType.Equals(input.TradeType))
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
                if (this.AlipayOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayOrderNo.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtPay != null)
                {
                    hashCode = (hashCode * 59) + this.GmtPay.GetHashCode();
                }
                if (this.GmtRefund != null)
                {
                    hashCode = (hashCode * 59) + this.GmtRefund.GetHashCode();
                }
                if (this.GoodsMemo != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsMemo.GetHashCode();
                }
                if (this.GoodsTitle != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsTitle.GetHashCode();
                }
                if (this.MerchantOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantOrderNo.GetHashCode();
                }
                if (this.NetMdiscount != null)
                {
                    hashCode = (hashCode * 59) + this.NetMdiscount.GetHashCode();
                }
                if (this.OtherAccount != null)
                {
                    hashCode = (hashCode * 59) + this.OtherAccount.GetHashCode();
                }
                if (this.RefundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAmount.GetHashCode();
                }
                if (this.ServiceFee != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceFee.GetHashCode();
                }
                if (this.StoreName != null)
                {
                    hashCode = (hashCode * 59) + this.StoreName.GetHashCode();
                }
                if (this.StoreNo != null)
                {
                    hashCode = (hashCode * 59) + this.StoreNo.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                if (this.TradeStatus != null)
                {
                    hashCode = (hashCode * 59) + this.TradeStatus.GetHashCode();
                }
                if (this.TradeType != null)
                {
                    hashCode = (hashCode * 59) + this.TradeType.GetHashCode();
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
