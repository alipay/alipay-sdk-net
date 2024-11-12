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
    /// AlipayFundJointaccountMemberConsultResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundJointaccountMemberConsultResponseModel")]
    public partial class AlipayFundJointaccountMemberConsultResponseModel : IEquatable<AlipayFundJointaccountMemberConsultResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountMemberConsultResponseModel" /> class.
        /// </summary>
        /// <param name="accountId">企业ID.</param>
        /// <param name="code">返回码 10000-成功 其他都是失败.</param>
        /// <param name="memberList">员工列表.</param>
        /// <param name="msg">描述信息.</param>
        public AlipayFundJointaccountMemberConsultResponseModel(string accountId = default(string), string code = default(string), List<MemberStatusRespDTO> memberList = default(List<MemberStatusRespDTO>), string msg = default(string))
        {
            this.AccountId = accountId;
            this.Code = code;
            this.MemberList = memberList;
            this.Msg = msg;
        }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 返回码 10000-成功 其他都是失败
        /// </summary>
        /// <value>返回码 10000-成功 其他都是失败</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 员工列表
        /// </summary>
        /// <value>员工列表</value>
        [DataMember(Name = "member_list", EmitDefaultValue = false)]
        public List<MemberStatusRespDTO> MemberList { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        /// <value>描述信息</value>
        [DataMember(Name = "msg", EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundJointaccountMemberConsultResponseModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  MemberList: ").Append(MemberList).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
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
            return this.Equals(input as AlipayFundJointaccountMemberConsultResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundJointaccountMemberConsultResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundJointaccountMemberConsultResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundJointaccountMemberConsultResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.MemberList == input.MemberList ||
                    this.MemberList != null &&
                    input.MemberList != null &&
                    this.MemberList.SequenceEqual(input.MemberList)
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.MemberList != null)
                {
                    hashCode = (hashCode * 59) + this.MemberList.GetHashCode();
                }
                if (this.Msg != null)
                {
                    hashCode = (hashCode * 59) + this.Msg.GetHashCode();
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
