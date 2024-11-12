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
    /// AlipayMerchantIotDeviceBindDefaultResponse
    /// </summary>
    [JsonConverter(typeof(AlipayMerchantIotDeviceBindDefaultResponseJsonConverter))]
    [DataContract(Name = "alipay_merchant_iot_device_bind_default_response")]
    public partial class AlipayMerchantIotDeviceBindDefaultResponse : AbstractOpenAPISchema, IEquatable<AlipayMerchantIotDeviceBindDefaultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantIotDeviceBindDefaultResponse" /> class
        /// with the <see cref="AlipayMerchantIotDeviceBindErrorResponseModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AlipayMerchantIotDeviceBindErrorResponseModel.</param>
        public AlipayMerchantIotDeviceBindDefaultResponse(AlipayMerchantIotDeviceBindErrorResponseModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantIotDeviceBindDefaultResponse" /> class
        /// with the <see cref="CommonErrorType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CommonErrorType.</param>
        public AlipayMerchantIotDeviceBindDefaultResponse(CommonErrorType actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(AlipayMerchantIotDeviceBindErrorResponseModel))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CommonErrorType))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AlipayMerchantIotDeviceBindErrorResponseModel, CommonErrorType");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AlipayMerchantIotDeviceBindErrorResponseModel`. If the actual instance is not `AlipayMerchantIotDeviceBindErrorResponseModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AlipayMerchantIotDeviceBindErrorResponseModel</returns>
        public AlipayMerchantIotDeviceBindErrorResponseModel GetAlipayMerchantIotDeviceBindErrorResponseModel()
        {
            return (AlipayMerchantIotDeviceBindErrorResponseModel)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CommonErrorType`. If the actual instance is not `CommonErrorType`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CommonErrorType</returns>
        public CommonErrorType GetCommonErrorType()
        {
            return (CommonErrorType)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlipayMerchantIotDeviceBindDefaultResponse {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, AlipayMerchantIotDeviceBindDefaultResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AlipayMerchantIotDeviceBindDefaultResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AlipayMerchantIotDeviceBindDefaultResponse</returns>
        public static AlipayMerchantIotDeviceBindDefaultResponse FromJson(string jsonString)
        {
            AlipayMerchantIotDeviceBindDefaultResponse newAlipayMerchantIotDeviceBindDefaultResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAlipayMerchantIotDeviceBindDefaultResponse;
            }

            try
            {
                newAlipayMerchantIotDeviceBindDefaultResponse = new AlipayMerchantIotDeviceBindDefaultResponse(JsonConvert.DeserializeObject<AlipayMerchantIotDeviceBindErrorResponseModel>(jsonString, AlipayMerchantIotDeviceBindDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAlipayMerchantIotDeviceBindDefaultResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AlipayMerchantIotDeviceBindErrorResponseModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newAlipayMerchantIotDeviceBindDefaultResponse = new AlipayMerchantIotDeviceBindDefaultResponse(JsonConvert.DeserializeObject<CommonErrorType>(jsonString, AlipayMerchantIotDeviceBindDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAlipayMerchantIotDeviceBindDefaultResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CommonErrorType: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlipayMerchantIotDeviceBindDefaultResponse);
        }

        /// <summary>
        /// Returns true if AlipayMerchantIotDeviceBindDefaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantIotDeviceBindDefaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantIotDeviceBindDefaultResponse input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for AlipayMerchantIotDeviceBindDefaultResponse
    /// </summary>
    public class AlipayMerchantIotDeviceBindDefaultResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AlipayMerchantIotDeviceBindDefaultResponse).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return AlipayMerchantIotDeviceBindDefaultResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
