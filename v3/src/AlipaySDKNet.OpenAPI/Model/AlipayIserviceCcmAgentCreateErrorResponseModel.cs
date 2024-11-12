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
    /// AlipayIserviceCcmAgentCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmAgentCreateErrorResponseModel")]
    public partial class AlipayIserviceCcmAgentCreateErrorResponseModel : IEquatable<AlipayIserviceCcmAgentCreateErrorResponseModel>, IValidatableObject
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
            /// Enum INTERNALERROR for value: INTERNAL_ERROR
            /// </summary>
            [EnumMember(Value = "INTERNAL_ERROR")]
            INTERNALERROR = 2,

            /// <summary>
            /// Enum TENENTNOTFOUND for value: TENENT_NOT_FOUND
            /// </summary>
            [EnumMember(Value = "TENENT_NOT_FOUND")]
            TENENTNOTFOUND = 3,

            /// <summary>
            /// Enum AGENTCREATORIDISNULL for value: AGENT_CREATORID_IS_NULL
            /// </summary>
            [EnumMember(Value = "AGENT_CREATORID_IS_NULL")]
            AGENTCREATORIDISNULL = 4,

            /// <summary>
            /// Enum AGENTNICKNAMEISNULL for value: AGENT_NICKNAME_IS_NULL
            /// </summary>
            [EnumMember(Value = "AGENT_NICKNAME_IS_NULL")]
            AGENTNICKNAMEISNULL = 5,

            /// <summary>
            /// Enum AGENTREALNAMEISNULL for value: AGENT_REALNAME_IS_NULL
            /// </summary>
            [EnumMember(Value = "AGENT_REALNAME_IS_NULL")]
            AGENTREALNAMEISNULL = 6,

            /// <summary>
            /// Enum AGENTJOBNUMBERISNULL for value: AGENT_JOBNUMBER_IS_NULL
            /// </summary>
            [EnumMember(Value = "AGENT_JOBNUMBER_IS_NULL")]
            AGENTJOBNUMBERISNULL = 7,

            /// <summary>
            /// Enum AGENTUSERCHANNELINVALID for value: AGENT_USERCHANNEL_INVALID
            /// </summary>
            [EnumMember(Value = "AGENT_USERCHANNEL_INVALID")]
            AGENTUSERCHANNELINVALID = 8,

            /// <summary>
            /// Enum AGENTEXTERNALUSERIDISNULL for value: AGENT_EXTERNALUSERID_IS_NULL
            /// </summary>
            [EnumMember(Value = "AGENT_EXTERNALUSERID_IS_NULL")]
            AGENTEXTERNALUSERIDISNULL = 9,

            /// <summary>
            /// Enum AGENTROLLIDSISNULL for value: AGENT_ROLLIDS_IS_NULL
            /// </summary>
            [EnumMember(Value = "AGENT_ROLLIDS_IS_NULL")]
            AGENTROLLIDSISNULL = 10,

            /// <summary>
            /// Enum AGENTCCSINSTANCEIDSISNULL for value: AGENT_CCSINSTANCEIDS_IS_NULL
            /// </summary>
            [EnumMember(Value = "AGENT_CCSINSTANCEIDS_IS_NULL")]
            AGENTCCSINSTANCEIDSISNULL = 11,

            /// <summary>
            /// Enum INVALIDJOBNUMBER for value: INVALID_JOB_NUMBER
            /// </summary>
            [EnumMember(Value = "INVALID_JOB_NUMBER")]
            INVALIDJOBNUMBER = 12,

            /// <summary>
            /// Enum DUPLICATEJOBNUMBER for value: DUPLICATE_JOB_NUMBER
            /// </summary>
            [EnumMember(Value = "DUPLICATE_JOB_NUMBER")]
            DUPLICATEJOBNUMBER = 13,

            /// <summary>
            /// Enum INVALIDHOTLINEANSWERINGMODE for value: INVALID_HOTLINE_ANSWERING_MODE
            /// </summary>
            [EnumMember(Value = "INVALID_HOTLINE_ANSWERING_MODE")]
            INVALIDHOTLINEANSWERINGMODE = 14,

            /// <summary>
            /// Enum ROLEINSTANCEINVALID for value: ROLE_INSTANCE_INVALID
            /// </summary>
            [EnumMember(Value = "ROLE_INSTANCE_INVALID")]
            ROLEINSTANCEINVALID = 15,

            /// <summary>
            /// Enum ROLENOTEXISTS for value: ROLE_NOT_EXISTS
            /// </summary>
            [EnumMember(Value = "ROLE_NOT_EXISTS")]
            ROLENOTEXISTS = 16,

            /// <summary>
            /// Enum UNKNOWERROR for value: UNKNOW_ERROR
            /// </summary>
            [EnumMember(Value = "UNKNOW_ERROR")]
            UNKNOWERROR = 17,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 18

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmAgentCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayIserviceCcmAgentCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmAgentCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayIserviceCcmAgentCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayIserviceCcmAgentCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayIserviceCcmAgentCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayIserviceCcmAgentCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmAgentCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmAgentCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmAgentCreateErrorResponseModel input)
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
