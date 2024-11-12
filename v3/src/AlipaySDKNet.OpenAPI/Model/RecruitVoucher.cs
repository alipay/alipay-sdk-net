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
    /// RecruitVoucher
    /// </summary>
    [DataContract(Name = "RecruitVoucher")]
    public partial class RecruitVoucher : IEquatable<RecruitVoucher>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecruitVoucher" /> class.
        /// </summary>
        /// <param name="activityId">券活动id。支持商家券（创建商家券请参考https://opendocs.alipay.com/apis/01xm17）和支付券（创建支付券请参考https://opendocs.alipay.com/pre-apis/027185，仅供受邀用户使用），取值均为返回结果的activity_id字段。.</param>
        public RecruitVoucher(string activityId = default(string))
        {
            this.ActivityId = activityId;
        }

        /// <summary>
        /// 券活动id。支持商家券（创建商家券请参考https://opendocs.alipay.com/apis/01xm17）和支付券（创建支付券请参考https://opendocs.alipay.com/pre-apis/027185，仅供受邀用户使用），取值均为返回结果的activity_id字段。
        /// </summary>
        /// <value>券活动id。支持商家券（创建商家券请参考https://opendocs.alipay.com/apis/01xm17）和支付券（创建支付券请参考https://opendocs.alipay.com/pre-apis/027185，仅供受邀用户使用），取值均为返回结果的activity_id字段。</value>
        [DataMember(Name = "activity_id", EmitDefaultValue = false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecruitVoucher {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
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
            return this.Equals(input as RecruitVoucher);
        }

        /// <summary>
        /// Returns true if RecruitVoucher instances are equal
        /// </summary>
        /// <param name="input">Instance of RecruitVoucher to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecruitVoucher input)
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
