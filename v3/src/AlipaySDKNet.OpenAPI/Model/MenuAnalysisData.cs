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
    /// MenuAnalysisData
    /// </summary>
    [DataContract(Name = "MenuAnalysisData")]
    public partial class MenuAnalysisData : IEquatable<MenuAnalysisData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuAnalysisData" /> class.
        /// </summary>
        /// <param name="avgClickUserCnt">人均点击次数.</param>
        /// <param name="clickCnt">菜单点击次数.</param>
        /// <param name="clickUserCnt">菜单点击人数.</param>
        /// <param name="date">日期.</param>
        /// <param name="menuType">菜单类型 ，iconDefault ：图标菜单、default：文字菜单.</param>
        /// <param name="name">菜单名称.</param>
        /// <param name="subName">子菜单名称，文字菜单才有.</param>
        public MenuAnalysisData(string avgClickUserCnt = default(string), int clickCnt = default(int), int clickUserCnt = default(int), string date = default(string), string menuType = default(string), string name = default(string), string subName = default(string))
        {
            this.AvgClickUserCnt = avgClickUserCnt;
            this.ClickCnt = clickCnt;
            this.ClickUserCnt = clickUserCnt;
            this.Date = date;
            this.MenuType = menuType;
            this.Name = name;
            this.SubName = subName;
        }

        /// <summary>
        /// 人均点击次数
        /// </summary>
        /// <value>人均点击次数</value>
        [DataMember(Name = "avg_click_user_cnt", EmitDefaultValue = false)]
        public string AvgClickUserCnt { get; set; }

        /// <summary>
        /// 菜单点击次数
        /// </summary>
        /// <value>菜单点击次数</value>
        [DataMember(Name = "click_cnt", EmitDefaultValue = false)]
        public int ClickCnt { get; set; }

        /// <summary>
        /// 菜单点击人数
        /// </summary>
        /// <value>菜单点击人数</value>
        [DataMember(Name = "click_user_cnt", EmitDefaultValue = false)]
        public int ClickUserCnt { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        /// <value>日期</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// 菜单类型 ，iconDefault ：图标菜单、default：文字菜单
        /// </summary>
        /// <value>菜单类型 ，iconDefault ：图标菜单、default：文字菜单</value>
        [DataMember(Name = "menu_type", EmitDefaultValue = false)]
        public string MenuType { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        /// <value>菜单名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 子菜单名称，文字菜单才有
        /// </summary>
        /// <value>子菜单名称，文字菜单才有</value>
        [DataMember(Name = "sub_name", EmitDefaultValue = false)]
        public string SubName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MenuAnalysisData {\n");
            sb.Append("  AvgClickUserCnt: ").Append(AvgClickUserCnt).Append("\n");
            sb.Append("  ClickCnt: ").Append(ClickCnt).Append("\n");
            sb.Append("  ClickUserCnt: ").Append(ClickUserCnt).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  MenuType: ").Append(MenuType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubName: ").Append(SubName).Append("\n");
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
            return this.Equals(input as MenuAnalysisData);
        }

        /// <summary>
        /// Returns true if MenuAnalysisData instances are equal
        /// </summary>
        /// <param name="input">Instance of MenuAnalysisData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MenuAnalysisData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvgClickUserCnt == input.AvgClickUserCnt ||
                    (this.AvgClickUserCnt != null &&
                    this.AvgClickUserCnt.Equals(input.AvgClickUserCnt))
                ) && 
                (
                    this.ClickCnt == input.ClickCnt ||
                    this.ClickCnt.Equals(input.ClickCnt)
                ) && 
                (
                    this.ClickUserCnt == input.ClickUserCnt ||
                    this.ClickUserCnt.Equals(input.ClickUserCnt)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.MenuType == input.MenuType ||
                    (this.MenuType != null &&
                    this.MenuType.Equals(input.MenuType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SubName == input.SubName ||
                    (this.SubName != null &&
                    this.SubName.Equals(input.SubName))
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
                if (this.AvgClickUserCnt != null)
                {
                    hashCode = (hashCode * 59) + this.AvgClickUserCnt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ClickCnt.GetHashCode();
                hashCode = (hashCode * 59) + this.ClickUserCnt.GetHashCode();
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.MenuType != null)
                {
                    hashCode = (hashCode * 59) + this.MenuType.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SubName != null)
                {
                    hashCode = (hashCode * 59) + this.SubName.GetHashCode();
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
