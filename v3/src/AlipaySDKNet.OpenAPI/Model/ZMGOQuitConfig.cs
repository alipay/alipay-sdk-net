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
    /// ZMGOQuitConfig
    /// </summary>
    [DataContract(Name = "ZMGOQuitConfig")]
    public partial class ZMGOQuitConfig : IEquatable<ZMGOQuitConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZMGOQuitConfig" /> class.
        /// </summary>
        /// <param name="quitDesc">退出提示.</param>
        /// <param name="quitJumpUrl">退出跳转商家页地址，当quit_type取值为：QUIT_MERCHANT_JUMP，必传.</param>
        /// <param name="quitType">退出芝麻GO方式，取值：   （1）QUIT_COMMON(\&quot;QUIT_COMMON\&quot;, \&quot;标准退出\&quot;), （2）QUIT_MERCHANT_JUMP(\&quot;QUIT_MERCHANT_JUMP\&quot;, \&quot;商家页退出\&quot;), （3）QUIT_ONLY_TIPS(\&quot;QUIT_ONLY_TIPS\&quot;, \&quot;仅退出提示\&quot;).</param>
        public ZMGOQuitConfig(string quitDesc = default(string), string quitJumpUrl = default(string), string quitType = default(string))
        {
            this.QuitDesc = quitDesc;
            this.QuitJumpUrl = quitJumpUrl;
            this.QuitType = quitType;
        }

        /// <summary>
        /// 退出提示
        /// </summary>
        /// <value>退出提示</value>
        [DataMember(Name = "quit_desc", EmitDefaultValue = false)]
        public string QuitDesc { get; set; }

        /// <summary>
        /// 退出跳转商家页地址，当quit_type取值为：QUIT_MERCHANT_JUMP，必传
        /// </summary>
        /// <value>退出跳转商家页地址，当quit_type取值为：QUIT_MERCHANT_JUMP，必传</value>
        [DataMember(Name = "quit_jump_url", EmitDefaultValue = false)]
        public string QuitJumpUrl { get; set; }

        /// <summary>
        /// 退出芝麻GO方式，取值：   （1）QUIT_COMMON(\&quot;QUIT_COMMON\&quot;, \&quot;标准退出\&quot;), （2）QUIT_MERCHANT_JUMP(\&quot;QUIT_MERCHANT_JUMP\&quot;, \&quot;商家页退出\&quot;), （3）QUIT_ONLY_TIPS(\&quot;QUIT_ONLY_TIPS\&quot;, \&quot;仅退出提示\&quot;)
        /// </summary>
        /// <value>退出芝麻GO方式，取值：   （1）QUIT_COMMON(\&quot;QUIT_COMMON\&quot;, \&quot;标准退出\&quot;), （2）QUIT_MERCHANT_JUMP(\&quot;QUIT_MERCHANT_JUMP\&quot;, \&quot;商家页退出\&quot;), （3）QUIT_ONLY_TIPS(\&quot;QUIT_ONLY_TIPS\&quot;, \&quot;仅退出提示\&quot;)</value>
        [DataMember(Name = "quit_type", EmitDefaultValue = false)]
        public string QuitType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZMGOQuitConfig {\n");
            sb.Append("  QuitDesc: ").Append(QuitDesc).Append("\n");
            sb.Append("  QuitJumpUrl: ").Append(QuitJumpUrl).Append("\n");
            sb.Append("  QuitType: ").Append(QuitType).Append("\n");
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
            return this.Equals(input as ZMGOQuitConfig);
        }

        /// <summary>
        /// Returns true if ZMGOQuitConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ZMGOQuitConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZMGOQuitConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QuitDesc == input.QuitDesc ||
                    (this.QuitDesc != null &&
                    this.QuitDesc.Equals(input.QuitDesc))
                ) && 
                (
                    this.QuitJumpUrl == input.QuitJumpUrl ||
                    (this.QuitJumpUrl != null &&
                    this.QuitJumpUrl.Equals(input.QuitJumpUrl))
                ) && 
                (
                    this.QuitType == input.QuitType ||
                    (this.QuitType != null &&
                    this.QuitType.Equals(input.QuitType))
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
                if (this.QuitDesc != null)
                {
                    hashCode = (hashCode * 59) + this.QuitDesc.GetHashCode();
                }
                if (this.QuitJumpUrl != null)
                {
                    hashCode = (hashCode * 59) + this.QuitJumpUrl.GetHashCode();
                }
                if (this.QuitType != null)
                {
                    hashCode = (hashCode * 59) + this.QuitType.GetHashCode();
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
