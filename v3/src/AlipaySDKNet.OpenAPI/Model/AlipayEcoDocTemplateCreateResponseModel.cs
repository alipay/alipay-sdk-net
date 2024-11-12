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
    /// AlipayEcoDocTemplateCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEcoDocTemplateCreateResponseModel")]
    public partial class AlipayEcoDocTemplateCreateResponseModel : IEquatable<AlipayEcoDocTemplateCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoDocTemplateCreateResponseModel" /> class.
        /// </summary>
        /// <param name="templateId">模板id（请记录模板ID（templateId），后续发起合同签署需要使用到）.</param>
        /// <param name="uploadUrl">文件直传地址，需要用此上传地址使用PUT方式上传文件，只有文件上传后模板才可用.</param>
        public AlipayEcoDocTemplateCreateResponseModel(string templateId = default(string), string uploadUrl = default(string))
        {
            this.TemplateId = templateId;
            this.UploadUrl = uploadUrl;
        }

        /// <summary>
        /// 模板id（请记录模板ID（templateId），后续发起合同签署需要使用到）
        /// </summary>
        /// <value>模板id（请记录模板ID（templateId），后续发起合同签署需要使用到）</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 文件直传地址，需要用此上传地址使用PUT方式上传文件，只有文件上传后模板才可用
        /// </summary>
        /// <value>文件直传地址，需要用此上传地址使用PUT方式上传文件，只有文件上传后模板才可用</value>
        [DataMember(Name = "upload_url", EmitDefaultValue = false)]
        public string UploadUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoDocTemplateCreateResponseModel {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
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
            return this.Equals(input as AlipayEcoDocTemplateCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoDocTemplateCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoDocTemplateCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoDocTemplateCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.UploadUrl == input.UploadUrl ||
                    (this.UploadUrl != null &&
                    this.UploadUrl.Equals(input.UploadUrl))
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
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.UploadUrl != null)
                {
                    hashCode = (hashCode * 59) + this.UploadUrl.GetHashCode();
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
