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
    /// DeductInfo
    /// </summary>
    [DataContract(Name = "DeductInfo")]
    public partial class DeductInfo : IEquatable<DeductInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeductInfo" /> class.
        /// </summary>
        /// <param name="customerDefineDeductRule">customerDefineDeductRule.</param>
        public DeductInfo(CustomerDefineDeductRule customerDefineDeductRule = default(CustomerDefineDeductRule))
        {
            this.CustomerDefineDeductRule = customerDefineDeductRule;
        }

        /// <summary>
        /// Gets or Sets CustomerDefineDeductRule
        /// </summary>
        [DataMember(Name = "customer_define_deduct_rule", EmitDefaultValue = false)]
        public CustomerDefineDeductRule CustomerDefineDeductRule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeductInfo {\n");
            sb.Append("  CustomerDefineDeductRule: ").Append(CustomerDefineDeductRule).Append("\n");
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
            return this.Equals(input as DeductInfo);
        }

        /// <summary>
        /// Returns true if DeductInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeductInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeductInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomerDefineDeductRule == input.CustomerDefineDeductRule ||
                    (this.CustomerDefineDeductRule != null &&
                    this.CustomerDefineDeductRule.Equals(input.CustomerDefineDeductRule))
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
                if (this.CustomerDefineDeductRule != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerDefineDeductRule.GetHashCode();
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
