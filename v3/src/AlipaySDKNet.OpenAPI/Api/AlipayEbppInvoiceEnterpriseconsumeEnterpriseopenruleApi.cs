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
    public interface IAlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 新增开票规则
        /// </summary>
        /// <remarks>
        /// 新增一条开票规则配置
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel</returns>
        AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel Create(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel = default(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 新增开票规则
        /// </summary>
        /// <remarks>
        /// 新增一条开票规则配置
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel> CreateWithHttpInfo(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel = default(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 修改开票规则
        /// </summary>
        /// <remarks>
        /// 修改开票规则
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel</returns>
        AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel Modify(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel = default(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 修改开票规则
        /// </summary>
        /// <remarks>
        /// 修改开票规则
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel> ModifyWithHttpInfo(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel = default(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 查询开票规则
        /// </summary>
        /// <remarks>
        /// 根据开票规则ID查询开票规则详情
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业ID (optional)</param>
        /// <param name="invoiceRuleId">开票规则ID (optional)</param>
        /// <param name="accountId">共同账户ID (optional)</param>
        /// <param name="agreementNo">授权签约协议号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel</returns>
        AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel Query(string enterpriseId = default(string), string invoiceRuleId = default(string), string accountId = default(string), string agreementNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询开票规则
        /// </summary>
        /// <remarks>
        /// 根据开票规则ID查询开票规则详情
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业ID (optional)</param>
        /// <param name="invoiceRuleId">开票规则ID (optional)</param>
        /// <param name="accountId">共同账户ID (optional)</param>
        /// <param name="agreementNo">授权签约协议号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel> QueryWithHttpInfo(string enterpriseId = default(string), string invoiceRuleId = default(string), string accountId = default(string), string agreementNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi : IAlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi : IAlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 新增开票规则 新增一条开票规则配置
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel</returns>
        public AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel Create(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel = default(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel> localVarResponse = CreateWithHttpInfo(alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 新增开票规则 新增一条开票规则配置
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel> CreateWithHttpInfo(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel = default(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi.Create";
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
            var localVarResponse = this.Client.Post<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateResponseModel>("/v3/alipay/ebpp/invoice/enterpriseconsume/enterpriseopenrule/create", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleCreateDefaultResponse.FromJson(exception.ErrorContent.ToString());
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

        /// <summary>
        /// 修改开票规则 修改开票规则
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel</returns>
        public AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel Modify(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel = default(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel> localVarResponse = ModifyWithHttpInfo(alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 修改开票规则 修改开票规则
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel> ModifyWithHttpInfo(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel = default(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
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

            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi.Modify";
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
            var localVarResponse = this.Client.Post<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyResponseModel>("/v3/alipay/ebpp/invoice/enterpriseconsume/enterpriseopenrule/modify", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Modify", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyDefaultResponse.FromJson(exception.ErrorContent.ToString());
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

        /// <summary>
        /// 查询开票规则 根据开票规则ID查询开票规则详情
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业ID (optional)</param>
        /// <param name="invoiceRuleId">开票规则ID (optional)</param>
        /// <param name="accountId">共同账户ID (optional)</param>
        /// <param name="agreementNo">授权签约协议号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel</returns>
        public AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel Query(string enterpriseId = default(string), string invoiceRuleId = default(string), string accountId = default(string), string agreementNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel> localVarResponse = QueryWithHttpInfo(enterpriseId, invoiceRuleId, accountId, agreementNo, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询开票规则 根据开票规则ID查询开票规则详情
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业ID (optional)</param>
        /// <param name="invoiceRuleId">开票规则ID (optional)</param>
        /// <param name="accountId">共同账户ID (optional)</param>
        /// <param name="agreementNo">授权签约协议号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel> QueryWithHttpInfo(string enterpriseId = default(string), string invoiceRuleId = default(string), string accountId = default(string), string agreementNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (enterpriseId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "enterprise_id", enterpriseId));
            }
            if (invoiceRuleId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "invoice_rule_id", invoiceRuleId));
            }
            if (accountId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "account_id", accountId));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryResponseModel>("/v3/alipay/ebpp/invoice/enterpriseconsume/enterpriseopenrule/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
