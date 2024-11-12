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
    /// AlipayUserAgreementTransferErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayUserAgreementTransferErrorResponseModel")]
    public partial class AlipayUserAgreementTransferErrorResponseModel : IEquatable<AlipayUserAgreementTransferErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum USERAGREEMENTNOTEXIST for value: USER_AGREEMENT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "USER_AGREEMENT_NOT_EXIST")]
            USERAGREEMENTNOTEXIST = 1,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 2,

            /// <summary>
            /// Enum PRODUCTCODEISINVALID for value: PRODUCT_CODE_IS_INVALID
            /// </summary>
            [EnumMember(Value = "PRODUCT_CODE_IS_INVALID")]
            PRODUCTCODEISINVALID = 3,

            /// <summary>
            /// Enum PRODUCTCODEALREADYUPDATE for value: PRODUCTCODE_ALREADY_UPDATE
            /// </summary>
            [EnumMember(Value = "PRODUCTCODE_ALREADY_UPDATE")]
            PRODUCTCODEALREADYUPDATE = 4,

            /// <summary>
            /// Enum NOTSUPPORTEDBUSINESS for value: NOT_SUPPORTED_BUSINESS
            /// </summary>
            [EnumMember(Value = "NOT_SUPPORTED_BUSINESS")]
            NOTSUPPORTEDBUSINESS = 5,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 6,

            /// <summary>
            /// Enum MERCHANTAGREEMENTISNOTEXIST for value: MERCHANT_AGREEMENT_IS_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MERCHANT_AGREEMENT_IS_NOT_EXIST")]
            MERCHANTAGREEMENTISNOTEXIST = 7,

            /// <summary>
            /// Enum MERCHANTSTATUSISNOTNORMAL for value: MERCHANT_STATUS_IS_NOT_NORMAL
            /// </summary>
            [EnumMember(Value = "MERCHANT_STATUS_IS_NOT_NORMAL")]
            MERCHANTSTATUSISNOTNORMAL = 8,

            /// <summary>
            /// Enum MERCHANTAGREEMENTISEXPIRED for value: MERCHANT_AGREEMENT_IS_EXPIRED
            /// </summary>
            [EnumMember(Value = "MERCHANT_AGREEMENT_IS_EXPIRED")]
            MERCHANTAGREEMENTISEXPIRED = 9,

            /// <summary>
            /// Enum USERAGREEMENTISOUTOFDATE for value: USER_AGREEMENT_IS_OUT_OF_DATE
            /// </summary>
            [EnumMember(Value = "USER_AGREEMENT_IS_OUT_OF_DATE")]
            USERAGREEMENTISOUTOFDATE = 10,

            /// <summary>
            /// Enum USERAGREEMENTSTATUSISEXPIRED for value: USER_AGREEMENT_STATUS_IS_EXPIRED
            /// </summary>
            [EnumMember(Value = "USER_AGREEMENT_STATUS_IS_EXPIRED")]
            USERAGREEMENTSTATUSISEXPIRED = 11

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserAgreementTransferErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayUserAgreementTransferErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserAgreementTransferErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayUserAgreementTransferErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayUserAgreementTransferErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayUserAgreementTransferErrorResponseModel {\n");
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
            return this.Equals(input as AlipayUserAgreementTransferErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayUserAgreementTransferErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserAgreementTransferErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserAgreementTransferErrorResponseModel input)
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
