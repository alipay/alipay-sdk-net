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
    /// AlipayOpenMiniVersionAuditApplyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniVersionAuditApplyErrorResponseModel")]
    public partial class AlipayOpenMiniVersionAuditApplyErrorResponseModel : IEquatable<AlipayOpenMiniVersionAuditApplyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 1,

            /// <summary>
            /// Enum APPNAMEISBLANK for value: APP_NAME_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_NAME_IS_BLANK")]
            APPNAMEISBLANK = 2,

            /// <summary>
            /// Enum INVALIDMINIAPPNAMELENGTH for value: INVALID_MINI_APP_NAME_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_NAME_LENGTH")]
            INVALIDMINIAPPNAMELENGTH = 3,

            /// <summary>
            /// Enum INVALIDMINIAPPNAME for value: INVALID_MINI_APP_NAME
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_NAME")]
            INVALIDMINIAPPNAME = 4,

            /// <summary>
            /// Enum ENGLISHNAMEISBLANK for value: ENGLISH_NAME_IS_BLANK
            /// </summary>
            [EnumMember(Value = "ENGLISH_NAME_IS_BLANK")]
            ENGLISHNAMEISBLANK = 5,

            /// <summary>
            /// Enum INVALIDMINIAPPENNAME for value: INVALID_MINI_APP_EN_NAME
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_EN_NAME")]
            INVALIDMINIAPPENNAME = 6,

            /// <summary>
            /// Enum INVALIDMINIAPPENNAMELENGTH for value: INVALID_MINI_APP_EN_NAME_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_EN_NAME_LENGTH")]
            INVALIDMINIAPPENNAMELENGTH = 7,

            /// <summary>
            /// Enum SLOGANISBLANK for value: SLOGAN_IS_BLANK
            /// </summary>
            [EnumMember(Value = "SLOGAN_IS_BLANK")]
            SLOGANISBLANK = 8,

            /// <summary>
            /// Enum INVALIDMINIAPPSLOGANLENGTH for value: INVALID_MINI_APP_SLOGAN_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_SLOGAN_LENGTH")]
            INVALIDMINIAPPSLOGANLENGTH = 9,

            /// <summary>
            /// Enum INVALIDMINIAPPSLOGAN for value: INVALID_MINI_APP_SLOGAN
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_SLOGAN")]
            INVALIDMINIAPPSLOGAN = 10,

            /// <summary>
            /// Enum SERVICETELANDMAILBOTHBLANK for value: SERVICE_TEL_AND_MAIL_BOTH_BLANK
            /// </summary>
            [EnumMember(Value = "SERVICE_TEL_AND_MAIL_BOTH_BLANK")]
            SERVICETELANDMAILBOTHBLANK = 11,

            /// <summary>
            /// Enum INVALIDMINIAPPSERVICETEL for value: INVALID_MINI_APP_SERVICE_TEL
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_SERVICE_TEL")]
            INVALIDMINIAPPSERVICETEL = 12,

            /// <summary>
            /// Enum INVALIDMINIAPPSERVICEMAIL for value: INVALID_MINI_APP_SERVICE_MAIL
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_SERVICE_MAIL")]
            INVALIDMINIAPPSERVICEMAIL = 13,

            /// <summary>
            /// Enum CATEGORYISBLANK for value: CATEGORY_IS_BLANK
            /// </summary>
            [EnumMember(Value = "CATEGORY_IS_BLANK")]
            CATEGORYISBLANK = 14,

            /// <summary>
            /// Enum CATEGORYNUMISINVALID for value: CATEGORY_NUM_IS_INVALID
            /// </summary>
            [EnumMember(Value = "CATEGORY_NUM_IS_INVALID")]
            CATEGORYNUMISINVALID = 15,

            /// <summary>
            /// Enum APPDESCISBLANK for value: APP_DESC_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_DESC_IS_BLANK")]
            APPDESCISBLANK = 16,

            /// <summary>
            /// Enum INVALIDMINIAPPDESCLENGTH for value: INVALID_MINI_APP_DESC_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_DESC_LENGTH")]
            INVALIDMINIAPPDESCLENGTH = 17,

            /// <summary>
            /// Enum INVALIDMINIAPPDESC for value: INVALID_MINI_APP_DESC
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_DESC")]
            INVALIDMINIAPPDESC = 18,

            /// <summary>
            /// Enum REGIONTYPEISBLANK for value: REGION_TYPE_IS_BLANK
            /// </summary>
            [EnumMember(Value = "REGION_TYPE_IS_BLANK")]
            REGIONTYPEISBLANK = 19,

            /// <summary>
            /// Enum REGIONTYPEISINVALID for value: REGION_TYPE_IS_INVALID
            /// </summary>
            [EnumMember(Value = "REGION_TYPE_IS_INVALID")]
            REGIONTYPEISINVALID = 20,

            /// <summary>
            /// Enum REGIONCODEISBLANK for value: REGION_CODE_IS_BLANK
            /// </summary>
            [EnumMember(Value = "REGION_CODE_IS_BLANK")]
            REGIONCODEISBLANK = 21,

            /// <summary>
            /// Enum APPVERSIONISBLANK for value: APP_VERSION_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_VERSION_IS_BLANK")]
            APPVERSIONISBLANK = 22,

            /// <summary>
            /// Enum VERSIONDESCISBLANK for value: VERSION_DESC_IS_BLANK
            /// </summary>
            [EnumMember(Value = "VERSION_DESC_IS_BLANK")]
            VERSIONDESCISBLANK = 23,

            /// <summary>
            /// Enum INVALIDVERSIONDESCLENGTH for value: INVALID_VERSION_DESC_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_VERSION_DESC_LENGTH")]
            INVALIDVERSIONDESCLENGTH = 24,

            /// <summary>
            /// Enum INVALIDMINIAPPVERSIONDESC for value: INVALID_MINI_APP_VERSION_DESC
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_VERSION_DESC")]
            INVALIDMINIAPPVERSIONDESC = 25,

            /// <summary>
            /// Enum SCREENSHOTSAREBLANK for value: SCREEN_SHOTS_ARE_BLANK
            /// </summary>
            [EnumMember(Value = "SCREEN_SHOTS_ARE_BLANK")]
            SCREENSHOTSAREBLANK = 26,

            /// <summary>
            /// Enum SCREENSHOTNUMISINVALID for value: SCREEN_SHOT_NUM_IS_INVALID
            /// </summary>
            [EnumMember(Value = "SCREEN_SHOT_NUM_IS_INVALID")]
            SCREENSHOTNUMISINVALID = 27,

            /// <summary>
            /// Enum INVALIDMINIAPPMEMOLENGTH for value: INVALID_MINI_APP_MEMO_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_MEMO_LENGTH")]
            INVALIDMINIAPPMEMOLENGTH = 28,

            /// <summary>
            /// Enum APPLICATIONTYPENOTMINIAPP for value: APPLICATION_TYPE_NOT_MINIAPP
            /// </summary>
            [EnumMember(Value = "APPLICATION_TYPE_NOT_MINIAPP")]
            APPLICATIONTYPENOTMINIAPP = 29,

            /// <summary>
            /// Enum INVALIDMINIAPPSAFEDOMAIN for value: INVALID_MINI_APP_SAFE_DOMAIN
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_SAFE_DOMAIN")]
            INVALIDMINIAPPSAFEDOMAIN = 30,

            /// <summary>
            /// Enum CANNOTSUBMITWITHALICLOUD for value: CAN_NOT_SUBMIT_WITH_ALI_CLOUD
            /// </summary>
            [EnumMember(Value = "CAN_NOT_SUBMIT_WITH_ALI_CLOUD")]
            CANNOTSUBMITWITHALICLOUD = 31,

            /// <summary>
            /// Enum MINIAPPNAMEDUPLICATE for value: MINI_APP_NAME_DUPLICATE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NAME_DUPLICATE")]
            MINIAPPNAMEDUPLICATE = 32,

            /// <summary>
            /// Enum MINIAPPENNAMEDUPLICATE for value: MINI_APP_EN_NAME_DUPLICATE
            /// </summary>
            [EnumMember(Value = "MINI_APP_EN_NAME_DUPLICATE")]
            MINIAPPENNAMEDUPLICATE = 33,

            /// <summary>
            /// Enum INVALIDCATEGORY for value: INVALID_CATEGORY
            /// </summary>
            [EnumMember(Value = "INVALID_CATEGORY")]
            INVALIDCATEGORY = 34,

            /// <summary>
            /// Enum INVALIDREGION for value: INVALID_REGION
            /// </summary>
            [EnumMember(Value = "INVALID_REGION")]
            INVALIDREGION = 35,

            /// <summary>
            /// Enum MINIAPPNAMESENSITIVE for value: MINI_APP_NAME_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NAME_SENSITIVE")]
            MINIAPPNAMESENSITIVE = 36,

            /// <summary>
            /// Enum MINIAPPENNAMESENSITIVE for value: MINI_APP_EN_NAME_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_EN_NAME_SENSITIVE")]
            MINIAPPENNAMESENSITIVE = 37,

            /// <summary>
            /// Enum MINIAPPSLOGANSENSITIVE for value: MINI_APP_SLOGAN_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_SLOGAN_SENSITIVE")]
            MINIAPPSLOGANSENSITIVE = 38,

            /// <summary>
            /// Enum MINIAPPMEMOSENSITIVE for value: MINI_APP_MEMO_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_MEMO_SENSITIVE")]
            MINIAPPMEMOSENSITIVE = 39,

            /// <summary>
            /// Enum MINIAPPDESCSENSITIVE for value: MINI_APP_DESC_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_DESC_SENSITIVE")]
            MINIAPPDESCSENSITIVE = 40,

            /// <summary>
            /// Enum MINIAPPSERVICEMAILSENSITIVE for value: MINI_APP_SERVICE_MAIL_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_SERVICE_MAIL_SENSITIVE")]
            MINIAPPSERVICEMAILSENSITIVE = 41,

            /// <summary>
            /// Enum MINIAPPVERSIONDESCSENSITIVE for value: MINI_APP_VERSION_DESC_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_VERSION_DESC_SENSITIVE")]
            MINIAPPVERSIONDESCSENSITIVE = 42,

            /// <summary>
            /// Enum MINIAPPPACKAGEINFONOTEXIST for value: MINI_APP_PACKAGE_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MINI_APP_PACKAGE_INFO_NOT_EXIST")]
            MINIAPPPACKAGEINFONOTEXIST = 43,

            /// <summary>
            /// Enum CANNOTMODIFYNAMEONCEONLINE for value: CAN_NOT_MODIFY_NAME_ONCE_ONLINE
            /// </summary>
            [EnumMember(Value = "CAN_NOT_MODIFY_NAME_ONCE_ONLINE")]
            CANNOTMODIFYNAMEONCEONLINE = 44,

            /// <summary>
            /// Enum CANNOTMODIFYENONCEONLINE for value: CAN_NOT_MODIFY_EN_ONCE_ONLINE
            /// </summary>
            [EnumMember(Value = "CAN_NOT_MODIFY_EN_ONCE_ONLINE")]
            CANNOTMODIFYENONCEONLINE = 45,

            /// <summary>
            /// Enum MODIFYSLOGANEXCEEDCOUNT for value: MODIFY_SLOGAN_EXCEED_COUNT
            /// </summary>
            [EnumMember(Value = "MODIFY_SLOGAN_EXCEED_COUNT")]
            MODIFYSLOGANEXCEEDCOUNT = 46,

            /// <summary>
            /// Enum MODIFYCATEGORYIDEXCEEDCOUNT for value: MODIFY_CATEGORY_ID_EXCEED_COUNT
            /// </summary>
            [EnumMember(Value = "MODIFY_CATEGORY_ID_EXCEED_COUNT")]
            MODIFYCATEGORYIDEXCEEDCOUNT = 47,

            /// <summary>
            /// Enum MODIFYDESCEXCEEDCOUNT for value: MODIFY_DESC_EXCEED_COUNT
            /// </summary>
            [EnumMember(Value = "MODIFY_DESC_EXCEED_COUNT")]
            MODIFYDESCEXCEEDCOUNT = 48,

            /// <summary>
            /// Enum CANNOTSUBMITWITHAUDIT for value: CAN_NOT_SUBMIT_WITH_AUDIT
            /// </summary>
            [EnumMember(Value = "CAN_NOT_SUBMIT_WITH_AUDIT")]
            CANNOTSUBMITWITHAUDIT = 49,

            /// <summary>
            /// Enum CANNOTSUBMITWITHOUTINIT for value: CAN_NOT_SUBMIT_WITHOUT_INIT
            /// </summary>
            [EnumMember(Value = "CAN_NOT_SUBMIT_WITHOUT_INIT")]
            CANNOTSUBMITWITHOUTINIT = 50,

            /// <summary>
            /// Enum CANNOTSUBMITWITHOUTSCANPASS for value: CAN_NOT_SUBMIT_WITHOUT_SCAN_PASS
            /// </summary>
            [EnumMember(Value = "CAN_NOT_SUBMIT_WITHOUT_SCAN_PASS")]
            CANNOTSUBMITWITHOUTSCANPASS = 51,

            /// <summary>
            /// Enum CANNOTSUBMITWITHAUDITGRAY for value: CAN_NOT_SUBMIT_WITH_AUDIT_GRAY
            /// </summary>
            [EnumMember(Value = "CAN_NOT_SUBMIT_WITH_AUDIT_GRAY")]
            CANNOTSUBMITWITHAUDITGRAY = 52,

            /// <summary>
            /// Enum EXISTLARGERONLINEDVERSION for value: EXIST_LARGER_ONLINED_VERSION
            /// </summary>
            [EnumMember(Value = "EXIST_LARGER_ONLINED_VERSION")]
            EXISTLARGERONLINEDVERSION = 53,

            /// <summary>
            /// Enum LICENSENOISBLANK for value: LICENSE_NO_IS_BLANK
            /// </summary>
            [EnumMember(Value = "LICENSE_NO_IS_BLANK")]
            LICENSENOISBLANK = 54,

            /// <summary>
            /// Enum LICENSEVALIDDATEISBLANK for value: LICENSE_VALID_DATE_IS_BLANK
            /// </summary>
            [EnumMember(Value = "LICENSE_VALID_DATE_IS_BLANK")]
            LICENSEVALIDDATEISBLANK = 55,

            /// <summary>
            /// Enum LICENSEVALIDDATEISINVALID for value: LICENSE_VALID_DATE_IS_INVALID
            /// </summary>
            [EnumMember(Value = "LICENSE_VALID_DATE_IS_INVALID")]
            LICENSEVALIDDATEISINVALID = 56,

            /// <summary>
            /// Enum OUTDOORPICISBLANK for value: OUT_DOOR_PIC_IS_BLANK
            /// </summary>
            [EnumMember(Value = "OUT_DOOR_PIC_IS_BLANK")]
            OUTDOORPICISBLANK = 57,

            /// <summary>
            /// Enum LICENSEPICSAREBLANK for value: LICENSE_PICS_ARE_BLANK
            /// </summary>
            [EnumMember(Value = "LICENSE_PICS_ARE_BLANK")]
            LICENSEPICSAREBLANK = 58,

            /// <summary>
            /// Enum LICENSEPICNUMISINVALID for value: LICENSE_PIC_NUM_IS_INVALID
            /// </summary>
            [EnumMember(Value = "LICENSE_PIC_NUM_IS_INVALID")]
            LICENSEPICNUMISINVALID = 59,

            /// <summary>
            /// Enum LICENSECHECKFAIL for value: LICENSE_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "LICENSE_CHECK_FAIL")]
            LICENSECHECKFAIL = 60,

            /// <summary>
            /// Enum LOGOHEIGHTNOTEQUALWIDTH for value: LOGO_HEIGHT_NOT_EQUAL_WIDTH
            /// </summary>
            [EnumMember(Value = "LOGO_HEIGHT_NOT_EQUAL_WIDTH")]
            LOGOHEIGHTNOTEQUALWIDTH = 61,

            /// <summary>
            /// Enum INVALIDSCREENSHOTEXT for value: INVALID_SCREEN_SHOT_EXT
            /// </summary>
            [EnumMember(Value = "INVALID_SCREEN_SHOT_EXT")]
            INVALIDSCREENSHOTEXT = 62,

            /// <summary>
            /// Enum SCREENSHOTEXCEEDMAXSIZE for value: SCREEN_SHOT_EXCEED_MAX_SIZE
            /// </summary>
            [EnumMember(Value = "SCREEN_SHOT_EXCEED_MAX_SIZE")]
            SCREENSHOTEXCEEDMAXSIZE = 63,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 64,

            /// <summary>
            /// Enum LOGOEXCEEDMAXSIZE for value: LOGO_EXCEED_MAX_SIZE
            /// </summary>
            [EnumMember(Value = "LOGO_EXCEED_MAX_SIZE")]
            LOGOEXCEEDMAXSIZE = 65,

            /// <summary>
            /// Enum INVALIDLOGOEXT for value: INVALID_LOGO_EXT
            /// </summary>
            [EnumMember(Value = "INVALID_LOGO_EXT")]
            INVALIDLOGOEXT = 66,

            /// <summary>
            /// Enum INVALIDPARAMS for value: INVALID_PARAMS
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMS")]
            INVALIDPARAMS = 67,

            /// <summary>
            /// Enum INVALIDLOGO for value: INVALID_LOGO
            /// </summary>
            [EnumMember(Value = "INVALID_LOGO")]
            INVALIDLOGO = 68,

            /// <summary>
            /// Enum RISKDECISIONCHECKFAIL for value: RISK_DECISION_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "RISK_DECISION_CHECK_FAIL")]
            RISKDECISIONCHECKFAIL = 69,

            /// <summary>
            /// Enum TINYAPPAUDITNOTPERMIT for value: TINY_APP_AUDIT_NOT_PERMIT
            /// </summary>
            [EnumMember(Value = "TINY_APP_AUDIT_NOT_PERMIT")]
            TINYAPPAUDITNOTPERMIT = 70,

            /// <summary>
            /// Enum RISKDECISIONHITBRAND for value: RISK_DECISION_HIT_BRAND
            /// </summary>
            [EnumMember(Value = "RISK_DECISION_HIT_BRAND")]
            RISKDECISIONHITBRAND = 71,

            /// <summary>
            /// Enum BRANDTORTNOTEND for value: BRAND_TORT_NOT_END
            /// </summary>
            [EnumMember(Value = "BRAND_TORT_NOT_END")]
            BRANDTORTNOTEND = 72,

            /// <summary>
            /// Enum SPECIALLICENSEPICSAREBLANK for value: SPECIAL_LICENSE_PICS_ARE_BLANK
            /// </summary>
            [EnumMember(Value = "SPECIAL_LICENSE_PICS_ARE_BLANK")]
            SPECIALLICENSEPICSAREBLANK = 73,

            /// <summary>
            /// Enum FILEISBLANK for value: FILE_IS_BLANK
            /// </summary>
            [EnumMember(Value = "FILE_IS_BLANK")]
            FILEISBLANK = 74,

            /// <summary>
            /// Enum INVALIDFILEEXT for value: INVALID_FILE_EXT
            /// </summary>
            [EnumMember(Value = "INVALID_FILE_EXT")]
            INVALIDFILEEXT = 75,

            /// <summary>
            /// Enum FILESIZEEXCEED for value: FILE_SIZE_EXCEED
            /// </summary>
            [EnumMember(Value = "FILE_SIZE_EXCEED")]
            FILESIZEEXCEED = 76,

            /// <summary>
            /// Enum INVALIDSPECIALLICENSENUM for value: INVALID_SPECIAL_LICENSE_NUM
            /// </summary>
            [EnumMember(Value = "INVALID_SPECIAL_LICENSE_NUM")]
            INVALIDSPECIALLICENSENUM = 77,

            /// <summary>
            /// Enum BUNDLEIDNOTEXIST for value: BUNDLE_ID_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "BUNDLE_ID_NOT_EXIST")]
            BUNDLEIDNOTEXIST = 78,

            /// <summary>
            /// Enum DEFAULTLOGO for value: DEFAULT_LOGO
            /// </summary>
            [EnumMember(Value = "DEFAULT_LOGO")]
            DEFAULTLOGO = 79,

            /// <summary>
            /// Enum SUBMITREPEAT for value: SUBMIT_REPEAT
            /// </summary>
            [EnumMember(Value = "SUBMIT_REPEAT")]
            SUBMITREPEAT = 80,

            /// <summary>
            /// Enum PRIVATENOTALLOWCATEGORY for value: PRIVATE_NOT_ALLOW_CATEGORY
            /// </summary>
            [EnumMember(Value = "PRIVATE_NOT_ALLOW_CATEGORY")]
            PRIVATENOTALLOWCATEGORY = 81,

            /// <summary>
            /// Enum MINIAPPINFOAUDITCONTAINS for value: MINI_APP_INFO_AUDIT_CONTAINS
            /// </summary>
            [EnumMember(Value = "MINI_APP_INFO_AUDIT_CONTAINS")]
            MINIAPPINFOAUDITCONTAINS = 82,

            /// <summary>
            /// Enum MINIVERSIONNAMEDUPLICATE for value: MINI_VERSION_NAME_DUPLICATE
            /// </summary>
            [EnumMember(Value = "MINI_VERSION_NAME_DUPLICATE")]
            MINIVERSIONNAMEDUPLICATE = 83,

            /// <summary>
            /// Enum LOGOSIZEEXCEED for value: LOGO_SIZE_EXCEED
            /// </summary>
            [EnumMember(Value = "LOGO_SIZE_EXCEED")]
            LOGOSIZEEXCEED = 84,

            /// <summary>
            /// Enum APPINFONOTEXIST for value: APP_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_INFO_NOT_EXIST")]
            APPINFONOTEXIST = 85,

            /// <summary>
            /// Enum USERNOTEXIST for value: USER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "USER_NOT_EXIST")]
            USERNOTEXIST = 86,

            /// <summary>
            /// Enum REGIONCODEISINVALID for value: REGION_CODE_IS_INVALID
            /// </summary>
            [EnumMember(Value = "REGION_CODE_IS_INVALID")]
            REGIONCODEISINVALID = 87,

            /// <summary>
            /// Enum SERVICETELISBLANK for value: SERVICE_TEL_IS_BLANK
            /// </summary>
            [EnumMember(Value = "SERVICE_TEL_IS_BLANK")]
            SERVICETELISBLANK = 88,

            /// <summary>
            /// Enum INVALIDMINIAPPNAMEPREFIX for value: INVALID_MINI_APP_NAME_PREFIX
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_NAME_PREFIX")]
            INVALIDMINIAPPNAMEPREFIX = 89,

            /// <summary>
            /// Enum SYSTEMLIMIT for value: SYSTEM_LIMIT
            /// </summary>
            [EnumMember(Value = "SYSTEM_LIMIT")]
            SYSTEMLIMIT = 90,

            /// <summary>
            /// Enum LOGOISBLANK for value: LOGO_IS_BLANK
            /// </summary>
            [EnumMember(Value = "LOGO_IS_BLANK")]
            LOGOISBLANK = 91,

            /// <summary>
            /// Enum HASNOMODIFYCNT for value: HAS_NO_MODIFY_CNT
            /// </summary>
            [EnumMember(Value = "HAS_NO_MODIFY_CNT")]
            HASNOMODIFYCNT = 92,

            /// <summary>
            /// Enum INVALIDTESTPWDLENGTH for value: INVALID_TEST_PWD_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_TEST_PWD_LENGTH")]
            INVALIDTESTPWDLENGTH = 93,

            /// <summary>
            /// Enum SUBAPPLICATIONTYPEERROR for value: SUB_APPLICATION_TYPE_ERROR
            /// </summary>
            [EnumMember(Value = "SUB_APPLICATION_TYPE_ERROR")]
            SUBAPPLICATIONTYPEERROR = 94,

            /// <summary>
            /// Enum LICENSENAMEISBLANK for value: LICENSE_NAME_IS_BLANK
            /// </summary>
            [EnumMember(Value = "LICENSE_NAME_IS_BLANK")]
            LICENSENAMEISBLANK = 95,

            /// <summary>
            /// Enum RISKDECISIONHITBROAD for value: RISK_DECISION_HIT_BROAD
            /// </summary>
            [EnumMember(Value = "RISK_DECISION_HIT_BROAD")]
            RISKDECISIONHITBROAD = 96,

            /// <summary>
            /// Enum INVALIDTESTACCOUNTLENGTH for value: INVALID_TEST_ACCOUNT_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_TEST_ACCOUNT_LENGTH")]
            INVALIDTESTACCOUNTLENGTH = 97,

            /// <summary>
            /// Enum DEVELOPERINFONOTEXIST for value: DEVELOPER_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "DEVELOPER_INFO_NOT_EXIST")]
            DEVELOPERINFONOTEXIST = 98,

            /// <summary>
            /// Enum INVALIIDMEMOTRADENO for value: INVALIID_MEMO_TRADENO
            /// </summary>
            [EnumMember(Value = "INVALIID_MEMO_TRADENO")]
            INVALIIDMEMOTRADENO = 99,

            /// <summary>
            /// Enum MEMOTRADENOCHECKFAIL for value: MEMO_TRADENO_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "MEMO_TRADENO_CHECK_FAIL")]
            MEMOTRADENOCHECKFAIL = 100,

            /// <summary>
            /// Enum MINIAPPVERSIONITERATIONEXIST for value: MINI_APP_VERSION_ITERATION_EXIST
            /// </summary>
            [EnumMember(Value = "MINI_APP_VERSION_ITERATION_EXIST")]
            MINIAPPVERSIONITERATIONEXIST = 101,

            /// <summary>
            /// Enum MINIAPPVERSIONNOTEXSIT for value: MINIAPP_VERSION_NOT_EXSIT
            /// </summary>
            [EnumMember(Value = "MINIAPP_VERSION_NOT_EXSIT")]
            MINIAPPVERSIONNOTEXSIT = 102

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniVersionAuditApplyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniVersionAuditApplyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniVersionAuditApplyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniVersionAuditApplyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniVersionAuditApplyErrorResponseModel and cannot be null");
            // }
            this.Message = message;
            this.Links = links;
        }

        /// <summary>
        /// 解决方案链接
        /// </summary>
        /// <value>解决方案链接</value>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public string Links { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        /// <value>错误描述</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniVersionAuditApplyErrorResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniVersionAuditApplyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniVersionAuditApplyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniVersionAuditApplyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniVersionAuditApplyErrorResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
