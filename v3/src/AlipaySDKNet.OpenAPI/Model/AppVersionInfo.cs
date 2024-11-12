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
    /// AppVersionInfo
    /// </summary>
    [DataContract(Name = "AppVersionInfo")]
    public partial class AppVersionInfo : IEquatable<AppVersionInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppVersionInfo" /> class.
        /// </summary>
        /// <param name="appVersion">版本号，一般为x.y.x格式，其中x、y、z都是数字.</param>
        /// <param name="baseAudit">准入审核结果 （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）.</param>
        /// <param name="bundleId">小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。.</param>
        /// <param name="canRelease">是否可上架 true：可上架 false：不可上架 （version_status 为PROMOTE_AUDIT_REJECT有值） （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）.</param>
        /// <param name="createTime">版本创建时间，精确到秒.</param>
        /// <param name="promoteAudit">营销审核结果： PASS：通过 REJECT：驳回 （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）.</param>
        /// <param name="versionDescription">小程序版本描述，介绍此版本的主要变更和功能，5-500个字符。.</param>
        /// <param name="versionStatus">版本状态，可选值为：INIT: 开发中, AUDITING: 审核中, AUDIT_REJECT: 审核驳回, WAIT_RELEASE: 待上架, BASE_AUDIT_PASS: 准入不可营销, GRAY: 灰度中, RELEASE: 已上架, OFFLINE: 已下架, AUDIT_OFFLINE: 被强制下架;.</param>
        public AppVersionInfo(string appVersion = default(string), string baseAudit = default(string), string bundleId = default(string), string canRelease = default(string), string createTime = default(string), string promoteAudit = default(string), string versionDescription = default(string), string versionStatus = default(string))
        {
            this.AppVersion = appVersion;
            this.BaseAudit = baseAudit;
            this.BundleId = bundleId;
            this.CanRelease = canRelease;
            this.CreateTime = createTime;
            this.PromoteAudit = promoteAudit;
            this.VersionDescription = versionDescription;
            this.VersionStatus = versionStatus;
        }

        /// <summary>
        /// 版本号，一般为x.y.x格式，其中x、y、z都是数字
        /// </summary>
        /// <value>版本号，一般为x.y.x格式，其中x、y、z都是数字</value>
        [DataMember(Name = "app_version", EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// 准入审核结果 （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）
        /// </summary>
        /// <value>准入审核结果 （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）</value>
        [DataMember(Name = "base_audit", EmitDefaultValue = false)]
        public string BaseAudit { get; set; }

        /// <summary>
        /// 小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。
        /// </summary>
        /// <value>小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 是否可上架 true：可上架 false：不可上架 （version_status 为PROMOTE_AUDIT_REJECT有值） （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）
        /// </summary>
        /// <value>是否可上架 true：可上架 false：不可上架 （version_status 为PROMOTE_AUDIT_REJECT有值） （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）</value>
        [DataMember(Name = "can_release", EmitDefaultValue = false)]
        public string CanRelease { get; set; }

        /// <summary>
        /// 版本创建时间，精确到秒
        /// </summary>
        /// <value>版本创建时间，精确到秒</value>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 营销审核结果： PASS：通过 REJECT：驳回 （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）
        /// </summary>
        /// <value>营销审核结果： PASS：通过 REJECT：驳回 （提审时 audit_rule 传 BASE_PROMOTE 时有该字段）</value>
        [DataMember(Name = "promote_audit", EmitDefaultValue = false)]
        public string PromoteAudit { get; set; }

        /// <summary>
        /// 小程序版本描述，介绍此版本的主要变更和功能，5-500个字符。
        /// </summary>
        /// <value>小程序版本描述，介绍此版本的主要变更和功能，5-500个字符。</value>
        [DataMember(Name = "version_description", EmitDefaultValue = false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// 版本状态，可选值为：INIT: 开发中, AUDITING: 审核中, AUDIT_REJECT: 审核驳回, WAIT_RELEASE: 待上架, BASE_AUDIT_PASS: 准入不可营销, GRAY: 灰度中, RELEASE: 已上架, OFFLINE: 已下架, AUDIT_OFFLINE: 被强制下架;
        /// </summary>
        /// <value>版本状态，可选值为：INIT: 开发中, AUDITING: 审核中, AUDIT_REJECT: 审核驳回, WAIT_RELEASE: 待上架, BASE_AUDIT_PASS: 准入不可营销, GRAY: 灰度中, RELEASE: 已上架, OFFLINE: 已下架, AUDIT_OFFLINE: 被强制下架;</value>
        [DataMember(Name = "version_status", EmitDefaultValue = false)]
        public string VersionStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppVersionInfo {\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  BaseAudit: ").Append(BaseAudit).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  CanRelease: ").Append(CanRelease).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  PromoteAudit: ").Append(PromoteAudit).Append("\n");
            sb.Append("  VersionDescription: ").Append(VersionDescription).Append("\n");
            sb.Append("  VersionStatus: ").Append(VersionStatus).Append("\n");
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
            return this.Equals(input as AppVersionInfo);
        }

        /// <summary>
        /// Returns true if AppVersionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AppVersionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppVersionInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.BaseAudit == input.BaseAudit ||
                    (this.BaseAudit != null &&
                    this.BaseAudit.Equals(input.BaseAudit))
                ) && 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.CanRelease == input.CanRelease ||
                    (this.CanRelease != null &&
                    this.CanRelease.Equals(input.CanRelease))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.PromoteAudit == input.PromoteAudit ||
                    (this.PromoteAudit != null &&
                    this.PromoteAudit.Equals(input.PromoteAudit))
                ) && 
                (
                    this.VersionDescription == input.VersionDescription ||
                    (this.VersionDescription != null &&
                    this.VersionDescription.Equals(input.VersionDescription))
                ) && 
                (
                    this.VersionStatus == input.VersionStatus ||
                    (this.VersionStatus != null &&
                    this.VersionStatus.Equals(input.VersionStatus))
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
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                if (this.BaseAudit != null)
                {
                    hashCode = (hashCode * 59) + this.BaseAudit.GetHashCode();
                }
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                if (this.CanRelease != null)
                {
                    hashCode = (hashCode * 59) + this.CanRelease.GetHashCode();
                }
                if (this.CreateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateTime.GetHashCode();
                }
                if (this.PromoteAudit != null)
                {
                    hashCode = (hashCode * 59) + this.PromoteAudit.GetHashCode();
                }
                if (this.VersionDescription != null)
                {
                    hashCode = (hashCode * 59) + this.VersionDescription.GetHashCode();
                }
                if (this.VersionStatus != null)
                {
                    hashCode = (hashCode * 59) + this.VersionStatus.GetHashCode();
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
