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
    /// AlipayTradeBatchTransferResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeBatchTransferResponseModel")]
    public partial class AlipayTradeBatchTransferResponseModel : IEquatable<AlipayTradeBatchTransferResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeBatchTransferResponseModel" /> class.
        /// </summary>
        /// <param name="gmtCreate">分账受理时间.</param>
        /// <param name="outRequestNo">分账请求外部流水号.</param>
        /// <param name="resultCode">业务结果码。 ACCEPT_SUCCESS：受理成功； ACCEPT_FAIL：受理失败； SUCCESS：结算处理成功； FAIL：结算处理失败； SYSTEM_EXCEPTION：系统异常.</param>
        /// <param name="settleNo">分账单据号.</param>
        public AlipayTradeBatchTransferResponseModel(string gmtCreate = default(string), string outRequestNo = default(string), string resultCode = default(string), string settleNo = default(string))
        {
            this.GmtCreate = gmtCreate;
            this.OutRequestNo = outRequestNo;
            this.ResultCode = resultCode;
            this.SettleNo = settleNo;
        }

        /// <summary>
        /// 分账受理时间
        /// </summary>
        /// <value>分账受理时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 分账请求外部流水号
        /// </summary>
        /// <value>分账请求外部流水号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 业务结果码。 ACCEPT_SUCCESS：受理成功； ACCEPT_FAIL：受理失败； SUCCESS：结算处理成功； FAIL：结算处理失败； SYSTEM_EXCEPTION：系统异常
        /// </summary>
        /// <value>业务结果码。 ACCEPT_SUCCESS：受理成功； ACCEPT_FAIL：受理失败； SUCCESS：结算处理成功； FAIL：结算处理失败； SYSTEM_EXCEPTION：系统异常</value>
        [DataMember(Name = "result_code", EmitDefaultValue = false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 分账单据号
        /// </summary>
        /// <value>分账单据号</value>
        [DataMember(Name = "settle_no", EmitDefaultValue = false)]
        public string SettleNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeBatchTransferResponseModel {\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  SettleNo: ").Append(SettleNo).Append("\n");
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
            return this.Equals(input as AlipayTradeBatchTransferResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeBatchTransferResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeBatchTransferResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeBatchTransferResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
                ) && 
                (
                    this.SettleNo == input.SettleNo ||
                    (this.SettleNo != null &&
                    this.SettleNo.Equals(input.SettleNo))
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
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.ResultCode != null)
                {
                    hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
                }
                if (this.SettleNo != null)
                {
                    hashCode = (hashCode * 59) + this.SettleNo.GetHashCode();
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
