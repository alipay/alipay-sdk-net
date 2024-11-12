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
    /// AlipayFundEnterprisepaySignResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundEnterprisepaySignResponseModel")]
    public partial class AlipayFundEnterprisepaySignResponseModel : IEquatable<AlipayFundEnterprisepaySignResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepaySignResponseModel" /> class.
        /// </summary>
        /// <param name="signToken">签约凭证.</param>
        /// <param name="signUrl">签约链接，用于跳转到开户页面.</param>
        public AlipayFundEnterprisepaySignResponseModel(string signToken = default(string), string signUrl = default(string))
        {
            this.SignToken = signToken;
            this.SignUrl = signUrl;
        }

        /// <summary>
        /// 签约凭证
        /// </summary>
        /// <value>签约凭证</value>
        [DataMember(Name = "sign_token", EmitDefaultValue = false)]
        public string SignToken { get; set; }

        /// <summary>
        /// 签约链接，用于跳转到开户页面
        /// </summary>
        /// <value>签约链接，用于跳转到开户页面</value>
        [DataMember(Name = "sign_url", EmitDefaultValue = false)]
        public string SignUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundEnterprisepaySignResponseModel {\n");
            sb.Append("  SignToken: ").Append(SignToken).Append("\n");
            sb.Append("  SignUrl: ").Append(SignUrl).Append("\n");
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
            return this.Equals(input as AlipayFundEnterprisepaySignResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundEnterprisepaySignResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundEnterprisepaySignResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundEnterprisepaySignResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignToken == input.SignToken ||
                    (this.SignToken != null &&
                    this.SignToken.Equals(input.SignToken))
                ) && 
                (
                    this.SignUrl == input.SignUrl ||
                    (this.SignUrl != null &&
                    this.SignUrl.Equals(input.SignUrl))
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
                if (this.SignToken != null)
                {
                    hashCode = (hashCode * 59) + this.SignToken.GetHashCode();
                }
                if (this.SignUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SignUrl.GetHashCode();
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
