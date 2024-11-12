/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-11-12
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using AlipaySDKNet.OpenAPI.Client;
using AlipaySDKNet.OpenAPI.Model;
using AlipaySDKNet.OpenAPI.Util;
using AlipaySDKNet.OpenAPI.Util.Model;

namespace AlipaySDKNet.OpenAPI.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZhimaCustomerJobworthInfoApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 职得工作证信息查询
        /// </summary>
        /// <remarks>
        /// 查询用户职得工作证信息 查询方式3选1，都设置时uid优先 1、支付宝uid查询：user_id 2、身份证+姓名查询：cert_type+cert_no 3、智能简历场景：conn_key
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userName">姓名 (optional)</param>
        /// <param name="connKey">外部订单号，zhima.credit.payafteruse.creditagreement.sign的入参 out_agreement_no智能简历场景支持只传该值 (optional)</param>
        /// <param name="certNo">证件号 ，根据cert_type类型设置对应证件号码，选择身份证校验时必传 (optional)</param>
        /// <param name="userId">蚂蚁统一会员ID ，为2088开头的唯一标识 选择支付宝uid检验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先 (optional)</param>
        /// <param name="openId">蚂蚁统一会员ID ，为2088开头的唯一标识 选择支付宝uid检验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先 (optional)</param>
        /// <param name="backUrl">若用户没有开通工作证或者芝麻，成功开通后回跳的链接 ，支持http或schema地址 (optional)</param>
        /// <param name="certType">证件类型 ，枚举值： 0:身份证1:护照2:台湾同胞回乡证3:港澳居民往来内地通行证4:台湾居民通行证5:港澳居民通行证 选择身份证校验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先 (optional)</param>
        /// <param name="kaVisitorId">商户内部的唯一id如果是需要返回h5页面必填 (optional)</param>
        /// <param name="visitorType">访问类型 C &#x3D; company  or P &#x3D; person 如果是需要返回h5页面必填 (optional)</param>
        /// <param name="visitorName">商户侧配置访客名称 如果是需要返回h5页面必填 (optional)</param>
        /// <param name="companyCertificate">公司社会统一代码h5页面访客展示使用 (optional)</param>
        /// <param name="visitorUrl">上传图片接口返回的id (optional)</param>
        /// <param name="hasButton">在h5页面是否展示底部跳转按钮 (optional)</param>
        /// <param name="hasNumber">true or false 是否展示 (optional)</param>
        /// <param name="hasQrCode">是否展示二维码 (optional)</param>
        /// <param name="hasHtml">是否需要返回h5页面 (optional)</param>
        /// <param name="jobId">对外使用的jobid (optional)</param>
        /// <param name="industryId">行业描述ID (optional)</param>
        /// <param name="cloudResumeScene">子场景 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaCustomerJobworthInfoQueryResponseModel</returns>
        ZhimaCustomerJobworthInfoQueryResponseModel Query(string userName = default(string), string connKey = default(string), string certNo = default(string), string userId = default(string), string openId = default(string), string backUrl = default(string), string certType = default(string), string kaVisitorId = default(string), string visitorType = default(string), string visitorName = default(string), string companyCertificate = default(string), string visitorUrl = default(string), bool? hasButton = default(bool?), bool? hasNumber = default(bool?), bool? hasQrCode = default(bool?), bool? hasHtml = default(bool?), string jobId = default(string), string industryId = default(string), string cloudResumeScene = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 职得工作证信息查询
        /// </summary>
        /// <remarks>
        /// 查询用户职得工作证信息 查询方式3选1，都设置时uid优先 1、支付宝uid查询：user_id 2、身份证+姓名查询：cert_type+cert_no 3、智能简历场景：conn_key
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userName">姓名 (optional)</param>
        /// <param name="connKey">外部订单号，zhima.credit.payafteruse.creditagreement.sign的入参 out_agreement_no智能简历场景支持只传该值 (optional)</param>
        /// <param name="certNo">证件号 ，根据cert_type类型设置对应证件号码，选择身份证校验时必传 (optional)</param>
        /// <param name="userId">蚂蚁统一会员ID ，为2088开头的唯一标识 选择支付宝uid检验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先 (optional)</param>
        /// <param name="openId">蚂蚁统一会员ID ，为2088开头的唯一标识 选择支付宝uid检验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先 (optional)</param>
        /// <param name="backUrl">若用户没有开通工作证或者芝麻，成功开通后回跳的链接 ，支持http或schema地址 (optional)</param>
        /// <param name="certType">证件类型 ，枚举值： 0:身份证1:护照2:台湾同胞回乡证3:港澳居民往来内地通行证4:台湾居民通行证5:港澳居民通行证 选择身份证校验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先 (optional)</param>
        /// <param name="kaVisitorId">商户内部的唯一id如果是需要返回h5页面必填 (optional)</param>
        /// <param name="visitorType">访问类型 C &#x3D; company  or P &#x3D; person 如果是需要返回h5页面必填 (optional)</param>
        /// <param name="visitorName">商户侧配置访客名称 如果是需要返回h5页面必填 (optional)</param>
        /// <param name="companyCertificate">公司社会统一代码h5页面访客展示使用 (optional)</param>
        /// <param name="visitorUrl">上传图片接口返回的id (optional)</param>
        /// <param name="hasButton">在h5页面是否展示底部跳转按钮 (optional)</param>
        /// <param name="hasNumber">true or false 是否展示 (optional)</param>
        /// <param name="hasQrCode">是否展示二维码 (optional)</param>
        /// <param name="hasHtml">是否需要返回h5页面 (optional)</param>
        /// <param name="jobId">对外使用的jobid (optional)</param>
        /// <param name="industryId">行业描述ID (optional)</param>
        /// <param name="cloudResumeScene">子场景 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaCustomerJobworthInfoQueryResponseModel</returns>
        ApiResponse<ZhimaCustomerJobworthInfoQueryResponseModel> QueryWithHttpInfo(string userName = default(string), string connKey = default(string), string certNo = default(string), string userId = default(string), string openId = default(string), string backUrl = default(string), string certType = default(string), string kaVisitorId = default(string), string visitorType = default(string), string visitorName = default(string), string companyCertificate = default(string), string visitorUrl = default(string), bool? hasButton = default(bool?), bool? hasNumber = default(bool?), bool? hasQrCode = default(bool?), bool? hasHtml = default(bool?), string jobId = default(string), string industryId = default(string), string cloudResumeScene = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZhimaCustomerJobworthInfoApi : IZhimaCustomerJobworthInfoApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ZhimaCustomerJobworthInfoApi : IZhimaCustomerJobworthInfoApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthInfoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZhimaCustomerJobworthInfoApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthInfoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZhimaCustomerJobworthInfoApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthInfoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ZhimaCustomerJobworthInfoApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthInfoApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ZhimaCustomerJobworthInfoApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.Configuration = configuration;
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }


        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AlipaySDKNet.OpenAPI.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// 职得工作证信息查询 查询用户职得工作证信息 查询方式3选1，都设置时uid优先 1、支付宝uid查询：user_id 2、身份证+姓名查询：cert_type+cert_no 3、智能简历场景：conn_key
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userName">姓名 (optional)</param>
        /// <param name="connKey">外部订单号，zhima.credit.payafteruse.creditagreement.sign的入参 out_agreement_no智能简历场景支持只传该值 (optional)</param>
        /// <param name="certNo">证件号 ，根据cert_type类型设置对应证件号码，选择身份证校验时必传 (optional)</param>
        /// <param name="userId">蚂蚁统一会员ID ，为2088开头的唯一标识 选择支付宝uid检验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先 (optional)</param>
        /// <param name="openId">蚂蚁统一会员ID ，为2088开头的唯一标识 选择支付宝uid检验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先 (optional)</param>
        /// <param name="backUrl">若用户没有开通工作证或者芝麻，成功开通后回跳的链接 ，支持http或schema地址 (optional)</param>
        /// <param name="certType">证件类型 ，枚举值： 0:身份证1:护照2:台湾同胞回乡证3:港澳居民往来内地通行证4:台湾居民通行证5:港澳居民通行证 选择身份证校验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先 (optional)</param>
        /// <param name="kaVisitorId">商户内部的唯一id如果是需要返回h5页面必填 (optional)</param>
        /// <param name="visitorType">访问类型 C &#x3D; company  or P &#x3D; person 如果是需要返回h5页面必填 (optional)</param>
        /// <param name="visitorName">商户侧配置访客名称 如果是需要返回h5页面必填 (optional)</param>
        /// <param name="companyCertificate">公司社会统一代码h5页面访客展示使用 (optional)</param>
        /// <param name="visitorUrl">上传图片接口返回的id (optional)</param>
        /// <param name="hasButton">在h5页面是否展示底部跳转按钮 (optional)</param>
        /// <param name="hasNumber">true or false 是否展示 (optional)</param>
        /// <param name="hasQrCode">是否展示二维码 (optional)</param>
        /// <param name="hasHtml">是否需要返回h5页面 (optional)</param>
        /// <param name="jobId">对外使用的jobid (optional)</param>
        /// <param name="industryId">行业描述ID (optional)</param>
        /// <param name="cloudResumeScene">子场景 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaCustomerJobworthInfoQueryResponseModel</returns>
        public ZhimaCustomerJobworthInfoQueryResponseModel Query(string userName = default(string), string connKey = default(string), string certNo = default(string), string userId = default(string), string openId = default(string), string backUrl = default(string), string certType = default(string), string kaVisitorId = default(string), string visitorType = default(string), string visitorName = default(string), string companyCertificate = default(string), string visitorUrl = default(string), bool? hasButton = default(bool?), bool? hasNumber = default(bool?), bool? hasQrCode = default(bool?), bool? hasHtml = default(bool?), string jobId = default(string), string industryId = default(string), string cloudResumeScene = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCustomerJobworthInfoQueryResponseModel> localVarResponse = QueryWithHttpInfo(userName, connKey, certNo, userId, openId, backUrl, certType, kaVisitorId, visitorType, visitorName, companyCertificate, visitorUrl, hasButton, hasNumber, hasQrCode, hasHtml, jobId, industryId, cloudResumeScene, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 职得工作证信息查询 查询用户职得工作证信息 查询方式3选1，都设置时uid优先 1、支付宝uid查询：user_id 2、身份证+姓名查询：cert_type+cert_no 3、智能简历场景：conn_key
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userName">姓名 (optional)</param>
        /// <param name="connKey">外部订单号，zhima.credit.payafteruse.creditagreement.sign的入参 out_agreement_no智能简历场景支持只传该值 (optional)</param>
        /// <param name="certNo">证件号 ，根据cert_type类型设置对应证件号码，选择身份证校验时必传 (optional)</param>
        /// <param name="userId">蚂蚁统一会员ID ，为2088开头的唯一标识 选择支付宝uid检验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先 (optional)</param>
        /// <param name="openId">蚂蚁统一会员ID ，为2088开头的唯一标识 选择支付宝uid检验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先 (optional)</param>
        /// <param name="backUrl">若用户没有开通工作证或者芝麻，成功开通后回跳的链接 ，支持http或schema地址 (optional)</param>
        /// <param name="certType">证件类型 ，枚举值： 0:身份证1:护照2:台湾同胞回乡证3:港澳居民往来内地通行证4:台湾居民通行证5:港澳居民通行证 选择身份证校验时必传，支付宝uid或身份证+身份证类型 查询2选1，都设置时uid优先 (optional)</param>
        /// <param name="kaVisitorId">商户内部的唯一id如果是需要返回h5页面必填 (optional)</param>
        /// <param name="visitorType">访问类型 C &#x3D; company  or P &#x3D; person 如果是需要返回h5页面必填 (optional)</param>
        /// <param name="visitorName">商户侧配置访客名称 如果是需要返回h5页面必填 (optional)</param>
        /// <param name="companyCertificate">公司社会统一代码h5页面访客展示使用 (optional)</param>
        /// <param name="visitorUrl">上传图片接口返回的id (optional)</param>
        /// <param name="hasButton">在h5页面是否展示底部跳转按钮 (optional)</param>
        /// <param name="hasNumber">true or false 是否展示 (optional)</param>
        /// <param name="hasQrCode">是否展示二维码 (optional)</param>
        /// <param name="hasHtml">是否需要返回h5页面 (optional)</param>
        /// <param name="jobId">对外使用的jobid (optional)</param>
        /// <param name="industryId">行业描述ID (optional)</param>
        /// <param name="cloudResumeScene">子场景 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaCustomerJobworthInfoQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCustomerJobworthInfoQueryResponseModel> QueryWithHttpInfo(string userName = default(string), string connKey = default(string), string certNo = default(string), string userId = default(string), string openId = default(string), string backUrl = default(string), string certType = default(string), string kaVisitorId = default(string), string visitorType = default(string), string visitorName = default(string), string companyCertificate = default(string), string visitorUrl = default(string), bool? hasButton = default(bool?), bool? hasNumber = default(bool?), bool? hasQrCode = default(bool?), bool? hasHtml = default(bool?), string jobId = default(string), string industryId = default(string), string cloudResumeScene = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (userName != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "user_name", userName));
            }
            if (connKey != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "conn_key", connKey));
            }
            if (certNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "cert_no", certNo));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (openId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "open_id", openId));
            }
            if (backUrl != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "back_url", backUrl));
            }
            if (certType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "cert_type", certType));
            }
            if (kaVisitorId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "ka_visitor_id", kaVisitorId));
            }
            if (visitorType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "visitor_type", visitorType));
            }
            if (visitorName != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "visitor_name", visitorName));
            }
            if (companyCertificate != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "company_certificate", companyCertificate));
            }
            if (visitorUrl != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "visitor_url", visitorUrl));
            }
            if (hasButton != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "has_button", hasButton));
            }
            if (hasNumber != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "has_number", hasNumber));
            }
            if (hasQrCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "has_qr_code", hasQrCode));
            }
            if (hasHtml != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "has_html", hasHtml));
            }
            if (jobId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "job_id", jobId));
            }
            if (industryId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "industry_id", industryId));
            }
            if (cloudResumeScene != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "cloud_resume_scene", cloudResumeScene));
            }

            localVarRequestOptions.Operation = "ZhimaCustomerJobworthInfoApi.Query";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ZhimaCustomerJobworthInfoQueryResponseModel>("/v3/zhima/customer/jobworth/info/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = ZhimaCustomerJobworthInfoQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
                        }
                        catch (Exception e)
                        {
                            AlipayLogger.logBizWarn("解析default body内容失败", e);
                        }
                    }
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
