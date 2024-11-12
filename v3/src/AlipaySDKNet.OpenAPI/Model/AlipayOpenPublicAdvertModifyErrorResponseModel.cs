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
    /// AlipayOpenPublicAdvertModifyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicAdvertModifyErrorResponseModel")]
    public partial class AlipayOpenPublicAdvertModifyErrorResponseModel : IEquatable<AlipayOpenPublicAdvertModifyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 1,

            /// <summary>
            /// Enum PUBLICADVERTSIZEINVALID for value: PUBLIC_ADVERT_SIZE_INVALID
            /// </summary>
            [EnumMember(Value = "PUBLIC_ADVERT_SIZE_INVALID")]
            PUBLICADVERTSIZEINVALID = 2,

            /// <summary>
            /// Enum PUBLICADVERTIMGURLISBLANK for value: PUBLIC_ADVERT_IMGURL_IS_BLANK
            /// </summary>
            [EnumMember(Value = "PUBLIC_ADVERT_IMGURL_IS_BLANK")]
            PUBLICADVERTIMGURLISBLANK = 3,

            /// <summary>
            /// Enum PUBLICADVERTIMGURLILLEGAL for value: PUBLIC_ADVERT_IMGURL_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PUBLIC_ADVERT_IMGURL_ILLEGAL")]
            PUBLICADVERTIMGURLILLEGAL = 4,

            /// <summary>
            /// Enum PUBLICADVERTLINKURLISBLANK for value: PUBLIC_ADVERT_LINKURL_IS_BLANK
            /// </summary>
            [EnumMember(Value = "PUBLIC_ADVERT_LINKURL_IS_BLANK")]
            PUBLICADVERTLINKURLISBLANK = 5,

            /// <summary>
            /// Enum PUBLICADVERTLINKURLILLEGAL for value: PUBLIC_ADVERT_LINKURL_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PUBLIC_ADVERT_LINKURL_ILLEGAL")]
            PUBLICADVERTLINKURLILLEGAL = 6,

            /// <summary>
            /// Enum PUBLICADVERTIMGURLOVERSIZE for value: PUBLIC_ADVERT_IMGURL_OVERSIZE
            /// </summary>
            [EnumMember(Value = "PUBLIC_ADVERT_IMGURL_OVERSIZE")]
            PUBLICADVERTIMGURLOVERSIZE = 7,

            /// <summary>
            /// Enum PUBLICADVERTLINKURLOVERSIZE for value: PUBLIC_ADVERT_LINKURL_OVERSIZE
            /// </summary>
            [EnumMember(Value = "PUBLIC_ADVERT_LINKURL_OVERSIZE")]
            PUBLICADVERTLINKURLOVERSIZE = 8,

            /// <summary>
            /// Enum LIFEAPPFILETOOLARGE for value: LIFE_APP_FILE_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "LIFE_APP_FILE_TOO_LARGE")]
            LIFEAPPFILETOOLARGE = 9,

            /// <summary>
            /// Enum PUBLICIMGTYPEINVALID for value: PUBLIC_IMG_TYPE_INVALID
            /// </summary>
            [EnumMember(Value = "PUBLIC_IMG_TYPE_INVALID")]
            PUBLICIMGTYPEINVALID = 10,

            /// <summary>
            /// Enum PUBLICADVERTEXISTS for value: PUBLIC_ADVERT_EXISTS
            /// </summary>
            [EnumMember(Value = "PUBLIC_ADVERT_EXISTS")]
            PUBLICADVERTEXISTS = 11,

            /// <summary>
            /// Enum PUBLICADVERTIDINVALID for value: PUBLIC_ADVERT_ID_INVALID
            /// </summary>
            [EnumMember(Value = "PUBLIC_ADVERT_ID_INVALID")]
            PUBLICADVERTIDINVALID = 12,

            /// <summary>
            /// Enum PUBLICADVERTNOTEXISTS for value: PUBLIC_ADVERT_NOT_EXISTS
            /// </summary>
            [EnumMember(Value = "PUBLIC_ADVERT_NOT_EXISTS")]
            PUBLICADVERTNOTEXISTS = 13,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 14,

            /// <summary>
            /// Enum BUSINESSERROR for value: BUSINESS_ERROR
            /// </summary>
            [EnumMember(Value = "BUSINESS_ERROR")]
            BUSINESSERROR = 15,

            /// <summary>
            /// Enum SECURITYCHECKFAILED for value: SECURITY_CHECK_FAILED
            /// </summary>
            [EnumMember(Value = "SECURITY_CHECK_FAILED")]
            SECURITYCHECKFAILED = 16,

            /// <summary>
            /// Enum AUTHORIZENOTADMIT for value: AUTHORIZE_NOT_ADMIT
            /// </summary>
            [EnumMember(Value = "AUTHORIZE_NOT_ADMIT")]
            AUTHORIZENOTADMIT = 17

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicAdvertModifyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenPublicAdvertModifyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicAdvertModifyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenPublicAdvertModifyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenPublicAdvertModifyErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenPublicAdvertModifyErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenPublicAdvertModifyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicAdvertModifyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicAdvertModifyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicAdvertModifyErrorResponseModel input)
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
