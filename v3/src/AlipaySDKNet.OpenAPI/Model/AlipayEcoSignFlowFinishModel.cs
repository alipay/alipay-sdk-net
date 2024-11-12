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
    /// AlipayEcoSignFlowFinishModel
    /// </summary>
    [DataContract(Name = "AlipayEcoSignFlowFinishModel")]
    public partial class AlipayEcoSignFlowFinishModel : IEquatable<AlipayEcoSignFlowFinishModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoSignFlowFinishModel" /> class.
        /// </summary>
        /// <param name="flowId">流程id.</param>
        public AlipayEcoSignFlowFinishModel(string flowId = default(string))
        {
            this.FlowId = flowId;
        }

        /// <summary>
        /// 流程id
        /// </summary>
        /// <value>流程id</value>
        [DataMember(Name = "flow_id", EmitDefaultValue = false)]
        public string FlowId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoSignFlowFinishModel {\n");
            sb.Append("  FlowId: ").Append(FlowId).Append("\n");
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
            return this.Equals(input as AlipayEcoSignFlowFinishModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoSignFlowFinishModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoSignFlowFinishModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoSignFlowFinishModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FlowId == input.FlowId ||
                    (this.FlowId != null &&
                    this.FlowId.Equals(input.FlowId))
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
                if (this.FlowId != null)
                {
                    hashCode = (hashCode * 59) + this.FlowId.GetHashCode();
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
