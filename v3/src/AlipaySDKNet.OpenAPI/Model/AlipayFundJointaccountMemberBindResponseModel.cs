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
    /// AlipayFundJointaccountMemberBindResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundJointaccountMemberBindResponseModel")]
    public partial class AlipayFundJointaccountMemberBindResponseModel : IEquatable<AlipayFundJointaccountMemberBindResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountMemberBindResponseModel" /> class.
        /// </summary>
        /// <param name="replyUrl">员工回应邀请链接.</param>
        public AlipayFundJointaccountMemberBindResponseModel(string replyUrl = default(string))
        {
            this.ReplyUrl = replyUrl;
        }

        /// <summary>
        /// 员工回应邀请链接
        /// </summary>
        /// <value>员工回应邀请链接</value>
        [DataMember(Name = "reply_url", EmitDefaultValue = false)]
        public string ReplyUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundJointaccountMemberBindResponseModel {\n");
            sb.Append("  ReplyUrl: ").Append(ReplyUrl).Append("\n");
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
            return this.Equals(input as AlipayFundJointaccountMemberBindResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundJointaccountMemberBindResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundJointaccountMemberBindResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundJointaccountMemberBindResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReplyUrl == input.ReplyUrl ||
                    (this.ReplyUrl != null &&
                    this.ReplyUrl.Equals(input.ReplyUrl))
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
                if (this.ReplyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ReplyUrl.GetHashCode();
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
