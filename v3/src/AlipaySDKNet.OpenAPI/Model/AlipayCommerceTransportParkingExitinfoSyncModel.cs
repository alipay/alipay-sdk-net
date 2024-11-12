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
    /// AlipayCommerceTransportParkingExitinfoSyncModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceTransportParkingExitinfoSyncModel")]
    public partial class AlipayCommerceTransportParkingExitinfoSyncModel : IEquatable<AlipayCommerceTransportParkingExitinfoSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceTransportParkingExitinfoSyncModel" /> class.
        /// </summary>
        /// <param name="exitName">车辆出场的出口通道名称；取实地通道名称；.</param>
        /// <param name="exitNumber">车辆出场的出口通道编号；与线下实地编码一致；.</param>
        /// <param name="isEncryptPlateNo">车牌是否加密，true为加密，false为不加密，默认为false.</param>
        /// <param name="openAppid">蚂蚁会员统一ID对应的归属应用appid.</param>
        /// <param name="openId">蚂蚁会员统一ID.</param>
        /// <param name="outSerialNo">外部停车流水号(用于串通进场与出场信息).</param>
        /// <param name="outTime">车辆出场的时间，格式\&quot;YYYY-MM-DD HH:mm:ss\&quot;，24小时制，请保证服务器时间准确，出场时间不应晚于当前网络时间，也不当早于入场时间。.</param>
        /// <param name="plateColor">车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。.</param>
        /// <param name="plateNo">车牌号（支持加密格式）.</param>
        /// <param name="serviceUrl">停车服务页面地址。 1、服务商停车服务页面地址必须是支付宝小程序URL（无需转换https），详见：https://opendocs.alipay.com/support/01rb18#URL%20%E6%A0%BC%E5%BC%8F 2、若服务商没有服务链接，可传输支付宝停车官方小程序的服务链接：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;pages%2Fparking-fee%2Findex 3、若此次对接的是无感支付，则服务链接传输为：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;%2Fpages%2Fparking-bill%2Findex.</param>
        public AlipayCommerceTransportParkingExitinfoSyncModel(string exitName = default(string), int exitNumber = default(int), bool isEncryptPlateNo = default(bool), string openAppid = default(string), string openId = default(string), string outSerialNo = default(string), string outTime = default(string), string plateColor = default(string), string plateNo = default(string), string serviceUrl = default(string))
        {
            this.ExitName = exitName;
            this.ExitNumber = exitNumber;
            this.IsEncryptPlateNo = isEncryptPlateNo;
            this.OpenAppid = openAppid;
            this.OpenId = openId;
            this.OutSerialNo = outSerialNo;
            this.OutTime = outTime;
            this.PlateColor = plateColor;
            this.PlateNo = plateNo;
            this.ServiceUrl = serviceUrl;
        }

        /// <summary>
        /// 车辆出场的出口通道名称；取实地通道名称；
        /// </summary>
        /// <value>车辆出场的出口通道名称；取实地通道名称；</value>
        [DataMember(Name = "exit_name", EmitDefaultValue = false)]
        public string ExitName { get; set; }

        /// <summary>
        /// 车辆出场的出口通道编号；与线下实地编码一致；
        /// </summary>
        /// <value>车辆出场的出口通道编号；与线下实地编码一致；</value>
        [DataMember(Name = "exit_number", EmitDefaultValue = false)]
        public int ExitNumber { get; set; }

        /// <summary>
        /// 车牌是否加密，true为加密，false为不加密，默认为false
        /// </summary>
        /// <value>车牌是否加密，true为加密，false为不加密，默认为false</value>
        [DataMember(Name = "is_encrypt_plate_no", EmitDefaultValue = true)]
        public bool IsEncryptPlateNo { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID对应的归属应用appid
        /// </summary>
        /// <value>蚂蚁会员统一ID对应的归属应用appid</value>
        [DataMember(Name = "open_appid", EmitDefaultValue = false)]
        public string OpenAppid { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID
        /// </summary>
        /// <value>蚂蚁会员统一ID</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部停车流水号(用于串通进场与出场信息)
        /// </summary>
        /// <value>外部停车流水号(用于串通进场与出场信息)</value>
        [DataMember(Name = "out_serial_no", EmitDefaultValue = false)]
        public string OutSerialNo { get; set; }

        /// <summary>
        /// 车辆出场的时间，格式\&quot;YYYY-MM-DD HH:mm:ss\&quot;，24小时制，请保证服务器时间准确，出场时间不应晚于当前网络时间，也不当早于入场时间。
        /// </summary>
        /// <value>车辆出场的时间，格式\&quot;YYYY-MM-DD HH:mm:ss\&quot;，24小时制，请保证服务器时间准确，出场时间不应晚于当前网络时间，也不当早于入场时间。</value>
        [DataMember(Name = "out_time", EmitDefaultValue = false)]
        public string OutTime { get; set; }

        /// <summary>
        /// 车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。
        /// </summary>
        /// <value>车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。</value>
        [DataMember(Name = "plate_color", EmitDefaultValue = false)]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号（支持加密格式）
        /// </summary>
        /// <value>车牌号（支持加密格式）</value>
        [DataMember(Name = "plate_no", EmitDefaultValue = false)]
        public string PlateNo { get; set; }

        /// <summary>
        /// 停车服务页面地址。 1、服务商停车服务页面地址必须是支付宝小程序URL（无需转换https），详见：https://opendocs.alipay.com/support/01rb18#URL%20%E6%A0%BC%E5%BC%8F 2、若服务商没有服务链接，可传输支付宝停车官方小程序的服务链接：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;pages%2Fparking-fee%2Findex 3、若此次对接的是无感支付，则服务链接传输为：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;%2Fpages%2Fparking-bill%2Findex
        /// </summary>
        /// <value>停车服务页面地址。 1、服务商停车服务页面地址必须是支付宝小程序URL（无需转换https），详见：https://opendocs.alipay.com/support/01rb18#URL%20%E6%A0%BC%E5%BC%8F 2、若服务商没有服务链接，可传输支付宝停车官方小程序的服务链接：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;pages%2Fparking-fee%2Findex 3、若此次对接的是无感支付，则服务链接传输为：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;%2Fpages%2Fparking-bill%2Findex</value>
        [DataMember(Name = "service_url", EmitDefaultValue = false)]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceTransportParkingExitinfoSyncModel {\n");
            sb.Append("  ExitName: ").Append(ExitName).Append("\n");
            sb.Append("  ExitNumber: ").Append(ExitNumber).Append("\n");
            sb.Append("  IsEncryptPlateNo: ").Append(IsEncryptPlateNo).Append("\n");
            sb.Append("  OpenAppid: ").Append(OpenAppid).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutSerialNo: ").Append(OutSerialNo).Append("\n");
            sb.Append("  OutTime: ").Append(OutTime).Append("\n");
            sb.Append("  PlateColor: ").Append(PlateColor).Append("\n");
            sb.Append("  PlateNo: ").Append(PlateNo).Append("\n");
            sb.Append("  ServiceUrl: ").Append(ServiceUrl).Append("\n");
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
            return this.Equals(input as AlipayCommerceTransportParkingExitinfoSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceTransportParkingExitinfoSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceTransportParkingExitinfoSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceTransportParkingExitinfoSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExitName == input.ExitName ||
                    (this.ExitName != null &&
                    this.ExitName.Equals(input.ExitName))
                ) && 
                (
                    this.ExitNumber == input.ExitNumber ||
                    this.ExitNumber.Equals(input.ExitNumber)
                ) && 
                (
                    this.IsEncryptPlateNo == input.IsEncryptPlateNo ||
                    this.IsEncryptPlateNo.Equals(input.IsEncryptPlateNo)
                ) && 
                (
                    this.OpenAppid == input.OpenAppid ||
                    (this.OpenAppid != null &&
                    this.OpenAppid.Equals(input.OpenAppid))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OutSerialNo == input.OutSerialNo ||
                    (this.OutSerialNo != null &&
                    this.OutSerialNo.Equals(input.OutSerialNo))
                ) && 
                (
                    this.OutTime == input.OutTime ||
                    (this.OutTime != null &&
                    this.OutTime.Equals(input.OutTime))
                ) && 
                (
                    this.PlateColor == input.PlateColor ||
                    (this.PlateColor != null &&
                    this.PlateColor.Equals(input.PlateColor))
                ) && 
                (
                    this.PlateNo == input.PlateNo ||
                    (this.PlateNo != null &&
                    this.PlateNo.Equals(input.PlateNo))
                ) && 
                (
                    this.ServiceUrl == input.ServiceUrl ||
                    (this.ServiceUrl != null &&
                    this.ServiceUrl.Equals(input.ServiceUrl))
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
                if (this.ExitName != null)
                {
                    hashCode = (hashCode * 59) + this.ExitName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExitNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.IsEncryptPlateNo.GetHashCode();
                if (this.OpenAppid != null)
                {
                    hashCode = (hashCode * 59) + this.OpenAppid.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OutSerialNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutSerialNo.GetHashCode();
                }
                if (this.OutTime != null)
                {
                    hashCode = (hashCode * 59) + this.OutTime.GetHashCode();
                }
                if (this.PlateColor != null)
                {
                    hashCode = (hashCode * 59) + this.PlateColor.GetHashCode();
                }
                if (this.PlateNo != null)
                {
                    hashCode = (hashCode * 59) + this.PlateNo.GetHashCode();
                }
                if (this.ServiceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceUrl.GetHashCode();
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
