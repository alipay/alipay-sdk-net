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
    /// AlipayEbppPdeductSignValidateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppPdeductSignValidateErrorResponseModel")]
    public partial class AlipayEbppPdeductSignValidateErrorResponseModel : IEquatable<AlipayEbppPdeductSignValidateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum USERISNOTEXITS for value: USER_IS_NOT_EXITS
            /// </summary>
            [EnumMember(Value = "USER_IS_NOT_EXITS")]
            USERISNOTEXITS = 1,

            /// <summary>
            /// Enum NOAUTHERITY for value: NO_AUTHERITY
            /// </summary>
            [EnumMember(Value = "NO_AUTHERITY")]
            NOAUTHERITY = 2,

            /// <summary>
            /// Enum NOAUTHERITYBYREALNAMED for value: NO_AUTHERITY_BY_REALNAMED
            /// </summary>
            [EnumMember(Value = "NO_AUTHERITY_BY_REALNAMED")]
            NOAUTHERITYBYREALNAMED = 3,

            /// <summary>
            /// Enum DEDUCTBALANCEISNOTPAYMENT for value: DEDUCT_BALANCE_IS_NOT_PAYMENT
            /// </summary>
            [EnumMember(Value = "DEDUCT_BALANCE_IS_NOT_PAYMENT")]
            DEDUCTBALANCEISNOTPAYMENT = 4,

            /// <summary>
            /// Enum DEDUCTINSTISNOTEXIST for value: DEDUCT_INST_IS_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "DEDUCT_INST_IS_NOT_EXIST")]
            DEDUCTINSTISNOTEXIST = 5,

            /// <summary>
            /// Enum DEDUCTINSTPRODISCLOSED for value: DEDUCT_INST_PROD_IS_CLOSED
            /// </summary>
            [EnumMember(Value = "DEDUCT_INST_PROD_IS_CLOSED")]
            DEDUCTINSTPRODISCLOSED = 6,

            /// <summary>
            /// Enum DEDUCTSIGNDUPLICATEDSELF for value: DEDUCT_SIGN_DUPLICATED_SELF
            /// </summary>
            [EnumMember(Value = "DEDUCT_SIGN_DUPLICATED_SELF")]
            DEDUCTSIGNDUPLICATEDSELF = 7,

            /// <summary>
            /// Enum DEDUCTSIGNDUPLICATEDOTHER for value: DEDUCT_SIGN_DUPLICATED_OTHER
            /// </summary>
            [EnumMember(Value = "DEDUCT_SIGN_DUPLICATED_OTHER")]
            DEDUCTSIGNDUPLICATEDOTHER = 8,

            /// <summary>
            /// Enum DEDUCTSIGNCTUCHECKFAILED for value: DEDUCT_SIGN_CTU_CHECK_FAILED
            /// </summary>
            [EnumMember(Value = "DEDUCT_SIGN_CTU_CHECK_FAILED")]
            DEDUCTSIGNCTUCHECKFAILED = 9,

            /// <summary>
            /// Enum INVALIDCARDNO for value: INVALID_CARD_NO
            /// </summary>
            [EnumMember(Value = "INVALID_CARD_NO")]
            INVALIDCARDNO = 10,

            /// <summary>
            /// Enum UNKNOWERROR for value: UNKNOW_ERROR
            /// </summary>
            [EnumMember(Value = "UNKNOW_ERROR")]
            UNKNOWERROR = 11,

            /// <summary>
            /// Enum INVOKEEBILLCENTEREXCEPTION for value: INVOKE_EBILL_CENTER_EXCEPTION
            /// </summary>
            [EnumMember(Value = "INVOKE_EBILL_CENTER_EXCEPTION")]
            INVOKEEBILLCENTEREXCEPTION = 12

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppPdeductSignValidateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayEbppPdeductSignValidateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppPdeductSignValidateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayEbppPdeductSignValidateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayEbppPdeductSignValidateErrorResponseModel and cannot be null");
            // }
            this.Message = message;
            this.Links = links;
        }

        /// <summary>
        /// 解决方案链接
        /// </summary>
        /// <value>解决方案链接</value>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public string Links { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        /// <value>错误描述</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppPdeductSignValidateErrorResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as AlipayEbppPdeductSignValidateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppPdeductSignValidateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppPdeductSignValidateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppPdeductSignValidateErrorResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
