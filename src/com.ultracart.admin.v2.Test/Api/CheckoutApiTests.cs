/* 
 * UltraCart Rest API V2
 *
 * This is the next generation UltraCart REST API...
 *
 * OpenAPI spec version: 2.0.0
 * Contact: support@ultracart.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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
    ///  Class for testing CheckoutApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CheckoutApiTests
    {
        private CheckoutApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CheckoutApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CheckoutApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CheckoutApi
            //Assert.IsInstanceOfType(typeof(CheckoutApi), instance, "instance is a CheckoutApi");
        }

        
        /// <summary>
        /// Test CheckoutBrowserKeyPut
        /// </summary>
        [Test]
        public void CheckoutBrowserKeyPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CheckoutSetupBrowserKeyRequest browserKeyRequest = null;
            //var response = instance.CheckoutBrowserKeyPut(browserKeyRequest);
            //Assert.IsInstanceOf<CheckoutSetupBrowserKeyResponse> (response, "response is CheckoutSetupBrowserKeyResponse");
        }
        
        /// <summary>
        /// Test CheckoutCartCartIdGet
        /// </summary>
        [Test]
        public void CheckoutCartCartIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string cartId = null;
            //string expand = null;
            //var response = instance.CheckoutCartCartIdGet(cartId, expand);
            //Assert.IsInstanceOf<CartResponse> (response, "response is CartResponse");
        }
        
        /// <summary>
        /// Test CheckoutCartFinalizeOrderPost
        /// </summary>
        [Test]
        public void CheckoutCartFinalizeOrderPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CartFinalizeOrderRequest finalizeRequest = null;
            //var response = instance.CheckoutCartFinalizeOrderPost(finalizeRequest);
            //Assert.IsInstanceOf<CartFinalizeOrderResponse> (response, "response is CartFinalizeOrderResponse");
        }
        
        /// <summary>
        /// Test CheckoutCartGet
        /// </summary>
        [Test]
        public void CheckoutCartGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string expand = null;
            //var response = instance.CheckoutCartGet(expand);
            //Assert.IsInstanceOf<CartResponse> (response, "response is CartResponse");
        }
        
        /// <summary>
        /// Test CheckoutCartHandoffPost
        /// </summary>
        [Test]
        public void CheckoutCartHandoffPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CheckoutHandoffRequest handoffRequest = null;
            //string expand = null;
            //var response = instance.CheckoutCartHandoffPost(handoffRequest, expand);
            //Assert.IsInstanceOf<CheckoutHandoffResponse> (response, "response is CheckoutHandoffResponse");
        }
        
        /// <summary>
        /// Test CheckoutCartProfileLoginPost
        /// </summary>
        [Test]
        public void CheckoutCartProfileLoginPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CartProfileLoginRequest loginRequest = null;
            //string expand = null;
            //var response = instance.CheckoutCartProfileLoginPost(loginRequest, expand);
            //Assert.IsInstanceOf<CartProfileLoginResponse> (response, "response is CartProfileLoginResponse");
        }
        
        /// <summary>
        /// Test CheckoutCartProfileLogoutPost
        /// </summary>
        [Test]
        public void CheckoutCartProfileLogoutPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Cart cart = null;
            //string expand = null;
            //var response = instance.CheckoutCartProfileLogoutPost(cart, expand);
            //Assert.IsInstanceOf<CartResponse> (response, "response is CartResponse");
        }
        
        /// <summary>
        /// Test CheckoutCartProfileRegisterPost
        /// </summary>
        [Test]
        public void CheckoutCartProfileRegisterPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CartProfileRegisterRequest registerRequest = null;
            //string expand = null;
            //var response = instance.CheckoutCartProfileRegisterPost(registerRequest, expand);
            //Assert.IsInstanceOf<CartProfileRegisterResponse> (response, "response is CartProfileRegisterResponse");
        }
        
        /// <summary>
        /// Test CheckoutCartPut
        /// </summary>
        [Test]
        public void CheckoutCartPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Cart cart = null;
            //string expand = null;
            //var response = instance.CheckoutCartPut(cart, expand);
            //Assert.IsInstanceOf<CartResponse> (response, "response is CartResponse");
        }
        
        /// <summary>
        /// Test CheckoutCartValidatePost
        /// </summary>
        [Test]
        public void CheckoutCartValidatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CartValidationRequest validationRequest = null;
            //string expand = null;
            //var response = instance.CheckoutCartValidatePost(validationRequest, expand);
            //Assert.IsInstanceOf<CartValidationResponse> (response, "response is CartValidationResponse");
        }
        
        /// <summary>
        /// Test CheckoutCityStatePost
        /// </summary>
        [Test]
        public void CheckoutCityStatePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Cart cart = null;
            //var response = instance.CheckoutCityStatePost(cart);
            //Assert.IsInstanceOf<ItemsResponse> (response, "response is ItemsResponse");
        }
        
        /// <summary>
        /// Test CheckoutRelatedItemsItemIdPost
        /// </summary>
        [Test]
        public void CheckoutRelatedItemsItemIdPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string itemId = null;
            //Cart cart = null;
            //string expand = null;
            //var response = instance.CheckoutRelatedItemsItemIdPost(itemId, cart, expand);
            //Assert.IsInstanceOf<ItemsResponse> (response, "response is ItemsResponse");
        }
        
        /// <summary>
        /// Test CheckoutRelatedItemsPost
        /// </summary>
        [Test]
        public void CheckoutRelatedItemsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Cart cart = null;
            //string expand = null;
            //var response = instance.CheckoutRelatedItemsPost(cart, expand);
            //Assert.IsInstanceOf<ItemsResponse> (response, "response is ItemsResponse");
        }
        
        /// <summary>
        /// Test CheckoutReturnReturnCodeGet
        /// </summary>
        [Test]
        public void CheckoutReturnReturnCodeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string returnCode = null;
            //string expand = null;
            //var response = instance.CheckoutReturnReturnCodeGet(returnCode, expand);
            //Assert.IsInstanceOf<CartResponse> (response, "response is CartResponse");
        }
        
    }

}
