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
    /// AlipayCommerceEcEmployeeAddModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcEmployeeAddModel")]
    public partial class AlipayCommerceEcEmployeeAddModel : IEquatable<AlipayCommerceEcEmployeeAddModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEmployeeAddModel" /> class.
        /// </summary>
        /// <param name="createShareCode">是否需要生成吱口令，默认不生成.</param>
        /// <param name="departmentIds">员工所属部门，支持多个部门，不传默认为根部门.</param>
        /// <param name="employeeCertNo">员工证件号码.</param>
        /// <param name="employeeCertType">员工证件类型.</param>
        /// <param name="employeeEmail">员工邮箱.</param>
        /// <param name="employeeMobile">员工手机号.</param>
        /// <param name="employeeName">员工姓名.</param>
        /// <param name="employeeNo">员工编号/工号.</param>
        /// <param name="encryptCertNo">加密证件号，需与证件类型搭配使用，可替代证件号码(employee_cert_no)字段.</param>
        /// <param name="encryptMobile">加密手机号，可替代手机号(employee_mobile)字段.</param>
        /// <param name="enterpriseId">员工所属企业ID.</param>
        /// <param name="freeSignToken">员工签约授权密钥；&lt;br/&gt; 该密钥需联系企业码业务小二申请，当传入密钥有效，则员工添加时会默认签约企业因公付，并激活员工。.</param>
        /// <param name="identity">员工身份唯一标识.</param>
        /// <param name="identityOpenId">当身份类型为支付宝会员ID(identity_type&#x3D;ALIPAY_USER_ID)时，传入user_id对应的open_id.</param>
        /// <param name="identityType">员工身份类型.</param>
        /// <param name="iotCheckType">员工签约开通企业刷脸付时，刷脸核身的核验方式.</param>
        /// <param name="iotVid">员工在企业人脸库的人脸唯一标识（该字段已作废，不支持自定义传入）(iot不支持自定义传入).</param>
        /// <param name="profiles">个性化信息 &lt;a href&#x3D;&#39;https://opendocs.alipay.com/pre-open/0ceh47?pathHash&#x3D;14fac87c&#39;&gt;详见文档&lt;/a&gt;.</param>
        /// <param name="roleList">默认角色列表，目前只支持默认为 USER(目前仅支持普通员工，作为默认值，无需调用方传入).</param>
        /// <param name="signReturnUrl">员工签约后回跳地址；支持 alipay scheme 协议地址，不传默认跳转企业码小程序首页.</param>
        /// <param name="signUrlCarryInfo">签约链接页面是否需要自动回显员工的身份信息（手机或邮箱），默认不显示.</param>
        /// <param name="withholdingSignStr">代扣签约字符串，员工需签约开通代扣时必传，否则无需传值.</param>
        public AlipayCommerceEcEmployeeAddModel(bool createShareCode = default(bool), List<string> departmentIds = default(List<string>), string employeeCertNo = default(string), string employeeCertType = default(string), string employeeEmail = default(string), string employeeMobile = default(string), string employeeName = default(string), string employeeNo = default(string), string encryptCertNo = default(string), string encryptMobile = default(string), string enterpriseId = default(string), string freeSignToken = default(string), string identity = default(string), string identityOpenId = default(string), string identityType = default(string), string iotCheckType = default(string), string iotVid = default(string), string profiles = default(string), List<string> roleList = default(List<string>), string signReturnUrl = default(string), bool signUrlCarryInfo = default(bool), string withholdingSignStr = default(string))
        {
            this.CreateShareCode = createShareCode;
            this.DepartmentIds = departmentIds;
            this.EmployeeCertNo = employeeCertNo;
            this.EmployeeCertType = employeeCertType;
            this.EmployeeEmail = employeeEmail;
            this.EmployeeMobile = employeeMobile;
            this.EmployeeName = employeeName;
            this.EmployeeNo = employeeNo;
            this.EncryptCertNo = encryptCertNo;
            this.EncryptMobile = encryptMobile;
            this.EnterpriseId = enterpriseId;
            this.FreeSignToken = freeSignToken;
            this.Identity = identity;
            this.IdentityOpenId = identityOpenId;
            this.IdentityType = identityType;
            this.IotCheckType = iotCheckType;
            this.IotVid = iotVid;
            this.Profiles = profiles;
            this.RoleList = roleList;
            this.SignReturnUrl = signReturnUrl;
            this.SignUrlCarryInfo = signUrlCarryInfo;
            this.WithholdingSignStr = withholdingSignStr;
        }

        /// <summary>
        /// 是否需要生成吱口令，默认不生成
        /// </summary>
        /// <value>是否需要生成吱口令，默认不生成</value>
        [DataMember(Name = "create_share_code", EmitDefaultValue = true)]
        public bool CreateShareCode { get; set; }

        /// <summary>
        /// 员工所属部门，支持多个部门，不传默认为根部门
        /// </summary>
        /// <value>员工所属部门，支持多个部门，不传默认为根部门</value>
        [DataMember(Name = "department_ids", EmitDefaultValue = false)]
        public List<string> DepartmentIds { get; set; }

        /// <summary>
        /// 员工证件号码
        /// </summary>
        /// <value>员工证件号码</value>
        [DataMember(Name = "employee_cert_no", EmitDefaultValue = false)]
        public string EmployeeCertNo { get; set; }

        /// <summary>
        /// 员工证件类型
        /// </summary>
        /// <value>员工证件类型</value>
        [DataMember(Name = "employee_cert_type", EmitDefaultValue = false)]
        public string EmployeeCertType { get; set; }

        /// <summary>
        /// 员工邮箱
        /// </summary>
        /// <value>员工邮箱</value>
        [DataMember(Name = "employee_email", EmitDefaultValue = false)]
        public string EmployeeEmail { get; set; }

        /// <summary>
        /// 员工手机号
        /// </summary>
        /// <value>员工手机号</value>
        [DataMember(Name = "employee_mobile", EmitDefaultValue = false)]
        public string EmployeeMobile { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        /// <value>员工姓名</value>
        [DataMember(Name = "employee_name", EmitDefaultValue = false)]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工编号/工号
        /// </summary>
        /// <value>员工编号/工号</value>
        [DataMember(Name = "employee_no", EmitDefaultValue = false)]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 加密证件号，需与证件类型搭配使用，可替代证件号码(employee_cert_no)字段
        /// </summary>
        /// <value>加密证件号，需与证件类型搭配使用，可替代证件号码(employee_cert_no)字段</value>
        [DataMember(Name = "encrypt_cert_no", EmitDefaultValue = false)]
        public string EncryptCertNo { get; set; }

        /// <summary>
        /// 加密手机号，可替代手机号(employee_mobile)字段
        /// </summary>
        /// <value>加密手机号，可替代手机号(employee_mobile)字段</value>
        [DataMember(Name = "encrypt_mobile", EmitDefaultValue = false)]
        public string EncryptMobile { get; set; }

        /// <summary>
        /// 员工所属企业ID
        /// </summary>
        /// <value>员工所属企业ID</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 员工签约授权密钥；&lt;br/&gt; 该密钥需联系企业码业务小二申请，当传入密钥有效，则员工添加时会默认签约企业因公付，并激活员工。
        /// </summary>
        /// <value>员工签约授权密钥；&lt;br/&gt; 该密钥需联系企业码业务小二申请，当传入密钥有效，则员工添加时会默认签约企业因公付，并激活员工。</value>
        [DataMember(Name = "free_sign_token", EmitDefaultValue = false)]
        public string FreeSignToken { get; set; }

        /// <summary>
        /// 员工身份唯一标识
        /// </summary>
        /// <value>员工身份唯一标识</value>
        [DataMember(Name = "identity", EmitDefaultValue = false)]
        public string Identity { get; set; }

        /// <summary>
        /// 当身份类型为支付宝会员ID(identity_type&#x3D;ALIPAY_USER_ID)时，传入user_id对应的open_id
        /// </summary>
        /// <value>当身份类型为支付宝会员ID(identity_type&#x3D;ALIPAY_USER_ID)时，传入user_id对应的open_id</value>
        [DataMember(Name = "identity_open_id", EmitDefaultValue = false)]
        public string IdentityOpenId { get; set; }

        /// <summary>
        /// 员工身份类型
        /// </summary>
        /// <value>员工身份类型</value>
        [DataMember(Name = "identity_type", EmitDefaultValue = false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// 员工签约开通企业刷脸付时，刷脸核身的核验方式
        /// </summary>
        /// <value>员工签约开通企业刷脸付时，刷脸核身的核验方式</value>
        [DataMember(Name = "iot_check_type", EmitDefaultValue = false)]
        public string IotCheckType { get; set; }

        /// <summary>
        /// 员工在企业人脸库的人脸唯一标识（该字段已作废，不支持自定义传入）(iot不支持自定义传入)
        /// </summary>
        /// <value>员工在企业人脸库的人脸唯一标识（该字段已作废，不支持自定义传入）(iot不支持自定义传入)</value>
        [DataMember(Name = "iot_vid", EmitDefaultValue = false)]
        [Obsolete]
        public string IotVid { get; set; }

        /// <summary>
        /// 个性化信息 &lt;a href&#x3D;&#39;https://opendocs.alipay.com/pre-open/0ceh47?pathHash&#x3D;14fac87c&#39;&gt;详见文档&lt;/a&gt;
        /// </summary>
        /// <value>个性化信息 &lt;a href&#x3D;&#39;https://opendocs.alipay.com/pre-open/0ceh47?pathHash&#x3D;14fac87c&#39;&gt;详见文档&lt;/a&gt;</value>
        [DataMember(Name = "profiles", EmitDefaultValue = false)]
        public string Profiles { get; set; }

        /// <summary>
        /// 默认角色列表，目前只支持默认为 USER(目前仅支持普通员工，作为默认值，无需调用方传入)
        /// </summary>
        /// <value>默认角色列表，目前只支持默认为 USER(目前仅支持普通员工，作为默认值，无需调用方传入)</value>
        [DataMember(Name = "role_list", EmitDefaultValue = false)]
        [Obsolete]
        public List<string> RoleList { get; set; }

        /// <summary>
        /// 员工签约后回跳地址；支持 alipay scheme 协议地址，不传默认跳转企业码小程序首页
        /// </summary>
        /// <value>员工签约后回跳地址；支持 alipay scheme 协议地址，不传默认跳转企业码小程序首页</value>
        [DataMember(Name = "sign_return_url", EmitDefaultValue = false)]
        public string SignReturnUrl { get; set; }

        /// <summary>
        /// 签约链接页面是否需要自动回显员工的身份信息（手机或邮箱），默认不显示
        /// </summary>
        /// <value>签约链接页面是否需要自动回显员工的身份信息（手机或邮箱），默认不显示</value>
        [DataMember(Name = "sign_url_carry_info", EmitDefaultValue = true)]
        public bool SignUrlCarryInfo { get; set; }

        /// <summary>
        /// 代扣签约字符串，员工需签约开通代扣时必传，否则无需传值
        /// </summary>
        /// <value>代扣签约字符串，员工需签约开通代扣时必传，否则无需传值</value>
        [DataMember(Name = "withholding_sign_str", EmitDefaultValue = false)]
        public string WithholdingSignStr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcEmployeeAddModel {\n");
            sb.Append("  CreateShareCode: ").Append(CreateShareCode).Append("\n");
            sb.Append("  DepartmentIds: ").Append(DepartmentIds).Append("\n");
            sb.Append("  EmployeeCertNo: ").Append(EmployeeCertNo).Append("\n");
            sb.Append("  EmployeeCertType: ").Append(EmployeeCertType).Append("\n");
            sb.Append("  EmployeeEmail: ").Append(EmployeeEmail).Append("\n");
            sb.Append("  EmployeeMobile: ").Append(EmployeeMobile).Append("\n");
            sb.Append("  EmployeeName: ").Append(EmployeeName).Append("\n");
            sb.Append("  EmployeeNo: ").Append(EmployeeNo).Append("\n");
            sb.Append("  EncryptCertNo: ").Append(EncryptCertNo).Append("\n");
            sb.Append("  EncryptMobile: ").Append(EncryptMobile).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  FreeSignToken: ").Append(FreeSignToken).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  IdentityOpenId: ").Append(IdentityOpenId).Append("\n");
            sb.Append("  IdentityType: ").Append(IdentityType).Append("\n");
            sb.Append("  IotCheckType: ").Append(IotCheckType).Append("\n");
            sb.Append("  IotVid: ").Append(IotVid).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  RoleList: ").Append(RoleList).Append("\n");
            sb.Append("  SignReturnUrl: ").Append(SignReturnUrl).Append("\n");
            sb.Append("  SignUrlCarryInfo: ").Append(SignUrlCarryInfo).Append("\n");
            sb.Append("  WithholdingSignStr: ").Append(WithholdingSignStr).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcEmployeeAddModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcEmployeeAddModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcEmployeeAddModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcEmployeeAddModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreateShareCode == input.CreateShareCode ||
                    this.CreateShareCode.Equals(input.CreateShareCode)
                ) && 
                (
                    this.DepartmentIds == input.DepartmentIds ||
                    this.DepartmentIds != null &&
                    input.DepartmentIds != null &&
                    this.DepartmentIds.SequenceEqual(input.DepartmentIds)
                ) && 
                (
                    this.EmployeeCertNo == input.EmployeeCertNo ||
                    (this.EmployeeCertNo != null &&
                    this.EmployeeCertNo.Equals(input.EmployeeCertNo))
                ) && 
                (
                    this.EmployeeCertType == input.EmployeeCertType ||
                    (this.EmployeeCertType != null &&
                    this.EmployeeCertType.Equals(input.EmployeeCertType))
                ) && 
                (
                    this.EmployeeEmail == input.EmployeeEmail ||
                    (this.EmployeeEmail != null &&
                    this.EmployeeEmail.Equals(input.EmployeeEmail))
                ) && 
                (
                    this.EmployeeMobile == input.EmployeeMobile ||
                    (this.EmployeeMobile != null &&
                    this.EmployeeMobile.Equals(input.EmployeeMobile))
                ) && 
                (
                    this.EmployeeName == input.EmployeeName ||
                    (this.EmployeeName != null &&
                    this.EmployeeName.Equals(input.EmployeeName))
                ) && 
                (
                    this.EmployeeNo == input.EmployeeNo ||
                    (this.EmployeeNo != null &&
                    this.EmployeeNo.Equals(input.EmployeeNo))
                ) && 
                (
                    this.EncryptCertNo == input.EncryptCertNo ||
                    (this.EncryptCertNo != null &&
                    this.EncryptCertNo.Equals(input.EncryptCertNo))
                ) && 
                (
                    this.EncryptMobile == input.EncryptMobile ||
                    (this.EncryptMobile != null &&
                    this.EncryptMobile.Equals(input.EncryptMobile))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.FreeSignToken == input.FreeSignToken ||
                    (this.FreeSignToken != null &&
                    this.FreeSignToken.Equals(input.FreeSignToken))
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.IdentityOpenId == input.IdentityOpenId ||
                    (this.IdentityOpenId != null &&
                    this.IdentityOpenId.Equals(input.IdentityOpenId))
                ) && 
                (
                    this.IdentityType == input.IdentityType ||
                    (this.IdentityType != null &&
                    this.IdentityType.Equals(input.IdentityType))
                ) && 
                (
                    this.IotCheckType == input.IotCheckType ||
                    (this.IotCheckType != null &&
                    this.IotCheckType.Equals(input.IotCheckType))
                ) && 
                (
                    this.IotVid == input.IotVid ||
                    (this.IotVid != null &&
                    this.IotVid.Equals(input.IotVid))
                ) && 
                (
                    this.Profiles == input.Profiles ||
                    (this.Profiles != null &&
                    this.Profiles.Equals(input.Profiles))
                ) && 
                (
                    this.RoleList == input.RoleList ||
                    this.RoleList != null &&
                    input.RoleList != null &&
                    this.RoleList.SequenceEqual(input.RoleList)
                ) && 
                (
                    this.SignReturnUrl == input.SignReturnUrl ||
                    (this.SignReturnUrl != null &&
                    this.SignReturnUrl.Equals(input.SignReturnUrl))
                ) && 
                (
                    this.SignUrlCarryInfo == input.SignUrlCarryInfo ||
                    this.SignUrlCarryInfo.Equals(input.SignUrlCarryInfo)
                ) && 
                (
                    this.WithholdingSignStr == input.WithholdingSignStr ||
                    (this.WithholdingSignStr != null &&
                    this.WithholdingSignStr.Equals(input.WithholdingSignStr))
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
                hashCode = (hashCode * 59) + this.CreateShareCode.GetHashCode();
                if (this.DepartmentIds != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentIds.GetHashCode();
                }
                if (this.EmployeeCertNo != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeCertNo.GetHashCode();
                }
                if (this.EmployeeCertType != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeCertType.GetHashCode();
                }
                if (this.EmployeeEmail != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeEmail.GetHashCode();
                }
                if (this.EmployeeMobile != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeMobile.GetHashCode();
                }
                if (this.EmployeeName != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeName.GetHashCode();
                }
                if (this.EmployeeNo != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeNo.GetHashCode();
                }
                if (this.EncryptCertNo != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptCertNo.GetHashCode();
                }
                if (this.EncryptMobile != null)
                {
                    hashCode = (hashCode * 59) + this.EncryptMobile.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.FreeSignToken != null)
                {
                    hashCode = (hashCode * 59) + this.FreeSignToken.GetHashCode();
                }
                if (this.Identity != null)
                {
                    hashCode = (hashCode * 59) + this.Identity.GetHashCode();
                }
                if (this.IdentityOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityOpenId.GetHashCode();
                }
                if (this.IdentityType != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityType.GetHashCode();
                }
                if (this.IotCheckType != null)
                {
                    hashCode = (hashCode * 59) + this.IotCheckType.GetHashCode();
                }
                if (this.IotVid != null)
                {
                    hashCode = (hashCode * 59) + this.IotVid.GetHashCode();
                }
                if (this.Profiles != null)
                {
                    hashCode = (hashCode * 59) + this.Profiles.GetHashCode();
                }
                if (this.RoleList != null)
                {
                    hashCode = (hashCode * 59) + this.RoleList.GetHashCode();
                }
                if (this.SignReturnUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SignReturnUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SignUrlCarryInfo.GetHashCode();
                if (this.WithholdingSignStr != null)
                {
                    hashCode = (hashCode * 59) + this.WithholdingSignStr.GetHashCode();
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
