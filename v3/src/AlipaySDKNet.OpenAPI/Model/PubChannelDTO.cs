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
    /// PubChannelDTO
    /// </summary>
    [DataContract(Name = "PubChannelDTO")]
    public partial class PubChannelDTO : IEquatable<PubChannelDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PubChannelDTO" /> class.
        /// </summary>
        /// <param name="extInfo">扩展信息，无需配置.</param>
        /// <param name="pubChannel">投放渠道类型（选择需要推广投放的渠道） SHOP_DETAIL：店铺详情页.</param>
        public PubChannelDTO(string extInfo = default(string), string pubChannel = default(string))
        {
            this.ExtInfo = extInfo;
            this.PubChannel = pubChannel;
        }

        /// <summary>
        /// 扩展信息，无需配置
        /// </summary>
        /// <value>扩展信息，无需配置</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 投放渠道类型（选择需要推广投放的渠道） SHOP_DETAIL：店铺详情页
        /// </summary>
        /// <value>投放渠道类型（选择需要推广投放的渠道） SHOP_DETAIL：店铺详情页</value>
        [DataMember(Name = "pub_channel", EmitDefaultValue = false)]
        public string PubChannel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PubChannelDTO {\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  PubChannel: ").Append(PubChannel).Append("\n");
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
            return this.Equals(input as PubChannelDTO);
        }

        /// <summary>
        /// Returns true if PubChannelDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PubChannelDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PubChannelDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.PubChannel == input.PubChannel ||
                    (this.PubChannel != null &&
                    this.PubChannel.Equals(input.PubChannel))
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
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.PubChannel != null)
                {
                    hashCode = (hashCode * 59) + this.PubChannel.GetHashCode();
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
