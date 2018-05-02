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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using com.ultracart.admin.v2.Client;
using com.ultracart.admin.v2.Api;
using com.ultracart.admin.v2.Model;

namespace com.ultracart.admin.v2.Test
{
    /// <summary>
    ///  Class for testing OauthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OauthApiTests
    {
        private OauthApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OauthApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OauthApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OauthApi
            //Assert.IsInstanceOfType(typeof(OauthApi), instance, "instance is a OauthApi");
        }

        
        /// <summary>
        /// Test OauthAccessToken
        /// </summary>
        [Test]
        public void OauthAccessTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string grantType = null;
            //string code = null;
            //string redirectUri = null;
            //string refreshToken = null;
            //var response = instance.OauthAccessToken(clientId, grantType, code, redirectUri, refreshToken);
            //Assert.IsInstanceOf<OauthTokenResponse> (response, "response is OauthTokenResponse");
        }
        
        /// <summary>
        /// Test OauthRevoke
        /// </summary>
        [Test]
        public void OauthRevokeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string token = null;
            //var response = instance.OauthRevoke(clientId, token);
            //Assert.IsInstanceOf<OauthRevokeSuccessResponse> (response, "response is OauthRevokeSuccessResponse");
        }
        
    }

}
