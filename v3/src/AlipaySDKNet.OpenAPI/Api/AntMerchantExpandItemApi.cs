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
    public interface IAntMerchantExpandItemApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 商品创建接口
        /// </summary>
        /// <remarks>
        /// 用于服务商或商户创建商品
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="antMerchantExpandItemCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AntMerchantExpandItemCreateResponseModel</returns>
        AntMerchantExpandItemCreateResponseModel Create(AntMerchantExpandItemCreateModel antMerchantExpandItemCreateModel = default(AntMerchantExpandItemCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 商品创建接口
        /// </summary>
        /// <remarks>
        /// 用于服务商或商户创建商品
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="antMerchantExpandItemCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AntMerchantExpandItemCreateResponseModel</returns>
        ApiResponse<AntMerchantExpandItemCreateResponseModel> CreateWithHttpInfo(AntMerchantExpandItemCreateModel antMerchantExpandItemCreateModel = default(AntMerchantExpandItemCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 商品删除接口
        /// </summary>
        /// <remarks>
        /// 用于服务商或商户删除商品
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemId">商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空） (optional)</param>
        /// <param name="externalItemId">外部商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空） (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AntMerchantExpandItemDeleteResponseModel</returns>
        AntMerchantExpandItemDeleteResponseModel Delete(string itemId = default(string), string externalItemId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 商品删除接口
        /// </summary>
        /// <remarks>
        /// 用于服务商或商户删除商品
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemId">商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空） (optional)</param>
        /// <param name="externalItemId">外部商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空） (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AntMerchantExpandItemDeleteResponseModel</returns>
        ApiResponse<AntMerchantExpandItemDeleteResponseModel> DeleteWithHttpInfo(string itemId = default(string), string externalItemId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 商品修改接口
        /// </summary>
        /// <remarks>
        /// 用于服务商或商户修改商品
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="antMerchantExpandItemModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AntMerchantExpandItemModifyResponseModel</returns>
        AntMerchantExpandItemModifyResponseModel Modify(AntMerchantExpandItemModifyModel antMerchantExpandItemModifyModel = default(AntMerchantExpandItemModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 商品修改接口
        /// </summary>
        /// <remarks>
        /// 用于服务商或商户修改商品
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="antMerchantExpandItemModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AntMerchantExpandItemModifyResponseModel</returns>
        ApiResponse<AntMerchantExpandItemModifyResponseModel> ModifyWithHttpInfo(AntMerchantExpandItemModifyModel antMerchantExpandItemModifyModel = default(AntMerchantExpandItemModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 商品查询接口
        /// </summary>
        /// <remarks>
        /// 用于服务商或商户查询其商品信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetType">商品归属主体类型:  5: 店铺  4: 主站MID  3: 参与者  2: 角色  1: 联系人 (optional)</param>
        /// <param name="targetId">商品归属主体id (optional)</param>
        /// <param name="undefinedCategory">未分类类目: true 的时候 front_category_id 必须不填（null） (optional)</param>
        /// <param name="frontCategoryId">商品前台类目id: null 表示所有分类 (optional)</param>
        /// <param name="status">商品状态：EFFECT、INVALID、PAUSE；不填返回所有状态商品 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AntMerchantExpandItemQueryResponseModel</returns>
        AntMerchantExpandItemQueryResponseModel Query(string targetType = default(string), string targetId = default(string), bool? undefinedCategory = default(bool?), string frontCategoryId = default(string), string status = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 商品查询接口
        /// </summary>
        /// <remarks>
        /// 用于服务商或商户查询其商品信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetType">商品归属主体类型:  5: 店铺  4: 主站MID  3: 参与者  2: 角色  1: 联系人 (optional)</param>
        /// <param name="targetId">商品归属主体id (optional)</param>
        /// <param name="undefinedCategory">未分类类目: true 的时候 front_category_id 必须不填（null） (optional)</param>
        /// <param name="frontCategoryId">商品前台类目id: null 表示所有分类 (optional)</param>
        /// <param name="status">商品状态：EFFECT、INVALID、PAUSE；不填返回所有状态商品 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AntMerchantExpandItemQueryResponseModel</returns>
        ApiResponse<AntMerchantExpandItemQueryResponseModel> QueryWithHttpInfo(string targetType = default(string), string targetId = default(string), bool? undefinedCategory = default(bool?), string frontCategoryId = default(string), string status = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAntMerchantExpandItemApi : IAntMerchantExpandItemApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AntMerchantExpandItemApi : IAntMerchantExpandItemApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandItemApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AntMerchantExpandItemApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandItemApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AntMerchantExpandItemApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandItemApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AntMerchantExpandItemApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AntMerchantExpandItemApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AntMerchantExpandItemApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 商品创建接口 用于服务商或商户创建商品
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="antMerchantExpandItemCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AntMerchantExpandItemCreateResponseModel</returns>
        public AntMerchantExpandItemCreateResponseModel Create(AntMerchantExpandItemCreateModel antMerchantExpandItemCreateModel = default(AntMerchantExpandItemCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AntMerchantExpandItemCreateResponseModel> localVarResponse = CreateWithHttpInfo(antMerchantExpandItemCreateModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 商品创建接口 用于服务商或商户创建商品
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="antMerchantExpandItemCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AntMerchantExpandItemCreateResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AntMerchantExpandItemCreateResponseModel> CreateWithHttpInfo(AntMerchantExpandItemCreateModel antMerchantExpandItemCreateModel = default(AntMerchantExpandItemCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = antMerchantExpandItemCreateModel;
            }

            localVarRequestOptions.Operation = "AntMerchantExpandItemApi.Create";
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
            var localVarResponse = this.Client.Post<AntMerchantExpandItemCreateResponseModel>("/v3/ant/merchant/expand/item/create", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AntMerchantExpandItemCreateDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 商品删除接口 用于服务商或商户删除商品
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemId">商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空） (optional)</param>
        /// <param name="externalItemId">外部商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空） (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AntMerchantExpandItemDeleteResponseModel</returns>
        public AntMerchantExpandItemDeleteResponseModel Delete(string itemId = default(string), string externalItemId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AntMerchantExpandItemDeleteResponseModel> localVarResponse = DeleteWithHttpInfo(itemId, externalItemId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 商品删除接口 用于服务商或商户删除商品
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="itemId">商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空） (optional)</param>
        /// <param name="externalItemId">外部商品ID（item_id不为空则以item_id作为删除KEY,item_id为空则以external_item_id作为删除KEY,两者不能同时为空） (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AntMerchantExpandItemDeleteResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AntMerchantExpandItemDeleteResponseModel> DeleteWithHttpInfo(string itemId = default(string), string externalItemId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (itemId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "item_id", itemId));
            }
            if (externalItemId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "external_item_id", externalItemId));
            }

            localVarRequestOptions.Operation = "AntMerchantExpandItemApi.Delete";
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
            var localVarResponse = this.Client.Delete<AntMerchantExpandItemDeleteResponseModel>("/v3/ant/merchant/expand/item/delete", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AntMerchantExpandItemDeleteDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 商品修改接口 用于服务商或商户修改商品
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="antMerchantExpandItemModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AntMerchantExpandItemModifyResponseModel</returns>
        public AntMerchantExpandItemModifyResponseModel Modify(AntMerchantExpandItemModifyModel antMerchantExpandItemModifyModel = default(AntMerchantExpandItemModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AntMerchantExpandItemModifyResponseModel> localVarResponse = ModifyWithHttpInfo(antMerchantExpandItemModifyModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 商品修改接口 用于服务商或商户修改商品
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="antMerchantExpandItemModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AntMerchantExpandItemModifyResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AntMerchantExpandItemModifyResponseModel> ModifyWithHttpInfo(AntMerchantExpandItemModifyModel antMerchantExpandItemModifyModel = default(AntMerchantExpandItemModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = antMerchantExpandItemModifyModel;
            }

            localVarRequestOptions.Operation = "AntMerchantExpandItemApi.Modify";
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
            var localVarResponse = this.Client.Post<AntMerchantExpandItemModifyResponseModel>("/v3/ant/merchant/expand/item/modify", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Modify", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AntMerchantExpandItemModifyDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 商品查询接口 用于服务商或商户查询其商品信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetType">商品归属主体类型:  5: 店铺  4: 主站MID  3: 参与者  2: 角色  1: 联系人 (optional)</param>
        /// <param name="targetId">商品归属主体id (optional)</param>
        /// <param name="undefinedCategory">未分类类目: true 的时候 front_category_id 必须不填（null） (optional)</param>
        /// <param name="frontCategoryId">商品前台类目id: null 表示所有分类 (optional)</param>
        /// <param name="status">商品状态：EFFECT、INVALID、PAUSE；不填返回所有状态商品 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AntMerchantExpandItemQueryResponseModel</returns>
        public AntMerchantExpandItemQueryResponseModel Query(string targetType = default(string), string targetId = default(string), bool? undefinedCategory = default(bool?), string frontCategoryId = default(string), string status = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AntMerchantExpandItemQueryResponseModel> localVarResponse = QueryWithHttpInfo(targetType, targetId, undefinedCategory, frontCategoryId, status, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 商品查询接口 用于服务商或商户查询其商品信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="targetType">商品归属主体类型:  5: 店铺  4: 主站MID  3: 参与者  2: 角色  1: 联系人 (optional)</param>
        /// <param name="targetId">商品归属主体id (optional)</param>
        /// <param name="undefinedCategory">未分类类目: true 的时候 front_category_id 必须不填（null） (optional)</param>
        /// <param name="frontCategoryId">商品前台类目id: null 表示所有分类 (optional)</param>
        /// <param name="status">商品状态：EFFECT、INVALID、PAUSE；不填返回所有状态商品 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AntMerchantExpandItemQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AntMerchantExpandItemQueryResponseModel> QueryWithHttpInfo(string targetType = default(string), string targetId = default(string), bool? undefinedCategory = default(bool?), string frontCategoryId = default(string), string status = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (targetType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "target_type", targetType));
            }
            if (targetId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "target_id", targetId));
            }
            if (undefinedCategory != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "undefined_category", undefinedCategory));
            }
            if (frontCategoryId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "front_category_id", frontCategoryId));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "status", status));
            }

            localVarRequestOptions.Operation = "AntMerchantExpandItemApi.Query";
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
            var localVarResponse = this.Client.Get<AntMerchantExpandItemQueryResponseModel>("/v3/ant/merchant/expand/item/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AntMerchantExpandItemQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
