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
    ///  Class for testing FulfillmentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FulfillmentApiTests
    {
        private FulfillmentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FulfillmentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FulfillmentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FulfillmentApi
            //Assert.IsInstanceOfType(typeof(FulfillmentApi), instance, "instance is a FulfillmentApi");
        }

        
        /// <summary>
        /// Test AcknowledgeOrders
        /// </summary>
        [Test]
        public void AcknowledgeOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string distributionCenterCode = null;
            //List<string> orderIds = null;
            //instance.AcknowledgeOrders(distributionCenterCode, orderIds);
            
        }
        
        /// <summary>
        /// Test GetDistributionCenterOrders
        /// </summary>
        [Test]
        public void GetDistributionCenterOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string distributionCenterCode = null;
            //var response = instance.GetDistributionCenterOrders(distributionCenterCode);
            //Assert.IsInstanceOf<OrdersResponse> (response, "response is OrdersResponse");
        }
        
        /// <summary>
        /// Test GetDistributionCenters
        /// </summary>
        [Test]
        public void GetDistributionCentersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetDistributionCenters();
            //Assert.IsInstanceOf<DistributionCentersResponse> (response, "response is DistributionCentersResponse");
        }
        
        /// <summary>
        /// Test ShipOrders
        /// </summary>
        [Test]
        public void ShipOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string distributionCenterCode = null;
            //List<FulfillmentShipment> shipments = null;
            //instance.ShipOrders(distributionCenterCode, shipments);
            
        }
        
        /// <summary>
        /// Test UpdateInventory
        /// </summary>
        [Test]
        public void UpdateInventoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string distributionCenterCode = null;
            //List<FulfillmentInventory> inventories = null;
            //instance.UpdateInventory(distributionCenterCode, inventories);
            
        }
        
    }

}
