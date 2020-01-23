/* 
 * UltraCart Rest API V2
 *
 * UltraCart REST API Version 2
 *
 * OpenAPI spec version: 2.0.0
 * Contact: support@ultracart.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Model;

namespace com.ultracart.admin.v2.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOauthApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Exchange authorization code for access token.
        /// </summary>
        /// <remarks>
        /// The final leg in the OAuth process which exchanges the specified access token for the access code needed to make API calls. 
        /// </remarks>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="grantType">Type of grant</param>
        /// <param name="code">Authorization code received back from the browser redirect (optional)</param>
        /// <param name="redirectUri">The URI that you redirect the browser to to start the authorization process (optional)</param>
        /// <param name="refreshToken">The refresh token received during the original grant_type&#x3D;authorization_code that can be used to return a new access token (optional)</param>
        /// <returns>OauthTokenResponse</returns>
        OauthTokenResponse OauthAccessToken (string clientId, string grantType, string code = null, string redirectUri = null, string refreshToken = null);

        /// <summary>
        /// Exchange authorization code for access token.
        /// </summary>
        /// <remarks>
        /// The final leg in the OAuth process which exchanges the specified access token for the access code needed to make API calls. 
        /// </remarks>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="grantType">Type of grant</param>
        /// <param name="code">Authorization code received back from the browser redirect (optional)</param>
        /// <param name="redirectUri">The URI that you redirect the browser to to start the authorization process (optional)</param>
        /// <param name="refreshToken">The refresh token received during the original grant_type&#x3D;authorization_code that can be used to return a new access token (optional)</param>
        /// <returns>ApiResponse of OauthTokenResponse</returns>
        ApiResponse<OauthTokenResponse> OauthAccessTokenWithHttpInfo (string clientId, string grantType, string code = null, string redirectUri = null, string refreshToken = null);
        /// <summary>
        /// Revoke this OAuth application.
        /// </summary>
        /// <remarks>
        /// Revokes the OAuth application associated with the specified client_id and token. 
        /// </remarks>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="token">The OAuth access token that is to be revoked..</param>
        /// <returns>OauthRevokeSuccessResponse</returns>
        OauthRevokeSuccessResponse OauthRevoke (string clientId, string token);

        /// <summary>
        /// Revoke this OAuth application.
        /// </summary>
        /// <remarks>
        /// Revokes the OAuth application associated with the specified client_id and token. 
        /// </remarks>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="token">The OAuth access token that is to be revoked..</param>
        /// <returns>ApiResponse of OauthRevokeSuccessResponse</returns>
        ApiResponse<OauthRevokeSuccessResponse> OauthRevokeWithHttpInfo (string clientId, string token);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Exchange authorization code for access token.
        /// </summary>
        /// <remarks>
        /// The final leg in the OAuth process which exchanges the specified access token for the access code needed to make API calls. 
        /// </remarks>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="grantType">Type of grant</param>
        /// <param name="code">Authorization code received back from the browser redirect (optional)</param>
        /// <param name="redirectUri">The URI that you redirect the browser to to start the authorization process (optional)</param>
        /// <param name="refreshToken">The refresh token received during the original grant_type&#x3D;authorization_code that can be used to return a new access token (optional)</param>
        /// <returns>Task of OauthTokenResponse</returns>
        System.Threading.Tasks.Task<OauthTokenResponse> OauthAccessTokenAsync (string clientId, string grantType, string code = null, string redirectUri = null, string refreshToken = null);

        /// <summary>
        /// Exchange authorization code for access token.
        /// </summary>
        /// <remarks>
        /// The final leg in the OAuth process which exchanges the specified access token for the access code needed to make API calls. 
        /// </remarks>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="grantType">Type of grant</param>
        /// <param name="code">Authorization code received back from the browser redirect (optional)</param>
        /// <param name="redirectUri">The URI that you redirect the browser to to start the authorization process (optional)</param>
        /// <param name="refreshToken">The refresh token received during the original grant_type&#x3D;authorization_code that can be used to return a new access token (optional)</param>
        /// <returns>Task of ApiResponse (OauthTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OauthTokenResponse>> OauthAccessTokenAsyncWithHttpInfo (string clientId, string grantType, string code = null, string redirectUri = null, string refreshToken = null);
        /// <summary>
        /// Revoke this OAuth application.
        /// </summary>
        /// <remarks>
        /// Revokes the OAuth application associated with the specified client_id and token. 
        /// </remarks>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="token">The OAuth access token that is to be revoked..</param>
        /// <returns>Task of OauthRevokeSuccessResponse</returns>
        System.Threading.Tasks.Task<OauthRevokeSuccessResponse> OauthRevokeAsync (string clientId, string token);

        /// <summary>
        /// Revoke this OAuth application.
        /// </summary>
        /// <remarks>
        /// Revokes the OAuth application associated with the specified client_id and token. 
        /// </remarks>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="token">The OAuth access token that is to be revoked..</param>
        /// <returns>Task of ApiResponse (OauthRevokeSuccessResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OauthRevokeSuccessResponse>> OauthRevokeAsyncWithHttpInfo (string clientId, string token);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OauthApi : IOauthApi
    {
        private com.ultracart.admin.v2.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OauthApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = com.ultracart.admin.v2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OauthApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.ultracart.admin.v2.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public com.ultracart.admin.v2.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Exchange authorization code for access token. The final leg in the OAuth process which exchanges the specified access token for the access code needed to make API calls. 
        /// </summary>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="grantType">Type of grant</param>
        /// <param name="code">Authorization code received back from the browser redirect (optional)</param>
        /// <param name="redirectUri">The URI that you redirect the browser to to start the authorization process (optional)</param>
        /// <param name="refreshToken">The refresh token received during the original grant_type&#x3D;authorization_code that can be used to return a new access token (optional)</param>
        /// <returns>OauthTokenResponse</returns>
        public OauthTokenResponse OauthAccessToken (string clientId, string grantType, string code = null, string redirectUri = null, string refreshToken = null)
        {
             ApiResponse<OauthTokenResponse> localVarResponse = OauthAccessTokenWithHttpInfo(clientId, grantType, code, redirectUri, refreshToken);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Exchange authorization code for access token. The final leg in the OAuth process which exchanges the specified access token for the access code needed to make API calls. 
        /// </summary>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="grantType">Type of grant</param>
        /// <param name="code">Authorization code received back from the browser redirect (optional)</param>
        /// <param name="redirectUri">The URI that you redirect the browser to to start the authorization process (optional)</param>
        /// <param name="refreshToken">The refresh token received during the original grant_type&#x3D;authorization_code that can be used to return a new access token (optional)</param>
        /// <returns>ApiResponse of OauthTokenResponse</returns>
        public ApiResponse< OauthTokenResponse > OauthAccessTokenWithHttpInfo (string clientId, string grantType, string code = null, string redirectUri = null, string refreshToken = null)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OauthApi->OauthAccessToken");
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling OauthApi->OauthAccessToken");

            var localVarPath = "/oauth/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clientId != null) localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (code != null) localVarFormParams.Add("code", Configuration.ApiClient.ParameterToString(code)); // form parameter
            if (redirectUri != null) localVarFormParams.Add("redirect_uri", Configuration.ApiClient.ParameterToString(redirectUri)); // form parameter
            if (refreshToken != null) localVarFormParams.Add("refresh_token", Configuration.ApiClient.ParameterToString(refreshToken)); // form parameter

            // authentication (ultraCartBrowserApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-ultracart-browser-key")))
            {
                localVarHeaderParams["x-ultracart-browser-key"] = Configuration.GetApiKeyWithPrefix("x-ultracart-browser-key");
            }
            // authentication (ultraCartOauth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (ultraCartSimpleApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-ultracart-simple-key")))
            {
                localVarHeaderParams["x-ultracart-simple-key"] = Configuration.GetApiKeyWithPrefix("x-ultracart-simple-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OauthAccessToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OauthTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OauthTokenResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OauthTokenResponse)));
        }

        /// <summary>
        /// Exchange authorization code for access token. The final leg in the OAuth process which exchanges the specified access token for the access code needed to make API calls. 
        /// </summary>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="grantType">Type of grant</param>
        /// <param name="code">Authorization code received back from the browser redirect (optional)</param>
        /// <param name="redirectUri">The URI that you redirect the browser to to start the authorization process (optional)</param>
        /// <param name="refreshToken">The refresh token received during the original grant_type&#x3D;authorization_code that can be used to return a new access token (optional)</param>
        /// <returns>Task of OauthTokenResponse</returns>
        public async System.Threading.Tasks.Task<OauthTokenResponse> OauthAccessTokenAsync (string clientId, string grantType, string code = null, string redirectUri = null, string refreshToken = null)
        {
             ApiResponse<OauthTokenResponse> localVarResponse = await OauthAccessTokenAsyncWithHttpInfo(clientId, grantType, code, redirectUri, refreshToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Exchange authorization code for access token. The final leg in the OAuth process which exchanges the specified access token for the access code needed to make API calls. 
        /// </summary>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="grantType">Type of grant</param>
        /// <param name="code">Authorization code received back from the browser redirect (optional)</param>
        /// <param name="redirectUri">The URI that you redirect the browser to to start the authorization process (optional)</param>
        /// <param name="refreshToken">The refresh token received during the original grant_type&#x3D;authorization_code that can be used to return a new access token (optional)</param>
        /// <returns>Task of ApiResponse (OauthTokenResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OauthTokenResponse>> OauthAccessTokenAsyncWithHttpInfo (string clientId, string grantType, string code = null, string redirectUri = null, string refreshToken = null)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OauthApi->OauthAccessToken");
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling OauthApi->OauthAccessToken");

            var localVarPath = "/oauth/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clientId != null) localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (code != null) localVarFormParams.Add("code", Configuration.ApiClient.ParameterToString(code)); // form parameter
            if (redirectUri != null) localVarFormParams.Add("redirect_uri", Configuration.ApiClient.ParameterToString(redirectUri)); // form parameter
            if (refreshToken != null) localVarFormParams.Add("refresh_token", Configuration.ApiClient.ParameterToString(refreshToken)); // form parameter

            // authentication (ultraCartBrowserApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-ultracart-browser-key")))
            {
                localVarHeaderParams["x-ultracart-browser-key"] = Configuration.GetApiKeyWithPrefix("x-ultracart-browser-key");
            }
            // authentication (ultraCartOauth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (ultraCartSimpleApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-ultracart-simple-key")))
            {
                localVarHeaderParams["x-ultracart-simple-key"] = Configuration.GetApiKeyWithPrefix("x-ultracart-simple-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OauthAccessToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OauthTokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OauthTokenResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OauthTokenResponse)));
        }

        /// <summary>
        /// Revoke this OAuth application. Revokes the OAuth application associated with the specified client_id and token. 
        /// </summary>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="token">The OAuth access token that is to be revoked..</param>
        /// <returns>OauthRevokeSuccessResponse</returns>
        public OauthRevokeSuccessResponse OauthRevoke (string clientId, string token)
        {
             ApiResponse<OauthRevokeSuccessResponse> localVarResponse = OauthRevokeWithHttpInfo(clientId, token);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Revoke this OAuth application. Revokes the OAuth application associated with the specified client_id and token. 
        /// </summary>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="token">The OAuth access token that is to be revoked..</param>
        /// <returns>ApiResponse of OauthRevokeSuccessResponse</returns>
        public ApiResponse< OauthRevokeSuccessResponse > OauthRevokeWithHttpInfo (string clientId, string token)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OauthApi->OauthRevoke");
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling OauthApi->OauthRevoke");

            var localVarPath = "/oauth/revoke";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clientId != null) localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (token != null) localVarFormParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // form parameter

            // authentication (ultraCartBrowserApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-ultracart-browser-key")))
            {
                localVarHeaderParams["x-ultracart-browser-key"] = Configuration.GetApiKeyWithPrefix("x-ultracart-browser-key");
            }
            // authentication (ultraCartOauth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (ultraCartSimpleApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-ultracart-simple-key")))
            {
                localVarHeaderParams["x-ultracart-simple-key"] = Configuration.GetApiKeyWithPrefix("x-ultracart-simple-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OauthRevoke", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OauthRevokeSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OauthRevokeSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OauthRevokeSuccessResponse)));
        }

        /// <summary>
        /// Revoke this OAuth application. Revokes the OAuth application associated with the specified client_id and token. 
        /// </summary>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="token">The OAuth access token that is to be revoked..</param>
        /// <returns>Task of OauthRevokeSuccessResponse</returns>
        public async System.Threading.Tasks.Task<OauthRevokeSuccessResponse> OauthRevokeAsync (string clientId, string token)
        {
             ApiResponse<OauthRevokeSuccessResponse> localVarResponse = await OauthRevokeAsyncWithHttpInfo(clientId, token);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Revoke this OAuth application. Revokes the OAuth application associated with the specified client_id and token. 
        /// </summary>
        /// <exception cref="com.ultracart.admin.v2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="clientId">The OAuth application client_id.</param>
        /// <param name="token">The OAuth access token that is to be revoked..</param>
        /// <returns>Task of ApiResponse (OauthRevokeSuccessResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OauthRevokeSuccessResponse>> OauthRevokeAsyncWithHttpInfo (string clientId, string token)
        {
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OauthApi->OauthRevoke");
            // verify the required parameter 'token' is set
            if (token == null)
                throw new ApiException(400, "Missing required parameter 'token' when calling OauthApi->OauthRevoke");

            var localVarPath = "/oauth/revoke";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (clientId != null) localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (token != null) localVarFormParams.Add("token", Configuration.ApiClient.ParameterToString(token)); // form parameter

            // authentication (ultraCartBrowserApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-ultracart-browser-key")))
            {
                localVarHeaderParams["x-ultracart-browser-key"] = Configuration.GetApiKeyWithPrefix("x-ultracart-browser-key");
            }
            // authentication (ultraCartOauth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (ultraCartSimpleApiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("x-ultracart-simple-key")))
            {
                localVarHeaderParams["x-ultracart-simple-key"] = Configuration.GetApiKeyWithPrefix("x-ultracart-simple-key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OauthRevoke", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OauthRevokeSuccessResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OauthRevokeSuccessResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OauthRevokeSuccessResponse)));
        }

    }
}
