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
    /// AlipayOpenSearchAppkeywordBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchAppkeywordBatchqueryResponseModel")]
    public partial class AlipayOpenSearchAppkeywordBatchqueryResponseModel : IEquatable<AlipayOpenSearchAppkeywordBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchAppkeywordBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="keyWordInfo">审核通过关键词明细.</param>
        /// <param name="pageNumber">第几页.</param>
        /// <param name="pageSize">每页条数.</param>
        /// <param name="totalCount">总条数.</param>
        /// <param name="totalPageCount">总页数.</param>
        public AlipayOpenSearchAppkeywordBatchqueryResponseModel(List<KeyWordInfo> keyWordInfo = default(List<KeyWordInfo>), int pageNumber = default(int), int pageSize = default(int), int totalCount = default(int), int totalPageCount = default(int))
        {
            this.KeyWordInfo = keyWordInfo;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.TotalCount = totalCount;
            this.TotalPageCount = totalPageCount;
        }

        /// <summary>
        /// 审核通过关键词明细
        /// </summary>
        /// <value>审核通过关键词明细</value>
        [DataMember(Name = "key_word_info", EmitDefaultValue = false)]
        public List<KeyWordInfo> KeyWordInfo { get; set; }

        /// <summary>
        /// 第几页
        /// </summary>
        /// <value>第几页</value>
        [DataMember(Name = "page_number", EmitDefaultValue = false)]
        public int PageNumber { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        /// <value>每页条数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        /// <value>总条数</value>
        [DataMember(Name = "total_count", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        /// <value>总页数</value>
        [DataMember(Name = "total_page_count", EmitDefaultValue = false)]
        public int TotalPageCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSearchAppkeywordBatchqueryResponseModel {\n");
            sb.Append("  KeyWordInfo: ").Append(KeyWordInfo).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  TotalPageCount: ").Append(TotalPageCount).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchAppkeywordBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchAppkeywordBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchAppkeywordBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchAppkeywordBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeyWordInfo == input.KeyWordInfo ||
                    this.KeyWordInfo != null &&
                    input.KeyWordInfo != null &&
                    this.KeyWordInfo.SequenceEqual(input.KeyWordInfo)
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    this.PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
                ) && 
                (
                    this.TotalPageCount == input.TotalPageCount ||
                    this.TotalPageCount.Equals(input.TotalPageCount)
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
                if (this.KeyWordInfo != null)
                {
                    hashCode = (hashCode * 59) + this.KeyWordInfo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPageCount.GetHashCode();
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
