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
    ///  Class for testing OrderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderApiTests
    {
        private OrderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderApi
            //Assert.IsInstanceOfType(typeof(OrderApi), instance, "instance is a OrderApi");
        }

        
        /// <summary>
        /// Test CancelOrder
        /// </summary>
        [Test]
        public void CancelOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderId = null;
            //var response = instance.CancelOrder(orderId);
            //Assert.IsInstanceOf<BaseResponse> (response, "response is BaseResponse");
        }
        
        /// <summary>
        /// Test DeleteOrder
        /// </summary>
        [Test]
        public void DeleteOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderId = null;
            //instance.DeleteOrder(orderId);
            
        }
        
        /// <summary>
        /// Test Format
        /// </summary>
        [Test]
        public void FormatTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderId = null;
            //OrderFormat formatOptions = null;
            //var response = instance.Format(orderId, formatOptions);
            //Assert.IsInstanceOf<OrderFormatResponse> (response, "response is OrderFormatResponse");
        }
        
        /// <summary>
        /// Test GetOrder
        /// </summary>
        [Test]
        public void GetOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderId = null;
            //string expand = null;
            //var response = instance.GetOrder(orderId, expand);
            //Assert.IsInstanceOf<OrderResponse> (response, "response is OrderResponse");
        }
        
        /// <summary>
        /// Test GetOrders
        /// </summary>
        [Test]
        public void GetOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderId = null;
            //string paymentMethod = null;
            //string company = null;
            //string firstName = null;
            //string lastName = null;
            //string city = null;
            //string stateRegion = null;
            //string postalCode = null;
            //string countryCode = null;
            //string phone = null;
            //string email = null;
            //string ccEmail = null;
            //decimal? total = null;
            //string screenBrandingThemeCode = null;
            //string storefrontHostName = null;
            //string creationDateBegin = null;
            //string creationDateEnd = null;
            //string paymentDateBegin = null;
            //string paymentDateEnd = null;
            //string shipmentDateBegin = null;
            //string shipmentDateEnd = null;
            //string rma = null;
            //string purchaseOrderNumber = null;
            //string itemId = null;
            //string currentStage = null;
            //string channelPartnerCode = null;
            //string channelPartnerOrderId = null;
            //int? customerProfileOid = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //string expand = null;
            //var response = instance.GetOrders(orderId, paymentMethod, company, firstName, lastName, city, stateRegion, postalCode, countryCode, phone, email, ccEmail, total, screenBrandingThemeCode, storefrontHostName, creationDateBegin, creationDateEnd, paymentDateBegin, paymentDateEnd, shipmentDateBegin, shipmentDateEnd, rma, purchaseOrderNumber, itemId, currentStage, channelPartnerCode, channelPartnerOrderId, customerProfileOid, limit, offset, sort, expand);
            //Assert.IsInstanceOf<OrdersResponse> (response, "response is OrdersResponse");
        }
        
        /// <summary>
        /// Test GetOrdersByQuery
        /// </summary>
        [Test]
        public void GetOrdersByQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderQuery orderQuery = null;
            //int? limit = null;
            //int? offset = null;
            //string sort = null;
            //string expand = null;
            //var response = instance.GetOrdersByQuery(orderQuery, limit, offset, sort, expand);
            //Assert.IsInstanceOf<OrdersResponse> (response, "response is OrdersResponse");
        }
        
        /// <summary>
        /// Test RefundOrder
        /// </summary>
        [Test]
        public void RefundOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Order order = null;
            //string orderId = null;
            //bool? rejectAfterRefund = null;
            //bool? skipCustomerNotification = null;
            //bool? autoOrderCancel = null;
            //bool? manualRefund = null;
            //bool? reverseAffiliateTransactions = null;
            //string expand = null;
            //var response = instance.RefundOrder(order, orderId, rejectAfterRefund, skipCustomerNotification, autoOrderCancel, manualRefund, reverseAffiliateTransactions, expand);
            //Assert.IsInstanceOf<OrderResponse> (response, "response is OrderResponse");
        }
        
        /// <summary>
        /// Test ResendReceipt
        /// </summary>
        [Test]
        public void ResendReceiptTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderId = null;
            //var response = instance.ResendReceipt(orderId);
            //Assert.IsInstanceOf<BaseResponse> (response, "response is BaseResponse");
        }
        
        /// <summary>
        /// Test ResendShipmentConfirmation
        /// </summary>
        [Test]
        public void ResendShipmentConfirmationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderId = null;
            //var response = instance.ResendShipmentConfirmation(orderId);
            //Assert.IsInstanceOf<BaseResponse> (response, "response is BaseResponse");
        }
        
        /// <summary>
        /// Test UpdateOrder
        /// </summary>
        [Test]
        public void UpdateOrderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Order order = null;
            //string orderId = null;
            //string expand = null;
            //var response = instance.UpdateOrder(order, orderId, expand);
            //Assert.IsInstanceOf<OrderResponse> (response, "response is OrderResponse");
        }
        
    }

}
