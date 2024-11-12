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
    /// ZolozAuthenticationCustomerFacemanageDeleteResponseModel
    /// </summary>
    [DataContract(Name = "ZolozAuthenticationCustomerFacemanageDeleteResponseModel")]
    public partial class ZolozAuthenticationCustomerFacemanageDeleteResponseModel : IEquatable<ZolozAuthenticationCustomerFacemanageDeleteResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZolozAuthenticationCustomerFacemanageDeleteResponseModel" /> class.
        /// </summary>
        /// <param name="result">返回值.</param>
        /// <param name="retcode">返回码.</param>
        /// <param name="retcodesub">返回详细码.</param>
        /// <param name="retmessage">返回信息.</param>
        /// <param name="retmessagesub">返回详细信息.</param>
        public ZolozAuthenticationCustomerFacemanageDeleteResponseModel(string result = default(string), string retcode = default(string), string retcodesub = default(string), string retmessage = default(string), string retmessagesub = default(string))
        {
            this.Result = result;
            this.Retcode = retcode;
            this.Retcodesub = retcodesub;
            this.Retmessage = retmessage;
            this.Retmessagesub = retmessagesub;
        }

        /// <summary>
        /// 返回值
        /// </summary>
        /// <value>返回值</value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public string Result { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        /// <value>返回码</value>
        [DataMember(Name = "retcode", EmitDefaultValue = false)]
        public string Retcode { get; set; }

        /// <summary>
        /// 返回详细码
        /// </summary>
        /// <value>返回详细码</value>
        [DataMember(Name = "retcodesub", EmitDefaultValue = false)]
        public string Retcodesub { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        /// <value>返回信息</value>
        [DataMember(Name = "retmessage", EmitDefaultValue = false)]
        public string Retmessage { get; set; }

        /// <summary>
        /// 返回详细信息
        /// </summary>
        /// <value>返回详细信息</value>
        [DataMember(Name = "retmessagesub", EmitDefaultValue = false)]
        public string Retmessagesub { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZolozAuthenticationCustomerFacemanageDeleteResponseModel {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Retcode: ").Append(Retcode).Append("\n");
            sb.Append("  Retcodesub: ").Append(Retcodesub).Append("\n");
            sb.Append("  Retmessage: ").Append(Retmessage).Append("\n");
            sb.Append("  Retmessagesub: ").Append(Retmessagesub).Append("\n");
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
            return this.Equals(input as ZolozAuthenticationCustomerFacemanageDeleteResponseModel);
        }

        /// <summary>
        /// Returns true if ZolozAuthenticationCustomerFacemanageDeleteResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZolozAuthenticationCustomerFacemanageDeleteResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZolozAuthenticationCustomerFacemanageDeleteResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Retcode == input.Retcode ||
                    (this.Retcode != null &&
                    this.Retcode.Equals(input.Retcode))
                ) && 
                (
                    this.Retcodesub == input.Retcodesub ||
                    (this.Retcodesub != null &&
                    this.Retcodesub.Equals(input.Retcodesub))
                ) && 
                (
                    this.Retmessage == input.Retmessage ||
                    (this.Retmessage != null &&
                    this.Retmessage.Equals(input.Retmessage))
                ) && 
                (
                    this.Retmessagesub == input.Retmessagesub ||
                    (this.Retmessagesub != null &&
                    this.Retmessagesub.Equals(input.Retmessagesub))
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
                if (this.Result != null)
                {
                    hashCode = (hashCode * 59) + this.Result.GetHashCode();
                }
                if (this.Retcode != null)
                {
                    hashCode = (hashCode * 59) + this.Retcode.GetHashCode();
                }
                if (this.Retcodesub != null)
                {
                    hashCode = (hashCode * 59) + this.Retcodesub.GetHashCode();
                }
                if (this.Retmessage != null)
                {
                    hashCode = (hashCode * 59) + this.Retmessage.GetHashCode();
                }
                if (this.Retmessagesub != null)
                {
                    hashCode = (hashCode * 59) + this.Retmessagesub.GetHashCode();
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
