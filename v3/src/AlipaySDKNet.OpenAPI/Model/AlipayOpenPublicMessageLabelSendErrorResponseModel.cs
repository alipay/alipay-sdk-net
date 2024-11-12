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
    /// AlipayOpenPublicMessageLabelSendErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicMessageLabelSendErrorResponseModel")]
    public partial class AlipayOpenPublicMessageLabelSendErrorResponseModel : IEquatable<AlipayOpenPublicMessageLabelSendErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum ILLEGALBIZPARAMS for value: ILLEGAL_BIZ_PARAMS
            /// </summary>
            [EnumMember(Value = "ILLEGAL_BIZ_PARAMS")]
            ILLEGALBIZPARAMS = 1,

            /// <summary>
            /// Enum LABELGROUPFILTEREMPTY for value: LABEL_GROUP_FILTER_EMPTY
            /// </summary>
            [EnumMember(Value = "LABEL_GROUP_FILTER_EMPTY")]
            LABELGROUPFILTEREMPTY = 2,

            /// <summary>
            /// Enum LABELGROUPLABELOVERLIMIT for value: LABEL_GROUP_LABEL_OVER_LIMIT
            /// </summary>
            [EnumMember(Value = "LABEL_GROUP_LABEL_OVER_LIMIT")]
            LABELGROUPLABELOVERLIMIT = 3,

            /// <summary>
            /// Enum LABELGROUPKEYEMPTY for value: LABEL_GROUP_KEY_EMPTY
            /// </summary>
            [EnumMember(Value = "LABEL_GROUP_KEY_EMPTY")]
            LABELGROUPKEYEMPTY = 4,

            /// <summary>
            /// Enum LABELGROUPITEMEMPTY for value: LABEL_GROUP_ITEM_EMPTY
            /// </summary>
            [EnumMember(Value = "LABEL_GROUP_ITEM_EMPTY")]
            LABELGROUPITEMEMPTY = 5,

            /// <summary>
            /// Enum LABELGROUPVALUESEMPTY for value: LABEL_GROUP_VALUES_EMPTY
            /// </summary>
            [EnumMember(Value = "LABEL_GROUP_VALUES_EMPTY")]
            LABELGROUPVALUESEMPTY = 6,

            /// <summary>
            /// Enum LABELGROUPTPLEMPTY for value: LABEL_GROUP_TPL_EMPTY
            /// </summary>
            [EnumMember(Value = "LABEL_GROUP_TPL_EMPTY")]
            LABELGROUPTPLEMPTY = 7,

            /// <summary>
            /// Enum LABELGROUPNOCONDITION for value: LABEL_GROUP_NO_CONDITION
            /// </summary>
            [EnumMember(Value = "LABEL_GROUP_NO_CONDITION")]
            LABELGROUPNOCONDITION = 8,

            /// <summary>
            /// Enum LABELGROUPVALUENOTNUMBER for value: LABEL_GROUP_VALUE_NOT_NUMBER
            /// </summary>
            [EnumMember(Value = "LABEL_GROUP_VALUE_NOT_NUMBER")]
            LABELGROUPVALUENOTNUMBER = 9,

            /// <summary>
            /// Enum LABELGROUPLABELNOTEXISTS for value: LABEL_GROUP_LABEL_NOT_EXISTS
            /// </summary>
            [EnumMember(Value = "LABEL_GROUP_LABEL_NOT_EXISTS")]
            LABELGROUPLABELNOTEXISTS = 10,

            /// <summary>
            /// Enum MSGTYPEILLEGAL for value: MSG_TYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "MSG_TYPE_ILLEGAL")]
            MSGTYPEILLEGAL = 11,

            /// <summary>
            /// Enum OPENIDISILLEGAL for value: OPEN_ID_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "OPEN_ID_IS_ILLEGAL")]
            OPENIDISILLEGAL = 12,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 13

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMessageLabelSendErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenPublicMessageLabelSendErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMessageLabelSendErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenPublicMessageLabelSendErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenPublicMessageLabelSendErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenPublicMessageLabelSendErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenPublicMessageLabelSendErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicMessageLabelSendErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicMessageLabelSendErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicMessageLabelSendErrorResponseModel input)
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
