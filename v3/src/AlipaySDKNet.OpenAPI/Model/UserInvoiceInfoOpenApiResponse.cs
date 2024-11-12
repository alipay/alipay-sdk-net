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
    /// UserInvoiceInfoOpenApiResponse
    /// </summary>
    [DataContract(Name = "UserInvoiceInfoOpenApiResponse")]
    public partial class UserInvoiceInfoOpenApiResponse : IEquatable<UserInvoiceInfoOpenApiResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvoiceInfoOpenApiResponse" /> class.
        /// </summary>
        /// <param name="acceptElectronic">(AR开票使用)是否接受电子票 true:是，false:否.</param>
        /// <param name="address">公司注册地址.</param>
        /// <param name="auto">(AR开票使用)是否自动申请开票 true:是，false:否.</param>
        /// <param name="bankAccount">银行账户.</param>
        /// <param name="bankName">开户行.</param>
        /// <param name="businessLicenceUrl">营业执照地址.</param>
        /// <param name="creator">资料创建人.</param>
        /// <param name="gmtCreate">创建时间.</param>
        /// <param name="gmtModified">修改时间.</param>
        /// <param name="hold">(AR开票使用)是否暂停开票  true:暂停开票，false:可开票.</param>
        /// <param name="id">开票资料ID.</param>
        /// <param name="ipId">商户PID,  type&#x3D;01时表示OU用户,填充的是InstId机构代码,例如Z50,  type&#x3D;02时表示商户MID,  type&#x3D;03时表示商户PID.</param>
        /// <param name="lastModifier">最后修改人.</param>
        /// <param name="openAccountPermitUrl">银行开户许可证地址.</param>
        /// <param name="otherQualificationUrl">其它资质证明地址.</param>
        /// <param name="status">资料状态，01：待审，02：已审(有效)， 03：已作废.</param>
        /// <param name="taskDate">上一次任务执行时间(针对自动开票场景),格式:YYYYMMDD.</param>
        /// <param name="taxNo">纳税人识别号（购方税号）.</param>
        /// <param name="taxPayerQualification">纳税人开票资格种类  01：一般纳税人，02：小规模纳税人.</param>
        /// <param name="taxQualificationUrl">一般纳税人资格证书地址.</param>
        /// <param name="taxRegCertUrl">税务登记证地址.</param>
        /// <param name="taxpayerQualiValid">纳税人资格开始时间 （时间戳）.</param>
        /// <param name="telephone">公司注册电话.</param>
        /// <param name="title">发票抬头.</param>
        /// <param name="tntInstId">租户ID.</param>
        /// <param name="type">开票资料用户类型   01：OU，02：商户，03：C用户.</param>
        /// <param name="userMailInfoList">收件人地址列表.</param>
        public UserInvoiceInfoOpenApiResponse(bool acceptElectronic = default(bool), string address = default(string), bool auto = default(bool), string bankAccount = default(string), string bankName = default(string), string businessLicenceUrl = default(string), string creator = default(string), string gmtCreate = default(string), string gmtModified = default(string), bool hold = default(bool), string id = default(string), string ipId = default(string), string lastModifier = default(string), string openAccountPermitUrl = default(string), string otherQualificationUrl = default(string), string status = default(string), string taskDate = default(string), string taxNo = default(string), string taxPayerQualification = default(string), string taxQualificationUrl = default(string), string taxRegCertUrl = default(string), string taxpayerQualiValid = default(string), string telephone = default(string), string title = default(string), string tntInstId = default(string), string type = default(string), List<UserMailInfoVO> userMailInfoList = default(List<UserMailInfoVO>))
        {
            this.AcceptElectronic = acceptElectronic;
            this.Address = address;
            this.Auto = auto;
            this.BankAccount = bankAccount;
            this.BankName = bankName;
            this.BusinessLicenceUrl = businessLicenceUrl;
            this.Creator = creator;
            this.GmtCreate = gmtCreate;
            this.GmtModified = gmtModified;
            this.Hold = hold;
            this.Id = id;
            this.IpId = ipId;
            this.LastModifier = lastModifier;
            this.OpenAccountPermitUrl = openAccountPermitUrl;
            this.OtherQualificationUrl = otherQualificationUrl;
            this.Status = status;
            this.TaskDate = taskDate;
            this.TaxNo = taxNo;
            this.TaxPayerQualification = taxPayerQualification;
            this.TaxQualificationUrl = taxQualificationUrl;
            this.TaxRegCertUrl = taxRegCertUrl;
            this.TaxpayerQualiValid = taxpayerQualiValid;
            this.Telephone = telephone;
            this.Title = title;
            this.TntInstId = tntInstId;
            this.Type = type;
            this.UserMailInfoList = userMailInfoList;
        }

        /// <summary>
        /// (AR开票使用)是否接受电子票 true:是，false:否
        /// </summary>
        /// <value>(AR开票使用)是否接受电子票 true:是，false:否</value>
        [DataMember(Name = "accept_electronic", EmitDefaultValue = true)]
        public bool AcceptElectronic { get; set; }

        /// <summary>
        /// 公司注册地址
        /// </summary>
        /// <value>公司注册地址</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// (AR开票使用)是否自动申请开票 true:是，false:否
        /// </summary>
        /// <value>(AR开票使用)是否自动申请开票 true:是，false:否</value>
        [DataMember(Name = "auto", EmitDefaultValue = true)]
        public bool Auto { get; set; }

        /// <summary>
        /// 银行账户
        /// </summary>
        /// <value>银行账户</value>
        [DataMember(Name = "bank_account", EmitDefaultValue = false)]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行
        /// </summary>
        /// <value>开户行</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// 营业执照地址
        /// </summary>
        /// <value>营业执照地址</value>
        [DataMember(Name = "business_licence_url", EmitDefaultValue = false)]
        public string BusinessLicenceUrl { get; set; }

        /// <summary>
        /// 资料创建人
        /// </summary>
        /// <value>资料创建人</value>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        public string Creator { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <value>修改时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// (AR开票使用)是否暂停开票  true:暂停开票，false:可开票
        /// </summary>
        /// <value>(AR开票使用)是否暂停开票  true:暂停开票，false:可开票</value>
        [DataMember(Name = "hold", EmitDefaultValue = true)]
        public bool Hold { get; set; }

        /// <summary>
        /// 开票资料ID
        /// </summary>
        /// <value>开票资料ID</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// 商户PID,  type&#x3D;01时表示OU用户,填充的是InstId机构代码,例如Z50,  type&#x3D;02时表示商户MID,  type&#x3D;03时表示商户PID
        /// </summary>
        /// <value>商户PID,  type&#x3D;01时表示OU用户,填充的是InstId机构代码,例如Z50,  type&#x3D;02时表示商户MID,  type&#x3D;03时表示商户PID</value>
        [DataMember(Name = "ip_id", EmitDefaultValue = false)]
        public string IpId { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        /// <value>最后修改人</value>
        [DataMember(Name = "last_modifier", EmitDefaultValue = false)]
        public string LastModifier { get; set; }

        /// <summary>
        /// 银行开户许可证地址
        /// </summary>
        /// <value>银行开户许可证地址</value>
        [DataMember(Name = "open_account_permit_url", EmitDefaultValue = false)]
        public string OpenAccountPermitUrl { get; set; }

        /// <summary>
        /// 其它资质证明地址
        /// </summary>
        /// <value>其它资质证明地址</value>
        [DataMember(Name = "other_qualification_url", EmitDefaultValue = false)]
        public string OtherQualificationUrl { get; set; }

        /// <summary>
        /// 资料状态，01：待审，02：已审(有效)， 03：已作废
        /// </summary>
        /// <value>资料状态，01：待审，02：已审(有效)， 03：已作废</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 上一次任务执行时间(针对自动开票场景),格式:YYYYMMDD
        /// </summary>
        /// <value>上一次任务执行时间(针对自动开票场景),格式:YYYYMMDD</value>
        [DataMember(Name = "task_date", EmitDefaultValue = false)]
        public string TaskDate { get; set; }

        /// <summary>
        /// 纳税人识别号（购方税号）
        /// </summary>
        /// <value>纳税人识别号（购方税号）</value>
        [DataMember(Name = "tax_no", EmitDefaultValue = false)]
        public string TaxNo { get; set; }

        /// <summary>
        /// 纳税人开票资格种类  01：一般纳税人，02：小规模纳税人
        /// </summary>
        /// <value>纳税人开票资格种类  01：一般纳税人，02：小规模纳税人</value>
        [DataMember(Name = "tax_payer_qualification", EmitDefaultValue = false)]
        public string TaxPayerQualification { get; set; }

        /// <summary>
        /// 一般纳税人资格证书地址
        /// </summary>
        /// <value>一般纳税人资格证书地址</value>
        [DataMember(Name = "tax_qualification_url", EmitDefaultValue = false)]
        public string TaxQualificationUrl { get; set; }

        /// <summary>
        /// 税务登记证地址
        /// </summary>
        /// <value>税务登记证地址</value>
        [DataMember(Name = "tax_reg_cert_url", EmitDefaultValue = false)]
        public string TaxRegCertUrl { get; set; }

        /// <summary>
        /// 纳税人资格开始时间 （时间戳）
        /// </summary>
        /// <value>纳税人资格开始时间 （时间戳）</value>
        [DataMember(Name = "taxpayer_quali_valid", EmitDefaultValue = false)]
        public string TaxpayerQualiValid { get; set; }

        /// <summary>
        /// 公司注册电话
        /// </summary>
        /// <value>公司注册电话</value>
        [DataMember(Name = "telephone", EmitDefaultValue = false)]
        public string Telephone { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        /// <value>发票抬头</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        /// <value>租户ID</value>
        [DataMember(Name = "tnt_inst_id", EmitDefaultValue = false)]
        public string TntInstId { get; set; }

        /// <summary>
        /// 开票资料用户类型   01：OU，02：商户，03：C用户
        /// </summary>
        /// <value>开票资料用户类型   01：OU，02：商户，03：C用户</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// 收件人地址列表
        /// </summary>
        /// <value>收件人地址列表</value>
        [DataMember(Name = "user_mail_info_list", EmitDefaultValue = false)]
        public List<UserMailInfoVO> UserMailInfoList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserInvoiceInfoOpenApiResponse {\n");
            sb.Append("  AcceptElectronic: ").Append(AcceptElectronic).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Auto: ").Append(Auto).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BusinessLicenceUrl: ").Append(BusinessLicenceUrl).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  Hold: ").Append(Hold).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IpId: ").Append(IpId).Append("\n");
            sb.Append("  LastModifier: ").Append(LastModifier).Append("\n");
            sb.Append("  OpenAccountPermitUrl: ").Append(OpenAccountPermitUrl).Append("\n");
            sb.Append("  OtherQualificationUrl: ").Append(OtherQualificationUrl).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaskDate: ").Append(TaskDate).Append("\n");
            sb.Append("  TaxNo: ").Append(TaxNo).Append("\n");
            sb.Append("  TaxPayerQualification: ").Append(TaxPayerQualification).Append("\n");
            sb.Append("  TaxQualificationUrl: ").Append(TaxQualificationUrl).Append("\n");
            sb.Append("  TaxRegCertUrl: ").Append(TaxRegCertUrl).Append("\n");
            sb.Append("  TaxpayerQualiValid: ").Append(TaxpayerQualiValid).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TntInstId: ").Append(TntInstId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserMailInfoList: ").Append(UserMailInfoList).Append("\n");
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
            return this.Equals(input as UserInvoiceInfoOpenApiResponse);
        }

        /// <summary>
        /// Returns true if UserInvoiceInfoOpenApiResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserInvoiceInfoOpenApiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInvoiceInfoOpenApiResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcceptElectronic == input.AcceptElectronic ||
                    this.AcceptElectronic.Equals(input.AcceptElectronic)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Auto == input.Auto ||
                    this.Auto.Equals(input.Auto)
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.BusinessLicenceUrl == input.BusinessLicenceUrl ||
                    (this.BusinessLicenceUrl != null &&
                    this.BusinessLicenceUrl.Equals(input.BusinessLicenceUrl))
                ) && 
                (
                    this.Creator == input.Creator ||
                    (this.Creator != null &&
                    this.Creator.Equals(input.Creator))
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.Hold == input.Hold ||
                    this.Hold.Equals(input.Hold)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IpId == input.IpId ||
                    (this.IpId != null &&
                    this.IpId.Equals(input.IpId))
                ) && 
                (
                    this.LastModifier == input.LastModifier ||
                    (this.LastModifier != null &&
                    this.LastModifier.Equals(input.LastModifier))
                ) && 
                (
                    this.OpenAccountPermitUrl == input.OpenAccountPermitUrl ||
                    (this.OpenAccountPermitUrl != null &&
                    this.OpenAccountPermitUrl.Equals(input.OpenAccountPermitUrl))
                ) && 
                (
                    this.OtherQualificationUrl == input.OtherQualificationUrl ||
                    (this.OtherQualificationUrl != null &&
                    this.OtherQualificationUrl.Equals(input.OtherQualificationUrl))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TaskDate == input.TaskDate ||
                    (this.TaskDate != null &&
                    this.TaskDate.Equals(input.TaskDate))
                ) && 
                (
                    this.TaxNo == input.TaxNo ||
                    (this.TaxNo != null &&
                    this.TaxNo.Equals(input.TaxNo))
                ) && 
                (
                    this.TaxPayerQualification == input.TaxPayerQualification ||
                    (this.TaxPayerQualification != null &&
                    this.TaxPayerQualification.Equals(input.TaxPayerQualification))
                ) && 
                (
                    this.TaxQualificationUrl == input.TaxQualificationUrl ||
                    (this.TaxQualificationUrl != null &&
                    this.TaxQualificationUrl.Equals(input.TaxQualificationUrl))
                ) && 
                (
                    this.TaxRegCertUrl == input.TaxRegCertUrl ||
                    (this.TaxRegCertUrl != null &&
                    this.TaxRegCertUrl.Equals(input.TaxRegCertUrl))
                ) && 
                (
                    this.TaxpayerQualiValid == input.TaxpayerQualiValid ||
                    (this.TaxpayerQualiValid != null &&
                    this.TaxpayerQualiValid.Equals(input.TaxpayerQualiValid))
                ) && 
                (
                    this.Telephone == input.Telephone ||
                    (this.Telephone != null &&
                    this.Telephone.Equals(input.Telephone))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.TntInstId == input.TntInstId ||
                    (this.TntInstId != null &&
                    this.TntInstId.Equals(input.TntInstId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.UserMailInfoList == input.UserMailInfoList ||
                    this.UserMailInfoList != null &&
                    input.UserMailInfoList != null &&
                    this.UserMailInfoList.SequenceEqual(input.UserMailInfoList)
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
                hashCode = (hashCode * 59) + this.AcceptElectronic.GetHashCode();
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Auto.GetHashCode();
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
                }
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.BusinessLicenceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLicenceUrl.GetHashCode();
                }
                if (this.Creator != null)
                {
                    hashCode = (hashCode * 59) + this.Creator.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Hold.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.IpId != null)
                {
                    hashCode = (hashCode * 59) + this.IpId.GetHashCode();
                }
                if (this.LastModifier != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifier.GetHashCode();
                }
                if (this.OpenAccountPermitUrl != null)
                {
                    hashCode = (hashCode * 59) + this.OpenAccountPermitUrl.GetHashCode();
                }
                if (this.OtherQualificationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.OtherQualificationUrl.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TaskDate != null)
                {
                    hashCode = (hashCode * 59) + this.TaskDate.GetHashCode();
                }
                if (this.TaxNo != null)
                {
                    hashCode = (hashCode * 59) + this.TaxNo.GetHashCode();
                }
                if (this.TaxPayerQualification != null)
                {
                    hashCode = (hashCode * 59) + this.TaxPayerQualification.GetHashCode();
                }
                if (this.TaxQualificationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.TaxQualificationUrl.GetHashCode();
                }
                if (this.TaxRegCertUrl != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRegCertUrl.GetHashCode();
                }
                if (this.TaxpayerQualiValid != null)
                {
                    hashCode = (hashCode * 59) + this.TaxpayerQualiValid.GetHashCode();
                }
                if (this.Telephone != null)
                {
                    hashCode = (hashCode * 59) + this.Telephone.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.TntInstId != null)
                {
                    hashCode = (hashCode * 59) + this.TntInstId.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.UserMailInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.UserMailInfoList.GetHashCode();
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
