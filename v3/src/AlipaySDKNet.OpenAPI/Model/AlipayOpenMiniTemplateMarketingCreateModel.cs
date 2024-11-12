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
    /// AlipayOpenMiniTemplateMarketingCreateModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniTemplateMarketingCreateModel")]
    public partial class AlipayOpenMiniTemplateMarketingCreateModel : IEquatable<AlipayOpenMiniTemplateMarketingCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniTemplateMarketingCreateModel" /> class.
        /// </summary>
        /// <param name="activityId">营销活动id.</param>
        /// <param name="gmtEnd">活动结束时间.</param>
        /// <param name="gmtStart">活动开始时间.</param>
        /// <param name="templateIds">消息模板id列表，最多50个模板id.</param>
        /// <param name="title">消息运营位名称，不填默认使用券名称.</param>
        public AlipayOpenMiniTemplateMarketingCreateModel(string activityId = default(string), string gmtEnd = default(string), string gmtStart = default(string), List<string> templateIds = default(List<string>), string title = default(string))
        {
            this.ActivityId = activityId;
            this.GmtEnd = gmtEnd;
            this.GmtStart = gmtStart;
            this.TemplateIds = templateIds;
            this.Title = title;
        }

        /// <summary>
        /// 营销活动id
        /// </summary>
        /// <value>营销活动id</value>
        [DataMember(Name = "activity_id", EmitDefaultValue = false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        /// <value>活动结束时间</value>
        [DataMember(Name = "gmt_end", EmitDefaultValue = false)]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        /// <value>活动开始时间</value>
        [DataMember(Name = "gmt_start", EmitDefaultValue = false)]
        public string GmtStart { get; set; }

        /// <summary>
        /// 消息模板id列表，最多50个模板id
        /// </summary>
        /// <value>消息模板id列表，最多50个模板id</value>
        [DataMember(Name = "template_ids", EmitDefaultValue = false)]
        public List<string> TemplateIds { get; set; }

        /// <summary>
        /// 消息运营位名称，不填默认使用券名称
        /// </summary>
        /// <value>消息运营位名称，不填默认使用券名称</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniTemplateMarketingCreateModel {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  GmtEnd: ").Append(GmtEnd).Append("\n");
            sb.Append("  GmtStart: ").Append(GmtStart).Append("\n");
            sb.Append("  TemplateIds: ").Append(TemplateIds).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniTemplateMarketingCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniTemplateMarketingCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniTemplateMarketingCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniTemplateMarketingCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.GmtEnd == input.GmtEnd ||
                    (this.GmtEnd != null &&
                    this.GmtEnd.Equals(input.GmtEnd))
                ) && 
                (
                    this.GmtStart == input.GmtStart ||
                    (this.GmtStart != null &&
                    this.GmtStart.Equals(input.GmtStart))
                ) && 
                (
                    this.TemplateIds == input.TemplateIds ||
                    this.TemplateIds != null &&
                    input.TemplateIds != null &&
                    this.TemplateIds.SequenceEqual(input.TemplateIds)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.ActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityId.GetHashCode();
                }
                if (this.GmtEnd != null)
                {
                    hashCode = (hashCode * 59) + this.GmtEnd.GetHashCode();
                }
                if (this.GmtStart != null)
                {
                    hashCode = (hashCode * 59) + this.GmtStart.GetHashCode();
                }
                if (this.TemplateIds != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateIds.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
