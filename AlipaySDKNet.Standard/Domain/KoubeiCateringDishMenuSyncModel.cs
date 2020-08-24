using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringDishMenuSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishMenuSyncModel : AopObject
    {
        /// <summary>
        /// 菜谱背景图片id
        /// </summary>
        [XmlElement("bg_image")]
        public string BgImage { get; set; }

        /// <summary>
        /// "CREATE_MENU"：创建菜单， "ADD_SHOP"：添加门店， "DELETE_SHOP"：删除门店， "ADD_DISH"：添加菜品， "DELETE_DISH"：删除菜品
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 菜谱类目列表
        /// </summary>
        [XmlArray("category_list")]
        [XmlArrayItem("kbdish_category_simplify_info")]
        public List<KbdishCategorySimplifyInfo> CategoryList { get; set; }

        /// <summary>
        /// 菜单名称，需要保证pid下唯一，这个接口才生效
        /// </summary>
        [XmlElement("cook_name")]
        public string CookName { get; set; }

        /// <summary>
        /// 时间区间日期结束
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 时间区间截止 闭区间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 操作者id或名称
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 外部门店id列表
        /// </summary>
        [XmlArray("out_shop_id")]
        [XmlArrayItem("string")]
        public List<string> OutShopId { get; set; }

        /// <summary>
        /// 时间约束类型 forever:永久; week:按周，每周周几 month:按月,每月几号
        /// </summary>
        [XmlElement("period_type")]
        public string PeriodType { get; set; }

        /// <summary>
        /// 时间控制值,如果选的week, 值 1,2,3,4 ; 如果选择month，值 1,11; 如果选择永久，为空
        /// </summary>
        [XmlElement("period_value")]
        public string PeriodValue { get; set; }

        /// <summary>
        /// 控制的日期区间开始
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 时间控制 到分 闭区间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// open：启用 stop：停用
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
