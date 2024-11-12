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
    /// AlipayMarketingCampaignCashTriggerModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCampaignCashTriggerModel")]
    public partial class AlipayMarketingCampaignCashTriggerModel : IEquatable<AlipayMarketingCampaignCashTriggerModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCampaignCashTriggerModel" /> class.
        /// </summary>
        /// <param name="crowdNo">现金活动号，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_5/alipay.marketing.campaign.cash.create\&quot;&gt;alipay.marketing.campaign.cash.create&lt;/a&gt;(创建现金活动)接口创建现金活动获取。.</param>
        /// <param name="loginId">用户登录账号名，一般为邮箱或手机号。 注意：user_id与login_id二选一必填，同时传入时以user_id为准。.</param>
        /// <param name="openId">open_id.</param>
        /// <param name="orderPrice">此字段如果传入金额，就忽略prize_type算法，按照传入的金额发奖。如果不传或者小于等于0，则按照活动创建时指定的prize_type为fixed或者random算法发奖.</param>
        /// <param name="outBizNo">领取红包的外部业务号，只由可由字母、数字、下划线组成。同一个活动中不可重复，相同的外部业务号会被幂等并返回之前的结果。不填时，系统会生成一个默认固定的外部业务号。.</param>
        /// <param name="userId">用户支付宝唯一标识，2088开头。 注意：user_id与login_id二选一必填，同时传入时以user_id为准。.</param>
        public AlipayMarketingCampaignCashTriggerModel(string crowdNo = default(string), string loginId = default(string), string openId = default(string), string orderPrice = default(string), string outBizNo = default(string), string userId = default(string))
        {
            this.CrowdNo = crowdNo;
            this.LoginId = loginId;
            this.OpenId = openId;
            this.OrderPrice = orderPrice;
            this.OutBizNo = outBizNo;
            this.UserId = userId;
        }

        /// <summary>
        /// 现金活动号，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_5/alipay.marketing.campaign.cash.create\&quot;&gt;alipay.marketing.campaign.cash.create&lt;/a&gt;(创建现金活动)接口创建现金活动获取。
        /// </summary>
        /// <value>现金活动号，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_5/alipay.marketing.campaign.cash.create\&quot;&gt;alipay.marketing.campaign.cash.create&lt;/a&gt;(创建现金活动)接口创建现金活动获取。</value>
        [DataMember(Name = "crowd_no", EmitDefaultValue = false)]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 用户登录账号名，一般为邮箱或手机号。 注意：user_id与login_id二选一必填，同时传入时以user_id为准。
        /// </summary>
        /// <value>用户登录账号名，一般为邮箱或手机号。 注意：user_id与login_id二选一必填，同时传入时以user_id为准。</value>
        [DataMember(Name = "login_id", EmitDefaultValue = false)]
        public string LoginId { get; set; }

        /// <summary>
        /// open_id
        /// </summary>
        /// <value>open_id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 此字段如果传入金额，就忽略prize_type算法，按照传入的金额发奖。如果不传或者小于等于0，则按照活动创建时指定的prize_type为fixed或者random算法发奖
        /// </summary>
        /// <value>此字段如果传入金额，就忽略prize_type算法，按照传入的金额发奖。如果不传或者小于等于0，则按照活动创建时指定的prize_type为fixed或者random算法发奖</value>
        [DataMember(Name = "order_price", EmitDefaultValue = false)]
        public string OrderPrice { get; set; }

        /// <summary>
        /// 领取红包的外部业务号，只由可由字母、数字、下划线组成。同一个活动中不可重复，相同的外部业务号会被幂等并返回之前的结果。不填时，系统会生成一个默认固定的外部业务号。
        /// </summary>
        /// <value>领取红包的外部业务号，只由可由字母、数字、下划线组成。同一个活动中不可重复，相同的外部业务号会被幂等并返回之前的结果。不填时，系统会生成一个默认固定的外部业务号。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户支付宝唯一标识，2088开头。 注意：user_id与login_id二选一必填，同时传入时以user_id为准。
        /// </summary>
        /// <value>用户支付宝唯一标识，2088开头。 注意：user_id与login_id二选一必填，同时传入时以user_id为准。</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCampaignCashTriggerModel {\n");
            sb.Append("  CrowdNo: ").Append(CrowdNo).Append("\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OrderPrice: ").Append(OrderPrice).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as AlipayMarketingCampaignCashTriggerModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCampaignCashTriggerModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCampaignCashTriggerModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCampaignCashTriggerModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CrowdNo == input.CrowdNo ||
                    (this.CrowdNo != null &&
                    this.CrowdNo.Equals(input.CrowdNo))
                ) && 
                (
                    this.LoginId == input.LoginId ||
                    (this.LoginId != null &&
                    this.LoginId.Equals(input.LoginId))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OrderPrice == input.OrderPrice ||
                    (this.OrderPrice != null &&
                    this.OrderPrice.Equals(input.OrderPrice))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.CrowdNo != null)
                {
                    hashCode = (hashCode * 59) + this.CrowdNo.GetHashCode();
                }
                if (this.LoginId != null)
                {
                    hashCode = (hashCode * 59) + this.LoginId.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OrderPrice != null)
                {
                    hashCode = (hashCode * 59) + this.OrderPrice.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
