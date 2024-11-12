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
    /// ConfigInfoBean
    /// </summary>
    [DataContract(Name = "ConfigInfoBean")]
    public partial class ConfigInfoBean : IEquatable<ConfigInfoBean>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigInfoBean" /> class.
        /// </summary>
        /// <param name="attachmentExplain">attachmentExplain.</param>
        /// <param name="autoArchive">签署完成是否自动归档，默认true，如果false，则归档需要调用签署流程归档接口.</param>
        /// <param name="collectAttachement">是否收集附件（需签署人上传身份证或者其他文件的，需设置为true）.</param>
        /// <param name="companyNo">物流公司编号（目前仅支持顺丰\&quot;SF\&quot;） 注：避免影响生产订单，联调及测试环境请传入SF_TEST。.</param>
        /// <param name="contractValidity">合同过期时间：该参数设置的时间若到期，则会触发流程文件过期通知.</param>
        /// <param name="jumpUrl">签署完成后跳转商户小程序的地址（signModel字段值为2时 选填）.</param>
        /// <param name="merchantMiniSignUrl">商户小程序签署地址（signModel字段值为1时 必填）.</param>
        /// <param name="noticeDeveloperUrl">https://esign.cn/callback.</param>
        /// <param name="platformOrderNo">平台订单号，可将商户订单与电子合同进行关联。用户通过支付宝官方小程序 合同管家 查看合同时，可快速进入商家的小程序及对应的订单详情页，为商家的小程序提供了流量入口，提高用户的活跃度和留存率；.</param>
        /// <param name="serialNo">12或15位物流单号.</param>
        /// <param name="signModel">快递扫码签收方式： 1-商户小程序：扫码后跳转商户小程序进行签收； 0-e签宝小程序：如商户没有支付宝小程序，可使用e签宝小程序完成签收。.</param>
        /// <param name="specifyAttachmentInfos">指定签署人需要上传的附件列表，例如：A、B、C三方签署，A需上传附件1，B需指定附件2，C需上传附件1,2,3.</param>
        public ConfigInfoBean(AttachmentExplainBean attachmentExplain = default(AttachmentExplainBean), bool autoArchive = default(bool), bool collectAttachement = default(bool), string companyNo = default(string), int contractValidity = default(int), string jumpUrl = default(string), string merchantMiniSignUrl = default(string), string noticeDeveloperUrl = default(string), string platformOrderNo = default(string), string serialNo = default(string), int signModel = default(int), List<SpecifyAttachmentInfo> specifyAttachmentInfos = default(List<SpecifyAttachmentInfo>))
        {
            this.AttachmentExplain = attachmentExplain;
            this.AutoArchive = autoArchive;
            this.CollectAttachement = collectAttachement;
            this.CompanyNo = companyNo;
            this.ContractValidity = contractValidity;
            this.JumpUrl = jumpUrl;
            this.MerchantMiniSignUrl = merchantMiniSignUrl;
            this.NoticeDeveloperUrl = noticeDeveloperUrl;
            this.PlatformOrderNo = platformOrderNo;
            this.SerialNo = serialNo;
            this.SignModel = signModel;
            this.SpecifyAttachmentInfos = specifyAttachmentInfos;
        }

        /// <summary>
        /// Gets or Sets AttachmentExplain
        /// </summary>
        [DataMember(Name = "attachment_explain", EmitDefaultValue = false)]
        public AttachmentExplainBean AttachmentExplain { get; set; }

        /// <summary>
        /// 签署完成是否自动归档，默认true，如果false，则归档需要调用签署流程归档接口
        /// </summary>
        /// <value>签署完成是否自动归档，默认true，如果false，则归档需要调用签署流程归档接口</value>
        [DataMember(Name = "auto_archive", EmitDefaultValue = true)]
        public bool AutoArchive { get; set; }

        /// <summary>
        /// 是否收集附件（需签署人上传身份证或者其他文件的，需设置为true）
        /// </summary>
        /// <value>是否收集附件（需签署人上传身份证或者其他文件的，需设置为true）</value>
        [DataMember(Name = "collect_attachement", EmitDefaultValue = true)]
        public bool CollectAttachement { get; set; }

        /// <summary>
        /// 物流公司编号（目前仅支持顺丰\&quot;SF\&quot;） 注：避免影响生产订单，联调及测试环境请传入SF_TEST。
        /// </summary>
        /// <value>物流公司编号（目前仅支持顺丰\&quot;SF\&quot;） 注：避免影响生产订单，联调及测试环境请传入SF_TEST。</value>
        [DataMember(Name = "company_no", EmitDefaultValue = false)]
        public string CompanyNo { get; set; }

        /// <summary>
        /// 合同过期时间：该参数设置的时间若到期，则会触发流程文件过期通知
        /// </summary>
        /// <value>合同过期时间：该参数设置的时间若到期，则会触发流程文件过期通知</value>
        [DataMember(Name = "contract_validity", EmitDefaultValue = false)]
        public int ContractValidity { get; set; }

        /// <summary>
        /// 签署完成后跳转商户小程序的地址（signModel字段值为2时 选填）
        /// </summary>
        /// <value>签署完成后跳转商户小程序的地址（signModel字段值为2时 选填）</value>
        [DataMember(Name = "jump_url", EmitDefaultValue = false)]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 商户小程序签署地址（signModel字段值为1时 必填）
        /// </summary>
        /// <value>商户小程序签署地址（signModel字段值为1时 必填）</value>
        [DataMember(Name = "merchant_mini_sign_url", EmitDefaultValue = false)]
        public string MerchantMiniSignUrl { get; set; }

        /// <summary>
        /// https://esign.cn/callback
        /// </summary>
        /// <value>https://esign.cn/callback</value>
        [DataMember(Name = "notice_developer_url", EmitDefaultValue = false)]
        public string NoticeDeveloperUrl { get; set; }

        /// <summary>
        /// 平台订单号，可将商户订单与电子合同进行关联。用户通过支付宝官方小程序 合同管家 查看合同时，可快速进入商家的小程序及对应的订单详情页，为商家的小程序提供了流量入口，提高用户的活跃度和留存率；
        /// </summary>
        /// <value>平台订单号，可将商户订单与电子合同进行关联。用户通过支付宝官方小程序 合同管家 查看合同时，可快速进入商家的小程序及对应的订单详情页，为商家的小程序提供了流量入口，提高用户的活跃度和留存率；</value>
        [DataMember(Name = "platform_order_no", EmitDefaultValue = false)]
        public string PlatformOrderNo { get; set; }

        /// <summary>
        /// 12或15位物流单号
        /// </summary>
        /// <value>12或15位物流单号</value>
        [DataMember(Name = "serial_no", EmitDefaultValue = false)]
        public string SerialNo { get; set; }

        /// <summary>
        /// 快递扫码签收方式： 1-商户小程序：扫码后跳转商户小程序进行签收； 0-e签宝小程序：如商户没有支付宝小程序，可使用e签宝小程序完成签收。
        /// </summary>
        /// <value>快递扫码签收方式： 1-商户小程序：扫码后跳转商户小程序进行签收； 0-e签宝小程序：如商户没有支付宝小程序，可使用e签宝小程序完成签收。</value>
        [DataMember(Name = "sign_model", EmitDefaultValue = false)]
        public int SignModel { get; set; }

        /// <summary>
        /// 指定签署人需要上传的附件列表，例如：A、B、C三方签署，A需上传附件1，B需指定附件2，C需上传附件1,2,3
        /// </summary>
        /// <value>指定签署人需要上传的附件列表，例如：A、B、C三方签署，A需上传附件1，B需指定附件2，C需上传附件1,2,3</value>
        [DataMember(Name = "specify_attachment_infos", EmitDefaultValue = false)]
        public List<SpecifyAttachmentInfo> SpecifyAttachmentInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConfigInfoBean {\n");
            sb.Append("  AttachmentExplain: ").Append(AttachmentExplain).Append("\n");
            sb.Append("  AutoArchive: ").Append(AutoArchive).Append("\n");
            sb.Append("  CollectAttachement: ").Append(CollectAttachement).Append("\n");
            sb.Append("  CompanyNo: ").Append(CompanyNo).Append("\n");
            sb.Append("  ContractValidity: ").Append(ContractValidity).Append("\n");
            sb.Append("  JumpUrl: ").Append(JumpUrl).Append("\n");
            sb.Append("  MerchantMiniSignUrl: ").Append(MerchantMiniSignUrl).Append("\n");
            sb.Append("  NoticeDeveloperUrl: ").Append(NoticeDeveloperUrl).Append("\n");
            sb.Append("  PlatformOrderNo: ").Append(PlatformOrderNo).Append("\n");
            sb.Append("  SerialNo: ").Append(SerialNo).Append("\n");
            sb.Append("  SignModel: ").Append(SignModel).Append("\n");
            sb.Append("  SpecifyAttachmentInfos: ").Append(SpecifyAttachmentInfos).Append("\n");
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
            return this.Equals(input as ConfigInfoBean);
        }

        /// <summary>
        /// Returns true if ConfigInfoBean instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigInfoBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigInfoBean input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AttachmentExplain == input.AttachmentExplain ||
                    (this.AttachmentExplain != null &&
                    this.AttachmentExplain.Equals(input.AttachmentExplain))
                ) && 
                (
                    this.AutoArchive == input.AutoArchive ||
                    this.AutoArchive.Equals(input.AutoArchive)
                ) && 
                (
                    this.CollectAttachement == input.CollectAttachement ||
                    this.CollectAttachement.Equals(input.CollectAttachement)
                ) && 
                (
                    this.CompanyNo == input.CompanyNo ||
                    (this.CompanyNo != null &&
                    this.CompanyNo.Equals(input.CompanyNo))
                ) && 
                (
                    this.ContractValidity == input.ContractValidity ||
                    this.ContractValidity.Equals(input.ContractValidity)
                ) && 
                (
                    this.JumpUrl == input.JumpUrl ||
                    (this.JumpUrl != null &&
                    this.JumpUrl.Equals(input.JumpUrl))
                ) && 
                (
                    this.MerchantMiniSignUrl == input.MerchantMiniSignUrl ||
                    (this.MerchantMiniSignUrl != null &&
                    this.MerchantMiniSignUrl.Equals(input.MerchantMiniSignUrl))
                ) && 
                (
                    this.NoticeDeveloperUrl == input.NoticeDeveloperUrl ||
                    (this.NoticeDeveloperUrl != null &&
                    this.NoticeDeveloperUrl.Equals(input.NoticeDeveloperUrl))
                ) && 
                (
                    this.PlatformOrderNo == input.PlatformOrderNo ||
                    (this.PlatformOrderNo != null &&
                    this.PlatformOrderNo.Equals(input.PlatformOrderNo))
                ) && 
                (
                    this.SerialNo == input.SerialNo ||
                    (this.SerialNo != null &&
                    this.SerialNo.Equals(input.SerialNo))
                ) && 
                (
                    this.SignModel == input.SignModel ||
                    this.SignModel.Equals(input.SignModel)
                ) && 
                (
                    this.SpecifyAttachmentInfos == input.SpecifyAttachmentInfos ||
                    this.SpecifyAttachmentInfos != null &&
                    input.SpecifyAttachmentInfos != null &&
                    this.SpecifyAttachmentInfos.SequenceEqual(input.SpecifyAttachmentInfos)
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
                if (this.AttachmentExplain != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentExplain.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AutoArchive.GetHashCode();
                hashCode = (hashCode * 59) + this.CollectAttachement.GetHashCode();
                if (this.CompanyNo != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyNo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ContractValidity.GetHashCode();
                if (this.JumpUrl != null)
                {
                    hashCode = (hashCode * 59) + this.JumpUrl.GetHashCode();
                }
                if (this.MerchantMiniSignUrl != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantMiniSignUrl.GetHashCode();
                }
                if (this.NoticeDeveloperUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NoticeDeveloperUrl.GetHashCode();
                }
                if (this.PlatformOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.PlatformOrderNo.GetHashCode();
                }
                if (this.SerialNo != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SignModel.GetHashCode();
                if (this.SpecifyAttachmentInfos != null)
                {
                    hashCode = (hashCode * 59) + this.SpecifyAttachmentInfos.GetHashCode();
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
