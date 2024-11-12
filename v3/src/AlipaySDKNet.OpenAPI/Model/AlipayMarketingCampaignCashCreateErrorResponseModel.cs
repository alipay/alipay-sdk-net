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
    /// AlipayMarketingCampaignCashCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCampaignCashCreateErrorResponseModel")]
    public partial class AlipayMarketingCampaignCashCreateErrorResponseModel : IEquatable<AlipayMarketingCampaignCashCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum UNKNOWSYSTEMERROR for value: UNKNOW_SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "UNKNOW_SYSTEM_ERROR")]
            UNKNOWSYSTEMERROR = 1,

            /// <summary>
            /// Enum SENSITIVEWORDCHECKFAILED for value: SENSITIVE_WORD_CHECK_FAILED
            /// </summary>
            [EnumMember(Value = "SENSITIVE_WORD_CHECK_FAILED")]
            SENSITIVEWORDCHECKFAILED = 2,

            /// <summary>
            /// Enum CASHPRIZETYPEERROR for value: CASH_PRIZE_TYPE_ERROR
            /// </summary>
            [EnumMember(Value = "CASH_PRIZE_TYPE_ERROR")]
            CASHPRIZETYPEERROR = 3,

            /// <summary>
            /// Enum CASHTIMECHECKFAILED for value: CASH_TIME_CHECK_FAILED
            /// </summary>
            [EnumMember(Value = "CASH_TIME_CHECK_FAILED")]
            CASHTIMECHECKFAILED = 4,

            /// <summary>
            /// Enum CASHCOUNTTOOSMALL for value: CASH_COUNT_TOO_SMALL
            /// </summary>
            [EnumMember(Value = "CASH_COUNT_TOO_SMALL")]
            CASHCOUNTTOOSMALL = 5,

            /// <summary>
            /// Enum CASHAMOUNTTOOMUCH for value: CASH_AMOUNT_TOO_MUCH
            /// </summary>
            [EnumMember(Value = "CASH_AMOUNT_TOO_MUCH")]
            CASHAMOUNTTOOMUCH = 6,

            /// <summary>
            /// Enum CASHPERAMOUNTTOOMUCH for value: CASH_PER_AMOUNT_TOO_MUCH
            /// </summary>
            [EnumMember(Value = "CASH_PER_AMOUNT_TOO_MUCH")]
            CASHPERAMOUNTTOOMUCH = 7,

            /// <summary>
            /// Enum CASHCOUNTTOOMUCH for value: CASH_COUNT_TOO_MUCH
            /// </summary>
            [EnumMember(Value = "CASH_COUNT_TOO_MUCH")]
            CASHCOUNTTOOMUCH = 8,

            /// <summary>
            /// Enum CASHAMOUNTTOOSMALL for value: CASH_AMOUNT_TOO_SMALL
            /// </summary>
            [EnumMember(Value = "CASH_AMOUNT_TOO_SMALL")]
            CASHAMOUNTTOOSMALL = 9,

            /// <summary>
            /// Enum CASHCOUPONNAMECHECKFAILED for value: CASH_COUPON_NAME_CHECK_FAILED
            /// </summary>
            [EnumMember(Value = "CASH_COUPON_NAME_CHECK_FAILED")]
            CASHCOUPONNAMECHECKFAILED = 10,

            /// <summary>
            /// Enum CASHPRIZEMSGCHECKFAILED for value: CASH_PRIZE_MSG_CHECK_FAILED
            /// </summary>
            [EnumMember(Value = "CASH_PRIZE_MSG_CHECK_FAILED")]
            CASHPRIZEMSGCHECKFAILED = 11,

            /// <summary>
            /// Enum BIZCONTENTISEMPTY for value: BIZ_CONTENT_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "BIZ_CONTENT_IS_EMPTY")]
            BIZCONTENTISEMPTY = 12,

            /// <summary>
            /// Enum BIZCONTENTFORMATERROR for value: BIZ_CONTENT_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "BIZ_CONTENT_FORMAT_ERROR")]
            BIZCONTENTFORMATERROR = 13,

            /// <summary>
            /// Enum PRODUCTISNOTOPENED for value: PRODUCT_IS_NOT_OPENED
            /// </summary>
            [EnumMember(Value = "PRODUCT_IS_NOT_OPENED")]
            PRODUCTISNOTOPENED = 14,

            /// <summary>
            /// Enum CALLTOOFREQUENCY for value: CALL_TOO_FREQUENCY
            /// </summary>
            [EnumMember(Value = "CALL_TOO_FREQUENCY")]
            CALLTOOFREQUENCY = 15,

            /// <summary>
            /// Enum CREATORLIMITERROR for value: CREATOR_LIMIT_ERROR
            /// </summary>
            [EnumMember(Value = "CREATOR_LIMIT_ERROR")]
            CREATORLIMITERROR = 16,

            /// <summary>
            /// Enum CREATORNOTREALNAME for value: CREATOR_NOT_REALNAME
            /// </summary>
            [EnumMember(Value = "CREATOR_NOT_REALNAME")]
            CREATORNOTREALNAME = 17,

            /// <summary>
            /// Enum SYSTEMLIMITERROR for value: SYSTEM_LIMIT_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_LIMIT_ERROR")]
            SYSTEMLIMITERROR = 18,

            /// <summary>
            /// Enum CASHMERCHANTLINKCHECKFAILED for value: CASH_MERCHANT_LINK_CHECK_FAILED
            /// </summary>
            [EnumMember(Value = "CASH_MERCHANT_LINK_CHECK_FAILED")]
            CASHMERCHANTLINKCHECKFAILED = 19,

            /// <summary>
            /// Enum CASHPERAMOUNTTOOSMALL for value: CASH_PER_AMOUNT_TOO_SMALL
            /// </summary>
            [EnumMember(Value = "CASH_PER_AMOUNT_TOO_SMALL")]
            CASHPERAMOUNTTOOSMALL = 20,

            /// <summary>
            /// Enum CASHSENDFREQUENCYERROR for value: CASH_SEND_FREQUENCY_ERROR
            /// </summary>
            [EnumMember(Value = "CASH_SEND_FREQUENCY_ERROR")]
            CASHSENDFREQUENCYERROR = 21

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCampaignCashCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayMarketingCampaignCashCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCampaignCashCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayMarketingCampaignCashCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayMarketingCampaignCashCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayMarketingCampaignCashCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayMarketingCampaignCashCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCampaignCashCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCampaignCashCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCampaignCashCreateErrorResponseModel input)
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
