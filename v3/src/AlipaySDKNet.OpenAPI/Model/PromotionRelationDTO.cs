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
    /// PromotionRelationDTO
    /// </summary>
    [DataContract(Name = "PromotionRelationDTO")]
    public partial class PromotionRelationDTO : IEquatable<PromotionRelationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionRelationDTO" /> class.
        /// </summary>
        /// <param name="applyReason">申请推广时填写的申请理由.</param>
        /// <param name="commodityId">服务商品ID.</param>
        /// <param name="commodityName">服务商品名称.</param>
        /// <param name="createTime">推广关系创建时间.</param>
        /// <param name="promoterContactName">推广服务商联系人名称.</param>
        /// <param name="promoterContactPhone">推广服务商联系电话.</param>
        /// <param name="promoterName">推广服务商的名称.</param>
        /// <param name="promoterPid">推广服务商的pid.</param>
        /// <param name="promotionId">推广任务id.</param>
        /// <param name="promotionName">推广任务的名称.</param>
        public PromotionRelationDTO(string applyReason = default(string), string commodityId = default(string), string commodityName = default(string), string createTime = default(string), string promoterContactName = default(string), string promoterContactPhone = default(string), string promoterName = default(string), string promoterPid = default(string), string promotionId = default(string), string promotionName = default(string))
        {
            this.ApplyReason = applyReason;
            this.CommodityId = commodityId;
            this.CommodityName = commodityName;
            this.CreateTime = createTime;
            this.PromoterContactName = promoterContactName;
            this.PromoterContactPhone = promoterContactPhone;
            this.PromoterName = promoterName;
            this.PromoterPid = promoterPid;
            this.PromotionId = promotionId;
            this.PromotionName = promotionName;
        }

        /// <summary>
        /// 申请推广时填写的申请理由
        /// </summary>
        /// <value>申请推广时填写的申请理由</value>
        [DataMember(Name = "apply_reason", EmitDefaultValue = false)]
        public string ApplyReason { get; set; }

        /// <summary>
        /// 服务商品ID
        /// </summary>
        /// <value>服务商品ID</value>
        [DataMember(Name = "commodity_id", EmitDefaultValue = false)]
        public string CommodityId { get; set; }

        /// <summary>
        /// 服务商品名称
        /// </summary>
        /// <value>服务商品名称</value>
        [DataMember(Name = "commodity_name", EmitDefaultValue = false)]
        public string CommodityName { get; set; }

        /// <summary>
        /// 推广关系创建时间
        /// </summary>
        /// <value>推广关系创建时间</value>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 推广服务商联系人名称
        /// </summary>
        /// <value>推广服务商联系人名称</value>
        [DataMember(Name = "promoter_contact_name", EmitDefaultValue = false)]
        public string PromoterContactName { get; set; }

        /// <summary>
        /// 推广服务商联系电话
        /// </summary>
        /// <value>推广服务商联系电话</value>
        [DataMember(Name = "promoter_contact_phone", EmitDefaultValue = false)]
        public string PromoterContactPhone { get; set; }

        /// <summary>
        /// 推广服务商的名称
        /// </summary>
        /// <value>推广服务商的名称</value>
        [DataMember(Name = "promoter_name", EmitDefaultValue = false)]
        public string PromoterName { get; set; }

        /// <summary>
        /// 推广服务商的pid
        /// </summary>
        /// <value>推广服务商的pid</value>
        [DataMember(Name = "promoter_pid", EmitDefaultValue = false)]
        public string PromoterPid { get; set; }

        /// <summary>
        /// 推广任务id
        /// </summary>
        /// <value>推广任务id</value>
        [DataMember(Name = "promotion_id", EmitDefaultValue = false)]
        public string PromotionId { get; set; }

        /// <summary>
        /// 推广任务的名称
        /// </summary>
        /// <value>推广任务的名称</value>
        [DataMember(Name = "promotion_name", EmitDefaultValue = false)]
        public string PromotionName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PromotionRelationDTO {\n");
            sb.Append("  ApplyReason: ").Append(ApplyReason).Append("\n");
            sb.Append("  CommodityId: ").Append(CommodityId).Append("\n");
            sb.Append("  CommodityName: ").Append(CommodityName).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  PromoterContactName: ").Append(PromoterContactName).Append("\n");
            sb.Append("  PromoterContactPhone: ").Append(PromoterContactPhone).Append("\n");
            sb.Append("  PromoterName: ").Append(PromoterName).Append("\n");
            sb.Append("  PromoterPid: ").Append(PromoterPid).Append("\n");
            sb.Append("  PromotionId: ").Append(PromotionId).Append("\n");
            sb.Append("  PromotionName: ").Append(PromotionName).Append("\n");
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
            return this.Equals(input as PromotionRelationDTO);
        }

        /// <summary>
        /// Returns true if PromotionRelationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PromotionRelationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromotionRelationDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyReason == input.ApplyReason ||
                    (this.ApplyReason != null &&
                    this.ApplyReason.Equals(input.ApplyReason))
                ) && 
                (
                    this.CommodityId == input.CommodityId ||
                    (this.CommodityId != null &&
                    this.CommodityId.Equals(input.CommodityId))
                ) && 
                (
                    this.CommodityName == input.CommodityName ||
                    (this.CommodityName != null &&
                    this.CommodityName.Equals(input.CommodityName))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.PromoterContactName == input.PromoterContactName ||
                    (this.PromoterContactName != null &&
                    this.PromoterContactName.Equals(input.PromoterContactName))
                ) && 
                (
                    this.PromoterContactPhone == input.PromoterContactPhone ||
                    (this.PromoterContactPhone != null &&
                    this.PromoterContactPhone.Equals(input.PromoterContactPhone))
                ) && 
                (
                    this.PromoterName == input.PromoterName ||
                    (this.PromoterName != null &&
                    this.PromoterName.Equals(input.PromoterName))
                ) && 
                (
                    this.PromoterPid == input.PromoterPid ||
                    (this.PromoterPid != null &&
                    this.PromoterPid.Equals(input.PromoterPid))
                ) && 
                (
                    this.PromotionId == input.PromotionId ||
                    (this.PromotionId != null &&
                    this.PromotionId.Equals(input.PromotionId))
                ) && 
                (
                    this.PromotionName == input.PromotionName ||
                    (this.PromotionName != null &&
                    this.PromotionName.Equals(input.PromotionName))
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
                if (this.ApplyReason != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyReason.GetHashCode();
                }
                if (this.CommodityId != null)
                {
                    hashCode = (hashCode * 59) + this.CommodityId.GetHashCode();
                }
                if (this.CommodityName != null)
                {
                    hashCode = (hashCode * 59) + this.CommodityName.GetHashCode();
                }
                if (this.CreateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateTime.GetHashCode();
                }
                if (this.PromoterContactName != null)
                {
                    hashCode = (hashCode * 59) + this.PromoterContactName.GetHashCode();
                }
                if (this.PromoterContactPhone != null)
                {
                    hashCode = (hashCode * 59) + this.PromoterContactPhone.GetHashCode();
                }
                if (this.PromoterName != null)
                {
                    hashCode = (hashCode * 59) + this.PromoterName.GetHashCode();
                }
                if (this.PromoterPid != null)
                {
                    hashCode = (hashCode * 59) + this.PromoterPid.GetHashCode();
                }
                if (this.PromotionId != null)
                {
                    hashCode = (hashCode * 59) + this.PromotionId.GetHashCode();
                }
                if (this.PromotionName != null)
                {
                    hashCode = (hashCode * 59) + this.PromotionName.GetHashCode();
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
