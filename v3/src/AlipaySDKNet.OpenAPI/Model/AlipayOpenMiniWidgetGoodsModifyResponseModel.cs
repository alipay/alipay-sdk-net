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
    /// AlipayOpenMiniWidgetGoodsModifyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniWidgetGoodsModifyResponseModel")]
    public partial class AlipayOpenMiniWidgetGoodsModifyResponseModel : IEquatable<AlipayOpenMiniWidgetGoodsModifyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniWidgetGoodsModifyResponseModel" /> class.
        /// </summary>
        /// <param name="commitId">商品修改返回的提交ID，用于查询商品信息的审核状态.</param>
        public AlipayOpenMiniWidgetGoodsModifyResponseModel(string commitId = default(string))
        {
            this.CommitId = commitId;
        }

        /// <summary>
        /// 商品修改返回的提交ID，用于查询商品信息的审核状态
        /// </summary>
        /// <value>商品修改返回的提交ID，用于查询商品信息的审核状态</value>
        [DataMember(Name = "commit_id", EmitDefaultValue = false)]
        public string CommitId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniWidgetGoodsModifyResponseModel {\n");
            sb.Append("  CommitId: ").Append(CommitId).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniWidgetGoodsModifyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniWidgetGoodsModifyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniWidgetGoodsModifyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniWidgetGoodsModifyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CommitId == input.CommitId ||
                    (this.CommitId != null &&
                    this.CommitId.Equals(input.CommitId))
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
                if (this.CommitId != null)
                {
                    hashCode = (hashCode * 59) + this.CommitId.GetHashCode();
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
