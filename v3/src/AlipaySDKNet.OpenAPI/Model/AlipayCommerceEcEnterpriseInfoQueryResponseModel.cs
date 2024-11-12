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
    /// AlipayCommerceEcEnterpriseInfoQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcEnterpriseInfoQueryResponseModel")]
    public partial class AlipayCommerceEcEnterpriseInfoQueryResponseModel : IEquatable<AlipayCommerceEcEnterpriseInfoQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEnterpriseInfoQueryResponseModel" /> class.
        /// </summary>
        /// <param name="enterpriseInfo">enterpriseInfo.</param>
        public AlipayCommerceEcEnterpriseInfoQueryResponseModel(EnterpriseInfoDTO enterpriseInfo = default(EnterpriseInfoDTO))
        {
            this.EnterpriseInfo = enterpriseInfo;
        }

        /// <summary>
        /// Gets or Sets EnterpriseInfo
        /// </summary>
        [DataMember(Name = "enterprise_info", EmitDefaultValue = false)]
        public EnterpriseInfoDTO EnterpriseInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcEnterpriseInfoQueryResponseModel {\n");
            sb.Append("  EnterpriseInfo: ").Append(EnterpriseInfo).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcEnterpriseInfoQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcEnterpriseInfoQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcEnterpriseInfoQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcEnterpriseInfoQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnterpriseInfo == input.EnterpriseInfo ||
                    (this.EnterpriseInfo != null &&
                    this.EnterpriseInfo.Equals(input.EnterpriseInfo))
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
                if (this.EnterpriseInfo != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseInfo.GetHashCode();
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
