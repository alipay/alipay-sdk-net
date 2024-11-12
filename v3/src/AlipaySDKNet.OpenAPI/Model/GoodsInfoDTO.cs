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
    /// GoodsInfoDTO
    /// </summary>
    [DataContract(Name = "GoodsInfoDTO")]
    public partial class GoodsInfoDTO : IEquatable<GoodsInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoodsInfoDTO" /> class.
        /// </summary>
        /// <param name="goodsAmount">商品金额.</param>
        /// <param name="goodsCount">商品购买数量.</param>
        /// <param name="goodsId">商品标准69码.</param>
        /// <param name="goodsName">商品名称.</param>
        public GoodsInfoDTO(string goodsAmount = default(string), string goodsCount = default(string), string goodsId = default(string), string goodsName = default(string))
        {
            this.GoodsAmount = goodsAmount;
            this.GoodsCount = goodsCount;
            this.GoodsId = goodsId;
            this.GoodsName = goodsName;
        }

        /// <summary>
        /// 商品金额
        /// </summary>
        /// <value>商品金额</value>
        [DataMember(Name = "goods_amount", EmitDefaultValue = false)]
        public string GoodsAmount { get; set; }

        /// <summary>
        /// 商品购买数量
        /// </summary>
        /// <value>商品购买数量</value>
        [DataMember(Name = "goods_count", EmitDefaultValue = false)]
        public string GoodsCount { get; set; }

        /// <summary>
        /// 商品标准69码
        /// </summary>
        /// <value>商品标准69码</value>
        [DataMember(Name = "goods_id", EmitDefaultValue = false)]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <value>商品名称</value>
        [DataMember(Name = "goods_name", EmitDefaultValue = false)]
        public string GoodsName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoodsInfoDTO {\n");
            sb.Append("  GoodsAmount: ").Append(GoodsAmount).Append("\n");
            sb.Append("  GoodsCount: ").Append(GoodsCount).Append("\n");
            sb.Append("  GoodsId: ").Append(GoodsId).Append("\n");
            sb.Append("  GoodsName: ").Append(GoodsName).Append("\n");
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
            return this.Equals(input as GoodsInfoDTO);
        }

        /// <summary>
        /// Returns true if GoodsInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of GoodsInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoodsInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GoodsAmount == input.GoodsAmount ||
                    (this.GoodsAmount != null &&
                    this.GoodsAmount.Equals(input.GoodsAmount))
                ) && 
                (
                    this.GoodsCount == input.GoodsCount ||
                    (this.GoodsCount != null &&
                    this.GoodsCount.Equals(input.GoodsCount))
                ) && 
                (
                    this.GoodsId == input.GoodsId ||
                    (this.GoodsId != null &&
                    this.GoodsId.Equals(input.GoodsId))
                ) && 
                (
                    this.GoodsName == input.GoodsName ||
                    (this.GoodsName != null &&
                    this.GoodsName.Equals(input.GoodsName))
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
                if (this.GoodsAmount != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsAmount.GetHashCode();
                }
                if (this.GoodsCount != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsCount.GetHashCode();
                }
                if (this.GoodsId != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsId.GetHashCode();
                }
                if (this.GoodsName != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsName.GetHashCode();
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
