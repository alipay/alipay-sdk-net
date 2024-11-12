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
    /// AssetShareSourceInfo
    /// </summary>
    [DataContract(Name = "AssetShareSourceInfo")]
    public partial class AssetShareSourceInfo : IEquatable<AssetShareSourceInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetShareSourceInfo" /> class.
        /// </summary>
        /// <param name="shareMode">当前规则可用的资产来源类型，搭配source_id_list使用。.</param>
        /// <param name="sourceIdList">资产共享来源id列表，与share_mode配合设置.</param>
        public AssetShareSourceInfo(string shareMode = default(string), List<string> sourceIdList = default(List<string>))
        {
            this.ShareMode = shareMode;
            this.SourceIdList = sourceIdList;
        }

        /// <summary>
        /// 当前规则可用的资产来源类型，搭配source_id_list使用。
        /// </summary>
        /// <value>当前规则可用的资产来源类型，搭配source_id_list使用。</value>
        [DataMember(Name = "share_mode", EmitDefaultValue = false)]
        public string ShareMode { get; set; }

        /// <summary>
        /// 资产共享来源id列表，与share_mode配合设置
        /// </summary>
        /// <value>资产共享来源id列表，与share_mode配合设置</value>
        [DataMember(Name = "source_id_list", EmitDefaultValue = false)]
        public List<string> SourceIdList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssetShareSourceInfo {\n");
            sb.Append("  ShareMode: ").Append(ShareMode).Append("\n");
            sb.Append("  SourceIdList: ").Append(SourceIdList).Append("\n");
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
            return this.Equals(input as AssetShareSourceInfo);
        }

        /// <summary>
        /// Returns true if AssetShareSourceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetShareSourceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetShareSourceInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ShareMode == input.ShareMode ||
                    (this.ShareMode != null &&
                    this.ShareMode.Equals(input.ShareMode))
                ) && 
                (
                    this.SourceIdList == input.SourceIdList ||
                    this.SourceIdList != null &&
                    input.SourceIdList != null &&
                    this.SourceIdList.SequenceEqual(input.SourceIdList)
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
                if (this.ShareMode != null)
                {
                    hashCode = (hashCode * 59) + this.ShareMode.GetHashCode();
                }
                if (this.SourceIdList != null)
                {
                    hashCode = (hashCode * 59) + this.SourceIdList.GetHashCode();
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
