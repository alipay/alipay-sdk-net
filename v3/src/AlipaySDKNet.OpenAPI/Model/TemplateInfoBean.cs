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
    /// TemplateInfoBean
    /// </summary>
    [DataContract(Name = "TemplateInfoBean")]
    public partial class TemplateInfoBean : IEquatable<TemplateInfoBean>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateInfoBean" /> class.
        /// </summary>
        /// <param name="fillContents">模板填充项，根据组件key值传入填写内容.</param>
        /// <param name="name">签署文件名称.</param>
        /// <param name="signfields">签署区，根据签署区key值传入对应的签署人信息.</param>
        /// <param name="templateId">模板id，通过创建合同模板获取.</param>
        public TemplateInfoBean(List<FillContent> fillContents = default(List<FillContent>), string name = default(string), List<SignFieldBean> signfields = default(List<SignFieldBean>), string templateId = default(string))
        {
            this.FillContents = fillContents;
            this.Name = name;
            this.Signfields = signfields;
            this.TemplateId = templateId;
        }

        /// <summary>
        /// 模板填充项，根据组件key值传入填写内容
        /// </summary>
        /// <value>模板填充项，根据组件key值传入填写内容</value>
        [DataMember(Name = "fill_contents", EmitDefaultValue = false)]
        public List<FillContent> FillContents { get; set; }

        /// <summary>
        /// 签署文件名称
        /// </summary>
        /// <value>签署文件名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 签署区，根据签署区key值传入对应的签署人信息
        /// </summary>
        /// <value>签署区，根据签署区key值传入对应的签署人信息</value>
        [DataMember(Name = "signfields", EmitDefaultValue = false)]
        public List<SignFieldBean> Signfields { get; set; }

        /// <summary>
        /// 模板id，通过创建合同模板获取
        /// </summary>
        /// <value>模板id，通过创建合同模板获取</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateInfoBean {\n");
            sb.Append("  FillContents: ").Append(FillContents).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Signfields: ").Append(Signfields).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
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
            return this.Equals(input as TemplateInfoBean);
        }

        /// <summary>
        /// Returns true if TemplateInfoBean instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateInfoBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateInfoBean input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FillContents == input.FillContents ||
                    this.FillContents != null &&
                    input.FillContents != null &&
                    this.FillContents.SequenceEqual(input.FillContents)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Signfields == input.Signfields ||
                    this.Signfields != null &&
                    input.Signfields != null &&
                    this.Signfields.SequenceEqual(input.Signfields)
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
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
                if (this.FillContents != null)
                {
                    hashCode = (hashCode * 59) + this.FillContents.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Signfields != null)
                {
                    hashCode = (hashCode * 59) + this.Signfields.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
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
