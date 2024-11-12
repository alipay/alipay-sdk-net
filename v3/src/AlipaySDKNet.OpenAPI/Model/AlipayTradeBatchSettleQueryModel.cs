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
    /// AlipayTradeBatchSettleQueryModel
    /// </summary>
    [DataContract(Name = "AlipayTradeBatchSettleQueryModel")]
    public partial class AlipayTradeBatchSettleQueryModel : IEquatable<AlipayTradeBatchSettleQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeBatchSettleQueryModel" /> class.
        /// </summary>
        /// <param name="extendParams">扩展参数.</param>
        /// <param name="outRequestNo">批量结算时传入的外部流水号，与settle_no二者必填其一。 out_request_no和settle_no如果同时存在，优先取settle_no.</param>
        /// <param name="settleNo">结算单据号，与out_request_no二者必填其一.</param>
        public AlipayTradeBatchSettleQueryModel(string extendParams = default(string), string outRequestNo = default(string), string settleNo = default(string))
        {
            this.ExtendParams = extendParams;
            this.OutRequestNo = outRequestNo;
            this.SettleNo = settleNo;
        }

        /// <summary>
        /// 扩展参数
        /// </summary>
        /// <value>扩展参数</value>
        [DataMember(Name = "extend_params", EmitDefaultValue = false)]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 批量结算时传入的外部流水号，与settle_no二者必填其一。 out_request_no和settle_no如果同时存在，优先取settle_no
        /// </summary>
        /// <value>批量结算时传入的外部流水号，与settle_no二者必填其一。 out_request_no和settle_no如果同时存在，优先取settle_no</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 结算单据号，与out_request_no二者必填其一
        /// </summary>
        /// <value>结算单据号，与out_request_no二者必填其一</value>
        [DataMember(Name = "settle_no", EmitDefaultValue = false)]
        public string SettleNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeBatchSettleQueryModel {\n");
            sb.Append("  ExtendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  SettleNo: ").Append(SettleNo).Append("\n");
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
            return this.Equals(input as AlipayTradeBatchSettleQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeBatchSettleQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeBatchSettleQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeBatchSettleQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExtendParams == input.ExtendParams ||
                    (this.ExtendParams != null &&
                    this.ExtendParams.Equals(input.ExtendParams))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.SettleNo == input.SettleNo ||
                    (this.SettleNo != null &&
                    this.SettleNo.Equals(input.SettleNo))
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
                if (this.ExtendParams != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendParams.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.SettleNo != null)
                {
                    hashCode = (hashCode * 59) + this.SettleNo.GetHashCode();
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
