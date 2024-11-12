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
    /// AlipayBossFncInvoiceBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayBossFncInvoiceBatchqueryModel")]
    public partial class AlipayBossFncInvoiceBatchqueryModel : IEquatable<AlipayBossFncInvoiceBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayBossFncInvoiceBatchqueryModel" /> class.
        /// </summary>
        /// <param name="applyOrderId">开票申请ID，唯一标识开票申请表的ID.</param>
        /// <param name="buyerInvoiceTitle">买方发票抬头，用于打印在发票上.</param>
        /// <param name="buyerIpid">对应发票商户的ipId，在主站标示mid，在其他环境标示ip_id。.</param>
        /// <param name="buyerIpids">购方商户ID集合.</param>
        /// <param name="buyerIproleId">商户结算的ipRoleId，表示商户的结算对象，在主站表示pid。.</param>
        /// <param name="buyerIproleIds">购方PID集合.</param>
        /// <param name="instId">对应发票所在OU的id，用于标示该发票所述的OU。.</param>
        /// <param name="invoiceChannel">开票渠道 01 线上;02 线下.</param>
        /// <param name="invoiceCode">发票代码，税务部门给予发票的编码.</param>
        /// <param name="invoiceCreateDateBegin">发票创建日期【起始日期，格式yyyyMMdd】.</param>
        /// <param name="invoiceCreateDateEnd">发票创建日期【结束日期，格式yyyyMMdd】.</param>
        /// <param name="invoiceIds">发票ID集合，发票ID，唯一标示一张发票的ID.</param>
        /// <param name="invoiceMaterial">开票介质 01电子 02纸质.</param>
        /// <param name="invoiceNo">发票号码，税务部门给予发票的编码.</param>
        /// <param name="invoiceOpenDateBegin">发票开票日期【起始日期，格式yyyyMMdd】.</param>
        /// <param name="invoiceOpenDateEnd">发票开票日期【结束日期，格式yyyyMMdd】.</param>
        /// <param name="invoiceStatus">发票状态：用于标示发票当前的状态，状态类型以及相关含义：01 待开票;02 开票中;03 已开票;04 作废中;05 已作废;06 红冲中;07 已红冲;08 部分红冲;09 无效.</param>
        /// <param name="invoiceTypes">发票类型,01专票 02普票 03营业税发票 04国际形式发票 05其它发票.</param>
        /// <param name="isOnline">是否能在线开票 Y能 N不能.</param>
        /// <param name="isRed">是否红字 Y红字 N蓝字.</param>
        /// <param name="mailStatus">邮寄状态 01 待邮寄;02 已邮寄;03 退回中;04 已退回.</param>
        /// <param name="monthlyBillNo">月账单号.</param>
        /// <param name="pageNo">起始页，分页时必须提供.</param>
        /// <param name="pageSize">每页显示数，分页时必须提供.</param>
        /// <param name="trackingNo">快递单号.</param>
        public AlipayBossFncInvoiceBatchqueryModel(string applyOrderId = default(string), string buyerInvoiceTitle = default(string), string buyerIpid = default(string), List<string> buyerIpids = default(List<string>), string buyerIproleId = default(string), List<string> buyerIproleIds = default(List<string>), string instId = default(string), string invoiceChannel = default(string), string invoiceCode = default(string), string invoiceCreateDateBegin = default(string), string invoiceCreateDateEnd = default(string), List<string> invoiceIds = default(List<string>), string invoiceMaterial = default(string), string invoiceNo = default(string), string invoiceOpenDateBegin = default(string), string invoiceOpenDateEnd = default(string), List<string> invoiceStatus = default(List<string>), List<string> invoiceTypes = default(List<string>), string isOnline = default(string), string isRed = default(string), List<string> mailStatus = default(List<string>), string monthlyBillNo = default(string), int pageNo = default(int), int pageSize = default(int), string trackingNo = default(string))
        {
            this.ApplyOrderId = applyOrderId;
            this.BuyerInvoiceTitle = buyerInvoiceTitle;
            this.BuyerIpid = buyerIpid;
            this.BuyerIpids = buyerIpids;
            this.BuyerIproleId = buyerIproleId;
            this.BuyerIproleIds = buyerIproleIds;
            this.InstId = instId;
            this.InvoiceChannel = invoiceChannel;
            this.InvoiceCode = invoiceCode;
            this.InvoiceCreateDateBegin = invoiceCreateDateBegin;
            this.InvoiceCreateDateEnd = invoiceCreateDateEnd;
            this.InvoiceIds = invoiceIds;
            this.InvoiceMaterial = invoiceMaterial;
            this.InvoiceNo = invoiceNo;
            this.InvoiceOpenDateBegin = invoiceOpenDateBegin;
            this.InvoiceOpenDateEnd = invoiceOpenDateEnd;
            this.InvoiceStatus = invoiceStatus;
            this.InvoiceTypes = invoiceTypes;
            this.IsOnline = isOnline;
            this.IsRed = isRed;
            this.MailStatus = mailStatus;
            this.MonthlyBillNo = monthlyBillNo;
            this.PageNo = pageNo;
            this.PageSize = pageSize;
            this.TrackingNo = trackingNo;
        }

        /// <summary>
        /// 开票申请ID，唯一标识开票申请表的ID
        /// </summary>
        /// <value>开票申请ID，唯一标识开票申请表的ID</value>
        [DataMember(Name = "apply_order_id", EmitDefaultValue = false)]
        public string ApplyOrderId { get; set; }

        /// <summary>
        /// 买方发票抬头，用于打印在发票上
        /// </summary>
        /// <value>买方发票抬头，用于打印在发票上</value>
        [DataMember(Name = "buyer_invoice_title", EmitDefaultValue = false)]
        public string BuyerInvoiceTitle { get; set; }

        /// <summary>
        /// 对应发票商户的ipId，在主站标示mid，在其他环境标示ip_id。
        /// </summary>
        /// <value>对应发票商户的ipId，在主站标示mid，在其他环境标示ip_id。</value>
        [DataMember(Name = "buyer_ipid", EmitDefaultValue = false)]
        public string BuyerIpid { get; set; }

        /// <summary>
        /// 购方商户ID集合
        /// </summary>
        /// <value>购方商户ID集合</value>
        [DataMember(Name = "buyer_ipids", EmitDefaultValue = false)]
        public List<string> BuyerIpids { get; set; }

        /// <summary>
        /// 商户结算的ipRoleId，表示商户的结算对象，在主站表示pid。
        /// </summary>
        /// <value>商户结算的ipRoleId，表示商户的结算对象，在主站表示pid。</value>
        [DataMember(Name = "buyer_iprole_id", EmitDefaultValue = false)]
        public string BuyerIproleId { get; set; }

        /// <summary>
        /// 购方PID集合
        /// </summary>
        /// <value>购方PID集合</value>
        [DataMember(Name = "buyer_iprole_ids", EmitDefaultValue = false)]
        public List<string> BuyerIproleIds { get; set; }

        /// <summary>
        /// 对应发票所在OU的id，用于标示该发票所述的OU。
        /// </summary>
        /// <value>对应发票所在OU的id，用于标示该发票所述的OU。</value>
        [DataMember(Name = "inst_id", EmitDefaultValue = false)]
        public string InstId { get; set; }

        /// <summary>
        /// 开票渠道 01 线上;02 线下
        /// </summary>
        /// <value>开票渠道 01 线上;02 线下</value>
        [DataMember(Name = "invoice_channel", EmitDefaultValue = false)]
        public string InvoiceChannel { get; set; }

        /// <summary>
        /// 发票代码，税务部门给予发票的编码
        /// </summary>
        /// <value>发票代码，税务部门给予发票的编码</value>
        [DataMember(Name = "invoice_code", EmitDefaultValue = false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票创建日期【起始日期，格式yyyyMMdd】
        /// </summary>
        /// <value>发票创建日期【起始日期，格式yyyyMMdd】</value>
        [DataMember(Name = "invoice_create_date_begin", EmitDefaultValue = false)]
        public string InvoiceCreateDateBegin { get; set; }

        /// <summary>
        /// 发票创建日期【结束日期，格式yyyyMMdd】
        /// </summary>
        /// <value>发票创建日期【结束日期，格式yyyyMMdd】</value>
        [DataMember(Name = "invoice_create_date_end", EmitDefaultValue = false)]
        public string InvoiceCreateDateEnd { get; set; }

        /// <summary>
        /// 发票ID集合，发票ID，唯一标示一张发票的ID
        /// </summary>
        /// <value>发票ID集合，发票ID，唯一标示一张发票的ID</value>
        [DataMember(Name = "invoice_ids", EmitDefaultValue = false)]
        public List<string> InvoiceIds { get; set; }

        /// <summary>
        /// 开票介质 01电子 02纸质
        /// </summary>
        /// <value>开票介质 01电子 02纸质</value>
        [DataMember(Name = "invoice_material", EmitDefaultValue = false)]
        public string InvoiceMaterial { get; set; }

        /// <summary>
        /// 发票号码，税务部门给予发票的编码
        /// </summary>
        /// <value>发票号码，税务部门给予发票的编码</value>
        [DataMember(Name = "invoice_no", EmitDefaultValue = false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票开票日期【起始日期，格式yyyyMMdd】
        /// </summary>
        /// <value>发票开票日期【起始日期，格式yyyyMMdd】</value>
        [DataMember(Name = "invoice_open_date_begin", EmitDefaultValue = false)]
        public string InvoiceOpenDateBegin { get; set; }

        /// <summary>
        /// 发票开票日期【结束日期，格式yyyyMMdd】
        /// </summary>
        /// <value>发票开票日期【结束日期，格式yyyyMMdd】</value>
        [DataMember(Name = "invoice_open_date_end", EmitDefaultValue = false)]
        public string InvoiceOpenDateEnd { get; set; }

        /// <summary>
        /// 发票状态：用于标示发票当前的状态，状态类型以及相关含义：01 待开票;02 开票中;03 已开票;04 作废中;05 已作废;06 红冲中;07 已红冲;08 部分红冲;09 无效
        /// </summary>
        /// <value>发票状态：用于标示发票当前的状态，状态类型以及相关含义：01 待开票;02 开票中;03 已开票;04 作废中;05 已作废;06 红冲中;07 已红冲;08 部分红冲;09 无效</value>
        [DataMember(Name = "invoice_status", EmitDefaultValue = false)]
        public List<string> InvoiceStatus { get; set; }

        /// <summary>
        /// 发票类型,01专票 02普票 03营业税发票 04国际形式发票 05其它发票
        /// </summary>
        /// <value>发票类型,01专票 02普票 03营业税发票 04国际形式发票 05其它发票</value>
        [DataMember(Name = "invoice_types", EmitDefaultValue = false)]
        public List<string> InvoiceTypes { get; set; }

        /// <summary>
        /// 是否能在线开票 Y能 N不能
        /// </summary>
        /// <value>是否能在线开票 Y能 N不能</value>
        [DataMember(Name = "is_online", EmitDefaultValue = false)]
        public string IsOnline { get; set; }

        /// <summary>
        /// 是否红字 Y红字 N蓝字
        /// </summary>
        /// <value>是否红字 Y红字 N蓝字</value>
        [DataMember(Name = "is_red", EmitDefaultValue = false)]
        public string IsRed { get; set; }

        /// <summary>
        /// 邮寄状态 01 待邮寄;02 已邮寄;03 退回中;04 已退回
        /// </summary>
        /// <value>邮寄状态 01 待邮寄;02 已邮寄;03 退回中;04 已退回</value>
        [DataMember(Name = "mail_status", EmitDefaultValue = false)]
        public List<string> MailStatus { get; set; }

        /// <summary>
        /// 月账单号
        /// </summary>
        /// <value>月账单号</value>
        [DataMember(Name = "monthly_bill_no", EmitDefaultValue = false)]
        public string MonthlyBillNo { get; set; }

        /// <summary>
        /// 起始页，分页时必须提供
        /// </summary>
        /// <value>起始页，分页时必须提供</value>
        [DataMember(Name = "page_no", EmitDefaultValue = false)]
        public int PageNo { get; set; }

        /// <summary>
        /// 每页显示数，分页时必须提供
        /// </summary>
        /// <value>每页显示数，分页时必须提供</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        /// <value>快递单号</value>
        [DataMember(Name = "tracking_no", EmitDefaultValue = false)]
        public string TrackingNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayBossFncInvoiceBatchqueryModel {\n");
            sb.Append("  ApplyOrderId: ").Append(ApplyOrderId).Append("\n");
            sb.Append("  BuyerInvoiceTitle: ").Append(BuyerInvoiceTitle).Append("\n");
            sb.Append("  BuyerIpid: ").Append(BuyerIpid).Append("\n");
            sb.Append("  BuyerIpids: ").Append(BuyerIpids).Append("\n");
            sb.Append("  BuyerIproleId: ").Append(BuyerIproleId).Append("\n");
            sb.Append("  BuyerIproleIds: ").Append(BuyerIproleIds).Append("\n");
            sb.Append("  InstId: ").Append(InstId).Append("\n");
            sb.Append("  InvoiceChannel: ").Append(InvoiceChannel).Append("\n");
            sb.Append("  InvoiceCode: ").Append(InvoiceCode).Append("\n");
            sb.Append("  InvoiceCreateDateBegin: ").Append(InvoiceCreateDateBegin).Append("\n");
            sb.Append("  InvoiceCreateDateEnd: ").Append(InvoiceCreateDateEnd).Append("\n");
            sb.Append("  InvoiceIds: ").Append(InvoiceIds).Append("\n");
            sb.Append("  InvoiceMaterial: ").Append(InvoiceMaterial).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  InvoiceOpenDateBegin: ").Append(InvoiceOpenDateBegin).Append("\n");
            sb.Append("  InvoiceOpenDateEnd: ").Append(InvoiceOpenDateEnd).Append("\n");
            sb.Append("  InvoiceStatus: ").Append(InvoiceStatus).Append("\n");
            sb.Append("  InvoiceTypes: ").Append(InvoiceTypes).Append("\n");
            sb.Append("  IsOnline: ").Append(IsOnline).Append("\n");
            sb.Append("  IsRed: ").Append(IsRed).Append("\n");
            sb.Append("  MailStatus: ").Append(MailStatus).Append("\n");
            sb.Append("  MonthlyBillNo: ").Append(MonthlyBillNo).Append("\n");
            sb.Append("  PageNo: ").Append(PageNo).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TrackingNo: ").Append(TrackingNo).Append("\n");
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
            return this.Equals(input as AlipayBossFncInvoiceBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayBossFncInvoiceBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayBossFncInvoiceBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayBossFncInvoiceBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyOrderId == input.ApplyOrderId ||
                    (this.ApplyOrderId != null &&
                    this.ApplyOrderId.Equals(input.ApplyOrderId))
                ) && 
                (
                    this.BuyerInvoiceTitle == input.BuyerInvoiceTitle ||
                    (this.BuyerInvoiceTitle != null &&
                    this.BuyerInvoiceTitle.Equals(input.BuyerInvoiceTitle))
                ) && 
                (
                    this.BuyerIpid == input.BuyerIpid ||
                    (this.BuyerIpid != null &&
                    this.BuyerIpid.Equals(input.BuyerIpid))
                ) && 
                (
                    this.BuyerIpids == input.BuyerIpids ||
                    this.BuyerIpids != null &&
                    input.BuyerIpids != null &&
                    this.BuyerIpids.SequenceEqual(input.BuyerIpids)
                ) && 
                (
                    this.BuyerIproleId == input.BuyerIproleId ||
                    (this.BuyerIproleId != null &&
                    this.BuyerIproleId.Equals(input.BuyerIproleId))
                ) && 
                (
                    this.BuyerIproleIds == input.BuyerIproleIds ||
                    this.BuyerIproleIds != null &&
                    input.BuyerIproleIds != null &&
                    this.BuyerIproleIds.SequenceEqual(input.BuyerIproleIds)
                ) && 
                (
                    this.InstId == input.InstId ||
                    (this.InstId != null &&
                    this.InstId.Equals(input.InstId))
                ) && 
                (
                    this.InvoiceChannel == input.InvoiceChannel ||
                    (this.InvoiceChannel != null &&
                    this.InvoiceChannel.Equals(input.InvoiceChannel))
                ) && 
                (
                    this.InvoiceCode == input.InvoiceCode ||
                    (this.InvoiceCode != null &&
                    this.InvoiceCode.Equals(input.InvoiceCode))
                ) && 
                (
                    this.InvoiceCreateDateBegin == input.InvoiceCreateDateBegin ||
                    (this.InvoiceCreateDateBegin != null &&
                    this.InvoiceCreateDateBegin.Equals(input.InvoiceCreateDateBegin))
                ) && 
                (
                    this.InvoiceCreateDateEnd == input.InvoiceCreateDateEnd ||
                    (this.InvoiceCreateDateEnd != null &&
                    this.InvoiceCreateDateEnd.Equals(input.InvoiceCreateDateEnd))
                ) && 
                (
                    this.InvoiceIds == input.InvoiceIds ||
                    this.InvoiceIds != null &&
                    input.InvoiceIds != null &&
                    this.InvoiceIds.SequenceEqual(input.InvoiceIds)
                ) && 
                (
                    this.InvoiceMaterial == input.InvoiceMaterial ||
                    (this.InvoiceMaterial != null &&
                    this.InvoiceMaterial.Equals(input.InvoiceMaterial))
                ) && 
                (
                    this.InvoiceNo == input.InvoiceNo ||
                    (this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(input.InvoiceNo))
                ) && 
                (
                    this.InvoiceOpenDateBegin == input.InvoiceOpenDateBegin ||
                    (this.InvoiceOpenDateBegin != null &&
                    this.InvoiceOpenDateBegin.Equals(input.InvoiceOpenDateBegin))
                ) && 
                (
                    this.InvoiceOpenDateEnd == input.InvoiceOpenDateEnd ||
                    (this.InvoiceOpenDateEnd != null &&
                    this.InvoiceOpenDateEnd.Equals(input.InvoiceOpenDateEnd))
                ) && 
                (
                    this.InvoiceStatus == input.InvoiceStatus ||
                    this.InvoiceStatus != null &&
                    input.InvoiceStatus != null &&
                    this.InvoiceStatus.SequenceEqual(input.InvoiceStatus)
                ) && 
                (
                    this.InvoiceTypes == input.InvoiceTypes ||
                    this.InvoiceTypes != null &&
                    input.InvoiceTypes != null &&
                    this.InvoiceTypes.SequenceEqual(input.InvoiceTypes)
                ) && 
                (
                    this.IsOnline == input.IsOnline ||
                    (this.IsOnline != null &&
                    this.IsOnline.Equals(input.IsOnline))
                ) && 
                (
                    this.IsRed == input.IsRed ||
                    (this.IsRed != null &&
                    this.IsRed.Equals(input.IsRed))
                ) && 
                (
                    this.MailStatus == input.MailStatus ||
                    this.MailStatus != null &&
                    input.MailStatus != null &&
                    this.MailStatus.SequenceEqual(input.MailStatus)
                ) && 
                (
                    this.MonthlyBillNo == input.MonthlyBillNo ||
                    (this.MonthlyBillNo != null &&
                    this.MonthlyBillNo.Equals(input.MonthlyBillNo))
                ) && 
                (
                    this.PageNo == input.PageNo ||
                    this.PageNo.Equals(input.PageNo)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.TrackingNo == input.TrackingNo ||
                    (this.TrackingNo != null &&
                    this.TrackingNo.Equals(input.TrackingNo))
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
                if (this.ApplyOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyOrderId.GetHashCode();
                }
                if (this.BuyerInvoiceTitle != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerInvoiceTitle.GetHashCode();
                }
                if (this.BuyerIpid != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerIpid.GetHashCode();
                }
                if (this.BuyerIpids != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerIpids.GetHashCode();
                }
                if (this.BuyerIproleId != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerIproleId.GetHashCode();
                }
                if (this.BuyerIproleIds != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerIproleIds.GetHashCode();
                }
                if (this.InstId != null)
                {
                    hashCode = (hashCode * 59) + this.InstId.GetHashCode();
                }
                if (this.InvoiceChannel != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceChannel.GetHashCode();
                }
                if (this.InvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCode.GetHashCode();
                }
                if (this.InvoiceCreateDateBegin != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCreateDateBegin.GetHashCode();
                }
                if (this.InvoiceCreateDateEnd != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCreateDateEnd.GetHashCode();
                }
                if (this.InvoiceIds != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceIds.GetHashCode();
                }
                if (this.InvoiceMaterial != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceMaterial.GetHashCode();
                }
                if (this.InvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNo.GetHashCode();
                }
                if (this.InvoiceOpenDateBegin != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceOpenDateBegin.GetHashCode();
                }
                if (this.InvoiceOpenDateEnd != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceOpenDateEnd.GetHashCode();
                }
                if (this.InvoiceStatus != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceStatus.GetHashCode();
                }
                if (this.InvoiceTypes != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceTypes.GetHashCode();
                }
                if (this.IsOnline != null)
                {
                    hashCode = (hashCode * 59) + this.IsOnline.GetHashCode();
                }
                if (this.IsRed != null)
                {
                    hashCode = (hashCode * 59) + this.IsRed.GetHashCode();
                }
                if (this.MailStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MailStatus.GetHashCode();
                }
                if (this.MonthlyBillNo != null)
                {
                    hashCode = (hashCode * 59) + this.MonthlyBillNo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNo.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.TrackingNo != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingNo.GetHashCode();
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
