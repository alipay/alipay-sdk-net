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
    /// AntMerchantExpandShopReceiptaccountSaveErrorResponseModel
    /// </summary>
    [DataContract(Name = "AntMerchantExpandShopReceiptaccountSaveErrorResponseModel")]
    public partial class AntMerchantExpandShopReceiptaccountSaveErrorResponseModel : IEquatable<AntMerchantExpandShopReceiptaccountSaveErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum MERARGUMENTNULL for value: MER_ARGUMENT_NULL
            /// </summary>
            [EnumMember(Value = "MER_ARGUMENT_NULL")]
            MERARGUMENTNULL = 1,

            /// <summary>
            /// Enum SHOPNOTEXIST for value: SHOP_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SHOP_NOT_EXIST")]
            SHOPNOTEXIST = 2,

            /// <summary>
            /// Enum RECEIPTACCOUNTNOTEXIST for value: RECEIPT_ACCOUNT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "RECEIPT_ACCOUNT_NOT_EXIST")]
            RECEIPTACCOUNTNOTEXIST = 3,

            /// <summary>
            /// Enum RECEIPTACCOUNTEXISTS for value: RECEIPT_ACCOUNT_EXISTS
            /// </summary>
            [EnumMember(Value = "RECEIPT_ACCOUNT_EXISTS")]
            RECEIPTACCOUNTEXISTS = 4,

            /// <summary>
            /// Enum RECEIPTACCOUNTEXCEEDLIMIT for value: RECEIPT_ACCOUNT_EXCEED_LIMIT
            /// </summary>
            [EnumMember(Value = "RECEIPT_ACCOUNT_EXCEED_LIMIT")]
            RECEIPTACCOUNTEXCEEDLIMIT = 5,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 6,

            /// <summary>
            /// Enum MERCHANTNOTEXIST for value: MERCHANT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MERCHANT_NOT_EXIST")]
            MERCHANTNOTEXIST = 7,

            /// <summary>
            /// Enum NOTALLOWEDSETTLE for value: NOT_ALLOWED_SETTLE
            /// </summary>
            [EnumMember(Value = "NOT_ALLOWED_SETTLE")]
            NOTALLOWEDSETTLE = 8

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandShopReceiptaccountSaveErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AntMerchantExpandShopReceiptaccountSaveErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandShopReceiptaccountSaveErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AntMerchantExpandShopReceiptaccountSaveErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AntMerchantExpandShopReceiptaccountSaveErrorResponseModel and cannot be null");
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
            sb.Append("class AntMerchantExpandShopReceiptaccountSaveErrorResponseModel {\n");
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
            return this.Equals(input as AntMerchantExpandShopReceiptaccountSaveErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandShopReceiptaccountSaveErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandShopReceiptaccountSaveErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandShopReceiptaccountSaveErrorResponseModel input)
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
