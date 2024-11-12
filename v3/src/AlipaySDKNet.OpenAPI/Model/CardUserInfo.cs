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
    /// CardUserInfo
    /// </summary>
    [DataContract(Name = "CardUserInfo")]
    public partial class CardUserInfo : IEquatable<CardUserInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardUserInfo" /> class.
        /// </summary>
        /// <param name="openId">用户open_id.</param>
        /// <param name="userUniId">用户唯一标识, 根据user_uni_id_type类型来定 （目前暂支持支付宝userId）  支付宝userId说明：支付宝用户号是以2088开头的16位纯数字组成.</param>
        /// <param name="userUniIdType">用户唯一标识类型.</param>
        public CardUserInfo(string openId = default(string), string userUniId = default(string), string userUniIdType = default(string))
        {
            this.OpenId = openId;
            this.UserUniId = userUniId;
            this.UserUniIdType = userUniIdType;
        }

        /// <summary>
        /// 用户open_id
        /// </summary>
        /// <value>用户open_id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户唯一标识, 根据user_uni_id_type类型来定 （目前暂支持支付宝userId）  支付宝userId说明：支付宝用户号是以2088开头的16位纯数字组成
        /// </summary>
        /// <value>用户唯一标识, 根据user_uni_id_type类型来定 （目前暂支持支付宝userId）  支付宝userId说明：支付宝用户号是以2088开头的16位纯数字组成</value>
        [DataMember(Name = "user_uni_id", EmitDefaultValue = false)]
        public string UserUniId { get; set; }

        /// <summary>
        /// 用户唯一标识类型
        /// </summary>
        /// <value>用户唯一标识类型</value>
        [DataMember(Name = "user_uni_id_type", EmitDefaultValue = false)]
        public string UserUniIdType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardUserInfo {\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  UserUniId: ").Append(UserUniId).Append("\n");
            sb.Append("  UserUniIdType: ").Append(UserUniIdType).Append("\n");
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
            return this.Equals(input as CardUserInfo);
        }

        /// <summary>
        /// Returns true if CardUserInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CardUserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardUserInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.UserUniId == input.UserUniId ||
                    (this.UserUniId != null &&
                    this.UserUniId.Equals(input.UserUniId))
                ) && 
                (
                    this.UserUniIdType == input.UserUniIdType ||
                    (this.UserUniIdType != null &&
                    this.UserUniIdType.Equals(input.UserUniIdType))
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
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.UserUniId != null)
                {
                    hashCode = (hashCode * 59) + this.UserUniId.GetHashCode();
                }
                if (this.UserUniIdType != null)
                {
                    hashCode = (hashCode * 59) + this.UserUniIdType.GetHashCode();
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
