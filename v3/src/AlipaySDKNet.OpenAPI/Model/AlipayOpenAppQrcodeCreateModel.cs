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
    /// AlipayOpenAppQrcodeCreateModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAppQrcodeCreateModel")]
    public partial class AlipayOpenAppQrcodeCreateModel : IEquatable<AlipayOpenAppQrcodeCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppQrcodeCreateModel" /> class.
        /// </summary>
        /// <param name="color">圆形二维码颜色（十六进制颜色色值），仅圆形二维码支持颜色设置，方形二维码默认为黑色。.</param>
        /// <param name="describe">对应的二维码描述.</param>
        /// <param name="queryParam">小程序启动参数，内容按照格式为参数名&#x3D;参数值&amp;参数名&#x3D;参数值。打开小程序的query ，在小程序 onLaunch的方法中获取。可查看 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/support/01rb2a\&quot;&gt;如何获取各种场景的启动参数&lt;/a&gt;。.</param>
        /// <param name="size">合成后图片的大小规格，有s、m、l三档可选。.</param>
        /// <param name="urlParam">page/component/component-pages/view/view为小程序中能访问到的页面路径.</param>
        public AlipayOpenAppQrcodeCreateModel(string color = default(string), string describe = default(string), string queryParam = default(string), string size = default(string), string urlParam = default(string))
        {
            this.Color = color;
            this.Describe = describe;
            this.QueryParam = queryParam;
            this.Size = size;
            this.UrlParam = urlParam;
        }

        /// <summary>
        /// 圆形二维码颜色（十六进制颜色色值），仅圆形二维码支持颜色设置，方形二维码默认为黑色。
        /// </summary>
        /// <value>圆形二维码颜色（十六进制颜色色值），仅圆形二维码支持颜色设置，方形二维码默认为黑色。</value>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// 对应的二维码描述
        /// </summary>
        /// <value>对应的二维码描述</value>
        [DataMember(Name = "describe", EmitDefaultValue = false)]
        public string Describe { get; set; }

        /// <summary>
        /// 小程序启动参数，内容按照格式为参数名&#x3D;参数值&amp;参数名&#x3D;参数值。打开小程序的query ，在小程序 onLaunch的方法中获取。可查看 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/support/01rb2a\&quot;&gt;如何获取各种场景的启动参数&lt;/a&gt;。
        /// </summary>
        /// <value>小程序启动参数，内容按照格式为参数名&#x3D;参数值&amp;参数名&#x3D;参数值。打开小程序的query ，在小程序 onLaunch的方法中获取。可查看 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/support/01rb2a\&quot;&gt;如何获取各种场景的启动参数&lt;/a&gt;。</value>
        [DataMember(Name = "query_param", EmitDefaultValue = false)]
        public string QueryParam { get; set; }

        /// <summary>
        /// 合成后图片的大小规格，有s、m、l三档可选。
        /// </summary>
        /// <value>合成后图片的大小规格，有s、m、l三档可选。</value>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public string Size { get; set; }

        /// <summary>
        /// page/component/component-pages/view/view为小程序中能访问到的页面路径
        /// </summary>
        /// <value>page/component/component-pages/view/view为小程序中能访问到的页面路径</value>
        [DataMember(Name = "url_param", EmitDefaultValue = false)]
        public string UrlParam { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAppQrcodeCreateModel {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Describe: ").Append(Describe).Append("\n");
            sb.Append("  QueryParam: ").Append(QueryParam).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  UrlParam: ").Append(UrlParam).Append("\n");
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
            return this.Equals(input as AlipayOpenAppQrcodeCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAppQrcodeCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAppQrcodeCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAppQrcodeCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.Describe == input.Describe ||
                    (this.Describe != null &&
                    this.Describe.Equals(input.Describe))
                ) && 
                (
                    this.QueryParam == input.QueryParam ||
                    (this.QueryParam != null &&
                    this.QueryParam.Equals(input.QueryParam))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.UrlParam == input.UrlParam ||
                    (this.UrlParam != null &&
                    this.UrlParam.Equals(input.UrlParam))
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
                if (this.Color != null)
                {
                    hashCode = (hashCode * 59) + this.Color.GetHashCode();
                }
                if (this.Describe != null)
                {
                    hashCode = (hashCode * 59) + this.Describe.GetHashCode();
                }
                if (this.QueryParam != null)
                {
                    hashCode = (hashCode * 59) + this.QueryParam.GetHashCode();
                }
                if (this.Size != null)
                {
                    hashCode = (hashCode * 59) + this.Size.GetHashCode();
                }
                if (this.UrlParam != null)
                {
                    hashCode = (hashCode * 59) + this.UrlParam.GetHashCode();
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
