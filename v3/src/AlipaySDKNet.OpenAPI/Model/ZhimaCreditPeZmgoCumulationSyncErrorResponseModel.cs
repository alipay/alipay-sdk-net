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
    /// ZhimaCreditPeZmgoCumulationSyncErrorResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPeZmgoCumulationSyncErrorResponseModel")]
    public partial class ZhimaCreditPeZmgoCumulationSyncErrorResponseModel : IEquatable<ZhimaCreditPeZmgoCumulationSyncErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum REQUESTPARAMILLEGAL for value: REQUEST_PARAM_ILLEGAL
            /// </summary>
            [EnumMember(Value = "REQUEST_PARAM_ILLEGAL")]
            REQUESTPARAMILLEGAL = 1,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 2,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 3,

            /// <summary>
            /// Enum REQUESTACCESSILLEGAL for value: REQUEST_ACCESS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "REQUEST_ACCESS_ILLEGAL")]
            REQUESTACCESSILLEGAL = 4,

            /// <summary>
            /// Enum INVALIDBIZACTION for value: INVALID_BIZ_ACTION
            /// </summary>
            [EnumMember(Value = "INVALID_BIZ_ACTION")]
            INVALIDBIZACTION = 5,

            /// <summary>
            /// Enum EASYMEMBERCONSULTFAIL for value: EASY_MEMBER_CONSULT_FAIL
            /// </summary>
            [EnumMember(Value = "EASY_MEMBER_CONSULT_FAIL")]
            EASYMEMBERCONSULTFAIL = 6,

            /// <summary>
            /// Enum INVALIDCUMULATEMODE for value: INVALID_CUMULATE_MODE
            /// </summary>
            [EnumMember(Value = "INVALID_CUMULATE_MODE")]
            INVALIDCUMULATEMODE = 7,

            /// <summary>
            /// Enum IDEMPOTENTERROR for value: IDEMPOTENT_ERROR
            /// </summary>
            [EnumMember(Value = "IDEMPOTENT_ERROR")]
            IDEMPOTENTERROR = 8,

            /// <summary>
            /// Enum INVALIDCUMULATETYPE for value: INVALID_CUMULATE_TYPE
            /// </summary>
            [EnumMember(Value = "INVALID_CUMULATE_TYPE")]
            INVALIDCUMULATETYPE = 9,

            /// <summary>
            /// Enum PAYORDERNOTEXIST for value: PAY_ORDER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "PAY_ORDER_NOT_EXIST")]
            PAYORDERNOTEXIST = 10,

            /// <summary>
            /// Enum ORDERAMOUNTILLEGAL for value: ORDER_AMOUNT_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ORDER_AMOUNT_ILLEGAL")]
            ORDERAMOUNTILLEGAL = 11,

            /// <summary>
            /// Enum DISCOUNTAMOUNTILLEGAL for value: DISCOUNT_AMOUNT_ILLEGAL
            /// </summary>
            [EnumMember(Value = "DISCOUNT_AMOUNT_ILLEGAL")]
            DISCOUNTAMOUNTILLEGAL = 12,

            /// <summary>
            /// Enum REFUNDTIMEILLEGAL for value: REFUND_TIME_ILLEGAL
            /// </summary>
            [EnumMember(Value = "REFUND_TIME_ILLEGAL")]
            REFUNDTIMEILLEGAL = 13,

            /// <summary>
            /// Enum REFUNDILLEGAL for value: REFUND_ILLEGAL
            /// </summary>
            [EnumMember(Value = "REFUND_ILLEGAL")]
            REFUNDILLEGAL = 14,

            /// <summary>
            /// Enum BUYERINFOERROR for value: BUYER_INFO_ERROR
            /// </summary>
            [EnumMember(Value = "BUYER_INFO_ERROR")]
            BUYERINFOERROR = 15,

            /// <summary>
            /// Enum SELLERINFOERROR for value: SELLER_INFO_ERROR
            /// </summary>
            [EnumMember(Value = "SELLER_INFO_ERROR")]
            SELLERINFOERROR = 16,

            /// <summary>
            /// Enum TRADENOTEXIST for value: TRADE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "TRADE_NOT_EXIST")]
            TRADENOTEXIST = 17

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoCumulationSyncErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ZhimaCreditPeZmgoCumulationSyncErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoCumulationSyncErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public ZhimaCreditPeZmgoCumulationSyncErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for ZhimaCreditPeZmgoCumulationSyncErrorResponseModel and cannot be null");
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
            sb.Append("class ZhimaCreditPeZmgoCumulationSyncErrorResponseModel {\n");
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
            return this.Equals(input as ZhimaCreditPeZmgoCumulationSyncErrorResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPeZmgoCumulationSyncErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPeZmgoCumulationSyncErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPeZmgoCumulationSyncErrorResponseModel input)
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
