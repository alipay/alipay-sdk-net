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
    /// AlipayMarketingActivityBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityBatchqueryResponseModel")]
    public partial class AlipayMarketingActivityBatchqueryResponseModel : IEquatable<AlipayMarketingActivityBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="activityLiteInfos">活动摘要信息.</param>
        /// <param name="pageNum">分页查询页码。.</param>
        /// <param name="pageSize">分页查询单页数据条数。.</param>
        /// <param name="totalSize">经过条件筛选，查询到的活动总数量.</param>
        public AlipayMarketingActivityBatchqueryResponseModel(List<ActivityLiteInfo> activityLiteInfos = default(List<ActivityLiteInfo>), int pageNum = default(int), int pageSize = default(int), string totalSize = default(string))
        {
            this.ActivityLiteInfos = activityLiteInfos;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// 活动摘要信息
        /// </summary>
        /// <value>活动摘要信息</value>
        [DataMember(Name = "activity_lite_infos", EmitDefaultValue = false)]
        public List<ActivityLiteInfo> ActivityLiteInfos { get; set; }

        /// <summary>
        /// 分页查询页码。
        /// </summary>
        /// <value>分页查询页码。</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数。
        /// </summary>
        /// <value>分页查询单页数据条数。</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 经过条件筛选，查询到的活动总数量
        /// </summary>
        /// <value>经过条件筛选，查询到的活动总数量</value>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public string TotalSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityBatchqueryResponseModel {\n");
            sb.Append("  ActivityLiteInfos: ").Append(ActivityLiteInfos).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityLiteInfos == input.ActivityLiteInfos ||
                    this.ActivityLiteInfos != null &&
                    input.ActivityLiteInfos != null &&
                    this.ActivityLiteInfos.SequenceEqual(input.ActivityLiteInfos)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.TotalSize == input.TotalSize ||
                    (this.TotalSize != null &&
                    this.TotalSize.Equals(input.TotalSize))
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
                if (this.ActivityLiteInfos != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityLiteInfos.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.TotalSize != null)
                {
                    hashCode = (hashCode * 59) + this.TotalSize.GetHashCode();
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
