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
    /// ZhimaCreditPeZmgoBizoptCloseResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPeZmgoBizoptCloseResponseModel")]
    public partial class ZhimaCreditPeZmgoBizoptCloseResponseModel : IEquatable<ZhimaCreditPeZmgoBizoptCloseResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoBizoptCloseResponseModel" /> class.
        /// </summary>
        /// <param name="bizOptNo">芝麻GO签约申请时生成的签约申请单据号.</param>
        /// <param name="openId">蚂蚁统一会员ID.</param>
        /// <param name="outRequestNo">商户本次操作的请求流水号.</param>
        /// <param name="partnerId">商户ID.</param>
        /// <param name="userId">蚂蚁统一会员ID.</param>
        public ZhimaCreditPeZmgoBizoptCloseResponseModel(string bizOptNo = default(string), string openId = default(string), string outRequestNo = default(string), string partnerId = default(string), string userId = default(string))
        {
            this.BizOptNo = bizOptNo;
            this.OpenId = openId;
            this.OutRequestNo = outRequestNo;
            this.PartnerId = partnerId;
            this.UserId = userId;
        }

        /// <summary>
        /// 芝麻GO签约申请时生成的签约申请单据号
        /// </summary>
        /// <value>芝麻GO签约申请时生成的签约申请单据号</value>
        [DataMember(Name = "biz_opt_no", EmitDefaultValue = false)]
        public string BizOptNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        /// <value>蚂蚁统一会员ID</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号
        /// </summary>
        /// <value>商户本次操作的请求流水号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        /// <value>商户ID</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        /// <value>蚂蚁统一会员ID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPeZmgoBizoptCloseResponseModel {\n");
            sb.Append("  BizOptNo: ").Append(BizOptNo).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as ZhimaCreditPeZmgoBizoptCloseResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPeZmgoBizoptCloseResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPeZmgoBizoptCloseResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPeZmgoBizoptCloseResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizOptNo == input.BizOptNo ||
                    (this.BizOptNo != null &&
                    this.BizOptNo.Equals(input.BizOptNo))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.BizOptNo != null)
                {
                    hashCode = (hashCode * 59) + this.BizOptNo.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
