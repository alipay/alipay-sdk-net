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
    /// Invoice
    /// </summary>
    [DataContract(Name = "Invoice")]
    public partial class Invoice : IEquatable<Invoice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        /// <param name="email">邮箱地址.</param>
        /// <param name="invoiceContent">发票内容，配送服务费.</param>
        /// <param name="invoiceFee">发票金额.</param>
        /// <param name="invoiceTitle">发票抬头，如支付宝（杭州）信息技术有限公司.</param>
        /// <param name="invoiceType">发票类型，0：默认电子发票.</param>
        /// <param name="phone">手机号码.</param>
        /// <param name="receiver">收件人姓名.</param>
        /// <param name="taxNumber">税号.</param>
        /// <param name="titleType">抬头类型，0：企业单位，1：个人/非企业.</param>
        public Invoice(string email = default(string), string invoiceContent = default(string), string invoiceFee = default(string), string invoiceTitle = default(string), int invoiceType = default(int), string phone = default(string), string receiver = default(string), string taxNumber = default(string), int titleType = default(int))
        {
            this.Email = email;
            this.InvoiceContent = invoiceContent;
            this.InvoiceFee = invoiceFee;
            this.InvoiceTitle = invoiceTitle;
            this.InvoiceType = invoiceType;
            this.Phone = phone;
            this.Receiver = receiver;
            this.TaxNumber = taxNumber;
            this.TitleType = titleType;
        }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        /// <value>邮箱地址</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// 发票内容，配送服务费
        /// </summary>
        /// <value>发票内容，配送服务费</value>
        [DataMember(Name = "invoice_content", EmitDefaultValue = false)]
        public string InvoiceContent { get; set; }

        /// <summary>
        /// 发票金额
        /// </summary>
        /// <value>发票金额</value>
        [DataMember(Name = "invoice_fee", EmitDefaultValue = false)]
        public string InvoiceFee { get; set; }

        /// <summary>
        /// 发票抬头，如支付宝（杭州）信息技术有限公司
        /// </summary>
        /// <value>发票抬头，如支付宝（杭州）信息技术有限公司</value>
        [DataMember(Name = "invoice_title", EmitDefaultValue = false)]
        public string InvoiceTitle { get; set; }

        /// <summary>
        /// 发票类型，0：默认电子发票
        /// </summary>
        /// <value>发票类型，0：默认电子发票</value>
        [DataMember(Name = "invoice_type", EmitDefaultValue = false)]
        public int InvoiceType { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        /// <value>手机号码</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        /// <value>收件人姓名</value>
        [DataMember(Name = "receiver", EmitDefaultValue = false)]
        public string Receiver { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        /// <value>税号</value>
        [DataMember(Name = "tax_number", EmitDefaultValue = false)]
        public string TaxNumber { get; set; }

        /// <summary>
        /// 抬头类型，0：企业单位，1：个人/非企业
        /// </summary>
        /// <value>抬头类型，0：企业单位，1：个人/非企业</value>
        [DataMember(Name = "title_type", EmitDefaultValue = false)]
        public int TitleType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Invoice {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  InvoiceContent: ").Append(InvoiceContent).Append("\n");
            sb.Append("  InvoiceFee: ").Append(InvoiceFee).Append("\n");
            sb.Append("  InvoiceTitle: ").Append(InvoiceTitle).Append("\n");
            sb.Append("  InvoiceType: ").Append(InvoiceType).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
            sb.Append("  TitleType: ").Append(TitleType).Append("\n");
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
            return this.Equals(input as Invoice);
        }

        /// <summary>
        /// Returns true if Invoice instances are equal
        /// </summary>
        /// <param name="input">Instance of Invoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Invoice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.InvoiceContent == input.InvoiceContent ||
                    (this.InvoiceContent != null &&
                    this.InvoiceContent.Equals(input.InvoiceContent))
                ) && 
                (
                    this.InvoiceFee == input.InvoiceFee ||
                    (this.InvoiceFee != null &&
                    this.InvoiceFee.Equals(input.InvoiceFee))
                ) && 
                (
                    this.InvoiceTitle == input.InvoiceTitle ||
                    (this.InvoiceTitle != null &&
                    this.InvoiceTitle.Equals(input.InvoiceTitle))
                ) && 
                (
                    this.InvoiceType == input.InvoiceType ||
                    this.InvoiceType.Equals(input.InvoiceType)
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
                ) && 
                (
                    this.TaxNumber == input.TaxNumber ||
                    (this.TaxNumber != null &&
                    this.TaxNumber.Equals(input.TaxNumber))
                ) && 
                (
                    this.TitleType == input.TitleType ||
                    this.TitleType.Equals(input.TitleType)
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.InvoiceContent != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceContent.GetHashCode();
                }
                if (this.InvoiceFee != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceFee.GetHashCode();
                }
                if (this.InvoiceTitle != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceTitle.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvoiceType.GetHashCode();
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.Receiver != null)
                {
                    hashCode = (hashCode * 59) + this.Receiver.GetHashCode();
                }
                if (this.TaxNumber != null)
                {
                    hashCode = (hashCode * 59) + this.TaxNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TitleType.GetHashCode();
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
