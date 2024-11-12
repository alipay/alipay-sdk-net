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
    /// AlipayOpenMiniIsvFastregisterCreateModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniIsvFastregisterCreateModel")]
    public partial class AlipayOpenMiniIsvFastregisterCreateModel : IEquatable<AlipayOpenMiniIsvFastregisterCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniIsvFastregisterCreateModel" /> class.
        /// </summary>
        /// <param name="appName">小程序名称，昵称半自动设定，强制后缀“的试用小程序”。且该参数会进行关键字检查，如果命中品牌关键字则会报错。 如遇到品牌大客户要用试用小程序，建议用户先换个名字，认证后再修改成品牌名。.</param>
        /// <param name="authNotifyUrl">授权确认成功后回调h5链接或小程序页面.</param>
        /// <param name="outOrderNo">开发者外部订单号，通过开发者账号+外部订单号做业务幂等.</param>
        /// <param name="uid">商户uid.</param>
        public AlipayOpenMiniIsvFastregisterCreateModel(string appName = default(string), string authNotifyUrl = default(string), string outOrderNo = default(string), string uid = default(string))
        {
            this.AppName = appName;
            this.AuthNotifyUrl = authNotifyUrl;
            this.OutOrderNo = outOrderNo;
            this.Uid = uid;
        }

        /// <summary>
        /// 小程序名称，昵称半自动设定，强制后缀“的试用小程序”。且该参数会进行关键字检查，如果命中品牌关键字则会报错。 如遇到品牌大客户要用试用小程序，建议用户先换个名字，认证后再修改成品牌名。
        /// </summary>
        /// <value>小程序名称，昵称半自动设定，强制后缀“的试用小程序”。且该参数会进行关键字检查，如果命中品牌关键字则会报错。 如遇到品牌大客户要用试用小程序，建议用户先换个名字，认证后再修改成品牌名。</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 授权确认成功后回调h5链接或小程序页面
        /// </summary>
        /// <value>授权确认成功后回调h5链接或小程序页面</value>
        [DataMember(Name = "auth_notify_url", EmitDefaultValue = false)]
        public string AuthNotifyUrl { get; set; }

        /// <summary>
        /// 开发者外部订单号，通过开发者账号+外部订单号做业务幂等
        /// </summary>
        /// <value>开发者外部订单号，通过开发者账号+外部订单号做业务幂等</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户uid
        /// </summary>
        /// <value>商户uid</value>
        [DataMember(Name = "uid", EmitDefaultValue = false)]
        public string Uid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniIsvFastregisterCreateModel {\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AuthNotifyUrl: ").Append(AuthNotifyUrl).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniIsvFastregisterCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniIsvFastregisterCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniIsvFastregisterCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniIsvFastregisterCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AuthNotifyUrl == input.AuthNotifyUrl ||
                    (this.AuthNotifyUrl != null &&
                    this.AuthNotifyUrl.Equals(input.AuthNotifyUrl))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
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
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.AuthNotifyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AuthNotifyUrl.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
                }
                if (this.Uid != null)
                {
                    hashCode = (hashCode * 59) + this.Uid.GetHashCode();
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
