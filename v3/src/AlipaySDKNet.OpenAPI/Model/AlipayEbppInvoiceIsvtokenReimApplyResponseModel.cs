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
    /// AlipayEbppInvoiceIsvtokenReimApplyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceIsvtokenReimApplyResponseModel")]
    public partial class AlipayEbppInvoiceIsvtokenReimApplyResponseModel : IEquatable<AlipayEbppInvoiceIsvtokenReimApplyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceIsvtokenReimApplyResponseModel" /> class.
        /// </summary>
        /// <param name="isvToken">支付宝分配给报销软件的授权token，当前设置有效时间为20分钟.</param>
        /// <param name="serialNo">该次请求的唯一标志，当前设置有效时间为20分钟.</param>
        public AlipayEbppInvoiceIsvtokenReimApplyResponseModel(string isvToken = default(string), string serialNo = default(string))
        {
            this.IsvToken = isvToken;
            this.SerialNo = serialNo;
        }

        /// <summary>
        /// 支付宝分配给报销软件的授权token，当前设置有效时间为20分钟
        /// </summary>
        /// <value>支付宝分配给报销软件的授权token，当前设置有效时间为20分钟</value>
        [DataMember(Name = "isv_token", EmitDefaultValue = false)]
        public string IsvToken { get; set; }

        /// <summary>
        /// 该次请求的唯一标志，当前设置有效时间为20分钟
        /// </summary>
        /// <value>该次请求的唯一标志，当前设置有效时间为20分钟</value>
        [DataMember(Name = "serial_no", EmitDefaultValue = false)]
        public string SerialNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceIsvtokenReimApplyResponseModel {\n");
            sb.Append("  IsvToken: ").Append(IsvToken).Append("\n");
            sb.Append("  SerialNo: ").Append(SerialNo).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceIsvtokenReimApplyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceIsvtokenReimApplyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceIsvtokenReimApplyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceIsvtokenReimApplyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsvToken == input.IsvToken ||
                    (this.IsvToken != null &&
                    this.IsvToken.Equals(input.IsvToken))
                ) && 
                (
                    this.SerialNo == input.SerialNo ||
                    (this.SerialNo != null &&
                    this.SerialNo.Equals(input.SerialNo))
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
                if (this.IsvToken != null)
                {
                    hashCode = (hashCode * 59) + this.IsvToken.GetHashCode();
                }
                if (this.SerialNo != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNo.GetHashCode();
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
